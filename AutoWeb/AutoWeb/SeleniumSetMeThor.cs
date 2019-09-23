using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace AutoWeb
{
    class SeleniumSetMeThor
    {
        public static void EnterText(IWebElement element, string values)
        {

           element.SendKeys(values);           
        }
       
        public static void Click(IWebElement element)
        {
           element.Click();           
        }

        public static void SelectDropDown(IWebElement element, string values)
        {
           new SelectElement(element).SelectByText(values);           
        }
        public static void SelectDropDownVaules(IWebElement element, string values)
        {
            new SelectElement(element).SelectByValue(values);
        }
    }
}
