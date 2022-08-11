using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        List<string> test = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test.Add("a");
            test.Add("b");
            test.Add("c");
            test.Add("d");
            test.Add("e");
            test.Add("f");
            for (int a = 0; a < 6; a++)
            {
                richTextBox1.Text += test[a] + "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test.Remove("d");
            for (int a = 0; a < 5; a++)
            {
                richTextBox1.Text += test[a] + "\n";
            }
        }
    }
}
