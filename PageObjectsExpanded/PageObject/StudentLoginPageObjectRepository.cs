using OpenQA.Selenium;

namespace PageObjectsExpanded.PageObject
{
    public class StudentLoginPageObjectRepository : BasePageObjectRepository
    {
        public IWebElement LoginButton => Driver.FindElement(By.Id("btn-signin"));
        public IWebElement PasswordField => Driver.FindElement(By.Id("user_password"));
        public IWebElement EmailField => Driver.FindElement(By.Id("user_email"));
        public StudentLoginPageObjectRepository(IWebDriver driver) : base(driver)
        {
        }
    }
}