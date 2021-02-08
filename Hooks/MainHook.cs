using AutomationPracsDOTNETCORE.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AutomationPracsDOTNETCORE.Hooks
{
    [Binding]
    public sealed class MainHook : BrowserManager
    {


        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("Chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseBrowser();
        }
    }
}
