using NunitCoreFramework.Driver;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitCoreFramework.Hooks
{
    [Binding]
    public class PreRequisite
    {
        private DriverFixture _driverFixture;
        //Context injection
        public PreRequisite(DriverFixture _driverFixture)=>this._driverFixture = _driverFixture;        

        [BeforeScenario("@shakeout")]
        public void BeforeScenarioWithTag()
        {
            //TODO: implement logic that has to run before executing each scenario


            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("disable-gpu");

            var config = new ChromeConfig();
            new WebDriverManager.DriverManager().SetUpDriver(config,config.GetMatchingBrowserVersion());
            _driverFixture.Driver= new ChromeDriver(options);            

        }


        [AfterScenario]
        public void AfterScenario()
        {
            _driverFixture.Driver.Quit();
        }
    }
}