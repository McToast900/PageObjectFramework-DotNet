using NUnit.Framework;
using OpenQA.Selenium;
using PageObjectFramework.Elements;
using TechTalk.SpecFlow;

namespace PageObjectFramework.Step_Definitions
{
    [Parallelizable]
    [Binding]
    class SearchSteps
    {
        private IWebDriver _driver;
        private SearchElements _searchElements;

        public SearchSteps(IWebDriver driver)
        {
            _driver = driver;
            _searchElements = new SearchElements(_driver);
        }

        [Given(@"The user visits google")]
        public void GivenTheUserVisitsGoogle()
        {
            _driver.Navigate().GoToUrl("https://www.google.com");
        }

        [When(@"The user searches for (.*)")]
        public void WhenTheUserSearchesFor(string term)
        {
            _searchElements.SearchBox.SendKeys(term);
            _searchElements.SearchBox.SendKeys(Keys.Return);
        }

        [Then(@"They see at least one (.*) in the results")]
        public void ThenTheySeeAtLeastOneInTheResults(string term)
        {
            Assert.That(_driver.FindElements(By.XPath($"//*[contains(text(), '{term}')]")).Count > 0);
        }


    }
}
