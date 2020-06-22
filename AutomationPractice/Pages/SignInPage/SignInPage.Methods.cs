using AutomationPractice.Factories;
using AutomationPractice.Models;

namespace AutomationPractice.Pages.SignInPage
{
    public partial class SignInPage : BasePage
    {
       
        public void SignIn(LoginFormModel user)
        {
           
            emailTextField.SendKeys(user.Email);

            createAccountButton.Click();
        }
    }    
}
