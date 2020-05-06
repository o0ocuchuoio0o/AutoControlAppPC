using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System.Net.Sockets;
using System.Net;
using OpenQA.Selenium.Support.PageObjects;

namespace SubTor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void RefreshTorIdentity()
        {
            Socket server = null;
            try
            {
                IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9151);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Connect(ip);
                server.Send(Encoding.ASCII.GetBytes("AUTHENTICATE \"johnsmith\"" + Environment.NewLine));
                byte[] data = new byte[1024];
                int receivedDataLength = server.Receive(data);
                string stringData = Encoding.ASCII.GetString(data, 0, receivedDataLength);
                server.Send(Encoding.ASCII.GetBytes("SIGNAL NEWNYM" + Environment.NewLine));
                data = new byte[1024];
                receivedDataLength = server.Receive(data);
                stringData = Encoding.ASCII.GetString(data, 0, receivedDataLength);
                if (!stringData.Contains("250"))
                {
                    Console.WriteLine("Unable to signal new user to server.");
                    server.Shutdown(SocketShutdown.Both);
                    server.Close();
                }
            }
            finally
            {
                server.Close();
            }
        }



        [FindsBy(How = How.Id, Using = "/html/body/div[2]/div/div[2]/div/div[2]/form/div/div[2]/div[2]/div/div[2]/button[2]")]
        public IWebElement m_LoginGoogle;

        private void button1_Click(object sender, EventArgs e)
        {
            String torBinaryPath = @"D:\Tor\Tor Browser\Browser\firefox.exe";
            Process TorProcess = new Process();
            TorProcess.StartInfo.FileName = torBinaryPath;
            TorProcess.StartInfo.Arguments = "-n";
            TorProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            TorProcess.Start();
            FirefoxOptions options = new FirefoxOptions();
            options.SetPreference("network.proxy.type", 1);
            options.SetPreference("network.proxy.socks", "127.0.0.1");
            options.SetPreference("network.proxy.socks_port", 9150);
            options.SetPreference("webdriver.firefox.profile", "default");
            FirefoxDriver _Driver = new FirefoxDriver(options);
            _Driver.Navigate().GoToUrl("https://member.lazada.vn/user/login");
            m_LoginGoogle.Click();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
