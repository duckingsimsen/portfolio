using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace 마우스컨트롤
{
    public partial class Form1 : Form
    {

        int sw1 = 0;
        int sw2 = 0;
        int sw3 = 0;
        int sw4 = 0;
        int sw5 = 0;
        int sw6 = 0;
        int time = 0;

        public Form1()
        {
            InitializeComponent();
            SoundPlayer sp = new SoundPlayer("C:\\Users\\sam87\\Desktop\\MAYDAY.wav");
            sp.Play();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time == 2)
            {
                timer1.Interval = 20;
                if (pictureBox1.Top > 236 && sw1 == 0)
                {
                    pictureBox1.Top -= 10;
                    if (pictureBox1.Top < 236)
                    {
                        sw1++;
                    }
                }
                else if (pictureBox1.Left < 160 && sw2 == 0)
                {
                    pictureBox1.Left += 10;
                    if (pictureBox1.Left > 160)
                    {
                        sw2++;
                    }
                }
                else if (pictureBox1.Top < 291 && sw1 == 1)
                {
                    pictureBox1.Top += 10;
                    if (pictureBox1.Top > 291)
                    {
                        sw1++;
                    }
                }
                else if (pictureBox1.Left < 264 && sw2 == 1)
                {
                    pictureBox1.Left += 10;
                    if (pictureBox1.Left > 264)
                    {
                        sw2++;
                    }
                }
                else if (pictureBox1.Top > 171 && sw1 == 2)
                {
                    pictureBox1.Top -= 10;
                    if (pictureBox1.Top < 171)
                    {
                        sw1++;
                    }
                }
                else if (pictureBox1.Left < 380 && sw2 == 2)
                {
                    pictureBox1.Left += 10;
                    if (pictureBox1.Left > 380)
                    {
                        sw2++;
                    }
                }
                else if (pictureBox1.Top < 360 && sw1 == 3)
                {
                    pictureBox1.Top += 10;
                    if (pictureBox1.Top > 360)
                    {
                        sw1++;
                    }
                }
                else if (pictureBox1.Left < 490 && sw2 == 3)
                {
                    pictureBox1.Left += 10;
                    if (pictureBox1.Left > 490)
                    {
                        sw2++;
                    }
                }
                else if (pictureBox1.Top > 290 && sw1 == 4)
                {
                    pictureBox1.Top -= 10;
                    if (pictureBox1.Top < 290)
                    {
                        sw1++;
                    }
                }
                else if (pictureBox1.Left < 600 && sw2 == 4)
                {
                    pictureBox1.Left += 10;
                    if (pictureBox1.Left > 600)
                    {
                        sw2++;
                    }
                }
                else if (pictureBox1.Top < 360 && sw1 == 5)
                {
                    pictureBox1.Top += 10;
                    if (pictureBox1.Top > 360)
                    {
                        sw1++;
                    }
                }
                else if (pictureBox1.Left < 705 && sw2 == 5)
                {
                    pictureBox1.Left += 10;
                    if (pictureBox1.Left > 705)
                    {
                        sw2++;
                    }
                }
                else if (pictureBox1.Top > 165 && sw1 == 6)
                {
                    pictureBox1.Top -= 10;
                    if (pictureBox1.Top < 165)
                    {
                        sw1++;
                    }
                }
                else if (pictureBox1.Left < 772 && sw2 == 6)
                {
                    pictureBox1.Left += 10;
                    if (pictureBox1.Left > 772)
                    {
                        sw2++;
                    }
                }
                else if (pictureBox1.Top > 2 && pictureBox1.Left < 1005)
                {
                    pictureBox1.Top -= 10;
                    pictureBox1.Left += 15;
                }
            }
            else
            {
                time++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel14.Top < 382 && sw3 == 0)
            {
                panel14.Top += 15;
                if (panel14.Top > 382)
                {
                    sw3++;
                }
            }
            else if (panel14.Top >= 2 && sw3 == 1)
            {
                panel14.Top -= 15;
                if (panel14.Top <= 2)
                {
                    sw3--;
                }
            }

            if (panel16.Top > 2 && sw4 == 0)
            {
                panel16.Top -= 15;
                if (panel16.Top < 2)
                {
                    sw4++;
                }
            }
            else if (panel16.Top <= 382 && sw4 == 1)
            {
                panel16.Top += 15;
                if (panel16.Top >= 382)
                {
                    sw4--;
                }
            }

            if (panel17.Top > 2 && sw5 == 0)
            {
                panel17.Top -= 15;
                if (panel17.Top < 2)
                {
                    sw5++;
                }
            }
            else if (panel17.Top <= 382 && sw5 == 1)
            {
                panel17.Top += 15;
                if (panel17.Top >= 382)
                {
                    sw5--;
                }
            }

            if (panel18.Top <= 382 && sw6 == 0)
            {
                panel18.Top += 15;
                if (panel18.Top >= 382)
                {
                    sw6++;
                }
            }
            else if (panel18.Top >= 2 && sw6 == 1)
            {
                panel18.Top -= 15;
                if (panel18.Top <= 2)
                {
                    sw6--;
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }
        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }
        private void panel9_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }

        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }

        private void panel11_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }

        private void panel12_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }

        private void panel13_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }

        private void panel14_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }

        private void panel15_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }

        private void panel16_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }

        private void panel17_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }

        private void panel18_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CRASH XP");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Well Done");
            pictureBox1.Top = 478;
            pictureBox1.Left = 3;
            sw1 = 0;
            sw2 = 0;
            sw3 = 0;
            sw4 = 0;
            sw5 = 0;
            sw6 = 0;
            time = 0;
            timer1.Interval = 1000;
            timer1.Enabled = false;

        }
    }
}
