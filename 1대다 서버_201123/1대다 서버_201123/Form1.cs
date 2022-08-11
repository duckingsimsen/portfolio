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

namespace _1대다_서버_201123
{
    public partial class Form1 : Form
    {
        TcpClient client;
        TcpListener sockServer;
        List<TcpClient> connectedClients = new List<TcpClient>();
        List<NetworkStream> NSClients = new List<NetworkStream>();
        List<StreamReader> SRClients = new List<StreamReader>();
        List<StreamWriter> SWClients = new List<StreamWriter>();
        List<string> CNLIST = new List<string>();

        int i = 0;
        string strMsg;
        string CN;
        string list1 = "";
        int b = 0;
        bool check = false;

        public Form1()
        {
            InitializeComponent();
            Server();
        }
        void Server()
        {
            try
            {
                sockServer = new TcpListener(IPAddress.Parse("127.0.0.1"), 9080);
                sockServer.Start();

                sockServer.BeginAcceptTcpClient(AcceptCallback, null);
                
            }
            catch(SocketException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        void AcceptCallback(IAsyncResult ar)
        {
            CheckForIllegalCrossThreadCalls = false;

            client = sockServer.EndAcceptTcpClient(ar);

            Thread t_handler = new Thread(getmessage);
            t_handler.IsBackground = true;
            t_handler.Start();

            sockServer.BeginAcceptTcpClient(AcceptCallback, null);

        }

        void getmessage()
        {
            CheckForIllegalCrossThreadCalls = false;

            connectedClients.Add(client);

            NetworkStream ns;
            StreamReader sr;
            StreamWriter sw;

            ns = client.GetStream();
            NSClients.Add(ns);
            sr = new StreamReader(ns);
            SRClients.Add(sr);
            sw = new StreamWriter(ns);
            SWClients.Add(sw);

            while (true)
            {
                int a;

                strMsg = sr.ReadLine();
                
                if(strMsg.IndexOf("@") == -1)
                {
                    if(strMsg.IndexOf("종료") == -1)
                    {
                        CNLIST.Add(strMsg);

                        richTextBox1.Text += CNLIST[i] + "님이 접속하였습니다" + "\n";
                        richTextBox2.Text += CNLIST[i] + "님" + "\n";
                        i++;
                    }
                    else
                    {
                        string exit = strMsg.Substring(0, strMsg.IndexOf("님"));
                        for(b = 0; b < CNLIST.Count; b++)
                        {
                            if(exit == CNLIST[b])
                            {
                                check = true;

                                richTextBox1.AppendText(strMsg + "\n"); 
                                List<string> myList = richTextBox2.Lines.ToList();
                                if (myList.Count > 0)
                                {
                                    string name = exit + "님";
                                    int cnt = 0;

                                    foreach (string line in richTextBox2.Lines)
                                    {
                                        if (line.Contains(name))
                                            myList.RemoveAt(cnt);
                                        cnt++;
                                    }

                                    SWClients[b].Close();
                                    SRClients[b].Close();
                                    NSClients[b].Close();
                                    connectedClients[b].Close();

                                    CNLIST.Remove(CNLIST[b]);
                                    SWClients.Remove(SWClients[b]);
                                    SRClients.Remove(SRClients[b]);
                                    NSClients.Remove(NSClients[b]);
                                    connectedClients.Remove(connectedClients[b]);

                                    richTextBox2.Lines = myList.ToArray();
                                    richTextBox2.Refresh();
                                }
                                break;
                            }
                        }
                        break;
                    }
                }
                else
                { 
                    string name = strMsg.Substring(strMsg.IndexOf('@') + 1, strMsg.IndexOf('_') - 1);
                    string text = strMsg.Substring(strMsg.IndexOf('_') + 1, strMsg.IndexOf('.') - strMsg.IndexOf('_') - 1);
                    string sender = strMsg.Substring(strMsg.IndexOf('.') + 1);
                    //call NSClient and CNList to send message

                    if(name == "everyone")
                    {
                        for(int b = 0; b < CNLIST.Count; b++)
                        {
                            SWClients[b].WriteLine(sender + ": " + text);
                            SWClients[b].Flush();
                        }
                    }
                    else
                    {
                        for (a = 0; a < CNLIST.Count; a++)
                        {
                            if (name == CNLIST[a])
                            {
                                SWClients[a].WriteLine(sender + ": " + text);
                                SWClients[a].Flush();
                            }
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (richTextBox2.Text != list1)
            {
                for (int a = 0; a < CNLIST.Count; a++)
                {
                    if(check == false)
                    {
                        list1 = richTextBox2.Text;
                        string list2 = list1.Replace("\n", "/");
                        SWClients[a].WriteLine(list2);
                        SWClients[a].Flush();
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
        }
    }
}
