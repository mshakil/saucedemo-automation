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

        public void EnterUserName(string userName)
        {
            MainCalls.SeleniumExtension.WebForElementAndSendKey(byUserName, userName);
        }

        public void EnterPassword(string password)
        {
            MainCalls.SeleniumExtension.WebForElementAndSendKey(byPassword, password);
        }

        public void ClickSubmitButton()
        {
            MainCalls.SeleniumExtension.WebForElementAndClick(loginButton);
        }
    }
}
