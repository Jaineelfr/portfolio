namespace pacman
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
            this.pacman = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            this.SuspendLayout();
            // 
            // pacman
            // 
            this.pacman.BackgroundImage = global::pacman.Properties.Resources.pacMouthClosed;
            this.pacman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pacman.Location = new System.Drawing.Point(13, 13);
            this.pacman.Margin = new System.Windows.Forms.Padding(4);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(118, 119);
            this.pacman.TabIndex = 0;
            this.pacman.TabStop = false;
            this.pacman.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1474, 1044);
            this.Controls.Add(this.pacman);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pacman;
    }
}

