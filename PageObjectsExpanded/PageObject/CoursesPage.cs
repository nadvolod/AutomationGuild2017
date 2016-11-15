using OpenQA.Selenium;

namespace PageObjectsExpanded.PageObject
{
    public class CoursesPage : BasePage
    {
        public IWebElement SignInLink => Driver.FindElement(By.ClassName("my-account"));

        public CoursesPage(IWebDriver driver) : base(driver)
        {}

        public void GoTo()
        {
            Driver.Navigate().GoToUrl("http://courses.ultimateqa.com/");
        }

        public StudentLoginPage ClickSignInLink()
        {
            SignInLink.Click();
            return new StudentLoginPage(Driver);
        }
    }
}