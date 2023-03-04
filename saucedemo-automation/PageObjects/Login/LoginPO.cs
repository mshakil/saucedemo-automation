using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo_automation
{
    public class LoginPO : BasePO
    {
        protected LoginPO(IWebDriver driver) : base(driver) { }

        protected By byUserName = By.Id("user-name");
        protected By byPassword = By.Id("password");
        protected By loginButton = By.Id("login-button");

    }
}
