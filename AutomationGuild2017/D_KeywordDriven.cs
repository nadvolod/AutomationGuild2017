using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AutomationGuild2017
{
    [TestFixture]
    [Description("The next level of encapsulation involves Keyword Driven Tests")]
    public class D_KeywordDriven
    {
        private IWebDriver wd;
        [Test]
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

        [Test]
        public void Test2()
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

        [Test]
        public void Test3()
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
            wd.FindElement(By.Id("user_email")).SendKeys(Environment.GetEnvironmentVariable("UQA_TEST_USER_NAME",EnvironmentVariableTarget.User));
        }

        private void ClickMyAccountLink()
        {
            wd.FindElement(By.ClassName("my-account")).Click();
        }
    }
}
