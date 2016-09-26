using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace AutomationGuild2017
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Recording1()
        {
            IWebDriver wd = new RemoteWebDriver(DesiredCapabilities.Firefox());
            try
            {
                var wait = new WebDriverWait(wd, TimeSpan.FromSeconds(60));
                wd.Navigate().GoToUrl("http://courses.ultimateqa.com/");
                wd.FindElement(By.CssSelector("button.navbar-toggle")).Click();
                wd.FindElement(By.LinkText("SIGN IN")).Click();
                if (wd.Url != "http://courses.ultimateqa.com")
                {
                    Console.Error.WriteLine("verifyCurrentUrl failed");
                }

                wd.FindElement(By.Id("user_email")).Click();
                wd.FindElement(By.Id("user_email")).Clear();
                wd.FindElement(By.Id("user_email")).SendKeys("todd.bernstein.1@mailinator.com");
                wd.FindElement(By.Id("user_password")).Click();
                wd.FindElement(By.Id("user_password")).Clear();
                wd.FindElement(By.Id("user_password")).SendKeys("Test12345!%");
                wd.FindElement(By.Id("btn-signin")).Click();
                if (!wd.FindElement(By.TagName("html")).Text.Contains("Your Student Dashboard"))
                {
                    Console.Error.WriteLine("verifyTextPresent failed");
                }
            }
            finally { wd.Quit(); }
        }
    }
}
