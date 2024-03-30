using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;



namespace NunitCoreFramework.Driver
{
    public class DriverFixture:IDriverFixture
    {
        public WebDriver Driver;        
        public WebDriver InitializeDriver(BrowserType browserType=BrowserType.CHROME)
        {
            Driver= browserType switch
            {
                BrowserType.FIREFOX =>  new FirefoxDriver() ,
                BrowserType.EDGE => new EdgeDriver(),
                _ => new ChromeDriver()

            };            
            return this.Driver;
        }
        /// <summary>
        /// UnImplemented
        /// </summary>
        /// <param name="browserType"></param>
        /// <returns></returns>
        public WebDriver InitializeDriverWithOptions(BrowserType browserType = BrowserType.CHROME)
        {
            switch (browserType)
            {
                case BrowserType.CHROME:break;


                case BrowserType.EDGE: break;
                    
                
            }return Driver;

        }


    }
    public enum BrowserType
    {
        CHROME,EDGE,FIREFOX,SAFARI
    }
}
