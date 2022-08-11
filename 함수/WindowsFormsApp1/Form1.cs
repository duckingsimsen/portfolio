using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int add(int a, int b)
        {
            int c = a + b;
            return c;
        }

        int sub(int a, int b)
        {
            int c = a - b;
            return c;
        }

        int mul(int a, int b)
        {
            int c = a * b;
            return c;
        }

        int div(int a, int b)
        {
            int c = b / a;
            return c;
        }

        void multable(int a, int b, string ch)
        {
            int c = 0;
            int d = 0;
            string e = ch;

            if(ch == "짝")
            {
                if (a < b)
                {
                    if (a % 2 == 0)
                    {
                        for (c = a; c <= b; c += 2)
                        {
                            for (d = 1; d <= 9; d++)
                            {
                                richTextBox1.AppendText(c + "*" + d + "=" + c * d + "\n");
                            }
                            richTextBox1.AppendText("\n");
                        }
                    }
                    else if (a % 2 == 1)
                    {
                        a++;
                        for (c = a; c <= b; c += 2)
                        {
                            for (d = 1; d <= 9; d++)
                            {
                                richTextBox1.AppendText(c + "*" + d + "=" + c * d + "\n");
                            }
                            richTextBox1.AppendText("\n");
                        }
                    }
                }
                else if (a > d)
                {
                    if (a % 2 == 0)
                    {
                        for (c = a; c >= b; c -= 2)
                        {
                            for (d = 1; d <= 9; d++)
                            {
                                richTextBox1.AppendText(c + "*" + d + "=" + c * d + "\n");
                            }
                            richTextBox1.AppendText("\n");
                        }
                    }
                    else if (a % 2 == 1)
                    {
                        a--;
                        for (c = a; c >= b; c -= 2)
                        {
                            for (d = 1; d <= 9; d++)
                            {
                                richTextBox1.AppendText(c + "*" + d + "=" + c * d + "\n");
                            }
                            richTextBox1.AppendText("\n");
                        }
                    }
                }
            }
            else if(ch == "홀")
            {
                if (a < b)
                {
                    if (a % 2 == 0)
                    {
                        a++;
                        for (c = a; c <= b; c += 2)
                        {
                            for (d = 1; d <= 9; d++)
                            {
                                richTextBox1.AppendText(c + "*" + d + "=" + c * d + "\n");
                            }
                            richTextBox1.AppendText("\n");
                        }
                    }
                    else if (a % 2 == 1)
                    {
                        for (c = a; c <= b; c += 2)
                        {
                            for (d = 1; d <= 9; d++)
                            {
                                richTextBox1.AppendText(c + "*" + d + "=" + c * d + "\n");
                            }
                            richTextBox1.AppendText("\n");
                        }
                    }
                }
                else if (a > d)
                {
                    if (a % 2 == 0)
                    {
                        a--;
                        for (c = a; c >= b; c -= 2)
                        {
                            for (d = 1; d <= 9; d++)
                            {
                                richTextBox1.AppendText(c + "*" + d + "=" + c * d + "\n");
                            }
                            richTextBox1.AppendText("\n");
                        }
                    }
                    else if (a % 2 == 1)
                    {
                        for (c = a; c >= b; c -= 2)
                        {
                            for (d = 1; d <= 9; d++)
                            {
                                richTextBox1.AppendText(c + "*" + d + "=" + c * d + "\n");
                            }
                            richTextBox1.AppendText("\n");
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("a + b =  " + add(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)) + "\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("a + b =  " + sub(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)) + "\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("a + b = " + mul(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)) + "\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("a + b = " + div(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)) + "\n");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            multable(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), textBox3.Text);
        }
    }
}
