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
                //string title = (string)js.ExecuteScript("document.title = '"+bien+"'");
                PropretiesCollection.driver.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            object look = new object();
            int k = 0;
            for (int i = 1; i <= 5; i++)
            {
                lock (look)
                {
                    Thread t1 = new Thread(() =>
                     {
                         
                         for (int j = 1; j <= int.Parse(txtsoluong.Text); j++)
                         {
                             k = k + 1;
                             Thread t = new Thread(() =>
                             {
                                 todo(k.ToString());
                             });
                             t.Start();                            
                         }
                     });
                    t1.Priority = ThreadPriority.Lowest;
                    t1.Start();
                    t1.Join();

                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
