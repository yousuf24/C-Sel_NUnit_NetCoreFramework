using NunitCoreFramework.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NunitCoreFramework.Pages
{
    public class HomePage
    {
        private readonly WebDriver Driver;

        public HomePage(WebDriver _df)
        {
            Driver = _df;
        }
        #region PageElements
        private IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));
        private IWebElement lnkLogOff => Driver.FindElement(By.XPath("//a[text()='Log off']"));
        #endregion

        #region PageActions
        public void ClickOnLogin() => lnkLogin.Click();

        public bool isLogOffExists()
        {
            //WebDriverWait wait = new WebDriverWait(Driver,TimeSpan.FromSeconds(60));
            //wait.Until<IWebElement>(d => d.FindElement(By.XPath("//a[text()='Log off']")));
            return lnkLogOff.Displayed;
        }
        #endregion
    }
}
