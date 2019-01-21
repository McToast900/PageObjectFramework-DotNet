using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace PageObjectFramework
{
    [Parallelizable]
    [Binding]
    public class BrowserSetup
    {
        private readonly IObjectContainer _objectContainer;

        public BrowserSetup(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void DriverInitialise()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-notifications");
            options.AddArgument("--headless");

            var webDriver = new ChromeDriver(options);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            _objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);
        }
    }
}
