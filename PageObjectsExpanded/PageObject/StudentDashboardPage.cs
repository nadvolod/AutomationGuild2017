using OpenQA.Selenium;

namespace PageObjectsExpanded.PageObject
{
    public class StudentDashboardPage : BasePage<StudentDashboardPageObjectRepository>
    {


        public StudentDashboardPage(IWebDriver driver) : base(driver, new StudentDashboardPageObjectRepository(driver))
        { }

        public bool? IsAt()
        {
            return ObjectRepository.HtmlTag.Text.Contains("Your Student Dashboard");
        }

        public UserInteractionsCoursePage ResumeUserInteractionsCourse()
        {
            ObjectRepository.ResumeUserInteractionsCourseButton.Click();
            return new UserInteractionsCoursePage(Driver);
        }
    }
}