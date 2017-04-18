using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    static class SeleniumSetMethods
    {
        public static void EnterText(this IWebElement element, string value)
        {
            new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(element)).SendKeys(value);
        }

        public static void ClickButton(this IWebElement element)
        {
            new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30000)).Until(ExpectedConditions.ElementToBeClickable(element)).Click();
        }
    }
}
