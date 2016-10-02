using OpenQA.Selenium;

namespace AutomationGuild2017.PageObject
{
    public class StudentDashboardPage
    {
        public IWebDriver Driver { get;  }

        private IWebElement HtmlTag { get { return Driver.FindElement(By.TagName("html")); } }

        public StudentDashboardPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool? IsAt()
        {
            return HtmlTag.Text.Contains("Your Student Dashboard");
        }
    }
}