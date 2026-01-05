# Scripture Quotes App

A simple Flask app where users register/login, choose their religion, enter keywords (motivation, stress, financial, etc.), and receive matching quotes from their scripture. Users can save quotes and view them later.

## Features
- Registration with email, name, gender, phone, religion, password
- Login/Logout
- Enter keywords to fetch quotes from your chosen scripture
- Save quotes to your account and view them in Saved Quotes

## Quickstart

```bash
python3 -m venv .venv
source .venv/bin/activate
pip install -r requirements.txt
export FLASK_APP=app.py
export FLASK_ENV=development
flask run
```

Then open http://127.0.0.1:5000

## Notes
- This app uses SQLite (`app.db`) for persistence.
- Quote dataset is minimal and intended as a demo. Expand `QUOTE_DATA` as needed.

## Full Scripture Data

Place full-text files (UTF-8) in the `data/` folder to enable full reading with pagination:

- `data/christianity.txt` (e.g., King James Version is public domain)
- `data/islam.txt` (check public-domain translations; verify rights locally)
- `data/hinduism.txt` (public-domain Bhagavad Gita translations exist)
- `data/buddhism.txt` (e.g., public-domain Dhammapada translations)
- `data/sikhism.txt` (verify public-domain source)
- `data/judaism.txt` (public-domain Tanakh translations may be available)

On the Scripture page, texts are paginated by characters and you can select any text snippet to save it as a quote. Saved quotes are highlighted wherever they appear.
