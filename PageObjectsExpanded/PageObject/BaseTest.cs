using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace PageObjectsExpanded.PageObject
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver Driver { get; private set; }

        [SetUp]
        public void InitializeDriverForEveryTest()
        {
            Driver = new FirefoxDriver();
            Driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void TearDownForEveryTest()
        {
            if (Driver == null)
                return;
            Driver.Quit();
        }
    }
}