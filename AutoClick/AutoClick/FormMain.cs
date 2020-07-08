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
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace AutoClick
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnmoweb_Click(object sender, EventArgs e)
        {
            ChromePerformanceLoggingPreferences perfLogPrefs = new ChromePerformanceLoggingPreferences();
            perfLogPrefs.AddTracingCategories(new string[] { "devtools.timeline" });
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");           
            options.AddArgument("--window-size=1500,900");
            options.AddArgument("--disable-infobars");
            options.PerformanceLoggingPreferences = perfLogPrefs;
            options.SetLoggingPreference(LogType.Driver, LogLevel.All);
            options.SetLoggingPreference("performance", LogLevel.All);
            options.AddAdditionalCapability(CapabilityType.EnableProfiling, true, true);
            PropretiesCollection.driver = new ChromeDriver(options);
            PropretiesCollection.driver.Navigate().GoToUrl("https://thuthapdiachi.vnpost.vn/");
        }
       // [FindsBy(How = How.XPath, Using = "/html/body/app-root/mat-grid-list/div/mat-grid-tile[2]/figure/mat-grid-list/div/mat-grid-tile[2]/figure/app-map/div[2]/div[2]/div[1]/div/button")]       
         [FindsBy(How = How.LinkText, Using = "Duyệt điểm")]       
        public IWebElement duyet;


        [FindsBy(How = How.XPath, Using = "/html/body/app-root/mat-grid-list/div/mat-grid-tile[2]/figure/mat-grid-list/div/mat-grid-tile[2]/figure/app-map/div[4]/kendo-dialog/div[2]/kendo-dialog-actions/button[1]")]
        public IWebElement xacnhanduyet;

        private void btnclick_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
                List<IWebElement> table = PropretiesCollection.driver.FindElements(By.XPath("//*[@class='leaflet-marker-icon leaflet-zoom-animated leaflet-interactive']")).ToList();
                int k = 1;
                int count = table.Count;
                int thanhcong =0;
                int loi = 0;
                foreach (IWebElement field in table)
                {
                    try
                    {
                        Thread.Sleep(1000);
                        //try
                        //{
                         

                        //    Actions builder = new Actions(PropretiesCollection.driver);
                        //    builder.MoveByOffset(field.Location.X, field.Location.Y).ClickAndHold(field).Build().Perform();
                        //}
                        //catch { }
                        field.Click();

                        Thread.Sleep(1000);        
               
                        PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/app-root/mat-grid-list/div/mat-grid-tile[2]/figure/mat-grid-list/div/mat-grid-tile[2]/figure/app-map/div[2]/div[2]/div[1]/div/button")).Click();
                        Thread.Sleep(1000);
                        PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/app-root/mat-grid-list/div/mat-grid-tile[2]/figure/mat-grid-list/div/mat-grid-tile[2]/figure/app-map/div[4]/kendo-dialog/div[2]/kendo-dialog-actions/button[1]")).Click();
                        Thread.Sleep(1000);
                        thanhcong = thanhcong + 1;
                    }
                    catch {
                        loi = loi + 1;
                    }
                    this.Invoke(new Action(() =>
                    {
                        lblthongbao.Text = "Số lượng duyệt " + k.ToString() + @"/" + count.ToString() + "Thành công : " + thanhcong.ToString() + "Lỗi :" + loi.ToString();
                    }));
                    
                    k = k + 1;
                }
                //chạy xong tắt chome
               // PropretiesCollection.driver.Close();
                MessageBox.Show("Đã duyệt hết điểm");      
            });
            t.IsBackground = false;
            t.Start();
           
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private static Bitmap screenBitmap;   
        private static Graphics screenGraphics;

        private void btnclickpixel_Click(object sender, EventArgs e)
        {
        //    screenBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
        //                                   Screen.PrimaryScreen.Bounds.Height,
        //                                   PixelFormat.Format32bppArgb);
        //    screenGraphics = Graphics.FromImage(screenBitmap);
        //    screenGraphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y,
        //                            0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
        //    screenBitmap.Save(@"C:\A.png", ImageFormat.Png);



        }
    }
}
