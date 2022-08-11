using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raspberry
{
    public partial class Form2 : Form
    {
        //int[] a = new int[42] { 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] b = new int[42] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        //int[] c = new int[42] { 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        public Form2()
        {
            InitializeComponent();
            month();
            calender();
            calendar_background();

            pictureBox3.Parent = pictureBox1;

            int a = DateTime.Now.Year;
            int b = DateTime.Now.Month;
            label3.Text = Convert.ToString(a);
            label4.Text = Convert.ToString(b);
        }

        public void month()
        {
            DateTime today = DateTime.Today;
            DateTime first_day = today.AddDays(1 - today.Day);
            int first_week_day_count = (int)(first_day.DayOfWeek);


            DateTime last_day = today.AddMonths(1).AddDays(0 - today.Day);
            int last_week_day_count = last_day.Day+ first_week_day_count;

            int day = 1;
            for (int i = 0; i < 42; i++)
            {
                if(first_week_day_count <= i && last_week_day_count> i)
                {
                    b[i] = day;
                    day++;
                }
            }
        }

        public void calender()
        {
            int d;
            int c = DateTime.Now.Day;
            Label[] lb = new Label[42] { label5, label6, label7, label8, label9, 
                label10, label11, label12, label13, label14, 
                label15, label16, label17, label18, label19, 
                label20, label21, label22, label23, label24,
                label25, label26, label27, label28, label29, 
                label30, label31, label32, label33, label34,
                label35, label36, label37, label38, label39,
                label40, label41, label42, label43, label44,
                label45, label46};

            for (d = 0; d < 42; d++)
            {
                lb[d].Parent = pictureBox1;
                if (b[d] == 0)
                {
                    lb[d].Text = null;
                }
                else
                {
                    lb[d].Text = Convert.ToString(b[d]);

                    lb[d].Left = lb[d].Left - 35;
                    lb[d].Top = lb[d].Top - 184;
                    if (b[d] > 9)
                    {
                        lb[d].Location= new Point(lb[d].Left-7, lb[d].Top);
                    }
                }
            }

            for(int e = 0; e < 42; e++)
            {
                int f = DateTime.Now.Day;
                if(lb[e].Text == Convert.ToString(f))
                {
                    // pictureBox3.Location = lb[e].Location;
                    //pictureBox3.Location = new Point(lb[e].Left - 13, lb[e].Top - 18);
                    pictureBox3.Hide();
                    lb[e].ForeColor = Color.Black;
                }
            }
        }

        public void calendar_background()
        {
            int a;

            a = DateTime.Now.Month;

            PictureBox[] cal = new PictureBox[1] { pictureBox1 };

            if(a >= 3 && a <= 5)
            {
                cal[0].Image = Properties.Resources.back_spring;
            }
            else if(a >= 6 && a <= 8)
            {
                cal[0].Image = Properties.Resources.back_summer_1;
            }
            else if(a >= 9 && a <= 11)
            {
                cal[0].Image = Properties.Resources.back_fall;
            }
            else if(a < 3 || a == 12)
            {
                cal[0].Image = Properties.Resources.back_winter;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
            this.Hide();
        }
    }
}
