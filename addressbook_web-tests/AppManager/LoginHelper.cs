﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebAddressBookTests
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(IWebDriver driver) : base(driver)
        {
        }
        public void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.CssSelector("input:nth-child(7)")).Click();
        }
    }
}
