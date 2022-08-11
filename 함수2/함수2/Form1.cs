using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 함수2
{
    public partial class Form1 : Form
    {
        int x = 0;
        int y = 0;
        int z = 0;
        int w = 0;
        public Form1()
        {
            InitializeComponent();
        }

        int essnecs1(int a, int b)
        {
            int c = a + b;
            return c;

        }
        int essnecs2(int a, int b)
        {
            int c = 0;
            c = a - b;
            return c;

        }
        float decimal1 (float a, float b)
        {
            float c = a * b;
            c = (float)Math.Round(c, 2);
            return c;
        }
        float decimal2(float a, float b)
        {
            float c = a / b;
            return c;
        }
        void move1 (int x, int y)
        {
            x *= 2;
            y *= 2;
            richTextBox1.Top += x;
            richTextBox1.Left += y;
        }
        void move2 (int z, int w)
        {
            x *= 3;
            y *= 3;
            richTextBox2.Top += z;
            richTextBox2.Left += w;
        }
        string copy (string a)
        {
            textBox3.Text = Convert.ToString(a);
            richTextBox2.AppendText(a + "\n");
            return a;
        }
        string mixture (string a, string b)
        {
            textBox3.Text = Convert.ToString(a);
            textBox4.Text = Convert.ToString(b);
            string c = a + b;
            richTextBox2.AppendText(c);
            return c;
        }
        char aaa (char a)
        {
            textBox5.Text = Convert.ToString(a);
            return a;
        }

        char charadd (string a, string b)
        {
            int c = Convert.ToInt32(a) + Convert.ToInt32(b);
            char d = Convert.ToChar(c);
            return d;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(Convert.ToInt32(textBox1.Text)+ "+" + Convert.ToInt32(textBox2.Text) + "=" + essnecs1(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)) + "\n");
            x++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(Convert.ToInt32(textBox1.Text) + "+" + Convert.ToInt32(textBox2.Text) + "=" + essnecs2(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)) + "\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float i = (float)Convert.ToDouble(textBox1.Text);
            float j = (float)Convert.ToDouble(textBox2.Text);
            richTextBox1.AppendText(i + "x" + j + "=" + Convert.ToString(decimal1(i,j)) + "\n");
            y++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float i = (float)Convert.ToDouble(textBox1.Text);
            float j = (float)Convert.ToDouble(textBox2.Text);
            richTextBox1.AppendText(i + "x" + j + "=" + Convert.ToString(decimal2(i, j)) + "\n");
        }

        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {
            move1(x, y);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            copy(Convert.ToString(textBox3.Text));
            z++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            w++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mixture(Convert.ToString(textBox3.Text), Convert.ToString(textBox4.Text) + "\n");
        }

        private void richTextBox2_DoubleClick(object sender, EventArgs e)
        {
            move2(z, w);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            char c = charadd(textBox1.Text, textBox2.Text);
            //richTextBox3.AppendText(Encoding.ASCII.GetString(Convert.ToSByte(c)));
        }
    }
}