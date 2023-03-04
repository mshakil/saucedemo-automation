using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace saucedemo_automation
{
    [TestClass]
    public class LoginTest : Hooks
    {
        [TestMethod]
        public void VerifyLoginToSauceDemoIsSuccessfull()
        {
            string webUrl = "https://www.saucedemo.com/";
            string userName = "standard_user";
            string password = "secret_sauce";

            MainCalls.SeleniumExtension.GotoUrl(webUrl);
            MainCalls.LoginFunctions.EnterUserName(userName);
            MainCalls.LoginFunctions.EnterPassword(password);
            MainCalls.LoginFunctions.ClickSubmitButton();

        }
    }
}
