using OpenQA.Selenium;

namespace PageObjectFramework.Elements
{
    public abstract class PageObject
    {
        protected IWebDriver Driver;

        public PageObject(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
