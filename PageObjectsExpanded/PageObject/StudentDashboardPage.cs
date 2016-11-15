using OpenQA.Selenium;

namespace PageObjectsExpanded.PageObject
{
    public class StudentDashboardPage : BasePage
    {

        private IWebElement HtmlTag => Driver.FindElement(By.TagName("html"));

        public IWebElement ResumeUserInteractionsCourseButton => Driver.FindElement(
            By.XPath(
                "//*[@href='/courses/take/selenium-webdriver-user-interactions/downloads/361893-course-resources']"));

        public StudentDashboardPage(IWebDriver driver) : base(driver)
        {}

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