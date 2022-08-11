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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            Thread thread = new Thread(getmessage);
            thread.IsBackground = true;
            thread.Start();

            richTextBox3.Text = Form1.ID.Text;
        }

        void getmessage()
        {
            CheckForIllegalCrossThreadCalls = false;

            while (true)
            {
                Form1.strRecvMsg = Form1.sr.ReadLine();

                if (Form1.strRecvMsg == null)
                {
                    break;
                }

                if (Form1.strRecvMsg != null)
                {
                    if (Form1.strRecvMsg.IndexOf("님") > -1)
                    {
                        richTextBox4.Clear();
                        richTextBox4.AppendText(Form1.strRecvMsg.Replace("/", "\n"));
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("everyone");
                        string name = richTextBox4.Text.Replace("님", "");
                        string[] aaa = new string[] { };
                        aaa = name.Split('\n');
                        for (int a = 0; a < aaa.Count() - 1; a++)
                        {
                            comboBox1.Items.Add(aaa[a]);
                        }
                    }
                    else
                    {
                        richTextBox2.AppendText(Form1.strRecvMsg + "\n");
                    }
                }
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 0xd)
            {
                string chat = richTextBox1.Text;

                if(chat.IndexOf("@") == -1)//콤보박스이용
                {
                    string text = "@" + comboBox1.SelectedItem.ToString() + "_" + chat;
                    richTextBox2.AppendText("Me: " + chat);
                    string edit = text.Replace("\n", "");
                    Form1.sw.WriteLine(edit + "." + Form1.ID.Text);
                    Form1.sw.Flush();
                    richTextBox1.Clear();
                }
                else//콤보박스 이용하지 않을때
                {
                    string text = chat.Substring(chat.IndexOf("_") + 1);
                    richTextBox2.AppendText("Me: " + text);
                    string edit = chat.Replace("\n", "");
                    Form1.sw.WriteLine(edit + "." + Form1.ID.Text);
                    Form1.sw.Flush();
                    richTextBox1.Clear();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string chat = richTextBox1.Text;

            if (chat.IndexOf("@") == -1)//없을때, combobox 설정후에
            {
                string text = "@" + comboBox1.SelectedItem.ToString() + "_" + chat;
                richTextBox2.AppendText("Me: " + chat);
                string edit = text.Replace("\n", "");
                Form1.sw.WriteLine(edit + "." + Form1.ID);
                Form1.sw.Flush();
                richTextBox1.Clear();
            }
            else//있을때
            {
                string text = chat.Substring(chat.IndexOf("_") + 1);
                richTextBox2.AppendText("Me: " + text);
                string edit = text.Replace("\n", "");
                Form1.sw.WriteLine(edit + "." + Form1.ID);
                Form1.sw.Flush();
                richTextBox1.Clear();
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.sw.WriteLine(Form1.ID.Text + ".exit");
            Form1.sw.Flush();
        }
    }
}
