using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace PageObjectFramework.Step_Definitions
{
    [Parallelizable]
    [Binding]
    class SearchSteps
    {
        private IWebDriver _driver;

        public SearchSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"The user visits google")]
        public void GivenTheUserVisitsGoogle()
        {
            _driver.Navigate().GoToUrl("https://www.google.com");
        }

        [When(@"The user searches for (.*)")]
        public void WhenTheUserSearchesFor(string term)
        {
            var searchBox = _driver.FindElement(By.CssSelector("input[title='Search']"));
            searchBox.SendKeys(term);
            searchBox.SendKeys(Keys.Return);
        }

        [Then(@"They see at least one (.*) in the results")]
        public void ThenTheySeeAtLeastOneInTheResults(string term)
        {
            Assert.That(_driver.FindElements(By.XPath($"//*[contains(text(), '{term}')]")).Count > 0);
        }


    }
}
