using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DemoQA
{
    public static class ElementExtensions
    {
        public static void WaitForElementToChange(this IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

        }
    }
}
