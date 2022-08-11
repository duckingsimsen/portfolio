using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text2
{
    public partial class Form1 : Form
    {
        string a;
        string b;
        string c;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = richTextBox1.Text.Substring(richTextBox1.Text.IndexOf("@") + 1, richTextBox1.Text.IndexOf("_") - 1);
            richTextBox3.Text = richTextBox1.Text.Substring(richTextBox1.Text.IndexOf("_"));
        }
    }
}
