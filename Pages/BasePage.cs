using AutomationPracsDOTNETCORE.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracsDOTNETCORE.Pages
{
    public class BasePage : Driver
    {
        public string BASE_URL = "http://automationpractice.com/";

        public void LaunchSite()
        {
            _driver.Navigate().GoToUrl(BASE_URL);

        }

    }
}
