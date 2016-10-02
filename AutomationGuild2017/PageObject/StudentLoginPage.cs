using OpenQA.Selenium;

namespace AutomationGuild2017.PageObject
{
    public class StudentLoginPage
    {
        public IWebDriver Driver { get; set; }

        private IWebElement LoginButton { get { return Driver.FindElement(By.Id("btn-signin")); } }
        private IWebElement PasswordField  { get {return Driver.FindElement(By.Id("user_password")); } }
        private IWebElement EmailField { get { return Driver.FindElement(By.Id("user_email")); } }
        public StudentLoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

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