
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

var driver = new ChromeDriver();
driver.Url = "https://wikipedia.org";
driver.Manage().Window.Maximize();

var searchField = driver.FindElement(By.CssSelector("input#searchInput"));
searchField.Click();
searchField.SendKeys("QA" + Keys.Enter);
//searchField.SendKeys(Keys.Enter);
driver.Quit();