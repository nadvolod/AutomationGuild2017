using OpenQA.Selenium;

namespace PageObjectsExpanded.PageObject
{
    public class StudentDashboardPageObjectRepository : BasePageObjectRepository
    {

        public IWebElement HtmlTag => Driver.FindElement(By.TagName("html"));

        public IWebElement ResumeUserInteractionsCourseButton => Driver.FindElement(
            By.XPath(
                "//*[contains(@href, 'user-interactions') and contains(@class,'btn-primary')]"));
        public StudentDashboardPageObjectRepository(IWebDriver driver) : base(driver)
        {
        }
    }
}