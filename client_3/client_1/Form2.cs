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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)//2. 서버와 접속성공했다고 뜸
        {
            Form4 f2 = new Form4();
            f2.Show();
            this.Hide();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.sw.WriteLine(Form1.ID.Text + "님이 종료를 했습니다");
            Form1.sw.Flush();
        }
    }
}
