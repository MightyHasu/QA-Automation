using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Pages.LoginPage
{
    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        { }        

        public IWebElement gender => Driver.FindElement(By.XPath("//*[@id= 'id_gender1']"));        

        public IWebElement firstName => Driver.FindElement(By.Id("customer_firstname"));

        public IWebElement lastName => Driver.FindElement(By.Id("customer_lastname"));

        public IWebElement email => Driver.FindElement(By.XPath("//*[@id = 'email']"));        

        public IWebElement password => Driver.FindElement(By.Id("passwd"));

        public SelectElement drpDate => new SelectElement(Driver.FindElement(By.Id("days")));

        public SelectElement drpMonth => new SelectElement(Driver.FindElement(By.Id("months")));

        public SelectElement drpYear => new SelectElement(Driver.FindElement(By.Id("years")));

        public IWebElement realFirstName => Driver.FindElement(By.Id("firstname"));

        public IWebElement realLastName => Driver.FindElement(By.Id("lastname"));

        public IWebElement address => Driver.FindElement(By.Id("address1"));

        public IWebElement city => Driver.FindElement(By.Id("city"));

        public IWebElement stateDD => Driver.FindElement(By.Id("id_state"));        

        public IWebElement postcode => Driver.FindElement(By.Id("postcode"));

        public IWebElement phone => Driver.FindElement(By.Id("phone_mobile"));

        public IWebElement alias => Driver.FindElement(By.Id("alias"));

        public IWebElement registerButton => Driver.FindElement(By.Id("submitAccount"));

        public IWebElement emailLabel => Driver.FindElement(By.XPath("//*[@for='email']"));        

        public IWebElement errorMessage (string labelText)=> Driver.FindElement(By.XPath($"//*[@class = 'alert alert-danger']//li[contains(.,'{labelText}')]"));
        
    }
}
