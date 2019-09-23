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
    public class ChatLuong
    {
        public ChatLuong()
        {
            PageFactory.InitElements(PropretiesCollection.driver, this);
        }
        
        #region // thong tin phat
        [FindsBy(How = How.Id, Using = "UserName")]
        public IWebElement m_UserName;
        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement m_PasswordPhat;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div/div/div/div/ul/li[7]/a")]
        public IWebElement m_menu;
        [FindsBy(How = How.XPath, Using ="/html/body/div/div/div/div/div/div/div/ul/li[7]/ul/li[2]/a")]
        public IWebElement m_menuquanly;
        [FindsBy(How = How.Id, Using = "StartDate")]
        public IWebElement m_TuNgay;
        [FindsBy(How = How.Id, Using = "EndDate")]
        public IWebElement m_DenNgay;

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div/div/div[2]/div/div[5]/div/div[4]/span/span/span/span")]
        public IWebElement m_loaibuugui;
        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div/ul/li[2]")]
        public IWebElement m_tatcacod;
         [FindsBy(How = How.XPath, Using ="/html/body/div[6]/div/ul/li[3]")]
        public IWebElement m_tatcaKcod;


        [FindsBy(How = How.XPath, Using = "//*[@id='btnSearch_Bieu11V2']/i")]
        public IWebElement m_TimKiemPhat;

        [FindsBy(How = How.Id, Using = "btnExportClcdPhat2")]
        public IWebElement m_XuanExcel;


        public void XuLy(string taikhoan, string matkhau, string tungay, string denngay,int loaibuugui)
        {
            m_UserName.Clear();
            m_UserName.SendKeys(taikhoan);
            Thread.Sleep(1000);
            m_PasswordPhat.Clear();
            m_PasswordPhat.SendKeys(matkhau + OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(1000);
            m_menu.Click();
            Thread.Sleep(1000);
            m_menuquanly.Click();
            Thread.Sleep(1000);
            m_TuNgay.Clear();
            m_TuNgay.SendKeys(tungay);
            Thread.Sleep(1000);
            m_DenNgay.Clear();
            m_DenNgay.SendKeys(denngay);
            Thread.Sleep(1000);
            m_loaibuugui.Click();
            Thread.Sleep(1000);
            if (loaibuugui == 0)
            {
                m_tatcacod.Click();
            }
            else if (loaibuugui == 1)
            {
                m_tatcaKcod.Click();
            }
            Thread.Sleep(1000);
            m_TimKiemPhat.Click();
            int kiemtra = 0;
            switch (kiemtra)
            {
                case 0:            
                    System.Threading.Thread.Sleep(15000);
                    goto case 1;
                    break;
                case 1:
                    try
                    {
                            m_XuanExcel.Click();  
                    }
                    catch { goto case 0; }
                    break;

            }
            System.Threading.Thread.Sleep(15000);
        }
     
        #endregion
    }
}
