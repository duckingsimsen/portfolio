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

namespace client_3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//3. 통로를 만들고 채팅방을 생성
        {
            Form3 f2 = new Form3();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.sw.WriteLine(Form1.ID.Text + "님이 종료를 했습니다");
            Form1.sw.Flush();
        }
    }
}