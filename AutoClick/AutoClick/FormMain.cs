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

        private void button2_Click(object sender, EventArgs e)
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
            PropretiesCollection.driver.Navigate().GoToUrl("http://10.1.45.26:8083/");
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/div/div/div[2]/div[2]/button[3]")]
        public IWebElement next;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div/div/div/div/div[2]/div[2]/button[4]")]
        public IWebElement hoanthanh;
        
        private void button1_Click(object sender, EventArgs e)
        {
             Thread t = new Thread(() =>
             {

                 for (int lap = 1; lap <= int.Parse(txtlapduyet.Value.ToString()); lap++)
                 {
                     try
                     {
                         int bienkiemtra = 0;
                         switch (bienkiemtra)
                         {
                             case 0:             // label case 1
                                 System.Threading.Thread.Sleep(2500);
                                 goto case 1;
                                 break;  
                             case 1:
                                 try
                                 {
                                     try
                                     {
                                         PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div/div/div[2]/div[2]/button[3]")).Click();
                                     }
                                     catch
                                     {
                                         try {
                                             PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/div/div/div/div/div[2]/div[2]/button[3]")).Click();
                                       
                                         }
                                         catch { goto case 0; }                                         
                                     }
                                     int kiemtrachu = 1;
                                     for (int i = 1; i <= 3; i++)
                                     {
                                         try
                                         {
                                             PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div/div/div[2]/div[2]/button[3]")).Click();
                                         }
                                         catch { }
                                         try
                                         {
                                             PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/div/div/div/div/div[2]/div[2]/button[3]")).Click();

                                         }
                                         catch {  }      
                                         Thread.Sleep(1500);
                                         if (kiemtrachu == 2)
                                         {
                                             IJavaScriptExecutor js = (IJavaScriptExecutor)PropretiesCollection.driver;
                                             js.ExecuteScript("window.scrollBy(0,250)", "");
                                             Thread.Sleep(4000);
                                             try
                                             {
                                                 PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div/div/div[2]/div[1]/div[21]/div[3]/input[2]")).Clear();
                                                
                                                 //PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.ClassName("form-control control-textarea")).Clear();
                                             }
                                             catch { }
                                             Thread.Sleep(1000);
                                             try
                                             {
                                                 PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/div/div/div/div/div[2]/div[1]/div[21]/div[3]/input[2]")).Clear();
                                                
                                                 //PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.ClassName("form-control control-textarea")).Clear();
                                             }
                                             catch { }
                                           
                                            
                                            
                                             Thread.Sleep(1000);
                                             try
                                             {
                                                 PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div/div/div[2]/div[1]/div[21]/div[3]/input[3]")).Clear();
                                                 //PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.ClassName("form-control control-textarea autocompleteWardSearch    inited ui-autocomplete-input")).Clear();
                                             }
                                             catch { }
                                             try
                                             {
                                                 PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/div/div/div/div/div[2]/div[1]/div[21]/div[3]/input[3]")).Clear();
                                                 //PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.ClassName("form-control control-textarea autocompleteWardSearch    inited ui-autocomplete-input")).Clear();
                                             }
                                             catch { }
                                             Thread.Sleep(2000);
                                         }
                                         else if (kiemtrachu == 3)
                                         { 
                                              try
                                             {
                                                 PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div/div/div[2]/div[1]/div[25]/div[3]/input[2]")).Clear();
                                                      }
                                             catch { }
                                             Thread.Sleep(1000);
                                              try
                                             {
                                                 PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/div/div/div/div/div[2]/div[1]/div[25]/div[3]/input[2]")).Clear();
                                               
                                                  // PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.ClassName("form-control control-textarea    ")).Clear();
                                              }
                                             catch { }
                                              Thread.Sleep(1000);
                                             try
                                             {
                                                 PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div/div/div[2]/div[1]/div[26]/div[3]/input[2]")).Clear();
                                                // PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.ClassName("form-control control-textarea    ")).Clear();
                                             }
                                             catch { }
                                             Thread.Sleep(1000);
                                             try
                                             {
                                                 PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/div/div/div/div/div[2]/div[1]/div[26]/div[3]/input[2]")).Clear();
                                                 // PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.ClassName("form-control control-textarea    ")).Clear();
                                             }
                                             catch { }
                                             Thread.Sleep(1000);
                                             try
                                             {
                                                 PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div/div/div[2]/div[1]/div[27]/div[3]/input[2]")).Clear();
                                             }
                                             catch { }
                                             Thread.Sleep(1000);
                                             try
                                             {
                                                 PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/div/div/div/div/div[2]/div[1]/div[27]/div[3]/input[2]")).Clear();
                                             }
                                             catch { }
                                             Thread.Sleep(2000);
                                         }
                                         kiemtrachu = kiemtrachu + 1;
                                     }
                                    
                                     try
                                     {
                                         PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div/div/div[2]/div[2]/button[4]")).Click();
                                     }
                                     catch { }
                                     try
                                     {
                                         PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/div/div/div/div/div[2]/div[2]/button[4]")).Click();
                                     }
                                     catch { }
                                 }
                                 catch {
                                     goto case 0;
                                 }
                                 break;                            
                         }

                       
                          }
                     catch {  }
                  }
             });
             t.IsBackground = false;
             t.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {

                for (int lap = 1; lap <= int.Parse(txtlapduyet.Value.ToString()); lap++)
                {
                    try
                    {
                        int bienkiemtra = 0;
                        switch (bienkiemtra)
                        {
                            case 0:             // label case 1
                                System.Threading.Thread.Sleep(2500);
                                goto case 1;
                                break;
                            case 1:
                                try
                                {
                                    try
                                    {
                                        PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div/div/div[2]/div[2]/button[3]")).Click();
                                    }
                                    catch
                                    {
                                        try
                                        {
                                            PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/div/div/div/div/div[2]/div[2]/button[3]")).Click();

                                        }
                                        catch {
                                            goto case 0;
                                        }
                                    }

                                    for (int i = 1; i <= 2; i++)
                                    {
                                        try
                                        {
                                            PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div/div/div[2]/div[2]/button[3]")).Click();
                                        }
                                        catch { }
                                        try
                                        {
                                            PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/div/div/div/div/div[2]/div[2]/button[3]")).Click();

                                        }
                                        catch { }
                                        Thread.Sleep(1500);
                                    }
                                    try
                                    {
                                        PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div/div/div[2]/div[2]/button[4]")).Click();
                                    }
                                    catch { }
                                    try
                                    {
                                        PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/div/div/div/div/div[2]/div[2]/button[4]")).Click();
                                    }
                                    catch { }
                                }
                                catch
                                {
                                    goto case 0;
                                }
                                break;
                        }


                    }
                    catch { }
                }
            });
            t.IsBackground = false;
            t.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {

                for (int lap = 1; lap <= int.Parse(txtlapduyet.Value.ToString()); lap++)
                {
                    try
                    {
                        int bienkiemtra = 0;
                        switch (bienkiemtra)
                        {
                            case 0:             // label case 1
                                System.Threading.Thread.Sleep(2500);
                                goto case 1;
                                break;
                            case 1:
                                try
                                {                                   
                                   
                                    try
                                    {
                                        PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div/div/div[2]/div[2]/button[4]")).Click();
                                    }
                                    catch {
                                        try
                                        {
                                            PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/div/div/div/div/div[2]/div[2]/button[4]")).Click();
                                        }
                                        catch { goto case 0; }
                                    }
                                    
                                }
                                catch
                                {
                                   
                                }
                                break;
                        }


                    }
                    catch { }
                }
            });
            t.IsBackground = false;
            t.Start();
        }


        #region // test final
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div[1]/div/div[2]/div[2]/div[1]/form/div/div[10]/div/input")]
        public IWebElement ngaysinhct;
      
      
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");
        }

        
        private void btncheckfinal_Click(object sender, EventArgs e)
        {
            
            Thread t = new Thread(() =>
            {
              
                for (int lap = 1; lap <= int.Parse(txtlapduyet.Value.ToString()); lap++)
                {
                    try
                    {
                        Thread.Sleep(3000);
                        for (int i = 1; i <= 30; i++)
                        {
                            Thread.Sleep(200);
                            System.Windows.Forms.SendKeys.SendWait("{TAB}");
                            if (i == 4 )
                            {
                                txtngaysinh.Text = "";
                                Thread.Sleep(2000);
                                SendKeys.SendWait("^c");
                                Thread.Sleep(2000);
                                //this.Invoke(new Action(() =>
                                //{
                                //    txtngaysinh.Paste();
                                //}));
                                 txtngaysinh.Paste();
                                Thread.Sleep(4000);
                                string ngaysinh = txtngaysinh.Text;
                                Thread.Sleep(2000);
                                txtngaysinh.Text = "";
                                if (ngaysinh.IndexOf("01/01") != -1)
                                {
                                    string temp = ngaysinh.Replace("01/01/", "");
                                    try
                                    {
                                      
                                        PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div[2]/div[2]/div[1]/form/div/div[10]/div/input")).SendKeys(temp);
                                       
                                    }
                                    catch { }
                                    try
                                    {
                                       
                                        PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/div[1]/div/div[2]/div[2]/div[1]/form/div/div[10]/div/input")).SendKeys(temp);
                                       
                                    }
                                    catch { }
                                    
                                   
                                }
                            }
                            //if (i == 6)
                            //{ Thread.Sleep(6000); }
                        }
                        #region // click xong
                        IJavaScriptExecutor js = (IJavaScriptExecutor)PropretiesCollection.driver;
                        js.ExecuteScript("window.scrollBy(0,450)", "");
                        int bienkiemtra = 0;
                        switch (bienkiemtra)
                        {
                            case 0:             // label case 1
                                System.Threading.Thread.Sleep(2500);
                                goto case 1;
                                break;
                            case 1:
                                try
                                {
                                    try
                                    {
                                        PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div[2]/div[2]/div[1]/form/div/div[29]/div/button")).Click();
                                    }
                                    catch
                                    {
                                        try
                                        {
                                            PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/div[1]/div/div[2]/div[2]/div[1]/form/div/div[29]/div/button")).Click();

                                        }
                                        catch
                                        {
                                            try { System.Windows.Forms.SendKeys.SendWait("^{ENTER}"); }
                                            catch { goto case 0; }
                                        }
                                    }

                                }
                                catch { goto case 0; }
                                break;
                        }
                        #endregion
                    }                    
                    catch {
                    }
                }
            });
            t.IsBackground = true;
            t.Start();
        }
        #endregion
    }
}
