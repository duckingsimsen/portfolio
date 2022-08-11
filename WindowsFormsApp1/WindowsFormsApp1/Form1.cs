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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] a = new string[10];
            richTextBox1.Text = richTextBox1.Text.Replace("님", "");
            a = richTextBox1.Text.Split();
            for(int i = 0; i < a.Count(); i++)
            {
                richTextBox2.AppendText(a[i]);
            }
        }
    }
}
