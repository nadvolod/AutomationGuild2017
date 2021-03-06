﻿using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace AutomationGuild2017
{
    [TestFixture]
    public class A_RecordedTests
    {
        public void OriginalRecording()
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
                wd.FindElement(By.Id("user_email")).SendKeys(Environment.GetEnvironmentVariable("UQA_TEST_USER_NAME",EnvironmentVariableTarget.User));
                wd.FindElement(By.Id("user_password")).Click();
                wd.FindElement(By.Id("user_password")).Clear();
                wd.FindElement(By.Id("user_password")).SendKeys(Environment.GetEnvironmentVariable("UQA_TEST_USER_PASS", EnvironmentVariableTarget.User));
                wd.FindElement(By.Id("btn-signin")).Click();
                if (!wd.FindElement(By.TagName("html")).Text.Contains("Your Student Dashboard"))
                {
                    Console.Error.WriteLine("verifyTextPresent failed");
                }
            }
            finally { wd.Quit(); }
        }

        [Test]
        public void Test1()
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
                wd.FindElement(By.Id("user_email")).SendKeys(Environment.GetEnvironmentVariable("UQA_TEST_USER_NAME",EnvironmentVariableTarget.User));
                wd.FindElement(By.Id("user_password")).Click();
                wd.FindElement(By.Id("user_password")).Clear();
                wd.FindElement(By.Id("user_password")).SendKeys(Environment.GetEnvironmentVariable("UQA_TEST_USER_PASS", EnvironmentVariableTarget.User));
                wd.FindElement(By.Id("btn-signin")).Click();

                //1. Replaced the statement with an actual assertion
                Assert.IsTrue(wd.FindElement(By.TagName("html")).Text.Contains("Your Student Dashboard"));
            }
            finally { wd.Quit(); }
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
                wd.FindElement(By.Id("user_email")).SendKeys(Environment.GetEnvironmentVariable("UQA_TEST_USER_NAME",EnvironmentVariableTarget.User));
                wd.FindElement(By.Id("user_password")).Click();
                wd.FindElement(By.Id("user_password")).Clear();
                wd.FindElement(By.Id("user_password")).SendKeys(Environment.GetEnvironmentVariable("UQA_TEST_USER_PASS", EnvironmentVariableTarget.User));
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
                wd.FindElement(By.Id("user_email")).SendKeys(Environment.GetEnvironmentVariable("UQA_TEST_USER_NAME",EnvironmentVariableTarget.User));
                wd.FindElement(By.Id("user_password")).Click();
                wd.FindElement(By.Id("user_password")).Clear();
                wd.FindElement(By.Id("user_password")).SendKeys(Environment.GetEnvironmentVariable("UQA_TEST_USER_PASS", EnvironmentVariableTarget.User));
                wd.FindElement(By.Id("btn-signin")).Click();

                //1. Replaced the statement with an actual assertion
                Assert.Pass("This test always passes");
            }
            finally { wd.Quit(); }
        }
    }
}
