from __future__ import annotations
from dataclasses import dataclass
from typing import Dict, List, Optional
import os
import secrets
from datetime import datetime, timedelta

from flask import Flask, render_template, request, redirect, url_for, flash
from flask import session as flask_session
from flask_login import LoginManager, login_user, logout_user, login_required, current_user, UserMixin
from flask_bcrypt import Bcrypt
from sqlalchemy import create_engine, Column, Integer, String, Text, ForeignKey, DateTime, Boolean, UniqueConstraint
from sqlalchemy.orm import declarative_base, sessionmaker, relationship, scoped_session
from email_validator import validate_email, EmailNotValidError
from pathlib import Path

# ----------------------------------------------------------------------------
# App setup
# ----------------------------------------------------------------------------

def create_app() -> Flask:
    app = Flask(__name__)
    app.config['SECRET_KEY'] = os.environ.get('SECRET_KEY', 'dev-secret-key-change-me')
    app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///app.db'
    app.config['SQLALCHEMY_ECHO'] = False
    return app

app = create_app()
bcrypt = Bcrypt(app)

login_manager = LoginManager(app)
login_manager.login_view = 'login'

# ----------------------------------------------------------------------------
# Database setup with SQLAlchemy (no Flask-SQLAlchemy to keep minimal deps)
# ----------------------------------------------------------------------------

Base = declarative_base()
engine = create_engine('sqlite:///app.db', echo=False, future=True)
SessionLocal = scoped_session(sessionmaker(bind=engine, autoflush=False, autocommit=False))

# ----------------------------------------------------------------------------
# Models
# ----------------------------------------------------------------------------

class User(Base, UserMixin):
    __tablename__ = 'users'

    id = Column(Integer, primary_key=True)
    email = Column(String(255), unique=True, nullable=False)
    name = Column(String(120), nullable=False)
    gender = Column(String(50), nullable=True)
    phone_number = Column(String(50), nullable=True)
    religion = Column(String(50), nullable=False)
    password_hash = Column(String(255), nullable=False)

    saved_quotes = relationship('SavedQuote', back_populates='user', cascade='all, delete-orphan')

    def get_id(self) -> str:
        return str(self.id)

class SavedQuote(Base):
    __tablename__ = 'saved_quotes'

    id = Column(Integer, primary_key=True)
    user_id = Column(Integer, ForeignKey('users.id'), nullable=False)
    religion = Column(String(50), nullable=False)
    keyword = Column(String(100), nullable=False)
    quote = Column(Text, nullable=False)
    source = Column(String(255), nullable=True)

    user = relationship('User', back_populates='saved_quotes')

Base.metadata.create_all(engine)

# ----------------------------------------------------------------------------
# Additional models for settings and one-time tokens
# ----------------------------------------------------------------------------

class UserSettings(Base):
    __tablename__ = 'user_settings'

    id = Column(Integer, primary_key=True)
    user_id = Column(Integer, ForeignKey('users.id'), nullable=False, unique=True)
    two_factor_enabled = Column(Boolean, default=False, nullable=False)
    language = Column(String(50), nullable=False, default='english')

    user = relationship('User')


class OneTimeToken(Base):
    __tablename__ = 'one_time_tokens'

    id = Column(Integer, primary_key=True)
    user_id = Column(Integer, ForeignKey('users.id'), nullable=False)
    token = Column(String(128), nullable=False, unique=True)
    purpose = Column(String(50), nullable=False)  # 'password_reset' | '2fa'
    code = Column(String(10), nullable=True)      # for 2FA numeric code
    expires_at = Column(DateTime, nullable=False)

    user = relationship('User')

Base.metadata.create_all(engine)

# Attempt to ensure new columns exist in SQLite (best-effort for dev)
try:
    with engine.begin() as conn:
        # Add language column if missing
        cols = conn.exec_driver_sql("PRAGMA table_info(user_settings)").all()
        col_names = {c[1] for c in cols}
        if 'language' not in col_names:
            conn.exec_driver_sql("ALTER TABLE user_settings ADD COLUMN language VARCHAR(50) NOT NULL DEFAULT 'english'")
except Exception:
    pass

# ----------------------------------------------------------------------------
# Login manager user loader
# ----------------------------------------------------------------------------

@login_manager.user_loader
def load_user(user_id: str) -> Optional[User]:
    db = SessionLocal()
    try:
        return db.get(User, int(user_id))
    finally:
        db.close()

# ----------------------------------------------------------------------------
# Quote dataset (demo scale; extend as needed)
# ----------------------------------------------------------------------------

QUOTE_DATA: Dict[str, Dict[str, List[Dict[str, str]]]] = {
    # Christianity - Bible
    'christianity': {
        'motivation': [
            { 'text': 'I can do all things through Christ who strengthens me.', 'source': 'Philippians 4:13' },
            { 'text': 'For I know the plans I have for you...', 'source': 'Jeremiah 29:11' },
        ],
        'stress': [
            { 'text': 'Cast all your anxiety on Him because He cares for you.', 'source': '1 Peter 5:7' },
            { 'text': 'Come to me, all you who are weary and burdened...', 'source': 'Matthew 11:28' },
        ],
        'financial': [
            { 'text': 'And my God will supply every need of yours...', 'source': 'Philippians 4:19' },
            { 'text': 'Keep your lives free from the love of money...', 'source': 'Hebrews 13:5' },
        ],
        'anxiety': [
            { 'text': 'Do not be anxious about anything, but in every situation, by prayer and petition, with thanksgiving, present your requests to God.', 'source': 'Philippians 4:6' },
        ],
        'grief': [
            { 'text': 'Blessed are those who mourn, for they shall be comforted.', 'source': 'Matthew 5:4' },
        ],
        'hope': [
            { 'text': 'Those who hope in the Lord will renew their strength.', 'source': 'Isaiah 40:31' },
        ],
        'patience': [
            { 'text': 'Be joyful in hope, patient in affliction, faithful in prayer.', 'source': 'Romans 12:12' },
        ],
        'forgiveness': [
            { 'text': 'Be kind and compassionate to one another, forgiving each other, just as in Christ God forgave you.', 'source': 'Ephesians 4:32' },
        ],
        'wisdom': [
            { 'text': 'If any of you lacks wisdom, you should ask God, who gives generously to all without finding fault.', 'source': 'James 1:5' },
        ],
        'perseverance': [
            { 'text': 'Let us run with perseverance the race marked out for us.', 'source': 'Hebrews 12:1' },
        ],
        'fear': [
            { 'text': 'For God gave us a spirit not of fear but of power and love and self-control.', 'source': '2 Timothy 1:7' },
        ],
        'love': [
            { 'text': 'Love is patient, love is kind...', 'source': '1 Corinthians 13:4-7' },
            { 'text': 'Above all, love each other deeply...', 'source': '1 Peter 4:8' },
        ],
        'faith': [
            { 'text': 'Now faith is confidence in what we hope for...', 'source': 'Hebrews 11:1' },
        ],
        'courage': [
            { 'text': 'Be strong and courageous. Do not be afraid...', 'source': 'Joshua 1:9' },
        ],
        'healing': [
            { 'text': 'He heals the brokenhearted and binds up their wounds.', 'source': 'Psalm 147:3' },
        ],
        'gratitude': [
            { 'text': 'Give thanks in all circumstances...', 'source': '1 Thessalonians 5:18' },
        ],
        'temptation': [
            { 'text': 'God is faithful; he will not let you be tempted beyond what you can bear.', 'source': '1 Corinthians 10:13' },
        ],
        'guidance': [
            { 'text': 'Trust in the Lord with all your heart and lean not on your own understanding.', 'source': 'Proverbs 3:5-6' },
        ],
        'strength': [
            { 'text': 'The Lord is my strength and my shield.', 'source': 'Psalm 28:7' },
        ],
        'peace': [
            { 'text': 'Peace I leave with you; my peace I give you.', 'source': 'John 14:27' },
        ],
        'joy': [
            { 'text': 'The joy of the Lord is your strength.', 'source': 'Nehemiah 8:10' },
        ],
        'humility': [
            { 'text': 'God opposes the proud but gives grace to the humble.', 'source': 'James 4:6' },
        ],
        'anger': [
            { 'text': 'Be angry and do not sin; do not let the sun go down on your anger.', 'source': 'Ephesians 4:26' },
        ],
        'loneliness': [
            { 'text': 'I will never leave you nor forsake you.', 'source': 'Hebrews 13:5' },
        ],
        'addiction': [
            { 'text': 'Where the Spirit of the Lord is, there is freedom.', 'source': '2 Corinthians 3:17' },
        ],
        'depression': [
            { 'text': 'Why, my soul, are you downcast? Put your hope in God.', 'source': 'Psalm 42:5' },
        ],
        'relationships': [
            { 'text': 'Do to others as you would have them do to you.', 'source': 'Luke 6:31' },
        ],
        'work': [
            { 'text': 'Whatever you do, work at it with all your heart, as working for the Lord.', 'source': 'Colossians 3:23' },
        ],
        'study': [
            { 'text': 'Let the wise listen and add to their learning.', 'source': 'Proverbs 1:5' },
        ],
        'decision': [
            { 'text': 'If any of you lacks wisdom, ask God...', 'source': 'James 1:5' },
        ],
        'purpose': [
            { 'text': 'For we are God’s handiwork, created in Christ Jesus to do good works...', 'source': 'Ephesians 2:10' },
        ],
    },
    # Islam - Quran
    'islam': {
        'motivation': [
            { 'text': 'Indeed, with hardship [will be] ease.', 'source': 'Quran 94:6' },
            { 'text': 'And whoever relies upon Allah – then He is sufficient for him.', 'source': 'Quran 65:3' },
        ],
        'stress': [
            { 'text': 'Verily in the remembrance of Allah do hearts find rest.', 'source': 'Quran 13:28' },
            { 'text': 'Allah does not burden a soul beyond that it can bear.', 'source': 'Quran 2:286' },
        ],
        'financial': [
            { 'text': 'Whatever you spend in good, He will replace it.', 'source': 'Quran 34:39' },
            { 'text': 'If you are grateful, I will surely increase you.', 'source': 'Quran 14:7' },
        ],
        'anxiety': [
            { 'text': 'So remember Me; I will remember you.', 'source': 'Quran 2:152' },
        ],
        'hope': [
            { 'text': 'Do not despair of the mercy of Allah.', 'source': 'Quran 39:53' },
        ],
        'patience': [
            { 'text': 'Indeed, Allah is with the patient.', 'source': 'Quran 2:153' },
        ],
        'gratitude': [ { 'text': 'If you are grateful, I will surely increase you.', 'source': 'Quran 14:7' } ],
        'forgiveness': [ { 'text': 'Pardon and overlook so that Allah may forgive you.', 'source': 'Quran 64:14' } ],
        'hope': [ { 'text': 'Do not despair of the mercy of Allah.', 'source': 'Quran 39:53' } ],
        'guidance': [ { 'text': 'And Allah guides whom He wills to a straight path.', 'source': 'Quran 2:213' } ],
        'peace': [ { 'text': 'It is in the remembrance of Allah that hearts find rest.', 'source': 'Quran 13:28' } ],
    },
    # Hinduism - Bhagavad Gita
    'hinduism': {
        'motivation': [
            { 'text': 'You have a right to perform your prescribed duty, but you are not entitled to the fruits of action.', 'source': 'Bhagavad Gita 2.47' },
            { 'text': 'Set thy heart upon thy work, but never on its reward.', 'source': 'Bhagavad Gita' },
        ],
        'stress': [
            { 'text': 'The mind is restless and difficult to restrain, but it is subdued by practice.', 'source': 'Bhagavad Gita 6.35' },
            { 'text': 'When meditation is mastered, the mind is unwavering like the flame of a lamp in a windless place.', 'source': 'Bhagavad Gita 6.19' },
        ],
        'financial': [
            { 'text': 'He who is without attachment, who does not rejoice in gain or lament over loss, is steady in wisdom.', 'source': 'Bhagavad Gita 2.57' },
        ],
        'wisdom': [
            { 'text': 'When your intellect crosses beyond the mire of delusion, then you will become indifferent to what has been heard and what is yet to be heard.', 'source': 'Bhagavad Gita 2.52' },
        ],
        'fear': [
            { 'text': 'The Self is not born, nor does it die.', 'source': 'Bhagavad Gita 2.20' },
        ],
        'duty': [ { 'text': 'You have a right to perform your prescribed duty, but not to the fruits of action.', 'source': 'Bhagavad Gita 2.47' } ],
        'equanimity': [ { 'text': 'Perform your duty with equipoise, abandoning all attachment to success or failure.', 'source': 'Bhagavad Gita 2.48' } ],
        'devotion': [ { 'text': 'Whatever you do, whatever you eat, offer it to Me.', 'source': 'Bhagavad Gita 9.27' } ],
    },
    # Buddhism - Dhammapada
    'buddhism': {
        'motivation': [
            { 'text': 'Drop by drop is the water pot filled. Likewise, the wise man, gathering it little by little, fills himself with good.', 'source': 'Dhammapada 122' },
            { 'text': 'No one saves us but ourselves. No one can and no one may. We ourselves must walk the path.', 'source': 'Dhammapada' },
        ],
        'stress': [
            { 'text': 'All conditioned things are impermanent—when one sees this with wisdom, one turns away from suffering.', 'source': 'Dhammapada 277' },
        ],
        'financial': [
            { 'text': 'Contentment is the greatest wealth.', 'source': 'Dhammapada' },
        ],
        'mindfulness': [
            { 'text': 'The mind is everything. What you think you become.', 'source': 'Dhammapada' },
        ],
        'compassion': [ { 'text': 'Hatred is never appeased by hatred... by non-hatred alone is hatred appeased.', 'source': 'Dhammapada 5' } ],
        'detachment': [ { 'text': 'All conditioned things are impermanent.', 'source': 'Dhammapada 277' } ],
    },
    # Sikhism - Guru Granth Sahib
    'sikhism': {
        'motivation': [
            { 'text': 'With your mind focused on the Lord, all your works are accomplished.', 'source': 'Guru Granth Sahib' },
        ],
        'stress': [
            { 'text': 'Remembering the Lord, all sorrows are dispelled.', 'source': 'Guru Granth Sahib' },
        ],
        'financial': [
            { 'text': 'Those who are contented and humble are the most wealthy.', 'source': 'Guru Granth Sahib' },
        ],
        'service': [ { 'text': 'The greatest comforts and lasting peace are obtained, when one eradicates selfishness from within.', 'source': 'Guru Granth Sahib' } ],
    },
    # Judaism - Tanakh
    'judaism': {
        'motivation': [
            { 'text': 'Be strong and courageous; do not be afraid...', 'source': 'Joshua 1:9' },
            { 'text': 'Commit your work to the Lord, and your plans will be established.', 'source': 'Proverbs 16:3' },
        ],
        'stress': [
            { 'text': 'The Lord is my shepherd; I shall not want... He restores my soul.', 'source': 'Psalm 23' },
        ],
        'financial': [
            { 'text': 'Honor the Lord with your wealth and with the firstfruits of all your produce.', 'source': 'Proverbs 3:9' },
        ],
        'wisdom': [ { 'text': 'The fear of the Lord is the beginning of wisdom.', 'source': 'Proverbs 9:10' } ],
        'peace': [ { 'text': 'Great peace have those who love your law; nothing can make them stumble.', 'source': 'Psalm 119:165' } ],
    },
}

SUPPORTED_RELIGIONS = [
    'christianity', 'islam', 'hinduism', 'buddhism', 'sikhism', 'judaism'
]

# Human-readable scripture names for selector/UI
SCRIPTURE_LABELS: Dict[str, str] = {
    'christianity': 'Holy Bible (KJV)',
    'islam': 'Qur\'an',
    'hinduism': 'Bhagavad Gita',
    'buddhism': 'Dhammapada',
    'sikhism': 'Guru Granth Sahib',
    'judaism': 'Tanakh',
}

# Canonical topics (24) shown for every scripture
CANONICAL_TOPICS: List[str] = [
    'motivation','stress','financial','anxiety','grief','hope','patience','forgiveness','wisdom','perseverance',
    'fear','love','faith','courage','healing','gratitude','temptation','guidance','strength','peace',
    'joy','humility','anger','loneliness','addiction','depression','relationships','work','study','decision','purpose'
][:30]

# ----------------------------------------------------------------------------
# Internationalization (i18n) - simple dictionary-based translations
# ----------------------------------------------------------------------------

LANGUAGES = ['english','mandarin','hindi','spanish','french','arabic','bengali','portuguese','russian','urdu']

TRANSLATIONS: Dict[str, Dict[str, str]] = {
    'english': {
        'app_title': 'Scripture Quotes',
        'nav_dashboard': 'Dashboard',
        'nav_saved': 'Saved Quotes',
        'nav_scripture': 'Scripture',
        'nav_settings': 'Settings',
        'nav_logout': 'Logout',
        'nav_login': 'Login',
        'nav_register': 'Register',
        'login_title': 'Login',
        'email': 'Email',
        'password': 'Password',
        'login': 'Login',
        'forgot_password': 'Forgot your password?',
        'create_account_prompt': 'Create an account',
        'register_title': 'Create Account',
        'name': 'Name',
        'gender': 'Gender',
        'phone_number': 'Phone Number',
        'religion': 'Religion',
        'register': 'Register',
        'settings_title': 'Settings',
        'language': 'Language',
        'two_factor_label': 'Enable 2FA (requires phone number)',
        'save_settings': 'Save Settings',
        'dashboard_welcome': 'Welcome',
        'selected_religion': 'Your selected religion',
        'select_topic': 'Select a topic',
        'get_quotes': 'Get Quotes',
        'or_read_scripture': 'or read the scripture',
        'results_for': 'Results for',
        'no_quotes': 'No quotes found. Try another selection.',
        'save': 'Save',
        'saved_quotes_title': 'Saved Quotes',
        'no_saved_quotes': 'You have no saved quotes yet.',
        'two_factor_title': 'Two-Factor Authentication',
        'enter_code': 'Enter the 6-digit code sent to your phone.',
        'verify': 'Verify',
        'forgot_title': 'Forgot Password',
        'forgot_desc': 'Enter your account email to receive a reset link.',
        'send_reset_link': 'Send Reset Link',
        'back_to_login': 'Back to Login',
        'reset_title': 'Reset Password',
        'new_password': 'New Password',
        'confirm_password': 'Confirm Password',
        'update_password': 'Update Password',
        'scripture_title': 'Scripture',
        'saved_highlighted': 'Saved quotes are highlighted.',
        'back_to_dashboard': 'Back to Dashboard',
        'invalid_credentials': 'Invalid credentials.',
        'welcome_back': 'Welcome back!',
        'logged_out': 'You have been logged out.',
        'no_quote_to_save': 'No quote to save.',
        'quote_saved': 'Quote saved!',
        'invalid_email': 'Invalid email',
        'provide_valid_name_religion': 'Please provide a valid name and pick a supported religion.',
        'password_min_length': 'Password must be at least 6 characters.',
        'email_exists': 'Email already registered. Please login.',
        'registration_success': 'Registration successful. Please login.',
        'twofa_expired': '2FA session expired. Please login again.',
        'invalid_or_expired_code': 'Invalid or expired code.',
        'twofa_verified': '2FA verified. Welcome!',
        'settings_updated': 'Settings updated.',
        'add_phone_for_2fa': 'Please add a phone number to enable 2FA.',
        'reset_link_if_exists': 'If the account exists, a reset link has been sent.',
        'invalid_or_expired_reset': 'Invalid or expired reset link.',
        'password_updated': 'Password updated. Please login.',
    },
}

def current_language() -> str:
    if not current_user.is_authenticated:
        return 'english'
    db = SessionLocal()
    try:
        settings = db.query(UserSettings).filter(UserSettings.user_id == int(current_user.get_id())).first()
        if settings and settings.language in LANGUAGES:
            return settings.language
        return 'english'
    finally:
        db.close()

def tr(key: str) -> str:
    lang = current_language()
    table = TRANSLATIONS.get(lang) or TRANSLATIONS['english']
    return table.get(key, TRANSLATIONS['english'].get(key, key))

@app.context_processor
def inject_translator():
    return {
        '_': tr
    }

# (Removed excerpt store; scripture reading removed)

# ----------------------------------------------------------------------------
# Helpers
# ----------------------------------------------------------------------------

def normalize_keyword(raw: str) -> str:
    return (raw or '').strip().lower()

# ----------------------------------------------------------------------------
# Routes
# ----------------------------------------------------------------------------

@app.route('/')
@login_required
def index():
    return redirect(url_for('dashboard'))

@app.route('/register', methods=['GET', 'POST'])
def register():
    if request.method == 'POST':
        email = (request.form.get('email') or '').strip().lower()
        name = (request.form.get('name') or '').strip()
        gender = (request.form.get('gender') or '').strip()
        phone_number = (request.form.get('phone_number') or '').strip()
        religion = 'christianity'
        password = request.form.get('password') or ''

        # basic validation
        try:
            validate_email(email)
        except EmailNotValidError as e:
            flash(f"{tr('invalid_email')}: {str(e)}", 'danger')
            return render_template('register.html', religions=SUPPORTED_RELIGIONS)

        if not name:
            flash(tr('provide_valid_name_religion'), 'danger')
            return render_template('register.html', religions=SUPPORTED_RELIGIONS)

        if len(password) < 6:
            flash(tr('password_min_length'), 'danger')
            return render_template('register.html', religions=SUPPORTED_RELIGIONS)

        db = SessionLocal()
        try:
            existing = db.query(User).filter(User.email == email).first()
            if existing:
                flash(tr('email_exists'), 'warning')
                return redirect(url_for('login'))

            pw_hash = bcrypt.generate_password_hash(password).decode('utf-8')
            user = User(
                email=email,
                name=name,
                gender=gender,
                phone_number=phone_number,
                religion=religion,
                password_hash=pw_hash,
            )
            db.add(user)
            db.commit()
            # initialize settings
            settings = UserSettings(user_id=user.id, two_factor_enabled=False)
            db.add(settings)
            db.commit()
            flash(tr('registration_success'), 'success')
            return redirect(url_for('login'))
        finally:
            db.close()
    return render_template('register.html', religions=SUPPORTED_RELIGIONS)

@app.route('/login', methods=['GET', 'POST'])
def login():
    if request.method == 'POST':
        email = (request.form.get('email') or '').strip().lower()
        password = request.form.get('password') or ''

        db = SessionLocal()
        try:
            user = db.query(User).filter(User.email == email).first()
            if not user or not bcrypt.check_password_hash(user.password_hash, password):
                flash(tr('invalid_credentials'), 'danger')
                return render_template('login.html')
            # Check 2FA settings
            settings = db.query(UserSettings).filter(UserSettings.user_id == user.id).first()
            if settings and settings.two_factor_enabled:
                # Generate a one-time 6-digit code valid for 10 minutes
                code = f"{secrets.randbelow(1000000):06d}"
                token_value = secrets.token_urlsafe(32)
                expires = datetime.utcnow() + timedelta(minutes=10)
                # cleanup existing 2fa tokens for user
                db.query(OneTimeToken).filter(OneTimeToken.user_id == user.id, OneTimeToken.purpose == '2fa').delete()
                db.add(OneTimeToken(user_id=user.id, token=token_value, purpose='2fa', code=code, expires_at=expires))
                db.commit()
                # Store pending user in session until code is verified
                flask_session['pending_2fa_user_id'] = user.id
                flask_session['pending_2fa_token'] = token_value
                # In a real app, send code via SMS to user.phone_number. Dev hint:
                flash(f"Dev: 2FA code sent (for demo) — {code}", 'info')
                return redirect(url_for('two_factor'))
            else:
                login_user(user)
                flash(tr('welcome_back'), 'success')
                return redirect(url_for('dashboard'))
        finally:
            db.close()
    return render_template('login.html')

@app.route('/logout')
@login_required
def logout():
    logout_user()
    flash(tr('logged_out'), 'info')
    return redirect(url_for('login'))

@app.route('/dashboard', methods=['GET', 'POST'])
@login_required
def dashboard():
    selected_keyword = None
    found_quotes: List[Dict[str, str]] = []
    selected_religion = flask_session.get('selected_religion') or 'christianity'

    if request.method == 'POST':
        raw_keyword = request.form.get('keyword')
        selected_religion = (request.form.get('religion') or selected_religion).strip().lower()
        flask_session['selected_religion'] = selected_religion
        selected_keyword = normalize_keyword(raw_keyword)
        bucket = QUOTE_DATA.get(selected_religion, {})
        # primary
        found_quotes = bucket.get(selected_keyword, []) or []
        # fallback 1: motivation
        if not found_quotes:
            found_quotes = bucket.get('motivation', []) or []
        # fallback 2: any quotes from this scripture
        if not found_quotes:
            agg: List[Dict[str, str]] = []
            for lst in bucket.values():
                if lst:
                    agg.extend(lst)
            found_quotes = agg

    return render_template(
        'dashboard.html',
        religion=selected_religion,
        selected_religion=selected_religion,
        scripture_options=[(k, SCRIPTURE_LABELS.get(k, k.capitalize())) for k in SUPPORTED_RELIGIONS],
        keywords=CANONICAL_TOPICS,
        selected_keyword=selected_keyword,
        quotes=found_quotes,
    )

# ----------------------------------------------------------------------------
# Two-Factor Authentication routes
# ----------------------------------------------------------------------------

@app.route('/two-factor', methods=['GET', 'POST'])
def two_factor():
    pending_user_id = flask_session.get('pending_2fa_user_id')
    pending_token = flask_session.get('pending_2fa_token')
    if not pending_user_id or not pending_token:
        flash(tr('twofa_expired'), 'warning')
        return redirect(url_for('login'))

    if request.method == 'POST':
        code = (request.form.get('code') or '').strip()
        db = SessionLocal()
        try:
            ott = (
                db.query(OneTimeToken)
                  .filter(OneTimeToken.user_id == int(pending_user_id), OneTimeToken.purpose == '2fa', OneTimeToken.token == pending_token)
                  .first()
            )
            if not ott or datetime.utcnow() > ott.expires_at or ott.code != code:
                flash(tr('invalid_or_expired_code'), 'danger')
                return render_template('two_factor.html')
            user = db.get(User, int(pending_user_id))
            # consume token
            db.delete(ott)
            db.commit()
            flask_session.pop('pending_2fa_user_id', None)
            flask_session.pop('pending_2fa_token', None)
            login_user(user)
            flash(tr('twofa_verified'), 'success')
            return redirect(url_for('dashboard'))
        finally:
            db.close()
    return render_template('two_factor.html')


@app.route('/settings', methods=['GET', 'POST'])
@login_required
def settings():
    db = SessionLocal()
    try:
        settings = db.query(UserSettings).filter(UserSettings.user_id == int(current_user.get_id())).first()
        if not settings:
            settings = UserSettings(user_id=int(current_user.get_id()), two_factor_enabled=False)
            db.add(settings)
            db.commit()
        if request.method == 'POST':
            phone_number = (request.form.get('phone_number') or '').strip()
            two_factor_enabled = (request.form.get('two_factor_enabled') == 'on')
            language = (request.form.get('language') or 'english').strip().lower()
            # update user phone
            user = db.get(User, int(current_user.get_id()))
            user.phone_number = phone_number
            settings.two_factor_enabled = two_factor_enabled and bool(phone_number)
            settings.language = language or 'english'
            db.commit()
            if two_factor_enabled and not phone_number:
                flash(tr('add_phone_for_2fa'), 'warning')
            else:
                flash(tr('settings_updated'), 'success')
            return redirect(url_for('settings'))
        # GET
        user = db.get(User, int(current_user.get_id()))
        return render_template('settings.html', settings=settings, user=user)
    finally:
        db.close()

@app.route('/save-quote', methods=['POST'])
@login_required
def save_quote():
    keyword = normalize_keyword(request.form.get('keyword'))
    quote = (request.form.get('quote') or '').strip()
    source = (request.form.get('source') or '').strip()
    religion = (request.form.get('religion') or flask_session.get('selected_religion') or 'christianity').strip().lower()

    if not quote:
        flash(tr('no_quote_to_save'), 'danger')
        return redirect(url_for('dashboard'))

    db = SessionLocal()
    try:
        entry = SavedQuote(
            user_id=int(current_user.get_id()),
            religion=religion,
            keyword=keyword or 'general',
            quote=quote,
            source=source,
        )
        db.add(entry)
        db.commit()
        flash(tr('quote_saved'), 'success')
    finally:
        db.close()
    return redirect(url_for('dashboard'))

@app.route('/saved')
@login_required
def saved():
    db = SessionLocal()
    try:
        quotes = (
            db.query(SavedQuote)
              .filter(SavedQuote.user_id == int(current_user.get_id()))
              .order_by(SavedQuote.id.desc())
              .all()
        )
        return render_template('saved.html', quotes=quotes)
    finally:
        db.close()

@app.route('/delete-quote', methods=['POST'])
@login_required
def delete_quote():
    quote_id_raw = request.form.get('id') or ''
    try:
        quote_id = int(quote_id_raw)
    except ValueError:
        flash('Invalid quote.', 'danger')
        return redirect(url_for('saved'))

    db = SessionLocal()
    try:
        q = db.query(SavedQuote).filter(SavedQuote.id == quote_id).first()
        if not q or q.user_id != int(current_user.get_id()):
            flash('Quote not found.', 'warning')
            return redirect(url_for('saved'))
        db.delete(q)
        db.commit()
        flash('Quote removed.', 'success')
        return redirect(url_for('saved'))
    finally:
        db.close()

# (Scripture reading feature removed as per requirements)

# ----------------------------------------------------------------------------
# Password reset flow (dev demo: shows link/code via flash)
# ----------------------------------------------------------------------------

@app.route('/forgot-password', methods=['GET', 'POST'])
def forgot_password():
    if request.method == 'POST':
        email = (request.form.get('email') or '').strip().lower()
        db = SessionLocal()
        try:
            user = db.query(User).filter(User.email == email).first()
            if not user:
                flash(tr('reset_link_if_exists'), 'info')
                return redirect(url_for('login'))
            token_value = secrets.token_urlsafe(32)
            expires = datetime.utcnow() + timedelta(hours=1)
            db.query(OneTimeToken).filter(OneTimeToken.user_id == user.id, OneTimeToken.purpose == 'password_reset').delete()
            db.add(OneTimeToken(user_id=user.id, token=token_value, purpose='password_reset', code=None, expires_at=expires))
            db.commit()
            reset_url = url_for('reset_password', token=token_value, _external=True)
            # In production, email this URL. For dev, show it.
            flash(f"Dev: Password reset link — {reset_url}", 'info')
            flash(tr('reset_link_if_exists'), 'info')
            return redirect(url_for('login'))
        finally:
            db.close()
    return render_template('forgot_password.html')


@app.route('/reset-password/<token>', methods=['GET', 'POST'])
def reset_password(token: str):
    db = SessionLocal()
    try:
        ott = db.query(OneTimeToken).filter(OneTimeToken.token == token, OneTimeToken.purpose == 'password_reset').first()
        if not ott or datetime.utcnow() > ott.expires_at:
            flash(tr('invalid_or_expired_reset'), 'danger')
            return redirect(url_for('login'))
        if request.method == 'POST':
            password = request.form.get('password') or ''
            confirm = request.form.get('confirm') or ''
            if len(password) < 6:
                flash(tr('password_min_length'), 'danger')
                return render_template('reset_password.html')
            if password != confirm:
                flash('Passwords do not match.', 'danger')
                return render_template('reset_password.html')
            user = db.get(User, ott.user_id)
            user.password_hash = bcrypt.generate_password_hash(password).decode('utf-8')
            db.delete(ott)
            db.commit()
            flash(tr('password_updated'), 'success')
            return redirect(url_for('login'))
        return render_template('reset_password.html')
    finally:
        db.close()

if __name__ == '__main__':
    app.run(debug=True)
