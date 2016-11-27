using OpenQA.Selenium;

namespace PageObjectsExpanded.PageObject
{
    public class StudentLoginPage : BasePage
    {

        private IWebElement LoginButton => Driver.FindElement(By.Id("btn-signin"));
        private IWebElement PasswordField => Driver.FindElement(By.Id("user_password"));
        private IWebElement EmailField => Driver.FindElement(By.Id("user_email"));

        public StudentLoginPage(IWebDriver driver) : base(driver)
        { }

        public StudentDashboardPage Login(string userName, string password)
        {
            TypeUserName(userName);
            TypePassword(password);
            LoginButton.Click();

            return new StudentDashboardPage(Driver);
        }

        private void TypePassword(string password)
        {
            PasswordField.Click();
            PasswordField.Clear();
            PasswordField.SendKeys(password);
        }

        private void TypeUserName(string userName)
        {
            EmailField.Click();
            EmailField.Clear();
            EmailField.SendKeys(userName);
        }
    }
}