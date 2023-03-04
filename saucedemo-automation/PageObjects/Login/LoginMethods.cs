using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo_automation
{
    public class LoginMethods : LoginPO
    {
        public LoginMethods(IWebDriver driver) : base(driver) { }

        private void EnterUserName(string userName)
        {
            MainCalls.SeleniumExtension.WebForElementAndSendKey(byUserName, userName);
        }

        private void EnterPassword(string password)
        {
            MainCalls.SeleniumExtension.WebForElementAndSendKey(byPassword, password);
        }

        private void ClickSubmitButton()
        {
            MainCalls.SeleniumExtension.WebForElementAndClick(loginButton);
        }

        public void LoginToSauceDemoApplication(string userName, string password)
        {
            EnterUserName(userName);
            EnterPassword(password);
            ClickSubmitButton();
        }

        public void NavigateToSauceDemoWebsite(string url)
        {
            MainCalls.SeleniumExtension.GotoUrl(url);
        }
    }
}
