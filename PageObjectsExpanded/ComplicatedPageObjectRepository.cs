using OpenQA.Selenium;
using PageObjectsExpanded.PageObject;

namespace PageObjectsExpanded
{
    public class ComplicatedPageObjectRepository : BasePageObjectRepository
    {
        public ComplicatedPageObjectRepository(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement FirstTwitterButton => Driver.FindElements(By.XPath("//*[@title='Twitter']"))[0];
    }
}