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

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = 1;
            int d = 0;
            b++;

            for (d = a; d < b; d++)
            {
                for (c = 1; c < 10; c++)
                {
                    richTextBox1.AppendText(d + " * " + c + " = " + d * c + "\n");
                }
                richTextBox1.AppendText("\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "";
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = 1;
            int d = 0;
            b++;

            for (d = a; d < b; d++)
            {
                if (d % 2 == 0)
                {
                    for (c = 1; c < 10; c++)
                    {
                    richTextBox1.AppendText(d + " * " + c + " = " + d * c + "\n");
                    }
                richTextBox1.AppendText("\n");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = 1;
            int d = 0;
            b++;

            for (d = a; d < b; d++)
            {
                if (d % 2 == 1)
                {
                    for (c = 1; c < 10; c++)
                    {
                        richTextBox1.AppendText(d + " * " + c + " = " + d * c + "\n");
                    }
                    richTextBox1.AppendText("\n");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = 1;
            int d = 0;

            if(a < b)
            {
                a--;
                for (d = b; d > a; d--)
                {
                    if (d % 2 == 0)
                    {
                        for (c = 1; c < 10; c++)
                        {
                            richTextBox1.AppendText(d + " * " + c + " = " + d * c + "\n");
                        }
                        richTextBox1.AppendText("\n");
                    }
                }
            }
            for(d = a; d > b; d--)
            {
                if(d % 2 == 0)
                {
                    for (c = 1; c < 10; c++)
                    {
                        richTextBox1.AppendText(d + " * " + c + " = " + d * c + "\n");
                    }
                    richTextBox1.AppendText("\n");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = 1;
            int d = 0;

            if (a < b)
            {
                a--;
                for (d = b; d > a; d--)
                {
                    if (d % 2 == 1)
                    {
                        for (c = 1; c < 10; c++)
                        {
                            richTextBox1.AppendText(d + " * " + c + " = " + d * c + "\n");
                        }
                        richTextBox1.AppendText("\n");
                    }
                }
            }
            for (d = a; d > b; d--)
            {
                if (d % 2 == 1)
                {
                    for (c = 1; c < 10; c++)
                    {
                        richTextBox1.AppendText(d + " * " + c + " = " + d * c + "\n");
                    }
                    richTextBox1.AppendText("\n");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = 1;
            int d = 0;
            b++;

            for (d = a; d < b; d++)
            {
                if (d % 2 == 1)
                {
                    for (c = 1; c < 10; c++)
                    {
                        if (c % 2 == 0)
                        {
                            richTextBox1.AppendText(d + " * " + c + " = " + d * c + "\n");
                        }
                    }
                    richTextBox1.AppendText("\n");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = 1;
            int d = 0;
            b++;

            for (d = a; d < b; d++)
            {
                if (d % 2 == 0)
                {
                    for (c = 1; c < 10; c++)
                    {
                        if (c % 2 == 1)
                        {
                            richTextBox1.AppendText(d + " * " + c + " = " + d * c + "\n");
                        }
                    }
                    richTextBox1.AppendText("\n");
                }
            }
        }
    }
}
