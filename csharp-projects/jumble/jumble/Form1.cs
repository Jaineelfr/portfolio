using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jumble
{
    public partial class Form1 : Form
    {
        string[] words = { "luck", "bank", "desk", "ship", "roof", "wave", "code", "tree", "book", "fire",
            "game", "lamp", "door", "star", "milk", "snow", "frog", "wind", "moon", "gold",
            "lion", "belt", "jump", "card", "rain", "note", "fish", "song", "blue", "foot",
            "leaf", "gift", "ring", "road", "tank", "shoe", "hand", "coin", "mask", "twin"};

        string[] newwords = {  "", "", "", "", "", "", "", "", "", "",
            "", "", "", "", "", "", "", "", "", "",
            "", "", "", "", "", "", "", "", "", "",
            "", "", "", "", "", "", "", "", "", ""};
       int time = 300;
        int counter = 0;
        int score = 0;
        int score2 = 0;
        
        Random box = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            while (counter < words.Length)
            {
                int num = box.Next(0, words.Length);
                if (words[num] != "gone")
                {
                    newwords[counter] = words[num];
                    words[num] = "gone";
                    counter++;

                }
            }

            lbl_score.Text = score2.ToString();
            jumble(newwords[score]);
          

            
        }

        private void label2_Click(object sender, EventArgs e)
        {



        }

        public void jumble(string word)
        {
            char[] racistmikes = word.ToCharArray();
            string wordpluh = "";
            int counter2 = 0;
            while (counter2 < racistmikes.Length)
            {
                int num = box.Next(0, racistmikes.Length);
                if (racistmikes[num] != '*')
                {
                    wordpluh = wordpluh + racistmikes[num];
                    racistmikes[num] = '*';
                    counter2++;
                    

                }
            }

            lbl_word.Text = wordpluh;
            lbl_time.Text = time.ToString();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (newwords[score] == tb_guess.Text)
            {
                MessageBox.Show("You got it right");
                score++;
                jumble(newwords[score]);
                score2++;
                lbl_score.Text = score2.ToString();
                time = time + 100;
                lbl_time.Text = time.ToString();
            }
            else if (newwords[39] == tb_guess.Text)
            {
                MessageBox.Show("YOU WON THE GAME! GOOD JOB!");
                Application.Exit();
                timer1.Stop();
            }
            else
            {
                MessageBox.Show("It's wrong TRY AGAIN");
                lbl_time.Text = time.ToString();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            if (time <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Your lost because you ran outta time");
                Application.Exit();
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_time_Click(object sender, EventArgs e)
        {
          
                lbl_time.Text = time.ToString();

            
        }
    }
}
