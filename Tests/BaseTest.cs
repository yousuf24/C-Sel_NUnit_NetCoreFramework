using NunitCoreFramework.Driver;
using OpenQA.Selenium;

namespace NunitCoreFramework.Tests
{
    public class BaseTest: DriverFixture,IDisposable
    {
        protected WebDriver Driver;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Inside setup!");
            //System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\Users\HI\My_Items\Job\Softwares\Jar Files\Browser Drivers\chromedriver.exe");
            this.Driver=InitializeDriver();
            Driver.Manage().Window.Maximize();
           
        }
        [TearDown]
        public void TearDown()
        {
            Dispose();
        }

        public void Dispose()
        {
            Driver?.Quit();
        }

        
    }
}
