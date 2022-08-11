using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 전체전역변수
{
    public partial class Form2 : Form
    {
        public static TextBox m;
        public Form2()
        {
            InitializeComponent();
            m = textBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
        public static void function()
        {
            m.Text = "aaaaa";
        }
    }
}
