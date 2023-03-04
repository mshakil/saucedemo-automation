using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo_automation
{
    public class SeleniumExtension
    {
        private IWebDriver wdriver;

        public SeleniumExtension(IWebDriver driver) // MAINCALL SE DRIVER AYA.. 
        {
            this.wdriver = driver;
        }

        public void GotoUrl(string url)
        {
            wdriver.Navigate().GoToUrl(url);
        }

        public IWebElement WaitAndFindElement(By selector)
        {
            return wdriver.FindElement(selector);
        }

        public void WebForElementAndSendKey(By selector, string key)
        {
            IWebElement element= wdriver.FindElement(selector);
            element.SendKeys(key);
        }

        public void WebForElementAndClick(By selector)
        {
            IWebElement element = wdriver.FindElement(selector);
            element.Click();
        }




    }
}
