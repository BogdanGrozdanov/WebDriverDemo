using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProjectFacebook
{
    public class Tests
    {
        private ChromeDriver driverFacebook;

        [OneTimeSetUp]
        public void Setup_OpenWebApp()
        {
            this.driverFacebook = new ChromeDriver();
            driverFacebook.Url = "https://en.wikipedia.org/wiki/QA";
            driverFacebook.Manage().Window.Maximize();
        }


        //[OneTimeTearDown]
        //public void TearDownWebApp()
        //{
        //    driverFacebook.Close();
        //}

        [Test]
        public void AssertMainPage()
        {
            Console.WriteLine(driverFacebook.Title);
            Assert.That(driverFacebook.Title ,Is.EqualTo("Facebook - log in or sign up"));
        }

        [Test]
        public void assertMainPage()
        {
            driverFacebook.Url= "https://en.wikipedia.org/wiki/QA";
            Assert.That(driverFacebook.Title, Is.Not.Null);
            driverFacebook.Close();
        }

    }
}