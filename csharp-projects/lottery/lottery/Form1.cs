using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottery
{
    public partial class Form1 : Form
    {
        Random box = new Random();
        int num;
        int num2;
        int num3;
        int num4;
        int num5;
      
     
        public Form1()
        {
            InitializeComponent();
        }

        private void rb_3lot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            if (rb_3lot.Checked)
            {
                num = box.Next(1, 100);
                num2 = box.Next(1, 100);
                num3 = box.Next(1, 100);
                txt_num.Text = num.ToString() + "  " + num2.ToString() + "   " + num3.ToString();

            }
            else if (rb_4lot.Checked) 
            {
                num = box.Next(1, 100);
                num2 = box.Next(1, 100);
                num3 = box.Next(1, 100);
                num4 = box.Next(1, 100);
                txt_num.Text = num.ToString() + "  " + num2.ToString() + "   " + num3.ToString() + "   " + num4.ToString();
            }
            else if (rb_5lot.Checked)
            {
                num = box.Next(1, 100);
                num2 = box.Next(1, 100);
                num3 = box.Next(1, 100);
                num4 = box.Next(1, 100);
                num5 = box.Next(1, 100);
                txt_num.Text = num.ToString() + "  " + num2.ToString() + "   " + num3.ToString() + "   " + num4.ToString() + "   " + num5.ToString();
            }
        }
    }
}
