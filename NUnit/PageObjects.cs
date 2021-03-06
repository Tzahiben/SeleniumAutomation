﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    class PageObjects
    {
        public PageObjects()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "btn_action_login")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "fn-user-name")]
        public IWebElement UserNameField { get; set; }
    }
}
