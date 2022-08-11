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
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace webcrwaling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ChromeOptions options = new ChromeOptions();
            ChromeDriverService driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = false;
            options.AddArguments("headless");
            options.AddArguments("window-size=1920x1080");
            
            string[] weather = new string [8] {"", "", "", "", "", "", "", ""};
            string[] temp = new string [8] {"", "", "", "", "", "", "", ""};
            string[] per = new string[1] { "" };

            ChromeDriver driver = new ChromeDriver(driverService, options);
            
                driver.Url = "https://www.msn.com/ko-kr/weather";
                Thread.Sleep(2000);

                var element = driver.FindElementByXPath("//*[@id='HourlyToggle']");
                element.Click(); //버튼 클릭.

                var elements = driver.FindElements(By.CssSelector("#ForecastHourly li"));

                int i = 0;

                foreach (var el in elements)
                {
                    if (i == 8)
                    {
                        break;
                    }

                    string[] infor = el.Text.Split(new char[] { '\n' });
                    weather[i] = infor[1];
                    temp[i] = infor[2];
                    per[0] = infor[3];
                    i++;
                }

                for(int j = 0; j < 8; j++)
                {
                    richTextBox1.AppendText(weather[j] + "\n" + temp[j]);
                    richTextBox1.AppendText("\n" + per[0]);
                }

            driver.Close();
        }
    }
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