using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace client_3
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
        public static void client3()
        {
            try
            {
                TcpClient sockClient = new TcpClient("127.0.0.1", 9080); //소켓생성, 커넥트
                ns = sockClient.GetStream();
                sr = new StreamReader(ns);
                sw = new StreamWriter(ns);
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0xd)
            {
                if ((richTextBox1.Text == "sam8729" && richTextBox2.Text == "tlatms8729!\n")
                    || (richTextBox1.Text == "sam87291" && richTextBox2.Text == "tlatms8729!\n")
                    || (richTextBox1.Text == "sam87292" && richTextBox2.Text == "tlatms8729!\n")
                    || (richTextBox1.Text == "sam87293" && richTextBox2.Text == "tlatms8729!\n"))
                {
                    client3();
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                else if (richTextBox1.Text != "sam8729" && richTextBox2.Text != "tlatms8729!\n")
                {
                    MessageBox.Show("wrong I.D\nwrong p.w");
                }
                else if (richTextBox1.Text != "sam8729" && richTextBox2.Text == "tlatms8729!\n")
                {
                    MessageBox.Show("wrong I.D");
                }
                else if (richTextBox1.Text == "sam8729" && richTextBox2.Text != "tlatms8729!\n")
                {
                    MessageBox.Show("wrong p.w");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((richTextBox1.Text == "sam8729" && richTextBox2.Text == "tlatms8729!")
                || (richTextBox1.Text == "sam87291" && richTextBox2.Text == "tlatms8729!")
                || (richTextBox1.Text == "sam87292" && richTextBox2.Text == "tlatms8729!")
                || (richTextBox1.Text == "sam87293" && richTextBox2.Text == "tlatms8729!"))//1. 소켓생성&커넥트
            {
                client3();
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else if (richTextBox1.Text != "sam8729" && richTextBox2.Text != "tlatms8729!")
            {
                MessageBox.Show("wrong I.D\nwrong p.w");
            }
            else if (richTextBox1.Text != "sam8729" && richTextBox2.Text == "tlatms8729!")
            {
                MessageBox.Show("wrong I.D");
            }
            else if (richTextBox1.Text == "sam8729" && richTextBox2.Text != "tlatms8729!")
            {
                MessageBox.Show("wrong p.w");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.sw.WriteLine(richTextBox1.Text + "님이 종료를 했습니다");
            Form1.sw.Flush();
        }
    }
}
