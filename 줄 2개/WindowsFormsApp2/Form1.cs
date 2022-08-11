using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        int sw1 = 0;
        int sw2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(panel2.Top < 375 && sw2 == 0) // 2 down
            {
                panel2.Top += 10;
                if(panel2.Top == 375)
                {
                    timer1.Enabled = false;
                    sw2++;
                }
            }
            else if(panel2.Top > 55 && sw2 == 1) // 2 up and 1, 2up
            {
                if (panel2.Top - panel1.Top < 60)
                {
                    panel1.Top -= 10;
                    panel2.Top -= 10;
                    if (panel2.Top == 55)
                    {
                        timer1.Enabled = false;
                        sw2--;
                        sw1 = 0;
                    }
                }
                else
                {
                    panel2.Top -= 10;
                    if (panel2.Top == 55)
                    {
                        timer1.Enabled = false;
                        sw2--;
                    }
                }
            }
            
            textBox1.Text = Convert.ToString(panel1.Top);
            textBox2.Text = Convert.ToString(panel2.Top);
            textBox3.Text = Convert.ToString(sw1);
            textBox4.Text = Convert.ToString(sw2);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel1.Top < 325 && sw1 == 0) // 1 down and 1, 2 down
            {
                if (panel2.Top - panel1.Top < 60)
                {
                    panel1.Top += 10;
                    panel2.Top += 10;
                    if (panel1.Top == 325)
                    {
                        timer2.Enabled = false;
                        sw1++;
                        sw2 = 1;
                    }
                }
                else
                {
                    panel1.Top += 10;
                    if (panel1.Top == 325)
                    {
                        timer2.Enabled = false;
                        sw1++;
                    }
                }
            }
            else if (panel1.Top > 5 && sw1 == 1) // 1 up
            {
                panel1.Top -= 10;
                if (panel1.Top == 5)
                {
                    timer2.Enabled = false;
                    sw1--;
                }
            }

            textBox1.Text = Convert.ToString(panel1.Top);
            textBox2.Text = Convert.ToString(panel2.Top);
            textBox3.Text = Convert.ToString(sw1);
            textBox4.Text = Convert.ToString(sw2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
