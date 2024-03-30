using NunitCoreFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace NunitCoreFramework.Tests
{
    public class Tests:BaseTest
    {
        [Test]
        public void Test1()
        {
            Driver.Url = "https://demowf.aspnetawesome.com/";
            IWebElement txtBox = Driver.FindElement(By.CssSelector("#ContentPlaceHolder1_Meal"));
            txtBox.SendKeys("Poached Egg");
            Actions _a = new Actions(Driver);
            var drpComboBox = Driver.FindElement(By.Id("ContentPlaceHolder1_AllMealsCombo-awed"));

            IWebElement cbCelery = Driver.FindElement(By.XPath("(//div[text()='Celery']/ancestor::li)[last()-1]"));
            _a.Click(cbCelery).Build().Perform();


        }
        [Test]
        public void SuhanaTest()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            HomePage _homePage = new HomePage(Driver);
            LoginPage _loginPage = new LoginPage(Driver);

            _homePage.ClickOnLogin();
            _loginPage.EnterUserNameAndPassword("admin","password");
            _loginPage.ClickLogin();
        }
    }
}