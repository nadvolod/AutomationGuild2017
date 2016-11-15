using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationGuild2017.PageObject
{
    public class UserInteractionsCoursePage
    {
        public IWebDriver Driver { get; }
        private By ExpandingElementLocator { get { return By.Id("lesson-shelf-toggle"); } }


        public UserInteractionsCoursePage(IWebDriver driver)
        {
            Driver = driver;
        }

        
        public bool? IsAt()
        {
            try
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
                wait.Until(ExpectedConditions.ElementIsVisible(ExpandingElementLocator));
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
            return true;
        }

    }
}