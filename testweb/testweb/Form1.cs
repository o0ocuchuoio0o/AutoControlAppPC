using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading.Tasks;

namespace testweb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void todo(string title)
        {
            
                PropretiesCollection.driver = new ChromeDriver();
                PropretiesCollection.driver.Navigate().GoToUrl("http://thongtinphat.vnpost.vn/Security/SignIn");
                //IJavaScriptExecutor js = (IJavaScriptExecutor)PropretiesCollection.driver;
                //string title = (string)js.ExecuteScript("document.title = '" + bien + "'");
                PropretiesCollection.driver.Close();
        }
        private string a;
        public void RunTask(string s)  {
            PropretiesCollection.driver = new ChromeDriver();
            PropretiesCollection.driver.Navigate().GoToUrl("http://thongtinphat.vnpost.vn/Security/SignIn");
            IJavaScriptExecutor js = (IJavaScriptExecutor)PropretiesCollection.driver;
            string title = (string)js.ExecuteScript("document.title = '" + a + "'");
           // PropretiesCollection.driver.Close();
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] mang = new string[] {"0", "1", "2","3","4","5","6","7","8","9" };
            for (int i = 0; i < 5;i=i+3)
            {
                string[] mangduyet = new string[2];
                
                mangduyet[0] = mang[i].ToString();
                mangduyet[1] = mang[i+1].ToString();               
                ParallelLoopResult result = Parallel.ForEach(mangduyet, (RunTask) => {

                    PropretiesCollection.driver = new ChromeDriver();
                    PropretiesCollection.driver.Navigate().GoToUrl("https://www.google.com/");
                    IJavaScriptExecutor js = (IJavaScriptExecutor)PropretiesCollection.driver;
                    string title = (string)js.ExecuteScript("document.title = '" + mangduyet[mangduyet.Length-1].ToString() + "'");
                });
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            var text = "Trần Văn Thắng";
            var base64 = text.EncodeBase64();
        }
    }
}
