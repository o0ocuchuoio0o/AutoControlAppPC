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
    public class ThongTinPhat
    {
        public ThongTinPhat()
        {
            PageFactory.InitElements(PropretiesCollection.driver, this);
        }

        #region // thong tin phat
        [FindsBy(How = How.Id, Using = "UserName")]
        public IWebElement m_UserName;
        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement m_PasswordPhat;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div/div/div/div/ul/li/div/i")]
        public IWebElement m_menu;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div/div/div/div/ul/li[3]/ul/li[6]/a")]
        public IWebElement m_menuquanlySMP;
        [FindsBy(How = How.Id, Using = "StartDate")]
        public IWebElement m_TuNgay;
        [FindsBy(How = How.Id, Using = "EndDate")]
        public IWebElement m_DenNgay;
        [FindsBy(How = How.XPath, Using = "//*[@name='SyncPost_input']")]
        public IWebElement m_MaBuuCuc;

        [FindsBy(How = How.XPath, Using = "//*[@id='btnSearch']/i")]
        public IWebElement m_TimKiemPhat;
       
        public void login(string taikhoan,string matkhau,string tungay,string denngay)
        {
            m_UserName.Clear();
            m_UserName.SendKeys(taikhoan);
            Thread.Sleep(1000);
            m_PasswordPhat.Clear();
            m_PasswordPhat.SendKeys(matkhau+ OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(1000);
            m_menu.Click();
            Thread.Sleep(1000);
            m_menuquanlySMP.Click();
            Thread.Sleep(1000);
            m_TuNgay.Clear();
            m_TuNgay.SendKeys(tungay);
            Thread.Sleep(1000);
            m_DenNgay.Clear();
            m_DenNgay.SendKeys(denngay);
            Thread.Sleep(1000);
        }
        public DataTable ThongTin(string mabuucuc,int timernghi)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(string));
            dt.Columns.Add("TenBuuTa", typeof(string));
            dt.Columns.Add("SoDienThoai", typeof(string));
            dt.Columns.Add("MabuuCuc", typeof(string));
            dt.Columns.Add("TenBuuCuc", typeof(string));
            dt.Columns.Add("TenTuyenPhat", typeof(string));
            dt.Columns.Add("SLGiaoBuuTa", typeof(string));
            dt.Columns.Add("ThanhCong", typeof(string));
            dt.Columns.Add("KhongThanhCong", typeof(string));
            m_MaBuuCuc.Clear();
            try
            {
                m_MaBuuCuc.SendKeys(mabuucuc + OpenQA.Selenium.Keys.Enter);
            }
            catch { }
            Thread.Sleep(3000);
            try
            {
                m_TimKiemPhat.Click();
            }
            catch { }
            Thread.Sleep(timernghi);
            try
            {
                List<IWebElement> table = PropretiesCollection.driver.FindElements(By.XPath("//*[@class='k-selectable']/tbody/tr")).ToList();
                foreach (IWebElement field in table)
                {

                    string I_tenbuuta = "";
                    string I_sodienthoai = "";
                    string I_mabuucuc = "";
                    string I_tenbuucuc = "";
                    string I_tentuyenphat = "";
                    string I_SLgiaobuuta = "0";
                    string I_ThanhCong = "0";
                    string I_KhongThanhCong = "0";
                    List<IWebElement> listcot = field.FindElements(By.TagName("td")).ToList();
                    int _count = listcot.Count;
                    int i = 0;
                    foreach (IWebElement cot in listcot)
                    {
                        if (i == 0)
                        {
                            I_tenbuuta = cot.Text;//GetAttribute("text");
                        }
                        if (i == 1)
                        {
                            I_sodienthoai = cot.Text;
                        }
                        if (i == 2)
                        {
                            I_mabuucuc = cot.Text;
                        }
                        if (i == 3)
                        {
                            I_tenbuucuc = cot.Text;
                        }
                        if (i == 4)
                        {
                            I_tentuyenphat = cot.Text;
                        }
                        if (i == 5)
                        {
                            I_SLgiaobuuta = cot.Text.Replace(",", "").Replace(".", "");
                        }
                        if (i == 6)
                        {
                            I_ThanhCong = cot.Text.Replace(",", "").Replace(".", "");
                        }
                        if (i == 7)
                        {
                            I_KhongThanhCong = cot.Text.Replace(",", "").Replace(".", "");
                        }
                        i++;
                    }
                    dt.Rows.Add("0", I_tenbuuta, I_sodienthoai, I_mabuucuc, I_tenbuucuc, I_tentuyenphat, I_SLgiaobuuta, I_ThanhCong, I_KhongThanhCong);
                }
            }
            catch { }
            return dt;
        }
        #endregion
    }
}
