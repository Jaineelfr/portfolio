namespace jumble
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
            this.btn_check = new System.Windows.Forms.Button();
            this.tb_guess = new System.Windows.Forms.TextBox();
            this.lbl_guess = new System.Windows.Forms.Label();
            this.lbl_word = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(602, 371);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(139, 83);
            this.btn_check.TabIndex = 0;
            this.btn_check.Text = "Enter";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // tb_guess
            // 
            this.tb_guess.Location = new System.Drawing.Point(286, 423);
            this.tb_guess.Name = "tb_guess";
            this.tb_guess.Size = new System.Drawing.Size(300, 31);
            this.tb_guess.TabIndex = 1;
            this.tb_guess.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_guess
            // 
            this.lbl_guess.AutoSize = true;
            this.lbl_guess.Location = new System.Drawing.Point(281, 382);
            this.lbl_guess.Name = "lbl_guess";
            this.lbl_guess.Size = new System.Drawing.Size(164, 25);
            this.lbl_guess.TabIndex = 2;
            this.lbl_guess.Text = "guess the word:";
            // 
            // lbl_word
            // 
            this.lbl_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_word.Location = new System.Drawing.Point(379, 194);
            this.lbl_word.Name = "lbl_word";
            this.lbl_word.Size = new System.Drawing.Size(194, 92);
            this.lbl_word.TabIndex = 3;
            this.lbl_word.Text = "WORD";
            this.lbl_word.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 92);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jaineel\'s Jumble";
            // 
            // lbl_score
            // 
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(29, 299);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(194, 92);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "SCORE";
            this.lbl_score.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Words you got correct:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Click below to see the Time left:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lbl_time
            // 
            this.lbl_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_time.Location = new System.Drawing.Point(593, 137);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(194, 92);
            this.lbl_time.TabIndex = 8;
            this.lbl_time.Text = "Time";
            this.lbl_time.Click += new System.EventHandler(this.lbl_time_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 637);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_word);
            this.Controls.Add(this.lbl_guess);
            this.Controls.Add(this.tb_guess);
            this.Controls.Add(this.btn_check);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox tb_guess;
        private System.Windows.Forms.Label lbl_guess;
        private System.Windows.Forms.Label lbl_word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_time;
    }
}

