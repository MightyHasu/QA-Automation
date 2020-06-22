using NUnit.Framework;
using OpenQA.Selenium;


namespace AutomationPractice.Pages.LoginPage
{
    public partial class LoginPage : BasePage
    {
        public void AssertCorrectEmailAutoFill(IWebElement element, string email)
        {
            this.WaitForLoad();            
            Assert.AreEqual(email, element.GetAttribute("value"));
        }

        public void AssertFormWithEmptyField(IWebElement element)
        {
            this.WaitForLoad();
            Assert.IsNotNull(element);
        }
    }
}
