using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObjectsExpanded.PageObject
{
    public class UserInteractionsCoursePage : BasePage<UserInteractionsCoursePageObjectRepository>
    {

        public UserInteractionsCoursePage(IWebDriver driver) : base(driver, new UserInteractionsCoursePageObjectRepository(driver))
        { }


        public bool? IsAt()
        {
            try
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(ObjectRepository.ExpandingElementLocator));
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
            return true;
        }

    }
}