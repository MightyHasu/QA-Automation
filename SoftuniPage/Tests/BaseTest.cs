using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.IO;
using System.Reflection;

namespace SoftuniPage
{
    public class BaseTest
    {
        public IWebDriver Driver { get; set; }

        public Actions Builder { get; set; }

        public void Initialize()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Builder = new Actions(Driver);
            Driver.Manage().Window.Maximize();
        }
    }
}
