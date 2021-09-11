using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace WebAddressBookTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver = new FirefoxDriver();
        protected string baseURL = "http://addressbook.local/";
         
        protected LoginHelper loginHelper;
        protected GroupHelper groupHelper;
        protected NavigationHelper navigator;

        public ApplicationManager()
        {
            loginHelper = new LoginHelper(driver);
            navigator = new NavigationHelper(driver, baseURL);
            groupHelper = new GroupHelper(driver);
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }

        public NavigationHelper Navigator
        {
            get
            {
                return navigator;
            }
        }

        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }
        }

        public void Stop ()
        {
            driver.Quit();
        }
    }
}
