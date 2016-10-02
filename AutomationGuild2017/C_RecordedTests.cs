using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace AutomationGuild2017
{
    [TestFixture]
    [Description("Finally got a working test. Can it withstand 20 iterations?")]
    public class C_RecordedTests
    {
        [Test]
        public void Test1_Fix2()
        {
            //2. Fix to FirefoxDriver so that the test can run
            IWebDriver wd = new FirefoxDriver();
            //3. Always start the driver in max so that we don't deal with these issues any more
            wd.Manage().Window.Maximize();
            try
            {
                var wait = new WebDriverWait(wd, TimeSpan.FromSeconds(60));
                wd.Navigate().GoToUrl("http://courses.ultimateqa.com/");
                //4. Click on the visible link rather than the element that's available when the page is collapsed
                wd.FindElement(By.ClassName("my-account")).Click();
                if (!wd.FindElement(By.TagName("html")).Text.Contains("Welcome Back"))
                {
                    Console.Error.WriteLine("verifyTextPresent failed");
                }
                wd.FindElement(By.Id("user_email")).Click();
                wd.FindElement(By.Id("user_email")).Clear();
                wd.FindElement(By.Id("user_email")).SendKeys(Environment.GetEnvironmentVariable("UQA_TEST_USER_NAME",EnvironmentVariableTarget.User));
                wd.FindElement(By.Id("user_password")).Click();
                wd.FindElement(By.Id("user_password")).Clear();
                wd.FindElement(By.Id("user_password")).SendKeys("Test12345!%!");
                wd.FindElement(By.Id("btn-signin")).Click();

                //1. Replaced the statement with an actual assertion
                Assert.IsTrue(wd.FindElement(By.TagName("html")).Text.Contains("Your Student Dashboard"));
            }
            finally { wd.Quit(); }
        }

        public void Test2_Fix2()
        {
            //2. Fix to FirefoxDriver so that the test can run
            IWebDriver wd = new FirefoxDriver();
            //3. Always start the driver in max so that we don't deal with these issues any more
            wd.Manage().Window.Maximize();
            try
            {
                var wait = new WebDriverWait(wd, TimeSpan.FromSeconds(60));
                wd.Navigate().GoToUrl("http://courses.ultimateqa.com/");
                //4. Click on the visible link rather than the element that's available when the page is collapsed
                wd.FindElement(By.ClassName("my-account")).Click();
                if (!wd.FindElement(By.TagName("html")).Text.Contains("Welcome Back"))
                {
                    Console.Error.WriteLine("verifyTextPresent failed");
                }
                wd.FindElement(By.Id("user_email")).Click();
                wd.FindElement(By.Id("user_email")).Clear();
                wd.FindElement(By.Id("user_email")).SendKeys(Environment.GetEnvironmentVariable("UQA_TEST_USER_NAME",EnvironmentVariableTarget.User));
                wd.FindElement(By.Id("user_password")).Click();
                wd.FindElement(By.Id("user_password")).Clear();
                wd.FindElement(By.Id("user_password")).SendKeys("Test12345!%!");
                wd.FindElement(By.Id("btn-signin")).Click();

                //1. Replaced the statement with an actual assertion
                Assert.IsTrue(wd.FindElement(By.TagName("html")).Text.Contains("Your Student Dashboard"));
            }
            finally { wd.Quit(); }
        }

        public void Test3_Fix2()
        {
            //2. Fix to FirefoxDriver so that the test can run
            IWebDriver wd = new FirefoxDriver();
            //3. Always start the driver in max so that we don't deal with these issues any more
            wd.Manage().Window.Maximize();
            try
            {
                var wait = new WebDriverWait(wd, TimeSpan.FromSeconds(60));
                wd.Navigate().GoToUrl("http://courses.ultimateqa.com/");
                //4. Click on the visible link rather than the element that's available when the page is collapsed
                wd.FindElement(By.ClassName("my-account")).Click();
                if (!wd.FindElement(By.TagName("html")).Text.Contains("Welcome Back"))
                {
                    Console.Error.WriteLine("verifyTextPresent failed");
                }
                wd.FindElement(By.Id("user_email")).Click();
                wd.FindElement(By.Id("user_email")).Clear();
                wd.FindElement(By.Id("user_email")).SendKeys(Environment.GetEnvironmentVariable("UQA_TEST_USER_NAME",EnvironmentVariableTarget.User));
                wd.FindElement(By.Id("user_password")).Click();
                wd.FindElement(By.Id("user_password")).Clear();
                wd.FindElement(By.Id("user_password")).SendKeys("Test12345!%!");
                wd.FindElement(By.Id("btn-signin")).Click();

                //1. Replaced the statement with an actual assertion
                Assert.IsTrue(wd.FindElement(By.TagName("html")).Text.Contains("Your Student Dashboard"));
            }
            finally { wd.Quit(); }
        }
    }
}
