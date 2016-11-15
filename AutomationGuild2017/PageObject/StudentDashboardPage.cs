using OpenQA.Selenium;

namespace AutomationGuild2017.PageObject
{
    public class StudentDashboardPage
    {
        public IWebDriver Driver { get;  }

        private IWebElement HtmlTag { get { return Driver.FindElement(By.TagName("html")); } }
        public IWebElement ResumeUserInteractionsCourseButton
        {
            get
            {
                return
                    Driver.FindElement(
                        By.XPath(
                            "//*[@href='/courses/take/selenium-webdriver-user-interactions/downloads/361893-course-resources']"));
            }
        }

        public StudentDashboardPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool? IsAt()
        {
            return HtmlTag.Text.Contains("Your Student Dashboard");
        }

        public UserInteractionsCoursePage ResumeUserInteractionsCourse()
        {
            ResumeUserInteractionsCourseButton.Click();
            return new UserInteractionsCoursePage(Driver);
        }
    }
}