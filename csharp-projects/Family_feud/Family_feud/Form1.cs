using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Family_feud
{
    public partial class Form1 : Form
    {
        int winner = 0;
        int correct = 0;
        int lives = 3;
        int time = 200;
        bool a1 = true;
        bool a2 = true;
        bool a3 = true;
        bool a4 = true;
        bool a5 = true;
        bool a6 = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_answer_TextChanged(object sender, EventArgs e)
        {


        }

        private void lbl_spongebob_Click(object sender, EventArgs e)
        {

        }

        private void lbl_score_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_answer.Text.ToLower() == "spongebob")
            {
                if (a1 == true)
                {
                    lbl_spongebob.Visible = true;
                    correct = correct + 1200;
                    winner = winner + 1;
                    a1 = false;
                    time = time + 50;
                }
                else
                {
                    MessageBox.Show("Are you crazy?, you already said it once like what the hell, are you dumb?");
                }
            }
            else if (txt_answer.Text.ToLower() == "patrick")
                if (a2 == true)
            {
                lbl_patrick.Visible = true;
                correct = correct + 1000;
                winner = winner + 1;
                    a2 = false;
                    time = time + 50;
                }
                else
                {
                    MessageBox.Show("Are you crazy?, you already said it once like what the hell, are you dumb?");
                }
            else if (txt_answer.Text.ToLower() == "mr.krabs")
                if(a3 == true)
            {
                lbl_mrcrabs.Visible = true;
                correct = correct + 250;
                winner = winner + 1;
                    a3 = false;
                    time = time + 50;
                }
                else
                {
                    MessageBox.Show("Are you crazy?, you already said it once like what the hell, are you dumb?");
                }
            else if (txt_answer.Text.ToLower() == "squidward")
                if(a4 == true)
            {
                lbl_squidward.Visible = true;
                correct = correct + 500;
                winner = winner + 1;
                    a4 = false;
                    time = time + 50;
                }
            else
                {
                    MessageBox.Show("Are you crazy?, you already said it once like what the hell, are you dumb?");
                }
            else if (txt_answer.Text.ToLower() == "plankton")
                if(a5 == true)
            {
                lbl_plankton.Visible = true;
                correct = correct + 800;
                winner = winner + 1;
                    a5 = false;
                    time = time + 50;
                }
                else
                {
                    MessageBox.Show("Are you crazy?, you already said it once like what the hell, are you dumb?");
                }
            else if (txt_answer.Text.ToLower() == "sandy")
                if (a6 == true) 
            {
                lbl_sandy.Visible = true;
                correct = correct + 150;
                winner = winner + 1;
                    a6 = false;
                    time = time + 50;
                }
            else
                {
                    MessageBox.Show("Are you crazy?, you already said it once like what the hell, are you dumb?");
                }
            else
            {
                lives = lives - 1;
                if (lives == 2)
                {
                    pb_life.Visible = false;
                }
                else if (lives == 1)
                {
                    pb_life2.Visible = false;
                }
                else if (lives == 0)
                {
                    pb_life3.Visible = false;
                    MessageBox.Show("You have lost all your lives, and Mr.Crabs has now overtaken your entire family estate. " +
                        "Cause ur a dumbass like holy shit man, how do you lose like that! " +
                        "(that comment was for everybody except john, because i need a good mark john please) But hey you can always try again! I lied you're a loser" +
                        "HEHE");
                    Application.Exit();
                }
                
            }
            if (winner == 6)
            {
                timer1.Stop();
                MessageBox.Show("Congrats!, youve won spongebob family fued with a score of " + correct + " Good job, you want a cookie?, NO YOU DONT GET ONE CAUSE ITS MY COOKIE");
                Application.Exit();
            }
            txt_answer.Text = "";
            lbl_score.Text = correct.ToString();
            lbl_time.Text = time.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lbl_time_Click(object sender, EventArgs e)
        {
            lbl_time.Text = time.ToString();
            time--;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = time.ToString();
            time--;
            if (time == -1)
            { 
            timer1.Stop();
                MessageBox.Show("You have lost all your time, and Mr.Crabs has now overtaken your entire family estate. cause i dont even why" +
                        "prolly Cause ur a dumbass like holy shit man, how do you lose like that! " +
                        "(that comment was for everybody except john, because i need a good mark john please) But hey you can always try again! I lied you're a loser" +
                        "HEHE");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}