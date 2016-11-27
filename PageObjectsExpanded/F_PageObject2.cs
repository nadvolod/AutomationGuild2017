using System;
using NUnit.Framework;
using PageObjectsExpanded.PageObject;

namespace PageObjectsExpanded
{
    [TestFixture]
    [Description("Enhanced page objects")]
    public class F_PageObject2 : BaseTest
    {
        [Test]
        public void Test1()
        {
            var coursesPage = new CoursesPage(Driver);
            coursesPage.GoTo();

            var loginPage = coursesPage.ClickSignInLink();
            var studentDashboardPage = loginPage.Login(Environment.GetEnvironmentVariable("UQA_TEST_USER_NAME", EnvironmentVariableTarget.User),
                Environment.GetEnvironmentVariable("UQA_TEST_USER_PASS", EnvironmentVariableTarget.User));

            Assert.IsTrue(studentDashboardPage.IsAt(), "The user was not able to successfully login.");
        }

        [Test]
        public void Test2()
        {
            var coursesPage = new CoursesPage(Driver);
            coursesPage.GoTo();

            var loginPage = coursesPage.ClickSignInLink();
            var studentDashboardPage = loginPage.Login(Environment.GetEnvironmentVariable("UQA_TEST_USER_NAME", EnvironmentVariableTarget.User),
                Environment.GetEnvironmentVariable("UQA_TEST_USER_PASS", EnvironmentVariableTarget.User));

            Assert.IsTrue(studentDashboardPage.IsAt(), "The user was not able to successfully login.");

            var userInteractionsCoursePage = studentDashboardPage.ResumeUserInteractionsCourse();
            Assert.IsTrue(userInteractionsCoursePage.IsAt(), "The course did not open succesfully.");
        }
    }


}
