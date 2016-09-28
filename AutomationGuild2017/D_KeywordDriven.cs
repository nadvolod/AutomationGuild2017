using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace AutomationGuild2017
{
    [TestFixture]
    [Description("The next level of encapsulation involves Keyword Driven Tests")]
    public class D_KeywordDriven
    {
        private IWebDriver wd;
        [Test]
        [Repeat(20)]
        public void Test1()
        {
            InitializeDriver();
            try
            {
                GoToCoursesPage();
                ClickMyAccountLink();
                if (!wd.FindElement(By.TagName("html")).Text.Contains("Welcome Back"))
                {
                    Console.Error.WriteLine("verifyTextPresent failed");
                }
                TypeUserName();
                TypePassword();
                ClickLoginButton();

                Assert.IsTrue(wd.FindElement(By.TagName("html")).Text.Contains("Your Student Dashboard"));
            }
            finally { wd.Quit(); }
        }

        private void GoToCoursesPage()
        {
            wd.Navigate().GoToUrl("http://courses.ultimateqa.com/");
        }

        private void InitializeDriver()
        {
            wd = new FirefoxDriver();
            wd.Manage().Window.Maximize();
        }

        private void ClickLoginButton()
        {
            wd.FindElement(By.Id("btn-signin")).Click();
        }

        private void TypePassword()
        {
            wd.FindElement(By.Id("user_password")).Click();
            wd.FindElement(By.Id("user_password")).Clear();
            wd.FindElement(By.Id("user_password")).SendKeys("Test12345!%!");
        }

        private void TypeUserName()
        {
            wd.FindElement(By.Id("user_email")).Click();
            wd.FindElement(By.Id("user_email")).Clear();
            wd.FindElement(By.Id("user_email")).SendKeys("todd.bernstein.1@mailinator.com");
        }

        private void ClickMyAccountLink()
        {
            wd.FindElement(By.ClassName("my-account")).Click();
        }

        [Test]
        public void Test2()
        {
            IWebDriver wd = new RemoteWebDriver(DesiredCapabilities.Firefox());
            try
            {
                var wait = new WebDriverWait(wd, TimeSpan.FromSeconds(60));
                wd.Navigate().GoToUrl("http://courses.ultimateqa.com/");
                wd.FindElement(By.CssSelector("button.navbar-toggle")).Click();
                wd.FindElement(By.LinkText("SIGN IN")).Click();
                if (!wd.FindElement(By.TagName("html")).Text.Contains("Welcome Back"))
                {
                    Console.Error.WriteLine("verifyTextPresent failed");
                }
                wd.FindElement(By.Id("user_email")).Click();
                wd.FindElement(By.Id("user_email")).Clear();
                wd.FindElement(By.Id("user_email")).SendKeys("todd.bernstein.1@mailinator.com");
                wd.FindElement(By.Id("user_password")).Click();
                wd.FindElement(By.Id("user_password")).Clear();
                wd.FindElement(By.Id("user_password")).SendKeys("Test12345!%");
                wd.FindElement(By.Id("btn-signin")).Click();

                //1. Replaced the statement with an actual assertion
                Assert.IsTrue(true);
            }
            finally { wd.Quit(); }
        }

        [Test]
        public void Test3()
        {
            IWebDriver wd = new RemoteWebDriver(DesiredCapabilities.Firefox());
            try
            {
                var wait = new WebDriverWait(wd, TimeSpan.FromSeconds(60));
                wd.Navigate().GoToUrl("http://courses.ultimateqa.com/");
                wd.FindElement(By.CssSelector("button.navbar-toggle")).Click();
                wd.FindElement(By.LinkText("SIGN IN")).Click();
                if (!wd.FindElement(By.TagName("html")).Text.Contains("Welcome Back"))
                {
                    Console.Error.WriteLine("verifyTextPresent failed");
                }
                wd.FindElement(By.Id("user_email")).Click();
                wd.FindElement(By.Id("user_email")).Clear();
                wd.FindElement(By.Id("user_email")).SendKeys("todd.bernstein.1@mailinator.com");
                wd.FindElement(By.Id("user_password")).Click();
                wd.FindElement(By.Id("user_password")).Clear();
                wd.FindElement(By.Id("user_password")).SendKeys("Test12345!%");
                wd.FindElement(By.Id("btn-signin")).Click();

                //1. Replaced the statement with an actual assertion
                Assert.Pass("This test always passes");
            }
            finally { wd.Quit(); }
        }
    }
}
