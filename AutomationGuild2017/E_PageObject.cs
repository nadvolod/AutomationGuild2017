using System;
using AutomationGuild2017.PageObject;
using NUnit.Framework;

namespace AutomationGuild2017
{
    [TestFixture]
    [Description("The next level of encapsulation involves Page Objects")]
    public class E_PageObject : BaseTest
    {
        [Test]
        public void Test1()
        {
            var coursesPage = new CoursesPage(Driver);
            coursesPage.GoTo();

            var loginPage = coursesPage.ClickSignInLink();
            var studentDashboardPage = loginPage.Login(Environment.GetEnvironmentVariable("UQA_TEST_USER_NAME",EnvironmentVariableTarget.User), 
                Environment.GetEnvironmentVariable("UQA_TEST_USER_PASS", EnvironmentVariableTarget.User));

            Assert.IsTrue(studentDashboardPage.IsAt(), "The user was not able to successfully login.");
        }
    }
}
