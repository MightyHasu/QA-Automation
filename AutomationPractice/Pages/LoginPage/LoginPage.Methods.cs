using AutomationPractice.Factories;
using OpenQA.Selenium.Support.UI;


namespace AutomationPractice.Pages.LoginPage
{
    public partial class LoginPage : BasePage
    {
        public void FillForm(LoginFormModel user)
        {
            gender.Click();  
            firstName.SendKeys(user.FirstName);
            lastName.SendKeys(user.LastName);
            password.SendKeys(user.Password);
            drpDate.SelectByValue(user.Date);            
            drpMonth.SelectByValue(user.Month);
            drpYear.SelectByValue(user.Year);
            realFirstName.SendKeys(user.RealFirstName);
            realLastName.SendKeys(user.RealLastName);
            address.SendKeys(user.Address);
            city.SendKeys(user.City);           
            SelectElement state = new SelectElement(stateDD);
            state.SelectByText(user.State);
            postcode.SendKeys(user.PostCode);
            phone.SendKeys(user.Phone);
            alias.SendKeys(user.Alias);
            ScrollTo(registerButton).Click();
        }
    }
}
