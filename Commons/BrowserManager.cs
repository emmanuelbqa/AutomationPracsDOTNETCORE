using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace AutomationPracsDOTNETCORE.Commons
{
    public class BrowserManager : Driver
    {
        private IWebDriver initChrome()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver();
        }

        private IWebDriver initFirefox()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            return new FirefoxDriver();
        }

        private IWebDriver initHeadless()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-gpu", "--headless");
            return new ChromeDriver(options);
        }


        public void LaunchBrowser(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    _driver = initChrome();
                    break;
                case "Headless":
                    _driver = initHeadless();
                    break;
                case "Firefox":
                    _driver = initFirefox();
                    break;
                default:
                    _driver = initChrome();
                    break;
            }

            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

        }

        public void CloseBrowser()
        {
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Quit();
        }
    }
}


