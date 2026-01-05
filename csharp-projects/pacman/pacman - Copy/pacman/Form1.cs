using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pacman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pacman.Location = new Point(11, 11);
            for (int x = 0; x < 667; x = x + 5)
            {


                pacman.Location = new Point(x, 11);
                this.Update();
                Thread.Sleep(50);

                if (x % 2 == 0)
                {
                    pacman.BackgroundImage = Properties.Resources.pacMouthOpen;

                }
                else
                {
                    pacman.BackgroundImage = Properties.Resources.pacMouthClosed;
                }


            }

            pacman.Location = new Point(667, 11);
            for (int y = 0; y < 470; y = y + 5)
            {


                pacman.Location = new Point(667, y);
                this.Update();
                Thread.Sleep(50);

                if (y % 2 == 0)
                {
                    pacman.BackgroundImage = Properties.Resources.pacMouthOpendown;

                }
                else
                {
                    pacman.BackgroundImage = Properties.Resources.pacMouthCloseddown;
                }
            }
            pacman.Location = new Point(667, 470);
            for (int x = 667; x > 0; x = x - 5)
            {


                pacman.Location = new Point(x, 470);
                this.Update();
                Thread.Sleep(50);

                if (x % 2 == 0)
                {
                    pacman.BackgroundImage = Properties.Resources.pacMouthOpenLeft;

                }
                else
                {
                    pacman.BackgroundImage = Properties.Resources.pacMouthClosedleft;
                }
            }
            pacman.Location = new Point(11, 470);
            for (int y = 470; y > 0; y = y - 5)
            {


                pacman.Location = new Point(11, y);
                this.Update();
                Thread.Sleep(50);

                if (y % 2 == 0)
                {
                    pacman.BackgroundImage = Properties.Resources.pacMouthOpenUp;

                }
                else
                {
                    pacman.BackgroundImage = Properties.Resources.pacMouthClosedup;
                }
                Application.Exit();
            }
        }
    }
}
