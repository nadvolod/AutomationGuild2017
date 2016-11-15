using OpenQA.Selenium;

namespace PageObjectsExpanded.PageObject
{
    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; set; }

    }
}