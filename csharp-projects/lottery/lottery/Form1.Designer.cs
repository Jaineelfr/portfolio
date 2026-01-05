namespace lottery
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
            this.pb_lottomax = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_3lot = new System.Windows.Forms.RadioButton();
            this.rb_4lot = new System.Windows.Forms.RadioButton();
            this.rb_5lot = new System.Windows.Forms.RadioButton();
            this.btn_generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lottomax)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_lottomax
            // 
            this.pb_lottomax.BackColor = System.Drawing.Color.Transparent;
            this.pb_lottomax.BackgroundImage = global::lottery.Properties.Resources.Lotto_Max_Logo;
            this.pb_lottomax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_lottomax.Location = new System.Drawing.Point(355, 39);
            this.pb_lottomax.Name = "pb_lottomax";
            this.pb_lottomax.Size = new System.Drawing.Size(489, 288);
            this.pb_lottomax.TabIndex = 0;
            this.pb_lottomax.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rb_5lot);
            this.groupBox1.Controls.Add(this.rb_3lot);
            this.groupBox1.Controls.Add(this.rb_4lot);
            this.groupBox1.Location = new System.Drawing.Point(408, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a game:";
            // 
            // rb_3lot
            // 
            this.rb_3lot.AutoSize = true;
            this.rb_3lot.BackColor = System.Drawing.Color.Transparent;
            this.rb_3lot.Location = new System.Drawing.Point(33, 50);
            this.rb_3lot.Name = "rb_3lot";
            this.rb_3lot.Size = new System.Drawing.Size(209, 29);
            this.rb_3lot.TabIndex = 0;
            this.rb_3lot.TabStop = true;
            this.rb_3lot.Text = "3-Number Lottery";
            this.rb_3lot.UseVisualStyleBackColor = false;
            this.rb_3lot.CheckedChanged += new System.EventHandler(this.rb_3lot_CheckedChanged);
            // 
            // rb_4lot
            // 
            this.rb_4lot.AutoSize = true;
            this.rb_4lot.BackColor = System.Drawing.Color.Transparent;
            this.rb_4lot.Location = new System.Drawing.Point(33, 100);
            this.rb_4lot.Name = "rb_4lot";
            this.rb_4lot.Size = new System.Drawing.Size(209, 29);
            this.rb_4lot.TabIndex = 2;
            this.rb_4lot.TabStop = true;
            this.rb_4lot.Text = "4-Number Lottery";
            this.rb_4lot.UseVisualStyleBackColor = false;
            // 
            // rb_5lot
            // 
            this.rb_5lot.AutoSize = true;
            this.rb_5lot.BackColor = System.Drawing.Color.Transparent;
            this.rb_5lot.Location = new System.Drawing.Point(33, 151);
            this.rb_5lot.Name = "rb_5lot";
            this.rb_5lot.Size = new System.Drawing.Size(209, 29);
            this.rb_5lot.TabIndex = 3;
            this.rb_5lot.TabStop = true;
            this.rb_5lot.Text = "5-Number Lottery";
            this.rb_5lot.UseVisualStyleBackColor = false;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(425, 583);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(321, 66);
            this.btn_generate.TabIndex = 2;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 688);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 3;
            // 
            // txt_num
            // 
            this.txt_num.Enabled = false;
            this.txt_num.Location = new System.Drawing.Point(487, 655);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(209, 31);
            this.txt_num.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1209, 915);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pb_lottomax);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_lottomax)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_lottomax;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_3lot;
        private System.Windows.Forms.RadioButton rb_4lot;
        private System.Windows.Forms.RadioButton rb_5lot;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_num;
    }
}

