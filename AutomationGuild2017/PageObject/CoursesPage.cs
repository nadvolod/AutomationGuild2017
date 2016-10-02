using OpenQA.Selenium;

namespace AutomationGuild2017.PageObject
{
    public class CoursesPage
    {
        public IWebDriver Driver { get; }

        public IWebElement SignInLink { get { return Driver.FindElement(By.ClassName("my-account")); } }

        public CoursesPage(IWebDriver driver)
        {
            Driver = driver;
        }

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