using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace client1_210215
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            label11.ForeColor = System.Drawing.Color.Red;
            label11.ForeColor = System.Drawing.Color.Black;

            for (int a = DateTime.Now.Year; a > DateTime.Now.Year - 100; a--)
            {
                comboBox1.Items.Add(a);
            }

            for(int b = 1; b < 13; b++)
            {
                comboBox2.Items.Add(b);
            }

            for (int c = 1; c < 32; c++)
            {
                comboBox3.Items.Add(c);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == richTextBox3.Text)
            {
                label11.ForeColor = System.Drawing.Color.Green;
                label11.Text = "비밀번호 재확인 완료";
            }
            else
            {
                label11.ForeColor = System.Drawing.Color.Red;
                label11.Text = "비밀번호 재확인 필요";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Form1.sw.WriteLine(richTextBox1.Text + ">" + richTextBox2.Text + ">>" + richTextBox4.Text + ">>>" + comboBox1.SelectedItem + "/" + comboBox2.SelectedItem + "/" +
                comboBox3.SelectedItem + ">>>>" + richTextBox5.Text);
            Form1.sw.Flush();

            while (true)
            {
                if (Form1.login == 0)
                {
                    //Form1 f1 = new Form1();
                    //f1.Show();
                    this.Hide();
                    break;
                }
            }
        }
    }
}
