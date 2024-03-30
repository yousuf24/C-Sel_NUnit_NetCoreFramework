using OpenQA.Selenium;

namespace NunitCoreFramework.Driver
{
    public interface IDriverFixture
    {
        
        WebDriver InitializeDriver(BrowserType browserType);
    }
}
