using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracsDOTNETCORE.Pages
{
    public class SignInPage : BasePage
    {
        public SignInPage(IWebDriver driver)
        {
            _driver = driver;
        }


        IWebElement menuSignInButton => _driver.FindElement(By.Id("SubmitLogin"));

        IWebElement emailTextBox => _driver.FindElement(By.Id("email"));

        IWebElement passwordBox => _driver.FindElement(By.Id("passwd"));

        IWebElement errorAlert => _driver.FindElement(By.XPath("//div[@class='alert alert-danger']/ol/li"));

       

        public void EnterEmail(string email)
        {
            emailTextBox.Clear();
            emailTextBox.SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            passwordBox.Clear();
            passwordBox.SendKeys(password);
        }


        public void AssertErrorMesage(string error)
        {
            var errorMessage = errorAlert.Text;
            Assert.IsTrue(errorMessage.Contains(error));
            
        }

        public void ClickSignInButton()
        {
            menuSignInButton.Click();
        }
    }
}

