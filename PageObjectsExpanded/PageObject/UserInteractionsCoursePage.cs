using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObjectsExpanded.PageObject
{
    public class UserInteractionsCoursePage : BasePage
    {
        private By ExpandingElementLocator => By.Id("lesson-shelf-toggle");


        public UserInteractionsCoursePage(IWebDriver driver) : base(driver)
        {}

        
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