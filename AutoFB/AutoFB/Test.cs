using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Threading;

namespace AutoFB
{
    public class Test
    {
        public Test()
        {
            PageFactory.InitElements(PropretiesCollection.driver, this);
        }

        #region // cac bien dang ky
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div[1]/div/div/div/div/div[2]/div/div/div[1]/form/div[5]/a")]
        public IWebElement m_TaoMoi;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div[1]/div/div/div/div/div[2]/div/div[2]/div/div/div/div[1]/form/div[1]/div[1]/div[1]/div[1]/div/div[1]/input")]
        public IWebElement m_Ho;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div[1]/div/div/div/div/div[2]/div/div[2]/div/div/div/div[1]/form/div[1]/div[1]/div[1]/div[2]/div/div[1]/input")]
        public IWebElement m_Ten;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div[1]/div/div/div/div/div[2]/div/div[2]/div/div/div/div[1]/form/div[1]/div[2]/div/div[1]/input")]
        public IWebElement m_Mail;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div[1]/div/div/div/div/div[2]/div/div[2]/div/div/div/div[1]/form/div[1]/div[3]/div/div/div[1]/input")]
        public IWebElement m_MailNhapLai;
        


        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div[1]/div/div/div/div/div[2]/div/div[2]/div/div/div/div[1]/form/div[1]/div[4]/div/div[1]/input")]
        public IWebElement m_Pass;
        [FindsBy(How = How.Id, Using = "day")]
        public IWebElement m_Ngay;
        [FindsBy(How = How.Id, Using = "month")]
        public IWebElement m_Thang;
        [FindsBy(How = How.Id, Using = "year")]
        public IWebElement m_Nam;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div[1]/div/div/div/div/div[2]/div/div[2]/div/div/div/div[1]/form/div[1]/div[6]/span/span[1]/input")]
        public IWebElement m_PhuNu;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div[1]/div/div/div/div/div[2]/div/div[2]/div/div/div/div[1]/form/div[1]/div[6]/span/span[2]/input")]
        public IWebElement m_DanOng;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div[1]/div/div/div/div/div[2]/div/div[2]/div/div/div/div[1]/form/div[1]/div[9]/button")]
        public IWebElement m_DangKy;
        #endregion

        public void DangKy(string Ho,string Ten,string Mail,string Pass)
        {
            Thread.Sleep(2000);
            try { m_TaoMoi.Click(); }
            catch { }
            Thread.Sleep(2000);
            m_Ho.Clear();
            m_Ho.SendKeys(Ho);
            Thread.Sleep(1000);
            m_Ten.Clear();
            m_Ten.SendKeys(Ten);
            Thread.Sleep(1000);
            m_Mail.Clear();
            m_Mail.SendKeys(Mail);
            Thread.Sleep(1000);
            m_MailNhapLai.Clear();
            m_MailNhapLai.SendKeys(Mail);
            Thread.Sleep(1000);
            m_Pass.Clear();
            m_Pass.SendKeys(Pass);
            Thread.Sleep(1000);
            Random randomngay = new Random();
            int ngay = randomngay.Next(1, 30);
            SeleniumSetMeThor.SelectDropDownVaules(m_Ngay,ngay.ToString());
            Thread.Sleep(1000);
            Random randomthang = new Random();
            int thang = randomthang.Next(1, 12);
            SeleniumSetMeThor.SelectDropDownVaules(m_Thang, thang.ToString());
            Thread.Sleep(1000);
            Random randomnam = new Random();
            int nam = randomnam.Next(1980, 1995);
            SeleniumSetMeThor.SelectDropDownVaules(m_Nam, nam.ToString());
            Thread.Sleep(1000);
            Random randomgioitinh = new Random();
            int gioitinh = randomgioitinh.Next(1, 2);
            if (gioitinh == 1)
            {
                m_PhuNu.Click();
            }
            else {
                m_DanOng.Click();
            }
            Thread.Sleep(1000);
            m_DangKy.Click();
        }




        #region // tao page 

        #endregion

    }
}
