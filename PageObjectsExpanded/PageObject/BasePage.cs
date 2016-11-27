using OpenQA.Selenium;

namespace PageObjectsExpanded.PageObject
{
    public class BasePage<TObjectRepository> where TObjectRepository : BasePageObjectRepository
    {
        public BasePage(IWebDriver driver, TObjectRepository repository)
        {
            Driver = driver;
            ObjectRepository = repository;
        }

        public IWebDriver Driver { get; }
        internal TObjectRepository ObjectRepository { get; }
    }
}