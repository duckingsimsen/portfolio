using System;
using System.Windows.Forms;
using System.IO;

namespace 커피자판기
{
    public partial class Form1 : Form
    {
        int a = 0;
        int b = 0;
        int c = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "아메리카노")
            {
                if (comboBox2.SelectedItem.ToString() == "ICE")
                {
                    textBox3.Text = Convert.ToString(2000 * Convert.ToInt32(textBox1.Text) + 500 * Convert.ToInt32(textBox1.Text));
                    a++;
                }
                else
                {
                    textBox3.Text = Convert.ToString(2000 * Convert.ToInt32(textBox1.Text));
                    a++;
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "바닐라 라때")
            {
                if (comboBox2.SelectedItem.ToString() == "ICE")
                {
                    textBox3.Text = Convert.ToString(3700 * Convert.ToInt32(textBox1.Text) + 500 * Convert.ToInt32(textBox1.Text));
                    b++;
                }
                else
                {
                    textBox3.Text = Convert.ToString(3700 * Convert.ToInt32(textBox1.Text));
                    b++;
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "콜드부루 오리지널")
            {
                if (comboBox2.SelectedItem.ToString() == "ICE")
                {
                    textBox3.Text = Convert.ToString(3300 * Convert.ToInt32(textBox1.Text) + 500 * Convert.ToInt32(textBox1.Text));
                    c++;
                }
                else
                {
                    textBox3.Text = Convert.ToString(3300 * Convert.ToInt32(textBox1.Text));
                    c++;
                }
            }
            dataGridView1.Rows.Add(comboBox1.Text, comboBox2.Text, textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.Rows.Count;
            int d = 0;
            int max = 0;
            int index = 0;
            int count = 1;
            string[] name = new string[100];
            string[] cost = new string[100];

            //하루 판 금액
            for (int l = 0; l < i - 1; l++)
            {
                d += Convert.ToInt32(dataGridView1.Rows[l].Cells[4].Value.ToString());
                textBox4.Text = Convert.ToString(d);
            }

            // 가장 많이 사간 손님
            string[,] cos = new string[dataGridView1.RowCount * 5 - 1,2];

            for(int p = 0; i < dataGridView1.RowCount; i++)
            {
                if(p == 0)
                {
                    //cos[dataGridView1.Rows[0].Cells[0]]
                }
            }

            //가장 많이 팔린 커피
            if (a > b)
            {
                if(a > c)
                {
                    textBox6.Text = Convert.ToString("아메리카노" + a + "개");
                }
                else
                {
                    textBox6.Text = Convert.ToString("콜드부루 오리지널" + c + "개");
                }
            }
            else
            {
                if(b > c)
                {
                    textBox6.Text = Convert.ToString("바닐라 라때" + b + "개");
                }
                else
                {
                    textBox6.Text = Convert.ToString("콜드부루 오리지널" + c + "개");
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"C:\Users\sam87\Desktop\organization.txt";
            string[] text = File.ReadAllLines(path);

            int cnt = 1;
            int row = 0;

            for (int i = 0; i < (text.Length / 5); i++)
            {
                dataGridView1.Rows.Add();
            }

            for (int i = 0; i < text.Length; i++)
            {
                dataGridView1.Rows[row].Cells[cnt - 1].Value = text[i];

                if (cnt % 5 == 0)
                {
                    row++;
                    cnt = 0;
                }

                cnt++;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string path = @"C:\Users\sam87\Desktop\organization.txt";
            string[] text = new string[dataGridView1.RowCount * 5 - 1];
            int p = 0;


            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                for (int l = 0; l < 5; l++)
                {
                    text[p] = dataGridView1.Rows[i].Cells[l].Value.ToString();
                    p++;
                }
            }

            File.WriteAllLines(path, text);
        }
    }
}
