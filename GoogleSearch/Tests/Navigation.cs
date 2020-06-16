using DemoQA.Utilities.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleSearch
{
    public class NavigationToPages : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://www.google.com");
        }

        [Test]
        [TestCase("selenium")]        
        public void CheckResult_When_SeleniumIsSearched(string sectionName)
        {
            var searchTextField = Driver.FindElement(By.XPath("//*[@class = 'gLFyf gsfi']"));
            searchTextField.SendKeys(sectionName);
            searchTextField.SendKeys(Keys.Enter);            

            var resultList = Driver.FindElements(By.XPath("//*[@class = 'LC20lb DKV0Md']"));
            resultList[0].Click();

            string currentUrl = Driver.Url;
            Assert.AreEqual("https://www.selenium.dev/", currentUrl);

            string actualTitle = Driver.Title;
            Assert.AreEqual("SeleniumHQ Browser Automation", actualTitle);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
