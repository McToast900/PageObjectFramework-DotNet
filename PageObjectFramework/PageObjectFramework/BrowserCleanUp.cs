using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace PageObjectFramework
{
    [Binding]
    class BrowserCleanUp
    {
        private IWebDriver _driver;

        public BrowserCleanUp(IWebDriver driver)
        {
            _driver = driver;
        }

        [AfterScenario]
        public void CleanUp()
        {
            _driver.Close();
            _driver.Dispose();
        }
    }
}
