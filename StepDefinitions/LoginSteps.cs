using NunitCoreFramework.Driver;
using NunitCoreFramework.Pages;
using NunitCoreFramework.Tests;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NunitCoreFramework.StepDefinitions
{
    [Binding]
    public sealed class LoginSteps
    {
        private DriverFixture _driverFixture;
        private readonly WebDriver driver;
        LoginPage _loginPage;
        HomePage _homePage;
        //Context injection
        public LoginSteps(DriverFixture _driverFixture)
        {
            this._driverFixture = _driverFixture;
            _loginPage = new LoginPage(_driverFixture.Driver);
            _homePage = new HomePage(_driverFixture.Driver);
            this.driver = _driverFixture.Driver;

        }        

        [Given(@"User Login to application")]
        public void LoginToApp(Table table)
        {
            _driverFixture.Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            if (driver.Title != "http://eaapp.somee.com/")
                driver.Navigate().Refresh();
            dynamic tableData = table.CreateDynamicInstance();
            _homePage.ClickOnLogin();
            _loginPage.EnterUserNameAndPassword(tableData.UserName, tableData.Password);

        }
        [When(@"user click on login")]
        public void UserClicksLogin()
        {
            _loginPage.ClickLogin();

        }
        [Then(@"user should be able to view homePage and logOff button")]
        public void UserSeeDashboardPage()
        {
            Assert.That(_homePage.isLogOffExists(),Is.True,"Log Off Doesn't exist");
            
        }
    }
}
