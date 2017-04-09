using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    class SeleniumSetMethods
    {
        public static void EnterText(IWebElement element, string value)
        {
            new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(element)).SendKeys(value);
        }

        public static void Click(IWebElement element)
        {
            new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(element)).Click();
        }
    }
}
