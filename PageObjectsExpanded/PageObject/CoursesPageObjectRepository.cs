using OpenQA.Selenium;

namespace PageObjectsExpanded.PageObject
{
    public class CoursesPageObjectRepository : BasePageObjectRepository
    {
        public IWebElement SignInLink => Driver.FindElement(By.ClassName("my-account"));

        public CoursesPageObjectRepository(IWebDriver driver) : base(driver)
        {

        }
    }
}