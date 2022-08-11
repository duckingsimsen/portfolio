using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Raspberry
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            selenium();
        }

        public void selenium()
        {
            Label[] LB1 = new Label[5] { label5, label6, label7, label8, label9 };
            Label[] LB2 = new Label[5] { label11, label12, label13, label14, label15 };
            int[] g = new int[5];
            int[] h = new int[5];

            ChromeOptions options = new ChromeOptions();
            ChromeDriverService driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            options.AddArguments("headless");
            options.AddArguments("window-size=1920x1080");

            ChromeDriver driver = new ChromeDriver(driverService, options);

            driver.Url = "https://news.naver.com/";
            Thread.Sleep(2000);

            //IT/과학
            var element_it_img = driver.FindElement(By.CssSelector("#section_it img"));
            String img_link = element_it_img.GetAttribute("src");

            var imageStream = HttpWebRequest.Create(img_link).GetResponse().GetResponseStream();
            pictureBox1.Image = Image.FromStream(imageStream);

            var element_it = driver.FindElement(By.CssSelector("#section_it dd"));
            label1.Text = element_it.Text;

            //경제

            var element_economy_img = driver.FindElement(By.CssSelector("#section_economy img"));
            String img_link_economy = element_economy_img.GetAttribute("src");

            var imageStream_economy = HttpWebRequest.Create(img_link_economy).GetResponse().GetResponseStream();
            pictureBox2.Image = Image.FromStream(imageStream_economy);

            var element_economy = driver.FindElement(By.CssSelector("#section_economy dd"));
            label2.Text = element_economy.Text;

            //사회

            var element_society_img = driver.FindElement(By.CssSelector("#section_society img"));
            String img_link_society = element_society_img.GetAttribute("src");

            var imageStream_society = HttpWebRequest.Create(img_link_society).GetResponse().GetResponseStream();
            pictureBox3.Image = Image.FromStream(imageStream_society);

            var element_society = driver.FindElement(By.CssSelector("#section_society dd"));
            label3.Text = element_society.Text;

            //세계

            var element_world = driver.FindElement(By.CssSelector("#section_world dd"));
            label4.Text = element_world.Text;

            var elements_world = driver.FindElements(By.CssSelector("#section_world li"));
            int s = 0;

            foreach(var el in elements_world)
            {
                if(s == 5)
                {
                    break;
                }

                LB1[s].Text = el.Text;
                s++;
            }

            //생활/문화

            var element_life = driver.FindElement(By.CssSelector("#section_life dd"));
            label10.Text = element_life.Text;

            var elements_life = driver.FindElements(By.CssSelector("#section_life li"));
            int p = 0;

            foreach(var el in elements_life)
            {
                if(p == 5)
                {
                    break;
                }

                LB2[p].Text = el.Text;
                p++;
            }

            int a = label1.Text.Length;
            int b = label2.Text.Length;
            int c = label3.Text.Length;
            int d = label4.Text.Length;
            int e = label10.Text.Length;

            if(a > 15 || b > 15 || c > 15)
            {
                label1.Text = label1.Text.Remove(15) + "...";
                label2.Text = label2.Text.Remove(15) + "...";
                label3.Text = label3.Text.Remove(15) + "...";
            }

            for(int f = 0; f < 5; f++)
            {
                g[f] = LB1[f].Text.Length;

                if(g[f] > 30)
                {
                    LB1[f].Text = LB1[f].Text.Remove(30) + "...";
                }
            }

            for(int i = 0; i < 5; i++)
            {
                h[i] = LB2[i].Text.Length;

                if(h[i] > 30)
                {
                    LB2[i].Text = LB2[i].Text.Remove(30) + "...";
                }
            }

            driver.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }
    }
}
