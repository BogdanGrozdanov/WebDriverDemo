
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//Create driver
var driver = new ChromeDriver();
//driver URL
driver.Url = "https://wikipedia.org";
//Maximize screen
driver.Manage().Window.Maximize();

// Print title page
Console.WriteLine("Current Title :  " + driver.Title);
//Find element
var searchField = driver.FindElement(By.CssSelector("input#searchInput"));
//click on element
searchField.Click();
//input on element
searchField.SendKeys("QA" + Keys.Enter);
//Print title element
Console.WriteLine("Title now :" +driver.Title);
//search element
searchField = driver.FindElement(By.CssSelector("input#searchInput"));
//enter input
searchField.SendKeys("Bulgaria" + Keys.Enter);
//Print title page
Console.WriteLine("Title:" + driver.Title);
//close driver(browser)
driver.Quit();