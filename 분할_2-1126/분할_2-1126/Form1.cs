using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 분할_2_1126
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;

            string name = str.Substring(str.IndexOf('@') + 1, str.IndexOf('_') - 1);
            string text = str.Substring(str.IndexOf('_') - 1);

            MessageBox.Show(name + "/" + text);
        }
    }
}
