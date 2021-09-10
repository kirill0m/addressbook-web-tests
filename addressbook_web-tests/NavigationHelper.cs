using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebAddressBookTests
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL; 
        public NavigationHelper(IWebDriver driver, string baseURL) : base(driver)
        {
            this.baseURL = baseURL;
        }
        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }
        public void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("Группы")).Click();
        }
    }
}
