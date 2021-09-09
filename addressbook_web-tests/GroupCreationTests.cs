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

namespace WebAdressBookTests
{

    [TestFixture]
    public class AuthorizationAndGroupCreationTests
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
            OpenHomePage();
            Login("admin", "secret");
            GoToGroupsPage();
            InitGropCreation();
            FillGroupForm("qwe", "asd", "zxc");
            SubmitGropCreation();
            ReturnToGroupPage();
        }

        private void ReturnToGroupPage()
        {
            driver.FindElement(By.LinkText("Группы")).Click();
        }

        private void SubmitGropCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        private void FillGroupForm(string name, string header, string footer)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).SendKeys(name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).SendKeys(header);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_footer")).SendKeys(footer);
        }

        private void InitGropCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }

        private void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("Группы")).Click();
        }

        private void Login(string username, string password)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys("admin");
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys("secret");
            driver.FindElement(By.CssSelector("input:nth-child(7)")).Click();
        }

        private void OpenHomePage()
        {
            driver.Navigate().GoToUrl("http://addressbook.local/");
        }
    }
}