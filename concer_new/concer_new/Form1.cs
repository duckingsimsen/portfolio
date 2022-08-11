using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace concer_new
{
    public partial class Form1 : Form
    {
        public static TcpClient client;
        public static NetworkStream ns;
        public static StreamReader sr;
        public static StreamWriter sw;
        public Form1()
        {
            InitializeComponent();
        }
        public void Server()
        {
            try
            {
                TcpListener sockServer = new TcpListener(IPAddress.Parse("127.0.0.1"), 9080);
                sockServer.Start();
                MessageBox.Show("Start Server! Wait for Client...");

                client = sockServer.AcceptTcpClient();
                MessageBox.Show("Client Connect!");

                ns = Form1.client.GetStream();
                sr = new StreamReader(ns);
                sw = new StreamWriter(ns);

                string welcome = "Server Connect Success!";
                sw.WriteLine(welcome);
                sw.Flush();
            }

            catch (SocketException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)//로그인 버튼을 누름
        {
            if (richTextBox1.Text == "sam8729" && richTextBox2.Text == "tlatms8729!")//1,2.  로그인을 하면서 서버생성&클라접속까지 기다림
            {
                chating f2 = new chating();
                f2.Show();
                Server();
                this.Hide();
            }
            else if (richTextBox1.Text != "sam8729" && richTextBox2.Text != "tlatms8729!")
            {
                MessageBox.Show("wrong I.D\nwrong p.w");
            }
            else if(richTextBox1.Text != "sam8729" && richTextBox2.Text == "tlatms8729!")
            {
                MessageBox.Show("wrong I.D");
            }
            else if(richTextBox1.Text =="sam8729" && richTextBox2.Text != "tlatms8729!")
            {
                MessageBox.Show("wrong p.w");
            }
            

        }
        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)//p.w칸에서 엔터를 치고 로그인
        {
            if (e.KeyChar == 0xd)//1,2. 로그인을 하면서 서버생성&클라접속까지 기다림
            {
                if (richTextBox1.Text == "sam8729" && richTextBox2.Text == "tlatms8729!\n")
                {
                    chating f2 = new chating();
                    f2.Show();
                    Server();
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
                else if (richTextBox1.Text == "sam8729" && richTextBox2.Text == "tlatms8729!\n")
                {
                    MessageBox.Show("wrong p.w");
                }
            }
            
        }
    }
}
