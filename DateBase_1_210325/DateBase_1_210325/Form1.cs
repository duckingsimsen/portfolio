using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace DateBase_1_210325
{
    public partial class Form1 : Form
    {

        public static MySqlConnection connection;
        String ServerName = "localhost";
        String DataBase = "socket_schema";
        String userid = "root";
        String userpw = "tlatms2033!";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection("Server=" + ServerName + ";Database=" + DataBase + ";Uid=" + userid + ";Pwd=" + userpw);
            connection.Open();

            Boolean temp = connection.Ping();

            //연결이 성공하였을 경우 DB연결 성공 실패하였을 경우 DB 연결 실패
            if (temp == true)
            {
                MessageBox.Show("DB연결 성공", "DB 연결", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("DB 연결 실패", "DB 연결", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string insertQuery = "insert into socket_schema.new_table (ID, PW, Birth, name_, PN) value ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + 
                textBox4.Text + "','" + textBox5.Text + "')";


            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            if (command.ExecuteNonQuery() == 1)
            {
                Console.WriteLine("인서트 성공");
            }
            else
            {
                Console.WriteLine("인서트 실패");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string insertQuery = "SELECT * FROM socket_schema.new_table";
            MySqlDataAdapter adpt = new MySqlDataAdapter(insertQuery, connection);
            adpt.Fill(ds, "socket_schema.new_table");



            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
