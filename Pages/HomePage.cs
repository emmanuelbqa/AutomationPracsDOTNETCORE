using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracsDOTNETCORE.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
          
        }


        IWebElement menuSignInButton => _driver.FindElement(By.ClassName("login"));



        public SignInPage ClickOnMenuSignInButton()
        {
            menuSignInButton.Click();
            return new SignInPage(_driver);
        }

    }
}

