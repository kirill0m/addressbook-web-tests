using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebAddressBookTests
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(IWebDriver driver) : base(driver)
        {
        }
        public void InitGropCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }
        public void FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }
        public void SubmitGropCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }
        public void SelectGroup()
        {
            driver.FindElement(By.Name("selected[]")).Click();
        }
        public void RemoverGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
        }
    }
}
