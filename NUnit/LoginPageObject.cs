﻿using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NUnit
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "btn_action_login")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "fn-user-name")]
        public IWebElement UserNameField { get; set; }

        public void Login(string userName)
        {
            LoginButton.ClickButton();
            UserNameField.EnterText(userName);

        }
    }
}
