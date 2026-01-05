using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deal_or_no_deal
{
    public partial class Form1 : Form
    {
        String[] values = { "1", "4", "10", "20", "50", "100", "150", "200", "400", "600", "800", "1000", "1500", "2000", "10000", "20000", "50000", "100000", "150000", "200000", "400000", "600000", "800000", "1000000", "1500000", "2000000" };
        String[] newvalues = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        int case1 = 0;
        int casesleft = 26;
        int value = 6836835;
        int offer = 0;
        int offerrun = 0;
        int counter = 0;
        Random box = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            while (counter < values.Length)
            {
                int num = box.Next(0, values.Length);
                if (values[num] != "gone")
                {
                    newvalues[counter] = values[num];
                    values[num] = "gone";
                    counter++;

                }
            }

        }

        private void tnt_click(object sender, EventArgs e)
        {
            PictureBox picked = (PictureBox)sender;
            char[] pic_one = picked.Name.ToCharArray();
            int num_in_name = int.Parse(pic_one[3].ToString() + pic_one[4]);

            switch (newvalues[num_in_name])
            {
                case "1":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_1.Text = "$      0";
                    MessageBox.Show("this case had $1");
                    case1++;
                    casesleft--;
                    value = value - 1;
                    break;

                case "4":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_2.Text = "$      0";
                    MessageBox.Show("this case had $4");
                    case1++;
                    casesleft--;
                    value = value - 4;
                    break;

                case "10":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_3.Text = "$      0";
                    MessageBox.Show("this case had $10");
                    case1++;
                    casesleft--;
                    value = value - 10;
                    break;

                case "20":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_4.Text = "$      0";
                    MessageBox.Show("this case had $20");
                    case1++;
                    casesleft--;
                    value = value - 20;
                    break;

                case "50":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_5.Text = "$      0";
                    MessageBox.Show("this case had $50");
                    case1++;
                    casesleft--;
                    value = value - 50;
                    break;

                case "100":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_6.Text = "$      0";
                    MessageBox.Show("this case had $100");
                    case1++;
                    casesleft--;
                    value = value - 100;
                    break;

                case "150":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_7.Text = "$      0";
                    MessageBox.Show("this case had $150");
                    case1++;
                    casesleft--;
                    value = value - 150;
                    break;

                case "200":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_8.Text = "$      0";
                    MessageBox.Show("this case had $200");
                    case1++;
                    casesleft--;
                    value = value - 200;
                    break;

                case "400":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_9.Text = "$      0";
                    MessageBox.Show("this case had $400");
                    case1++;
                    casesleft--;
                    value = value - 400;
                    break;

                case "600":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_10.Text = "$      0";
                    MessageBox.Show("this case had $600");
                    case1++;
                    casesleft--;
                    value = value - 600;
                    break;

                case "800":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_11.Text = "$      0";
                    MessageBox.Show("this case had $800");
                    case1++;
                    casesleft--;
                    value = value - 800;
                    break;

                case "1000":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_12.Text = "$      0";
                    MessageBox.Show("this case had $1000");
                    case1++;
                    casesleft--;
                    value = value - 1000;
                    break;

                case "1500":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_13.Text = "$      0";
                    MessageBox.Show("this case had $1500");
                    case1++;
                    casesleft--;
                    value = value - 1500;
                    break;

                case "2000":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_14.Text = "$      0";
                    MessageBox.Show("this case had $2000");
                    case1++;
                    casesleft--;
                    value = value - 2000;
                    break;

                case "10000":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_15.Text = "$      0";
                    MessageBox.Show("this case had $10000");
                    case1++;
                    casesleft--;
                    value = value - 10000;
                    break;

                case "20000":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_16.Text = "$      0";
                    MessageBox.Show("this case had $20000");
                    case1++;
                    casesleft--;
                    value = value - 20000;
                    break;

                case "50000":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_17.Text = "$      0";
                    MessageBox.Show("this case had $50000");
                    case1++;
                    casesleft--;
                    value = value - 50000;
                    break;

                case "100000":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_18.Text = "$      0";
                    MessageBox.Show("this case had $100000");
                    case1++;
                    casesleft--;
                    value = value - 100000;
                    break;

                case "150000":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_19.Text = "$      0";
                    MessageBox.Show("this case had $150000");
                    case1++;
                    casesleft--;
                    value = value - 150000;
                    break;

                case "200000":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_20.Text = "$      0";
                    MessageBox.Show("this case had $200000");
                    case1++;
                    casesleft--;
                    value = value - 200000;
                    break;

                case "400000":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_21.Text = "$      0";
                    MessageBox.Show("this case had $400000");
                    case1++;
                    casesleft--;
                    value = value - 400000;
                    break;

                case "600000":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_22.Text = "$      0";
                    MessageBox.Show("this case had $600000");
                    case1++;
                    casesleft--;
                    value = value - 600000;
                    break;

                case "800000":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_23.Text = "$      0";
                    MessageBox.Show("this case had $800000");
                    case1++;
                    casesleft--;
                    value = value - 800000;
                    break;

                case "1000000":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_24.Text = "$      0";
                    MessageBox.Show("this case had $1000000");
                    case1++;
                    casesleft--;
                    value = value - 1000000;
                    break;

                case "1500000":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_25.Text = "$      0";
                    MessageBox.Show("this case had $1500000");
                    case1++;
                    casesleft--;
                    value = value - 1500000;
                    break;

                case "2000000":
                    picked.Enabled = false;
                    picked.BackgroundImage = null;
                    lbl_26.Text = "$      0";
                    MessageBox.Show("this case had $2000000");
                    case1++;
                    casesleft--;
                    value = value - 2000000;
                    break;
            }


            if (case1 == 5)
            {
                offer = value / casesleft;
                offerrun++;
            
            if (case1 == 5 && casesleft != 1)
            {
                DialogResult result = MessageBox.Show("The offer made to you is $" + offer + " ! Do you accept?", "Accept?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Congratulations you made $" + offer + " you are done the game");
                    Application.Exit();

                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Contiue playing.");
                    case1 = 0;
                }
            }
                
            }

           
            if (offerrun == 5)
                {
                switch (newvalues[num_in_name])
                {
                    case "1":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_1.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $1");
                        Application.Exit();
                        break;

                    case "4":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_2.Text = "$      0";
                        MessageBox.Show("Congrats you finished with$4");
                        Application.Exit();
                        break;

                    case "10":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_3.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $10");
                        Application.Exit();
                        break;

                    case "20":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_4.Text = "$      0";
                        MessageBox.Show("this case had $20");
                        Application.Exit();
                        break;

                    case "50":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_5.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $50");
                        Application.Exit();
                        break;

                    case "100":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_6.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $100");
                        Application.Exit();
                        break;

                    case "150":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_7.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $150");
                        Application.Exit();
                        break;

                    case "200":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_8.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $200");
                        Application.Exit();
                        break;

                    case "400":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_9.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $400");
                        Application.Exit();
                        break;

                    case "600":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_10.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $600");
                        Application.Exit();
                        break;

                    case "800":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_11.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $800");
                        Application.Exit();
                        break;

                    case "1000":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_12.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $1000");
                        Application.Exit();
                        break;

                    case "1500":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_13.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $1500");
                        Application.Exit();
                        break;

                    case "2000":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_14.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $2000");
                        Application.Exit();
                        break;

                    case "10000":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_15.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $10000");
                        Application.Exit();
                        break;

                    case "20000":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_16.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $20000");
                        Application.Exit();
                        break;

                    case "50000":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_17.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $50000");
                        Application.Exit();
                        break;

                    case "100000":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_18.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $100000");
                        Application.Exit();
                        break;

                    case "150000":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_19.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $150000");
                        Application.Exit();
                        break;

                    case "200000":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_20.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $200000");
                        Application.Exit();
                        break;

                    case "400000":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_21.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $400000");
                        Application.Exit();
                        break;

                    case "600000":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_22.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $600000");
                        Application.Exit();
                        break;

                    case "800000":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_23.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $800000");
                        Application.Exit();
                        break;

                    case "1000000":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_24.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $1000000");
                        Application.Exit();
                        break;

                    case "1500000":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_25.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $1500000");
                        Application.Exit();
                        break;

                    case "2000000":
                        picked.Enabled = false;
                        picked.BackgroundImage = null;
                        lbl_26.Text = "$      0";
                        MessageBox.Show("Congrats you finished with $2000000");
                        Application.Exit();

                        break;
                }
                
          }    
                

            
            

        }
    }
}
