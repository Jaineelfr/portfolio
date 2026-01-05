namespace Family_feud
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_scoretxt = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.lbl_answertxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_spongebob = new System.Windows.Forms.Label();
            this.lbl_patrick = new System.Windows.Forms.Label();
            this.lbl_mrcrabs = new System.Windows.Forms.Label();
            this.lbl_sandy = new System.Windows.Forms.Label();
            this.lbl_squidward = new System.Windows.Forms.Label();
            this.lbl_plankton = new System.Windows.Forms.Label();
            this.pb_life = new System.Windows.Forms.PictureBox();
            this.lbl_life = new System.Windows.Forms.Label();
            this.pb_life2 = new System.Windows.Forms.PictureBox();
            this.pb_life3 = new System.Windows.Forms.PictureBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_life)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_life3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_scoretxt
            // 
            this.lbl_scoretxt.AutoSize = true;
            this.lbl_scoretxt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_scoretxt.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoretxt.Location = new System.Drawing.Point(13, 28);
            this.lbl_scoretxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_scoretxt.Name = "lbl_scoretxt";
            this.lbl_scoretxt.Size = new System.Drawing.Size(111, 29);
            this.lbl_scoretxt.TabIndex = 0;
            this.lbl_scoretxt.Text = "SCORE:";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_score.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(24, 57);
            this.lbl_score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(30, 29);
            this.lbl_score.TabIndex = 1;
            this.lbl_score.Text = "0";
            this.lbl_score.Click += new System.EventHandler(this.lbl_score_Click);
            // 
            // txt_answer
            // 
            this.txt_answer.BackColor = System.Drawing.Color.Black;
            this.txt_answer.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_answer.ForeColor = System.Drawing.Color.White;
            this.txt_answer.Location = new System.Drawing.Point(262, 504);
            this.txt_answer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(282, 35);
            this.txt_answer.TabIndex = 2;
            this.txt_answer.TextChanged += new System.EventHandler(this.txt_answer_TextChanged);
            // 
            // lbl_answertxt
            // 
            this.lbl_answertxt.AutoSize = true;
            this.lbl_answertxt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_answertxt.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_answertxt.Location = new System.Drawing.Point(122, 505);
            this.lbl_answertxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_answertxt.Name = "lbl_answertxt";
            this.lbl_answertxt.Size = new System.Drawing.Size(139, 29);
            this.lbl_answertxt.TabIndex = 3;
            this.lbl_answertxt.Text = "ANSWER:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(134, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Most Famous Spongebob Characters";
            // 
            // lbl_spongebob
            // 
            this.lbl_spongebob.AutoSize = true;
            this.lbl_spongebob.BackColor = System.Drawing.Color.Gold;
            this.lbl_spongebob.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spongebob.Location = new System.Drawing.Point(142, 238);
            this.lbl_spongebob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_spongebob.Name = "lbl_spongebob";
            this.lbl_spongebob.Size = new System.Drawing.Size(178, 29);
            this.lbl_spongebob.TabIndex = 5;
            this.lbl_spongebob.Text = "SPONGEBOB";
            this.lbl_spongebob.Visible = false;
            this.lbl_spongebob.Click += new System.EventHandler(this.lbl_spongebob_Click);
            // 
            // lbl_patrick
            // 
            this.lbl_patrick.AutoSize = true;
            this.lbl_patrick.BackColor = System.Drawing.Color.Gold;
            this.lbl_patrick.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patrick.Location = new System.Drawing.Point(166, 326);
            this.lbl_patrick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_patrick.Name = "lbl_patrick";
            this.lbl_patrick.Size = new System.Drawing.Size(131, 29);
            this.lbl_patrick.TabIndex = 6;
            this.lbl_patrick.Text = "PATRICK";
            this.lbl_patrick.Visible = false;
            // 
            // lbl_mrcrabs
            // 
            this.lbl_mrcrabs.AutoSize = true;
            this.lbl_mrcrabs.BackColor = System.Drawing.Color.Gold;
            this.lbl_mrcrabs.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mrcrabs.Location = new System.Drawing.Point(447, 326);
            this.lbl_mrcrabs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mrcrabs.Name = "lbl_mrcrabs";
            this.lbl_mrcrabs.Size = new System.Drawing.Size(156, 29);
            this.lbl_mrcrabs.TabIndex = 7;
            this.lbl_mrcrabs.Text = "MR.KRABS";
            this.lbl_mrcrabs.Visible = false;
            // 
            // lbl_sandy
            // 
            this.lbl_sandy.AutoSize = true;
            this.lbl_sandy.BackColor = System.Drawing.Color.Gold;
            this.lbl_sandy.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sandy.Location = new System.Drawing.Point(472, 419);
            this.lbl_sandy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sandy.Name = "lbl_sandy";
            this.lbl_sandy.Size = new System.Drawing.Size(105, 29);
            this.lbl_sandy.TabIndex = 8;
            this.lbl_sandy.Text = "SANDY";
            this.lbl_sandy.Visible = false;
            // 
            // lbl_squidward
            // 
            this.lbl_squidward.AutoSize = true;
            this.lbl_squidward.BackColor = System.Drawing.Color.Gold;
            this.lbl_squidward.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_squidward.Location = new System.Drawing.Point(433, 238);
            this.lbl_squidward.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_squidward.Name = "lbl_squidward";
            this.lbl_squidward.Size = new System.Drawing.Size(184, 29);
            this.lbl_squidward.TabIndex = 9;
            this.lbl_squidward.Text = "SQUIDWARD";
            this.lbl_squidward.Visible = false;
            // 
            // lbl_plankton
            // 
            this.lbl_plankton.AutoSize = true;
            this.lbl_plankton.BackColor = System.Drawing.Color.Gold;
            this.lbl_plankton.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plankton.Location = new System.Drawing.Point(160, 419);
            this.lbl_plankton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_plankton.Name = "lbl_plankton";
            this.lbl_plankton.Size = new System.Drawing.Size(160, 29);
            this.lbl_plankton.TabIndex = 10;
            this.lbl_plankton.Text = "PLANKTON";
            this.lbl_plankton.Visible = false;
            // 
            // pb_life
            // 
            this.pb_life.BackColor = System.Drawing.Color.Transparent;
            this.pb_life.BackgroundImage = global::Family_feud.Properties.Resources.rich;
            this.pb_life.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_life.Location = new System.Drawing.Point(507, 100);
            this.pb_life.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_life.Name = "pb_life";
            this.pb_life.Size = new System.Drawing.Size(70, 78);
            this.pb_life.TabIndex = 11;
            this.pb_life.TabStop = false;
            // 
            // lbl_life
            // 
            this.lbl_life.AutoSize = true;
            this.lbl_life.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_life.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_life.Location = new System.Drawing.Point(502, 37);
            this.lbl_life.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_life.Name = "lbl_life";
            this.lbl_life.Size = new System.Drawing.Size(98, 29);
            this.lbl_life.TabIndex = 12;
            this.lbl_life.Text = "LIFES:";
            // 
            // pb_life2
            // 
            this.pb_life2.BackColor = System.Drawing.Color.Transparent;
            this.pb_life2.BackgroundImage = global::Family_feud.Properties.Resources.rich;
            this.pb_life2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_life2.Location = new System.Drawing.Point(595, 100);
            this.pb_life2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_life2.Name = "pb_life2";
            this.pb_life2.Size = new System.Drawing.Size(70, 78);
            this.pb_life2.TabIndex = 13;
            this.pb_life2.TabStop = false;
            // 
            // pb_life3
            // 
            this.pb_life3.BackColor = System.Drawing.Color.Transparent;
            this.pb_life3.BackgroundImage = global::Family_feud.Properties.Resources.rich;
            this.pb_life3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_life3.Location = new System.Drawing.Point(685, 100);
            this.pb_life3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_life3.Name = "pb_life3";
            this.pb_life3.Size = new System.Drawing.Size(70, 78);
            this.pb_life3.TabIndex = 14;
            this.pb_life3.TabStop = false;
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_enter.Location = new System.Drawing.Point(549, 512);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 23);
            this.btn_enter.TabIndex = 15;
            this.btn_enter.Text = "ENTER";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_time.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(24, 115);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(82, 29);
            this.lbl_time.TabIndex = 16;
            this.lbl_time.Text = "TIME";
            this.lbl_time.Click += new System.EventHandler(this.lbl_time_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Family_feud.Properties.Resources.Family_Feud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 583);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.pb_life3);
            this.Controls.Add(this.pb_life2);
            this.Controls.Add(this.lbl_life);
            this.Controls.Add(this.pb_life);
            this.Controls.Add(this.lbl_plankton);
            this.Controls.Add(this.lbl_squidward);
            this.Controls.Add(this.lbl_sandy);
            this.Controls.Add(this.lbl_mrcrabs);
            this.Controls.Add(this.lbl_patrick);
            this.Controls.Add(this.lbl_spongebob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_answertxt);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_scoretxt);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_life)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_life3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_scoretxt;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.TextBox txt_answer;
        private System.Windows.Forms.Label lbl_answertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_spongebob;
        private System.Windows.Forms.Label lbl_patrick;
        private System.Windows.Forms.Label lbl_mrcrabs;
        private System.Windows.Forms.Label lbl_sandy;
        private System.Windows.Forms.Label lbl_squidward;
        private System.Windows.Forms.Label lbl_plankton;
        private System.Windows.Forms.PictureBox pb_life;
        private System.Windows.Forms.Label lbl_life;
        private System.Windows.Forms.PictureBox pb_life2;
        private System.Windows.Forms.PictureBox pb_life3;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
    }
}

