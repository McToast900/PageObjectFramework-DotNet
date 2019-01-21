using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace PageObjectFramework.Step_Definitions
{
    [Parallelizable]
    [Binding]
    class GitHubSteps
    {
        private IWebDriver _driver;

        public GitHubSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"The user navigates to the github page for this repository")]
        public void WhenTheUserNavigatesToTheGithubPageForThisRepository()
        {
            _driver.Navigate().GoToUrl("https://github.com/McToast900/PageObjectFramework-DotNet");
        }

        [Then(@"The user can see a description of this repo in the README file")]
        public void ThenTheUserCanSeeADescriptionOfThisRepoInTheREADMEFile()
        {
            var description = "This is a readme for this test harness.";

            Assert.That(_driver.FindElement(By.XPath($"//*[contains(text(), '{description}')]")).Displayed);
        }


    }
}
