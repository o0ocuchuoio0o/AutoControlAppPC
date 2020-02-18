using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace testweb
{
    class SeleniumGetMeThor
    {
        public static string GetText(IWebElement element)
        {           
          return element.GetAttribute("value");           
        }
        public static string GetText2(IWebElement element)
        {
            return element.GetAttribute("innerHTML");
        }
        public static string GetTextLink(IWebElement element)
        {
            return element.GetAttribute("src");
        }
        public static string GetTextFromDOL(IWebElement element)
        {
          
          return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
           
        }

    }
}
