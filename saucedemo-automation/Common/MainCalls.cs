﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo_automation
{
    public class MainCalls
    {
        public static IWebDriver WebDriver { get; set; }

        #region Classes OBJECT REGION

        private static SeleniumExtension _seleniiumExtension;
        public static SeleniumExtension SeleniumExtension
        {
            get
            {
                if (_seleniiumExtension == null)
                {
                    _seleniiumExtension = new SeleniumExtension(WebDriver);
                }
                return _seleniiumExtension;
            }
            set { _seleniiumExtension = value; }
        }

        private static LoginMethods _loginFunctions;
        public static LoginMethods LoginFunctions 
        {
            get
            {
                if (_loginFunctions == null)
                {
                    _loginFunctions = new LoginMethods(WebDriver);
                }
                return _loginFunctions;
            }
            set { _loginFunctions = value; }
        }


        #endregion
    }
}
