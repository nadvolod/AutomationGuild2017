using OpenQA.Selenium;

namespace PageObjectsExpanded.PageObject
{
    public class BasePageObjectRepository
    {
        protected readonly IWebDriver Driver;

        public BasePageObjectRepository(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}