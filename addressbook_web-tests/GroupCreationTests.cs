using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest() 
        {
            navigator.OpenHomePage();
            loginHelper.Login(new AccountData ("admin", "secret"));
            navigator.GoToGroupsPage();
            groupHelper.InitGropCreation();
            groupHelper.FillGroupForm(new GroupData("qwe", "qweqwe", "qweqweqwe"));
            groupHelper.SubmitGropCreation();
            navigator.GoToGroupsPage();
        }
    }
}