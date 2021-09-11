using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest() 
        {
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData ("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.Groups.InitGropCreation();
            app.Groups.FillGroupForm(new GroupData("qwe", "qweqwe", "qweqweqwe"));
            app.Groups.SubmitGropCreation();
            app.Navigator.GoToGroupsPage();
        }
    }
}