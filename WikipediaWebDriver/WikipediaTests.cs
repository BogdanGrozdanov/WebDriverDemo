
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

var driver = new ChromeDriver();
driver.Url = "https://wikipedia.org";
driver.Manage().Window.Maximize();


Console.WriteLine("Current Title :  " + driver.Title);
var searchField = driver.FindElement(By.CssSelector("input#searchInput"));
searchField.Click();
searchField.SendKeys("QA" + Keys.Enter);
Console.WriteLine("Title now :" +driver.Title);
searchField = driver.FindElement(By.CssSelector("input#searchInput"));
searchField.SendKeys("Bulgaria" + Keys.Enter);
Console.WriteLine("Title:" + driver.Title);
//searchField.SendKeys(Keys.Enter);
driver.Quit();