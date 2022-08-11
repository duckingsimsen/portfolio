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


namespace client1_210215
{
    public partial class Form1 : Form
    {
        public static NetworkStream ns;
        public static StreamReader sr;
        public static StreamWriter sw;
        public static string strRecvMsg;
        public static string strSendMsg = null;
        public static RichTextBox ID;
        public static string LogIn;
        public static string Getinfo;
        public static int login;
        public static int x = 0;

        public Form1()
        {
            InitializeComponent();
            
            TcpClient Client = new TcpClient("127.0.0.1", 9090);
            ns = Client.GetStream();
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);

            ID = richTextBox1;
            
            Thread thread = new Thread(Information);
            thread.IsBackground = true;
            thread.Start();
        }

        public static void client1()
        {
            
        }

        void Information()
        {
            CheckForIllegalCrossThreadCalls = false;

            while (true)
            {
                Getinfo = sr.ReadLine();

                if (Getinfo == "success")
                {
                    LogIn = "success";
                    x = 1; 
                    break;
                }
                else if (Getinfo == "fail")
                {
                    LogIn = "fail";
                    x = 1;
                }
                else if (Getinfo == "membership fail")
                {
                    MessageBox.Show("회원가입 실패");
                    login = 1;
                }
                else if (Getinfo == "membership success")
                {
                    MessageBox.Show("회원가입 성공");
                    this.Hide();

                    this.Invoke(new Action(delegate ()
                    {
                        Form1 form1 = new Form1();
                        form1.Show();
                    }));
                    login = 0;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string GiveID = richTextBox1.Text;
            string GivePW = richTextBox2.Text;

            sw.WriteLine(GiveID + "ID" + GivePW + ">");
            sw.Flush();

            while (x == 0)
            {

            }

            if(LogIn == "success")
            {
                client1();
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else if(LogIn == "fail")
            {
                MessageBox.Show("Wrong LonIn information");
            }
        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 0xd)
            {
                string GiveID = richTextBox1.Text;
                string GivePW = richTextBox2.Text;

                sw.WriteLine(GiveID + "ID" + GivePW + ">");
                sw.Flush();

                while (x == 0)
                {

                }

                if (LogIn == "success")
                {
                    client1();
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                else if (LogIn == "fail")
                {
                    MessageBox.Show("Wrong LonIn information");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client1();
            Form4 f4 = new Form4();
            f4.Show();
            Hide();
        }
    }
}