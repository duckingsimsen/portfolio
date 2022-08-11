using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        int sw1 = 0;
        int sw2 = 0;
        int sw3 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        // 1. 5 275
        // 2. 55 325
        // 3. 105 375
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(panel1.Top < 275 && sw1 == 0)// 1 down, 1, 2, 3 down
            {
                if(panel3.Top - panel1.Top == 100)// 1, 2, 3 down
                {
                    panel3.Top += 10;
                    panel2.Top += 10;
                    panel1.Top += 10;
                    if(panel1.Top == 275)
                    {
                        timer1.Enabled = false;
                        sw1++;
                        sw2 = 1;
                        sw3 = 1;
                    }
                }
                else if(panel2.Top - panel1.Top == 50)// 1, 2 down
                {
                    panel2.Top += 10;
                    panel1.Top += 10;
                    if(panel1.Top == 275)
                    {
                        timer1.Enabled = false;
                        sw1++;
                        sw2 = 1;
                    }
                }
                else // 1 down
                {
                    panel1.Top += 10;
                    if (panel1.Top == 275)
                    {
                        timer1.Enabled = false;
                        sw1++;
                    }
                }
            }
            else if(panel1.Top > 5 && sw1 == 1)// 1 up
            {
                panel1.Top -= 10;
                if(panel1.Top == 5)
                {
                    timer1.Enabled = false;
                    sw1--;
                }
            }


            textBox1.Text = panel1.Top.ToString();
            textBox2.Text = panel2.Top.ToString();
            textBox3.Text = sw1.ToString();
            textBox4.Text = sw2.ToString(); 
            textBox5.Text = panel3.Top.ToString();
            textBox6.Text = sw3.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(panel2.Top < 325 && sw2 == 0)// 2, 3 down, 2 down
            {
                if(panel3.Top - panel2.Top == 50)// 2, 3 down
                {
                    panel2.Top += 10;
                    panel3.Top += 10;
                    if(panel2.Top == 325)
                    {
                        timer2.Enabled = false;
                        sw2++;
                        sw3 = 1;
                    }
                }
                else // 2 down
                {
                    panel2.Top += 10;
                    if (panel2.Top == 325)
                    {
                        timer2.Enabled = false;
                        sw2++;
                    }
                }
            }
            else if(panel2.Top > 55 && sw2 == 1)// 2 up, 1, 2 up
            {
                if(panel2.Top - panel1.Top < 60)// 1, 2 up
                {
                    panel2.Top -= 10;
                    panel1.Top -= 10;
                    if(panel2.Top == 55)
                    {
                        timer2.Enabled = false;
                        sw2--;
                        sw1 = 0;
                    }
                }
                else // 2 up
                {
                    panel2.Top -= 10;
                    if (panel2.Top == 55)
                    {
                        timer2.Enabled = false;
                        sw2--;
                    }
                }
            }

            textBox1.Text = panel1.Top.ToString();
            textBox2.Text = panel2.Top.ToString();
            textBox3.Text = sw1.ToString();
            textBox4.Text = sw2.ToString();
            textBox5.Text = panel3.Top.ToString();
            textBox6.Text = sw3.ToString();
        }
        
        private void timer3_Tick(object sender, EventArgs e)
        {
            if(panel3.Top < 375 && sw3 == 0) // 3 down
            {
                panel3.Top += 10;
                if(panel3.Top == 375)
                {
                    timer3.Enabled = false;
                    sw3++;
                }
            }
            else if(panel3.Top > 105 && sw3 == 1)// 3 up, 2, 3 up, 1, 2, 3 up
            {
                if(panel3.Top - panel1.Top == 100)// 1, 2, 3 up
                {
                    panel3.Top -= 10;
                    panel2.Top -= 10;
                    panel1.Top -= 10;
                    if(panel3.Top == 105)
                    {
                        timer3.Enabled = false;
                        sw3--;
                        sw1 = 0;
                        sw2 = 0;
                    }
                }
                else if(panel3.Top - panel2.Top == 50)// 2, 3 up
                {
                    panel3.Top -= 10;
                    panel2.Top -= 10;
                    if(panel3.Top == 105)
                    {
                        timer3.Enabled = false;
                        sw3--;
                        sw2 = 0;
                    }
                }
                else // 3 up
                {
                    panel3.Top -= 10;
                    if (panel3.Top == 105)
                    {
                        timer3.Enabled = false;
                        sw3--;
                    }
                }
            }


            textBox1.Text = panel1.Top.ToString();
            textBox2.Text = panel2.Top.ToString();
            textBox3.Text = sw1.ToString();
            textBox4.Text = sw2.ToString();
            textBox5.Text = panel3.Top.ToString();
            textBox6.Text = sw3.ToString();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }
    }
}
