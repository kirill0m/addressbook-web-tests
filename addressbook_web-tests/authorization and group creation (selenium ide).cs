using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

[TestFixture]
public class AuthorizationAndGroupCreationTest
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new FirefoxDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void AuthorizationAndGroupCreation()
    {
        driver.Navigate().GoToUrl("http://addressbook.local/");
        driver.Manage().Window.Size = new System.Drawing.Size(1132, 692);
        driver.FindElement(By.Name("user")).Click();
        driver.FindElement(By.Name("user")).SendKeys("admin");
        driver.FindElement(By.Name("pass")).SendKeys("secret");
        driver.FindElement(By.CssSelector("input:nth-child(7)")).Click();
        driver.FindElement(By.LinkText("Группы")).Click();
        driver.FindElement(By.Name("new")).Click();
        driver.FindElement(By.Name("group_name")).Click();
        driver.FindElement(By.Name("group_name")).SendKeys("qweqwe");
        driver.FindElement(By.Name("submit")).Click();
        driver.FindElement(By.LinkText("Группы")).Click();
    }
}
