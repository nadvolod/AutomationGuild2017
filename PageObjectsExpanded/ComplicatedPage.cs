using System;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
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

        public void Search(string searchString)
        {
            ObjectRepository.SearchBox.SendKeys(searchString);
            ObjectRepository.SearchButton.Click();
        }

        public void OpenToggle()
        {
            var actions = new Actions(Driver);
            actions.MoveToElement(ObjectRepository.PostsSlider).Perform();
            ObjectRepository.Toggle.Click();

            //var jse = (IJavaScriptExecutor)Driver;

            //jse.ExecuteScript("arguments[0].scrollIntoView()", ObjectRepository.Toggle);
            //actions.MoveToElement(ObjectRepository.Toggle).Click().Perform();
        }

        public bool IsToggleOpen()
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(ObjectRepository.ToggleInnerTextLocator));
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
    }
}