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
using System.Threading.Tasks;
using System.IO;

namespace client_3
{
    public partial class Form3 : Form
    {
        string list1;
        string list2;

        public Form3()
        {
            InitializeComponent();

            try
            {
                Form1.sw.WriteLine(Form1.ID.Text);
                Form1.sw.Flush();

                Thread t_handler = new Thread(getmessage);
                t_handler.IsBackground = true;
                t_handler.Start();
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.ToString());
            }

            richTextBox3.Text = Form1.ID.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
        
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0xd)
            {
                string nt = richTextBox1.Text;

                if (nt.IndexOf("@") == -1)
                {
                    richTextBox1.Text = richTextBox1.Text.Replace("\n", "");
                    nt = "@" + comboBox1.SelectedItem.ToString() + "_" + richTextBox1.Text;

                    string name = nt.Substring(nt.IndexOf('@') + 1, nt.IndexOf('_') - 1);
                    string text = nt.Substring(nt.IndexOf('_') + 1);
                    richTextBox2.AppendText("Me: " + text + "\n");
                    Form1.sw.WriteLine(nt + "." + Form1.ID.Text);
                    Form1.sw.Flush();
                    richTextBox1.Clear();
                }
                else
                {
                    string name = nt.Substring(nt.IndexOf('@') + 1, nt.IndexOf('_') - 1);
                    string text = nt.Substring(nt.IndexOf('_') + 1);
                    richTextBox2.AppendText("Me: " + text);
                    richTextBox1.Text = richTextBox1.Text.Replace("\n", "");
                    Form1.sw.WriteLine(richTextBox1.Text + "." + Form1.ID.Text);
                    Form1.sw.Flush();
                    richTextBox1.Clear();
                }
            }
        }

        public void getmessage()//5. thread 실행과, getmessage 실행
        {
            CheckForIllegalCrossThreadCalls = false;
            while (true)
            {
                try
                {
                    Form1.strRecvMsg = Form1.sr.ReadLine();
                    if (Form1.strRecvMsg != null)
                    {
                        if (Form1.strRecvMsg.IndexOf("님") != -1)
                        {
                            richTextBox4.Clear();
                            richTextBox4.AppendText(Form1.strRecvMsg.Replace("/", "\n"));
                            comboBox1.Items.Clear();
                            comboBox1.Items.Add("everyone");
                            string cb = richTextBox4.Text.Replace("님", "");
                            string[] str = new string[10];
                            str = cb.Split('\n');
                            for (int a = 0; a < str.Count() - 1; a++)
                            {
                                comboBox1.Items.Add(str[a]);
                            }
                            comboBox1.SelectedIndex = 0;
                        }
                        else
                        {
                            richTextBox2.AppendText(Form1.strRecvMsg + "\n");
                        }
                    }
                }
                catch(Exception e)
                {
                   
                }
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            richTextBox2.AppendText("Me: " + richTextBox1.Text);
            Form1.sw.WriteLine(richTextBox1.Text);
            Form1.sw.Flush();
            richTextBox1.Clear();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.sw.WriteLine(Form1.ID.Text + "님이 종료를 했습니다");
            Form1.sw.Flush();
        }
    }
}
