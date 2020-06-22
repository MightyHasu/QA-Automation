using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages.SignInPage
{
    public partial class SignInPage : BasePage
    {
        public SignInPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement emailTextField => Driver.FindElement(By.XPath("//*[@name= 'email_create']"));

        public IWebElement createAccountButton => Driver.FindElement(By.Id("SubmitCreate"));        
    }
}
