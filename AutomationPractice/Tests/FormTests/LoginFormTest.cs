using AutomationPractice.Factories;
using AutomationPractice.Pages.HomePage;
using AutomationPractice.Pages.LoginPage;
using AutomationPractice.Pages.SignInPage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomationPractice.Tests.FormTests
{
    public class LoginFormTest : BaseTest
    {
        private LoginFormModel _user;
        private SignInPage _signInPage;
        private HomePage _homePage;
        private LoginPage _loginPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Driver.Manage().Window.Maximize();
            _homePage = new HomePage(Driver);
            _homePage.SignInButtonClick();
            _signInPage = new SignInPage(Driver);
            _user = LoginFormFactory.Create();
        }

        [Test]
        public void EmailIsFilledCorrectly()
        {
            _signInPage.SignIn(_user);

            _loginPage = new LoginPage(Driver);
            _loginPage.WaitForLoad();
            Builder.DoubleClick(_loginPage.emailLabel).Perform();
            Builder.DoubleClick(_loginPage.email).Perform();
            

            _loginPage.AssertCorrectEmailAutoFill(_loginPage.email, _user.Email);
        }

        [Test]
        public void ErrorDisplayed_When_FillFormWithoutFirstName()
        {
            //Arange
            _signInPage.SignIn(_user);
            _loginPage = new LoginPage(Driver);         
            _user.FirstName = string.Empty;
            
            //Act
            _loginPage.FillForm(_user);
            _loginPage.registerButton.Click();

            //Assert            
            _loginPage.AssertFormWithEmptyField(_loginPage.errorMessage("firstname is required."));
        }

        [Test]
        public void ErrorDisplayed_When_FillFormWithoutLastName()
        {
            //Arange
            _signInPage.SignIn(_user);
            _loginPage = new LoginPage(Driver);         
            _user.LastName = string.Empty;

            //Act
            _loginPage.FillForm(_user);
            _loginPage.registerButton.Click();

            //Assert            
            _loginPage.AssertFormWithEmptyField(_loginPage.errorMessage("lastname is required."));
        }

        [Test]
        public void ErrorDisplayed_When_FillFormWithoutCity()
        {
            //Arange
            _signInPage.SignIn(_user);
            _loginPage = new LoginPage(Driver);            
            _user.City = string.Empty;

            //Act
            _loginPage.FillForm(_user);
            _loginPage.registerButton.Click();

            //Assert
            _loginPage.AssertFormWithEmptyField(_loginPage.errorMessage("city is required."));            
        }

        [Test]
        public void ErrorDisplayed_When_FillFormWithoutPhoneNumber()
        {
            //Arange
            _signInPage.SignIn(_user);
            _loginPage = new LoginPage(Driver);           
            _user.Phone = string.Empty;

            //Act
            _loginPage.FillForm(_user);
            _loginPage.registerButton.Click();

            //Assert           
            _loginPage.AssertFormWithEmptyField(_loginPage.errorMessage("You must register at least one phone number."));
        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
