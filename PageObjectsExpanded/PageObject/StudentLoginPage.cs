using OpenQA.Selenium;

namespace PageObjectsExpanded.PageObject
{
    public class StudentLoginPage : BasePage<StudentLoginPageObjectRepository>
    {
        public StudentLoginPage(IWebDriver driver) : base(driver, new StudentLoginPageObjectRepository(driver))
        { }

        public StudentDashboardPage Login(string userName, string password)
        {
            TypeUserName(userName);
            TypePassword(password);
            ObjectRepository.LoginButton.Click();

            return new StudentDashboardPage(Driver);
        }

        private void TypePassword(string password)
        {
            ObjectRepository.PasswordField.Click();
            ObjectRepository.PasswordField.Clear();
            ObjectRepository.PasswordField.SendKeys(password);
        }

        private void TypeUserName(string userName)
        {
            ObjectRepository.EmailField.Click();
            ObjectRepository.EmailField.Clear();
            ObjectRepository.EmailField.SendKeys(userName);
        }
    }
}