using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slotmachine
{
    public partial class Form1 : Form
    {
        Random box = new Random();
        int num;
        int num2;
        int num3;
        int points = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btn_pull_Click(object sender, EventArgs e)
        {
            lbl_score.Text = points.ToString();
            points = points - 10;
            num = box.Next(1,4);
            num2 = box.Next(1, 4);
            num3 = box.Next(1, 4);
            if(num==num2&&num2==num3)
            {
                num = box.Next(1, 4);
                num2 = box.Next(1, 4);
                num3 = box.Next(1, 4);
            }
            if (num == 1) 
            { 
                pb_arash.BackgroundImage = Properties.Resources.arash; 
            }
            else if (num == 2)
            {
                pb_arash.BackgroundImage = Properties.Resources.arash2;
            }
           else if (num == 3)
            {
                pb_arash.BackgroundImage = Properties.Resources.arash3;
            }



            
            if (num2 == 1)
            {
                pb_arash_2.BackgroundImage = Properties.Resources.arash;
            }
            else if (num2 == 2)
            {
                pb_arash_2.BackgroundImage = Properties.Resources.arash2;
            }
            else if (num2 == 3)
            {
                pb_arash_2.BackgroundImage = Properties.Resources.arash3;
            }



            
            if (num3 == 1)
            {
                pb_arash_3.BackgroundImage = Properties.Resources.arash;
            }
            else if (num3 == 2)
            {
                pb_arash_3.BackgroundImage = Properties.Resources.arash2;
            }
            else if (num3 == 3)
            {
                pb_arash_3.BackgroundImage = Properties.Resources.arash3;
            }
            if (num == 1 && num2 == 1 && num3 == 1)
            {
                points = points + 50;
                MessageBox.Show("You Won 50 Points!");
                lbl_score.Text = points.ToString();
            }
            if (num == 2 && num2 == 2 && num3 == 2)
            {
                points = points + 500;
                MessageBox.Show("You Won 500 Points!");
                lbl_score.Text = points.ToString();
            }
            if (num == 3 && num2 == 3 && num3 == 3)
            {
                points = points + 100;
                MessageBox.Show("You Won 100 Points!");
                lbl_score.Text = points.ToString();
            }
            if (points == 0)
            {
                lbl_score.Text = points.ToString();
                MessageBox.Show("U are literally as dumb as Arash, and now you've lost ur all ur points. SO GO HOME AND CRY, I DONT CARE");
                Application.Exit();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_score_Click(object sender, EventArgs e)
        {
            lbl_score.Text = points.ToString();
        }

        private void pb_arash_Click(object sender, EventArgs e)
        {

        }
    }
}
