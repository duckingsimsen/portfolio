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

using MySql.Data.MySqlClient;

namespace main_server_210215
{
    public partial class Form1 : Form
    {
        DataSet ds_s;
        TcpClient client;
        TcpListener sockServer;
        List<TcpClient> connectedClients = new List<TcpClient>();
        List<NetworkStream> NSClients = new List<NetworkStream>();
        List<StreamReader> SRClients = new List<StreamReader>();
        List<StreamWriter> SWClients = new List<StreamWriter>();
        List<string> CNLIST = new List<string>();
        bool check = false;
        string save1 = "";
        string ID;
        string PW;
        string name_;
        string Birth;
        string PN;

        public static MySqlConnection connection;
        String ServerName = "localhost";
        String DataBase = "socket_schema";
        String userid = "root";
        String userpw = "tlatms2033!";

        public Form1()
        {
            InitializeComponent();
            Server();

            connection = new MySqlConnection("Server = " + ServerName + ";DataBase = " + DataBase + ";Uid = " + userid + ";Pwd = " + userpw);
            connection.Open();
        }

        void Server()
        {
            sockServer = new TcpListener(IPAddress.Parse("127.0.0.1"), 9090);
            sockServer.Start();

            sockServer.BeginAcceptTcpClient(AcceptCallback, null);
        }

        void AcceptCallback(IAsyncResult ar)
        {
            CheckForIllegalCrossThreadCalls = false;

            client = sockServer.EndAcceptTcpClient(ar);

            Thread thread = new Thread(getmessage);
            thread.IsBackground = true;
            thread.Start();

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
                try
                {
                    string chat = sr.ReadLine();

                    if (chat.IndexOf("@") == -1)// 채팅인지 아닌지 확인하는 과정
                    {
                        if(chat.IndexOf(">") == -1)//회원가입인지 출입기록인지
                        {
                            if (chat.IndexOf("exit") == -1)//들어온거
                            {
                                CNLIST.Add(chat);

                                richTextBox1.AppendText(chat + "님이 들어왔습니다." + "\n");
                                richTextBox2.AppendText(chat + "님" + "\n");

                                int a = DateTime.Now.Year;
                                int b = DateTime.Now.Month;
                                int c = DateTime.Now.Day;
                                int d = DateTime.Now.Hour;
                                int e = DateTime.Now.Minute;
                                int f = DateTime.Now.Second;

                                string SQL = "INSERT INTO SOCKET_SCHEMA.check_log(enter_or_leave, time) value('" + chat + "(in)','" + a + "-" + b + "-" + c + "/" + d + ":" +
                                    e + ":" + f + "')";

                                MySqlCommand command = new MySqlCommand(SQL, connection);
                                command.ExecuteNonQuery();
                            }
                            //온라인상태 받는거 확인해보기
                            else//있을때 온르인 상태인것 지우기
                            {
                                string exit = chat.Substring(0, chat.IndexOf("."));
                                for (int b = 0; b < CNLIST.Count; b++)
                                {
                                    if (exit == CNLIST[b])
                                    {
                                        check = true;
                                        string en = chat.Substring(0, chat.IndexOf("."));
                                        richTextBox1.AppendText(en + "님이 종료합니다" + "\n");
                                        List<string> myList = richTextBox2.Lines.ToList();
                                        if (myList.Count > 0)
                                        {
                                            check = true;

                                            string name = exit + "님";
                                            int cnt = 0;

                                            foreach (string line in richTextBox2.Lines)
                                            {
                                                if (line.Contains(name))
                                                    myList.RemoveAt(cnt);
                                                cnt++;
                                            }
                                            int a = DateTime.Now.Year;
                                            int g = DateTime.Now.Month;
                                            int c = DateTime.Now.Day;
                                            int d = DateTime.Now.Hour;
                                            int e = DateTime.Now.Minute;
                                            int f = DateTime.Now.Second;

                                            string SQL = "INSERT INTO SOCKET_SCHEMA.check_log(enter_or_leave, time) value('" + chat + "(out)','" + a + "-" + g + "-" + c + "/" + d + ":" +
                                                e + ":" + f + "')";

                                            MySqlCommand command = new MySqlCommand(SQL, connection);
                                            command.ExecuteNonQuery();

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
                            }
                        }
                        else
                        {
                            if(chat.IndexOf("ID") == -1)
                            {
                                ID = chat.Substring(0, chat.IndexOf(">"));
                                PW = chat.Substring(chat.IndexOf(">") + 1, chat.IndexOf(">>") - chat.IndexOf(">") - 1);
                                name_ = chat.Substring(chat.IndexOf(">>") + 2, chat.IndexOf(">>>") - chat.IndexOf(">>") - 2);
                                Birth = chat.Substring(chat.IndexOf(">>>") + 3, chat.IndexOf(">>>>") - chat.IndexOf(">>>") - 3);
                                PN = chat.Substring(chat.IndexOf(">>>>") + 4);

                                DataSet DB1 = new DataSet();

                                string SQL1 = "SELECT ID FROM socket_schema.new_table where ID = '" + ID + "'";
                                MySqlDataAdapter data = new MySqlDataAdapter(SQL1, connection);
                                data.Fill(DB1, "socket_schema.new_table");

                                int cnt = 0;

                                foreach (DataRow a in DB1.Tables[0].Rows)
                                {
                                    cnt++;
                                }

                                if (cnt != 0)//ID overlap
                                {
                                    sw.WriteLine("membership fail");
                                    sw.Flush();
                                }
                                else//ID not overlap
                                {
                                    sw.WriteLine("membership success");
                                    sw.Flush();

                                    string SQL = "INSERT INTO socket_schema.new_table (ID, PW, Birth, name_, PN) values ('" + ID + "','" + PW + "','" + name_ + "','" + Birth + "','" + PN + "')";

                                    MySqlCommand command = new MySqlCommand(SQL, connection);
                                    command.ExecuteNonQuery();

                                    ds_s = new DataSet();
                                    string insertQuery = "SELECT * FROM socket_schema.chat_log";
                                    MySqlDataAdapter adpt = new MySqlDataAdapter(insertQuery, connection);
                                    MySqlCommand chating = new MySqlCommand(insertQuery, connection);
                                    adpt.Fill(ds_s, "socket_schema.chat_log");
                                    chating.ExecuteNonQuery();
                                }
                            }
                            else if(chat.IndexOf("ID") > -1)
                            {
                                DataSet DB1 = new DataSet();

                                string ID = chat.Substring(0, chat.IndexOf("ID"));
                                string PW = chat.Substring(chat.IndexOf("ID") + 2, chat.IndexOf(">") - chat.IndexOf("ID") - 2);//클라이언트에서 아이디와 비밀번호를 받아옴
                                string SQL = "SELECT ID,PW FROM socket_schema.new_table where ID = '" + ID + "'";
                                MySqlDataAdapter Data = new MySqlDataAdapter(SQL, connection);
                                Data.Fill(DB1, "socket_schema.new_table");

                                DataTable dt = new DataTable();
                                dt = DB1.Tables["socket_schema.new_table"];

                                foreach (DataRow dr in dt.Rows)
                                {
                                    if (dr["PW"].ToString() == PW)
                                    {
                                        sw.WriteLine("success");
                                        sw.Flush();
                                    }
                                    else
                                    {
                                        sw.WriteLine("fail");
                                        sw.Flush();
                                    }
                                }

                            }
                        }
                    }
                    else if (chat.IndexOf("@") > -1)
                    {
                        string receiver = chat.Substring(chat.IndexOf("@") + 1, chat.IndexOf("_") - 1);
                        string text = chat.Substring(chat.IndexOf("_") + 1, chat.IndexOf(".") - chat.IndexOf("_") - 1);
                        string sender = chat.Substring(chat.IndexOf(".") + 1);

                        if (receiver == "everyone")
                        {
                            for (int a = 0; a < CNLIST.Count; a++)
                            {
                                if(sender == CNLIST[a])
                                {
                                    continue;
                                }
                                else
                                {
                                    SWClients[a].WriteLine(sender + ": " + text);
                                    SWClients[a].Flush();
                                }
                            }

                            int g = DateTime.Now.Year;
                            int b = DateTime.Now.Month;
                            int c = DateTime.Now.Day;
                            int d = DateTime.Now.Hour;
                            int e = DateTime.Now.Minute;
                            int f = DateTime.Now.Second;

                            string SQL = "INSERT INTO SOCKET_SCHEMA.chat_log(sender, receiver, chat, time) values ('" + sender + "','" + receiver + "','" + text + "','" + g + "-" + b
                                + "-" + c + "/" + d + ":" + e + ":" + f + "')";
                            MySqlCommand command = new MySqlCommand(SQL, connection);
                            command.ExecuteNonQuery();

                            dataGridView1.DataSource = ds_s.Tables[0];
                        }
                        else
                        {
                            for (int a = 0; a < CNLIST.Count; a++)
                            {
                                if (receiver == CNLIST[a])
                                {
                                    SWClients[a].WriteLine(sender + ": " + text);
                                    SWClients[a].Flush();
                                }
                            }
                            
                            int g = DateTime.Now.Year;
                            int b = DateTime.Now.Month;
                            int c = DateTime.Now.Day;
                            int d = DateTime.Now.Hour;
                            int e = DateTime.Now.Minute;
                            int f = DateTime.Now.Second;

                            string SQL = "INSERT INTO SOCKET_SCHEMA.chat_log(sender, receiver, chat, time) values ('" + sender + "','" + receiver + "','" + text + "','" + g + "-" + b
                                + "-" + c + "/" + d + ":" + e + ":" + f + "')";
                            MySqlCommand command = new MySqlCommand(SQL, connection);
                            command.ExecuteNonQuery();

                            dataGridView1.DataSource = ds_s.Tables[0];
                        }
                    }
                }
                catch
                {

                }
            }
        }

        void comparison()
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (richTextBox2.Text != save1)
            {
                for(int a = 0; a < CNLIST.Count; a++)
                {  
                    if(check == false)
                    {
                        save1 = richTextBox2.Text;
                        string save2 = save1.Replace("\n", "/");
                        SWClients[a].WriteLine(save2);
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
