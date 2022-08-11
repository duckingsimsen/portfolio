using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using LiveCharts;
using LiveCharts.Wpf;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Raspberry
{
    public partial class Form1 : Form
    {
        public string[] weather = new string[8] { "", "", "", "", "", "", "", "" };
        public string[] temp = new string[8] { "", "", "", "", "", "", "", "" };
        public string[] per = new string[1] { "" };

        public Form1()
        {
            InitializeComponent();
            selenium();
            weatherop();
        }

        public void selenium()
        {
            ChromeOptions options = new ChromeOptions();
            ChromeDriverService driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            options.AddArguments("headless");
            options.AddArguments("window-size=1920x1080");

            ChromeDriver driver = new ChromeDriver(driverService, options);
            
            driver.Url = "https://www.msn.com/ko-kr/weather";
            Thread.Sleep(2000);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            var element = driver.FindElementByXPath("//*[@id='HourlyToggle']");
            element.Click();

            var elements = driver.FindElements(By.CssSelector("#ForecastHourly li")); 

            int s = 0;
            foreach(var el in elements)
            {
                int log;
                
                if(s == 8)
                {
                    break;
                }
                
                string[] infor = el.Text.Split(new char[] { '\n' });
                log = infor[0].IndexOf('°');

                if(log < 0) //°가 없는거
                {
                    weather[s] = infor[2]; // 날씨나타내는거
                    temp[s] = infor[1]; // 온도나타내는거
                }
                else //°가 있는거
                {
                    weather[s] = infor[1]; // 날씨나타내는거
                    temp[s] = infor[0]; // 온도나타내는거
                }

                if(s == 0)
                {
                    per[0] = infor[3]; // 현재 강수량 나타내는거
                }
                s++;
            }
            driver.Close();

            label2.Text = "현재 온도는\n" + temp[0] + " 입니다.";
            label3.Text = "현재 강수확률은\n" + per[0] + " 입니다.";
        }

        public void weatherop()
        {
            int b;
            string c;
            int d;
            int e = 0;
            int g;

            PictureBox[] PB = new PictureBox[8] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };
            Label[] LB1 = new Label[8] { label4, label5, label6, label7, label8, label9, label10, label11};
            Label[] LB2 = new Label[8] { label16, label17, label18, label19, label20, label21, label22, label23 };
            Label[] LB3 = new Label[8] { label24, label25, label26, label27, label28, label29, label30, label31 };
            //TextBox[] TB = new TextBox[8] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8 };

            for(b = 0; b < 8; b++)
            {
                /*if(weather[b].IndexOf(' ') != -1)
                {
                    weather[b] = weather[b].Insert(weather[b].IndexOf(' '), "\n");
                }*/
                
                LB2[b].Text = weather[b];

                weather[b] = weather[b].Replace("\r", "");

                g = weather[b].Length;

                if(g == 2)
                {
                    continue;
                }
                else if(g > 2)
                {
                    LB2[b].Left = LB2[b].Left - 10;
                }
                else if(g < 2)
                {
                    LB2[b].Left = LB2[b].Left + 7;
                }
            }

            //시간나타내는것
            for(int f = DateTime.Now.Hour; f < DateTime.Now.Hour + 8; f++)
            {
                d = f;
                if(d > 23)
                {
                    d -= 24;
                    if(d > 12)
                    {
                        d -= 12;
                        LB1[e].Text = Convert.ToString(d) + " PM";
                        e++;
                    }
                    else
                    {
                        LB1[e].Text = Convert.ToString(d) + " AM";
                        e++;
                    }

                    if(e > 7)
                    {
                        break;
                    }

                    /*if(d > 9)
                    {
                        LB1[e].Location = new Point(LB1[e].Left - 7, LB1[e].Top);
                    }*/
                }
                else
                {
                    if(d > 12)
                    {
                        d -= 12;
                        LB1[e].Text = Convert.ToString(d) + " PM";
                        e++;
                    }
                    else
                    {
                        LB1[e].Text = Convert.ToString(d) + " AM";
                        e++;
                    }

                    if(e > 7)
                    {
                        break;
                    }

                    /*if (d < 9)
                    {
                        LB1[e].Location = new Point(LB1[e].Left + 7, LB1[e].Top);
                    }*/
                }
            }
            //날씨 나타내는것
            for(b = 0; b < 8; b++)
            {
                int s = weather[b].IndexOf("맑음");
                int p = weather[b].IndexOf("흐림");
                int q = weather[b].IndexOf("구름많음");
                int r = weather[b].IndexOf("비");
                int t = weather[b].IndexOf("눈");
                int u = weather[b].IndexOf("소나기");
                int v = weather[b].IndexOf("화창");

                

                if(s >= 0 || v >= 0)
                {
                    c = "sunny";

                    PB[b].Image = Properties.Resources.sunny3;
                }
                else if(p >= 0)
                {
                    c = "cloud";

                    PB[b].Image = Properties.Resources.cloud3;
                }
                else if(q >= 0)
                {
                    c = "fade";

                    PB[b].Image = Properties.Resources.fade3;
                }
                else if(r >= 0 || u >= 0)
                {
                    c = "rain";

                    PB[b].Image = Properties.Resources.rain3;
                }
                else if(t >= 0)
                {
                    c = "snow";

                    PB[b].Image = Properties.Resources.snow3;
                }
            }

            //온도 나타내는거
            for(b = 0; b < 8; b++)
            {
                LB3[b].Text = temp[b];
            }

            pictureBox1.Image = pictureBox2.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)//시간표출
        {
            int y = DateTime.Now.Year;
            int m = DateTime.Now.Month;
            int d = DateTime.Now.Day;
            int h1 = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int s = DateTime.Now.Millisecond;
            int h2;
            string division;

            label1.Text = Convert.ToString(y) + "-" + Convert.ToString(m) + "-" + Convert.ToString(d);

            if(h1 > 12)
            {
                h2 = h1 - 12;
                division = "오후";
            }
            else
            {
                h2 = h1;
                division = "오전";
            }
            
            label15.Text = division + " " + DateTime.Now.ToString("hh:mm");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //init data
            /*cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();

            for(int i = 0; i < 8; i++)
            {
                temp[i] = temp[i].Remove(2, 2);
            }

            List<double> values = new List<double>();
            for(int time = 0; time <= 7; time++)
            {
                values.Add(Convert.ToDouble(temp[time]));
            }

            series.Add(new LineSeries() { Title = "temp", Values = new ChartValues<double>(values), DataLabels = true, Fill = System.Windows.Media.Brushes.Transparent });
            
            cartesianChart1.Series = series;*/
        }
    }
}
