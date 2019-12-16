using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace AutoFB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            ChromePerformanceLoggingPreferences perfLogPrefs = new ChromePerformanceLoggingPreferences();
            perfLogPrefs.AddTracingCategories(new string[] { "devtools.timeline" });
            ChromeOptions options = new ChromeOptions();           
            options.AddArguments("--disable-notifications");
            options.AddArguments("--incognito");
            options.PerformanceLoggingPreferences = perfLogPrefs;
            options.SetLoggingPreference(LogType.Driver, LogLevel.All);
            options.SetLoggingPreference("performance", LogLevel.All);
            options.AddAdditionalCapability(CapabilityType.EnableProfiling, true, true);
            PropretiesCollection.driver = new ChromeDriver(options);
            PropretiesCollection.driver.Navigate().GoToUrl("http://facebook.com/");
            Test a = new Test();
            a.DangKy("tran", "Linh", "a12312321@gmail.com", "a12312321.thang@gmail.com");
        }
    }
}
