using OpenQA.Selenium;

namespace NunitCoreFramework.Pages
{
    public class LoginPage
    {
        private readonly WebDriver Driver;
        public LoginPage(WebDriver Driver)
        {
            this.Driver = Driver;

        }
        #region PageElements
        private IWebElement tbUserName => Driver.FindElement(By.Name("UserName"));
        private IWebElement tbPassword => Driver.FindElement(By.Name("Password"));
        private IWebElement lnkLogin => Driver.FindElement(By.CssSelector("[value='Log in']"));
        #endregion

        #region PageAction
        public void EnterUserNameAndPassword(string strId,string strPwd)
        {
            tbUserName.Clear();
            tbUserName.SendKeys(strId);
            tbPassword.Clear();
            tbPassword.SendKeys(strPwd);
        }
        public void ClickLogin() =>lnkLogin.Click();
        #endregion
    }
}
