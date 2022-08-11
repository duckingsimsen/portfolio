using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace client2_210215
{
    public partial class Form1 : Form
    {
        public static NetworkStream ns;
        public static StreamReader sr;
        public static StreamWriter sw;
        public static string strRecvMsg;
        public static string strSendMsg = null;
        public static RichTextBox ID;

        public Form1()
        {
            InitializeComponent();

            ID = richTextBox1;
        }

        public static void client2()
        {
            TcpClient Client = new TcpClient("127.0.0.1", 9090);
            ns = Client.GetStream();
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "sam8729" && richTextBox2.Text == "tlatms8729!"
                || richTextBox1.Text == "sam87291" && richTextBox2.Text == "tlatms8729!"
                 || richTextBox1.Text == "sam87292" && richTextBox2.Text == "tlatms8729!"
                  || richTextBox1.Text == "sam87293" && richTextBox2.Text == "tlatms8729!")
            {
                client2();
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else if (richTextBox1.Text != "sam8729" && richTextBox2.Text == "tlatms8729!"
                || richTextBox1.Text != "sam87291" && richTextBox2.Text == "tlatms8729!"
                 || richTextBox1.Text != "sam87292" && richTextBox2.Text == "tlatms8729!"
                  || richTextBox1.Text != "sam87293" && richTextBox2.Text == "tlatms8729!")
            {
                MessageBox.Show("Wrong I.D.");
            }
            else if (richTextBox1.Text == "sam8729" && richTextBox2.Text != "tlatms8729!"
                || richTextBox1.Text == "sam87291" && richTextBox2.Text != "tlatms8729!"
                 || richTextBox1.Text == "sam87292" && richTextBox2.Text != "tlatms8729!"
                  || richTextBox1.Text == "sam87293" && richTextBox2.Text != "tlatms8729!")
            {
                MessageBox.Show("Wrong Passward");
            }
            else if (richTextBox1.Text != "sam8729" && richTextBox2.Text != "tlatms8729!"
                || richTextBox1.Text != "sam87291" && richTextBox2.Text != "tlatms8729!"
                 || richTextBox1.Text != "sam87292" && richTextBox2.Text != "tlatms8729!"
                  || richTextBox1.Text != "sam87293" && richTextBox2.Text != "tlatms8729!")
            {
                MessageBox.Show("Wrong I.D. and Passward");
            }
        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0xd)
            {
                if (richTextBox1.Text == "sam8729" && richTextBox2.Text == "tlatms8729!"
                || richTextBox1.Text == "sam87291" && richTextBox2.Text == "tlatms8729!"
                 || richTextBox1.Text == "sam87292" && richTextBox2.Text == "tlatms8729!"
                  || richTextBox1.Text == "sam87293" && richTextBox2.Text == "tlatms8729!")
                {
                    client2();
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                else if (richTextBox1.Text != "sam8729" && richTextBox2.Text == "tlatms8729!"
                    || richTextBox1.Text != "sam87291" && richTextBox2.Text == "tlatms8729!"
                     || richTextBox1.Text != "sam87292" && richTextBox2.Text == "tlatms8729!"
                      || richTextBox1.Text != "sam87293" && richTextBox2.Text == "tlatms8729!")
                {
                    MessageBox.Show("Wrong I.D.");
                }
                else if (richTextBox1.Text == "sam8729" && richTextBox2.Text != "tlatms8729!"
                    || richTextBox1.Text == "sam87291" && richTextBox2.Text != "tlatms8729!"
                     || richTextBox1.Text == "sam87292" && richTextBox2.Text != "tlatms8729!"
                      || richTextBox1.Text == "sam87293" && richTextBox2.Text != "tlatms8729!")
                {
                    MessageBox.Show("Wrong Passward");
                }
                else if (richTextBox1.Text != "sam8729" && richTextBox2.Text != "tlatms8729!"
                    || richTextBox1.Text != "sam87291" && richTextBox2.Text != "tlatms8729!"
                     || richTextBox1.Text != "sam87292" && richTextBox2.Text != "tlatms8729!"
                      || richTextBox1.Text != "sam87293" && richTextBox2.Text != "tlatms8729!")
                {
                    MessageBox.Show("Wrong I.D. and Passward");
                }
            }
        }
    }
}
