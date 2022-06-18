using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class SoftUniTests
{
    private ChromeDriver softUni_Driver;

    [SetUp]
    public void SetUp()
    {
        this.softUni_Driver = new ChromeDriver();
        softUni_Driver.Url = "https://softuni.bg";
        softUni_Driver.Manage().Window.Maximize();
    }

    [TearDown]
    public void Close() => softUni_Driver?.Close();

    [Test]
    public void Assert_Main_Page_Title()
    {
        string exeptedTitle = "Обучение по програмиране - Софтуерен университет";
        Assert.That(softUni_Driver.Title, Is.EqualTo(exeptedTitle));
    }

    [Test]
    public void Assert_AboutUs_Page()
    {
        var aboutUs = softUni_Driver.FindElement(By.CssSelector("li:nth-of-type(1) > .nav-link > .cell"));

        var exepectedTitle = "За нас - Софтуерен университет";

        aboutUs.Click();
        Assert.That(softUni_Driver.Title, Is.EqualTo(exepectedTitle));
    }
}