using OpenQA.Selenium;
using PageObjectsExpanded.PageObject;

namespace PageObjectsExpanded
{
    public class ComplicatedPage : BasePage<ComplicatedPageObjectRepository>
    {
        public ComplicatedPage(IWebDriver driver) : base(driver, new ComplicatedPageObjectRepository(driver))
        {
        }

        public void GoTo()
        {
            Driver.Navigate().GoToUrl("http://www.ultimateqa.com/complicated-page/");
        }

        public bool IsAt()
        {
            return Driver.Url.Contains("complicated-page");
        }

        public void ClickFirstTwitterButton()
        {
            ObjectRepository.FirstTwitterButton.Click();
        }
    }
}