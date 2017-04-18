using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

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
            ExcelLib.PopulateInCollection(@"C:\Users\Tzahi.Ben\Documents\NUnit\Data.xlsx");
            LoginPageObject pageLogin = new LoginPageObject();
            pageLogin.Login(ExcelLib.ReadData(1, "userName"));

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
