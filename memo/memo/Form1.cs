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

namespace memo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\sam87\Desktop\caffe.txt";
            string[] text = File.ReadAllLines(path);
            
            for(int i = 0; i < text.Length; i++)
            {
                richTextBox1.AppendText(text[i] + "\n");
            }
        }
    }
}
