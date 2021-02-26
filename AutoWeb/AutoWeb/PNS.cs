using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions.Internal;
using System.Collections.ObjectModel;
using System.Data;

namespace AutoWeb
{
    public class PNS
    {
        public PNS()
        {
            PageFactory.InitElements(PropretiesCollection.driver, this);
        }
        #region // thong tin phat
        [FindsBy(How = How.Id, Using = "userid")]
        public IWebElement m_UserName;
        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement m_PasswordPhat;
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div/div/form/fieldset/div[2]/div/div[7]/button")]
        public IWebElement m_login;

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div[1]/div[1]/div/div/div[2]/div")]
        public IWebElement m_thugom;

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div[1]/div[1]/div/div/div[2]/nav/ul/li[6]/a/span")]
        public IWebElement m_thugomtudong;

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div[1]/div[2]/div/div/div[1]/div/div/form/div[1]/div[1]/div/span/span[1]/span/span[2]")]
        public IWebElement m_timkiemtrungtam;
        [FindsBy(How = How.Id, Using = "txtPODistrictCode")]
        public IWebElement cmbtimkiemtrungtam;
        



        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div[1]/div[2]/div/div/div[2]/div/button")]
        public IWebElement m_themtudong;

        [FindsBy(How = How.Id, Using = "CustomerCode")]
        public IWebElement m_txtCustomerCode;
        [FindsBy(How = How.Id, Using = "SenderPhone")]
        public IWebElement m_txtSenderPhone;
                                          
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div[1]/div[2]/div/div/div[4]/div/div/div/div[2]/form/div[3]/div/div/span/span[1]/span/span[2]")]
        public IWebElement m_cmbtrungtam;
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div[1]/div[2]/div/div/div[3]/div[2]/div/div/div/div[2]/form/div[3]/div/div/span/span[1]/span/span[2]")]
        public IWebElement m_cmbtrungtam1;
        [FindsBy(How = How.Id, Using = "PODistrictPickupCode")]
        public IWebElement cmbtrungtam;
                                           
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div[1]/div[2]/div/div/div[4]/div/div/div/div[2]/form/div[4]/div/div/span/span[1]/span/span[2]")]
        public IWebElement m_cmbbuucuc;
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div[1]/div[2]/div/div/div[3]/div[2]/div/div/div/div[2]/form/div[4]/div/div/span/span[1]/span/span[2]/b")]
        public IWebElement m_cmbbuucuc1;

        [FindsBy(How = How.Id, Using = "POPickupCode")]
        public IWebElement cmbbuucuc;

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div[1]/div[2]/div/div/div[4]/div/div/div/div[3]/button[1]")]
        public IWebElement btnthemtuyen;
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div[1]/div[2]/div/div/div[3]/div[2]/div/div/div/div[3]/button[1]")]
        public IWebElement btnthemtuyen1;
        

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div[7]/div/div/div/div[2]")]
        public IWebElement txtketqua;
        
        #endregion
        public void login(string taikhoan, string matkhau)
        {
            m_UserName.Clear();
            m_UserName.SendKeys(taikhoan);
            Thread.Sleep(1000);
            m_PasswordPhat.Clear();
            m_PasswordPhat.SendKeys(matkhau + OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(1000);           
            m_thugom.Click();
            Thread.Sleep(1000);
            m_thugomtudong.Click();
            Thread.Sleep(5000);
           
            m_timkiemtrungtam.Click();
            Thread.Sleep(1000);
            SeleniumSetMeThor.SelectDropDownVaules(cmbtimkiemtrungtam, "1580");
            Thread.Sleep(1000);
            m_timkiemtrungtam.Click();
            Thread.Sleep(1000);
        }

        public int GanTuDong(string CustomerCode, string SenderPhone, string trungtam, string buucuc)
        {
            int kq = 0;
            Thread.Sleep(5000);
         
            m_themtudong.Click();
           // PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div/div[2]/div/button")).Click();
            Thread.Sleep(10000);
            DefaultWait<IWebDriver> flusername = new DefaultWait<IWebDriver>(PropretiesCollection.driver);
            flusername.Timeout = TimeSpan.FromSeconds(10);
            flusername.PollingInterval = TimeSpan.FromMilliseconds(250);
            flusername.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement searchusername = flusername.Until(x => x.FindElement(By.Id("CustomerCode")));
            if (searchusername!=null)
            {
            m_txtCustomerCode.Clear();
            m_txtCustomerCode.SendKeys(CustomerCode);
            Thread.Sleep(1000);
            m_txtSenderPhone.Clear();
            m_txtSenderPhone.SendKeys(SenderPhone);
            Thread.Sleep(3000);
            try { m_cmbtrungtam.Click(); }
            catch { }
            try { m_cmbtrungtam1.Click(); }
            catch { }
            Thread.Sleep(1000);
            SeleniumSetMeThor.SelectDropDownVaules(cmbtrungtam,trungtam);
            Thread.Sleep(1000);
            try { m_cmbtrungtam.Click(); }
            catch { }
            try { m_cmbtrungtam1.Click(); }
            catch { }
            Thread.Sleep(1000);
            try
            {
                m_cmbbuucuc.Click();
            }
            catch { }
            try
            {
                m_cmbbuucuc1.Click();
            }
            catch { }
            Thread.Sleep(2000);
            SeleniumSetMeThor.SelectDropDownVaules(cmbbuucuc, buucuc);
            Thread.Sleep(1000);
            try
            {
                m_cmbbuucuc.Click();
            }
            catch { }
            try
            {
                m_cmbbuucuc1.Click();
            }
            catch { }
            Thread.Sleep(1000);
            try
            {
                btnthemtuyen.Click();
            }
            catch { }
            try
            {
                btnthemtuyen1.Click();
            }
            catch { }
            Thread.Sleep(1000);
            switch (kq)
            {
                case 0:
                    System.Threading.Thread.Sleep(3000);
                    goto case 1;
                    break;
                case 1:
                    try
                    {
                        string thongbao = SeleniumGetMeThor.GetText2(txtketqua);
                        if (thongbao == "Cập nhật dữ liệu thành công")
                        {
                            kq = 1; 
                        
                        }
                        else if (thongbao.IndexOf("đã được thiết lập")!=-1)
                        {
                            kq = 1;
                            try
                            {
                                PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[4]/div[7]/div/div/div/div[3]/button")).Click();
                            }
                            catch { }
                            Thread.Sleep(1000);
                            try
                            {                                                                                
                                PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div/div[4]/div/div/div/div[3]/button[2]")).Click();
                            }
                            catch { }
                            Thread.Sleep(1000);
                            try
                            {
                                PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div/div[3]/div[2]/div/div/div/div[3]/button[2]")).Click();
                            }
                            catch { }
                            
                        }
                        else {
                            goto case 0;
                        }
                    }
                    catch { goto case 0; }
                    break;

            }
            Thread.Sleep(4000);
            try
            {
                PropretiesCollection.driver.SwitchTo().ActiveElement().FindElement(By.XPath("/html/body/div[4]/div[7]/div/div/div/div[3]/button")).Click();
            }
            catch { }
                
            }
            return kq;
        }
    }
}
