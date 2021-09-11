using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebAddressBookTests
{
    public class HelperBase 
    {
        protected IWebDriver driver;
        public HelperBase(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}