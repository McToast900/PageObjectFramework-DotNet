using OpenQA.Selenium;

namespace PageObjectFramework.Elements
{
    public class SearchElements : PageObject
    {
        public SearchElements(IWebDriver driver) : base(driver) { }

        public IWebElement SearchBox { get => Driver.FindElement(By.CssSelector("input[title='Search']")); }
    }
}
