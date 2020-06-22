using DemoQA.Utilities.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftuniPage.Tests
{
    class Navigation : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://www.softuni.bg");
            Driver.Manage().Window.Maximize();
        }


        [Test]
        [TestCase("Обучения")]
        public void HeadingTagH1Exists(string sectionName)
        {            
            var learningsButton = Driver.FindElement(By.XPath($"//*[@class = 'nav-list horizontal-list']//*[normalize-space(text())='{sectionName}']"));
            learningsButton.Click();

            var activeCourseBtn = Driver.FindElement(By.XPath("//*[contains(text(),'Активни курсове')]"));
            activeCourseBtn.Click();

            var QAbutton = Driver.FindElement(By.XPath("//*[contains(text(),'QA Automation - май 2020')]"));
            Driver.ScrollTo(QAbutton);
            QAbutton.Click();

            var headingTag = Driver.FindElement(By.TagName("h1"));

            Assert.AreEqual("QA Automation - май 2020", headingTag.Text);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
