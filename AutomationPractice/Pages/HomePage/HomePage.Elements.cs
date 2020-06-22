using OpenQA.Selenium;

namespace AutomationPractice.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }      

        
        public IWebElement signInButon => Driver.FindElement(By.XPath("//*[@class = 'login']"));      

    }
}
