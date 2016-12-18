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

        [Test]
        public void Test3()
        {
            var complicatedPage = new ComplicatedPage(Driver);
            complicatedPage.GoTo();
            Assert.IsTrue(complicatedPage.IsAt(), 
                "The complicated page did not open successfully");

            complicatedPage.ClickFirstTwitterButton();
            Assert.That(complicatedPage.IsAt(), Is.False);
        }
        [Test]
        public void Test4()
        {
            var complicatedPage = new ComplicatedPage(Driver);
            complicatedPage.GoTo();
            Assert.IsTrue(complicatedPage.IsAt(),
                "The complicated page did not open successfully");

            complicatedPage.Search("selenium");
            Assert.That(complicatedPage.IsAt(), Is.False);
        }
        [Test]
        public void Test5()
        {
            var complicatedPage = new ComplicatedPage(Driver);
            complicatedPage.GoTo();
            Assert.IsTrue(complicatedPage.IsAt(),
                "The complicated page did not open successfully");

            complicatedPage.OpenToggle();
            Assert.That(complicatedPage.IsToggleOpen(), Is.True);
        }
    }
}
