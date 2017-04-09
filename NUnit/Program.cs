using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            PropertiesCollection.driver.Manage().Window.Maximize();
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.galacasino.com/");

            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            LoginPageObject pageLogin = new LoginPageObject();
            pageLogin.Login("in2906161");

            Console.WriteLine("Executed tests");
        }

        [TearDown]
        public void CleanUp()
        {
            Console.ReadLine();
            //PropertiesCollection.driver.Close();

            Console.WriteLine("Closed the browser");
        }
    }
}
