using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class SoftUniTests
{
    private ChromeDriver driver;


    [OneTimeSetUp]
    public void SetUp()
    {
        this.driver = new ChromeDriver();
        driver.Url = "https://softuni.bg";
        driver.Manage().Window.Maximize();
    }

    [OneTimeTearDown]
    public void Close() => driver?.Close();

    [Test]
    public void Assert_Main_Page_Title()
    {
        driver.Url = "https://softuni.bg";
        string exeptedTitle = "Обучение по програмиране - Софтуерен университет";
        Assert.That(driver.Title, Is.EqualTo(exeptedTitle));
    }

    [Test]
    public void Assert_AboutUs_Page()
    {
        var aboutUs = driver.FindElement(By.CssSelector("li:nth-of-type(1) > .nav-link > .cell"));

        var exepectedTitle = "За нас - Софтуерен университет";

        aboutUs.Click();
        Assert.That(driver.Title, Is.EqualTo(exepectedTitle));
    }

    [Test]
    public void logOutLogIn()
    {
        driver.Navigate().GoToUrl("https://softuni.bg/");
        // driver.Manage().Window.Size = new System.Drawing.Size(1936, 1048);
        driver.FindElement(By.CssSelector(".softuni-btn.softuni-btn-primary.softuni-btn-small")).Click();
        driver.FindElement(By.CssSelector(".softuni-btn-primary")).Click();
        driver.FindElement(By.Id("username")).SendKeys("User1");
        driver.FindElement(By.Id("password-input")).SendKeys("password");
        driver.FindElement(By.CssSelector(".softuni-btn")).Click();
        Assert.That(driver.FindElement(By.CssSelector("li")).Text, Is.EqualTo("Невалидно потребителско име или парола"));
        driver.Close();

    }
}