using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crawling
{
    public partial class Form1 : Form
    {
        IWebDriver driver = null;
        public Form1()
        {
            InitializeComponent();

            //ChromeOptions options = new ChromeOptions();
           // ChromeDriverService driverService = ChromeDriverService.CreateDefaultService();
            //driverService.HideCommandPromptWindow = false;
           // options.AddArgument("--headless");

            using (driver = new ChromeDriver())
            {
                driver.Url = "https://www.weather.go.kr/w/index.do";
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

                /*var element = driver.FindElement(By.ClassName("tchart"));
                MessageBox.Show(element.Text); // 온도 8시간 자르기
                string[] result = element.Text.Split(new char[] { '\n' });

                var element2 = driver.FindElement(By.ClassName("dfs-slider"));
                element2 = element2.FindElement(By.ClassName("item-wrap"));
                var e3 = element2.FindElement(By.ClassName("pcp"));
                MessageBox.Show(e3.Text); // - 이면 강수량 0mm


                var e4 = element2.FindElement(By.ClassName("hid"));
                MessageBox.Show(e4.Text); // null 이면 0%
                */
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //driver.Close();
        }
    }
}
