using DemoQA.Models;
using OpenQA.Selenium;

namespace DemoQA.Pages.PracticeForm
{
    public partial class PracticeFormPage : BasePage
    {
        public PracticeFormPage(IWebDriver driver) 
            : base(driver)
        {
        }

        public void FillForm(PracticeFormModel user)
        {
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Email.SendKeys(user.Email);
            Gender(user.Gender).Click();
            PhoneNumber.SendKeys(user.PhoneNumber);
            SportsCheckBox.Click();

            ScrollTo(Submit).Click();
        }
    }
}
