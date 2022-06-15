using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

var driver = new ChromeDriver();
driver.Url = "https://softuni.bg";
driver.Manage().Window.Maximize();

var aboutUs = driver.FindElement(By.CssSelector("li:nth-of-type(1) > .nav-link > .cell"));
aboutUs.Click();
System.Console.WriteLine(driver.Title);