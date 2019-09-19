using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
namespace AutoWeb
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        ClassName,
        CssSelector
    }

    public class PropretiesCollection
    {
      
        public static IWebDriver driver { get; set; }
    }
}
