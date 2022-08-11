using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concer_new
{
    public partial class chating : Form
    {
        public chating()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Form4 f2 = new Form4();
            f2.Show();
            this.Hide();
        }
    }
}
