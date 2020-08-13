using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;

namespace AutoTiktok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Placement(double stt)
        {
           
            int x;
            int y;
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            double width = bounds.Width;
            double height = bounds.Height;
            double a = width / 504.0;
            double giatrithuong = Math.Round(a);
            int m_stt = (int)(stt / giatrithuong);
            int phandu = (int)(stt % giatrithuong);
            int giatriy;
            if (phandu == 0)
            {
                giatriy = m_stt;
            }
            else
            {
                giatriy = m_stt + 1;
            }
            int giatrix = ((int)stt) - ((giatriy - 1) * ((int)giatrithuong));
            if (giatriy == 1)
            {
                y = 0;
            }
            else
            {
                y = (giatriy - 1) * 502;
            }
            if (giatrix == 1)
            {
                x = 0;
            }
            else
            {
                x = (giatrix - 1) * 502;
            }
            return ("--window-position=" + (x+5).ToString() + "," + y.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <=4; i++)
            {               
                ChromeOptions options = new ChromeOptions();
                options.AddExcludedArgument("enable-automation");
                options.AddAdditionalCapability("useAutomationExtension", false);
                options.AddArgument("---disable-notifications");
                options.AddUserProfilePreference("credentials_enable_service", false);
                options.AddUserProfilePreference("profile.password_manager_enabled", false);
                string argument = this.Placement((double)(i));
                options.AddArgument(argument);
                options.AddArgument("--blink-settings=imagesEnabled=false");
               // string[] argumentsToAdd = new string[] { "--window-size=400,450" };
                options.AddArguments("--window-size=320,480");
               // options.AddArgument("--user-agent=" + this.RandomUserAgent());
                ChromeDriver driver = new ChromeDriver(options);
                driver.Navigate().GoToUrl("https://www.tiktok.com/");
                driver.Manage().Window.Size = new Size(320, 480);
            }
        }
    }
}
