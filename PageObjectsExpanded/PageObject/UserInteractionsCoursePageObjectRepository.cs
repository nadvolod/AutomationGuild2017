using OpenQA.Selenium;

namespace PageObjectsExpanded.PageObject
{
    public class UserInteractionsCoursePageObjectRepository : BasePageObjectRepository
    {
        public By ExpandingElementLocator => By.Id("lesson-shelf-toggle");

        public UserInteractionsCoursePageObjectRepository(IWebDriver driver) : base(driver)
        {
        }
    }
}