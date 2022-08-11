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
    public partial class Form3 : Form
    {
        public Form3()//thread
        {
            InitializeComponent();

            Thread t_handler = new Thread(getmessage);
            t_handler.IsBackground = true;
            t_handler.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)//화면 전환
        {
            chating f2 = new chating();
            f2.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)//4. 채팅창에서 thread실행시키기, getmessage 실행
        {
            Form1.sw.WriteLine(richTextBox1.Text);
            Form1.sw.Flush();
        }
        
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 0xd)
            {
                richTextBox1.Text = richTextBox1.Text.Replace("\n", "");
                Form1.sw.WriteLine(richTextBox1.Text);
                Form1.sw.Flush();

            }
        }

        public void getmessage()
        {

            CheckForIllegalCrossThreadCalls = false;
            while (true)
            {
                string strMsg = Form1.sr.ReadLine();

                if (strMsg != null)
                {
                    richTextBox2.Text = strMsg + "\n";
                }

                if (strMsg == "exit")
                {
                    break;
                }
            }
        }
    }
}
