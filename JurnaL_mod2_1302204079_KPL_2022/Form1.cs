using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jurnal_mod2_1302204079_KPL_2022
{
    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_selesai = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textdisplay.Text);
            textdisplay2.Text = "+";
            textdisplay.Text = " ";
            opr = 1;
            opr_selesai = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textdisplay.Text != "0")
            {
                textdisplay.Text += "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textdisplay.Text == "0")
            {
                textdisplay.Text = "1";
            }
            else
            {
                textdisplay.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textdisplay.Text == "0")
            {
                textdisplay.Text = "2";
            }
            else
            {
                textdisplay.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textdisplay.Text == "0")
            {
                textdisplay.Text = "3";
            }
            else
            {
                textdisplay.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textdisplay.Text == "0")
            {
                textdisplay.Text = "4";
            }
            else
            {
                textdisplay.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textdisplay.Text == "0")
            {
                textdisplay.Text = "5";
            }
            else
            {
                textdisplay.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textdisplay.Text == "0")
            {
                textdisplay.Text = "6";
            }
            else
            {
                textdisplay.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textdisplay.Text == "0")
            {
                textdisplay.Text = "7";
            }
            else
            {
                textdisplay.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textdisplay.Text == "0")
            {
                textdisplay.Text = "8";
            }
            else
            {
                textdisplay.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textdisplay.Text == "0")
            {
                textdisplay.Text = "9";
            }
            else
            {
                textdisplay.Text += "9";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (opr_selesai == true)
                bil2 = Convert.ToDecimal(textdisplay.Text);
            {
                textdisplay.Text = Convert.ToString(bil1 + bil2);
            }
        }
    }
}