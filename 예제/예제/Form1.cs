using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 예제
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int num = str.IndexOf('@');
            textBox2.Text = str.Substring(num, str.IndexOf('#'));
            textBox3.Text = str.Substring(str.IndexOf('#'), str.Length- str.IndexOf('#'));
        }
    }
}
