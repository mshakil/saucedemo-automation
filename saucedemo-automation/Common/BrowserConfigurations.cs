using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace saucedemo_automation
{
    public class BrowserConfigurations : MainCalls
    {
        public static void InitializeWebDriver()
        {
            string browserType = "chrome";

            if (browserType.Equals("chrome"))
            {
                InitializeChromeDriver();
            }
        }

        public static void CloseWebDriver()
        {
            webDriver.Close();
            webDriver.Quit();
        }

        private static void InitializeChromeDriver()
        {
            if (webDriver == null)
            {
                //  USING WEB DRIVER MANAGER.
                new DriverManager().SetUpDriver(new ChromeConfig());
                webDriver = new ChromeDriver();
                webDriver.Manage().Window.Maximize();
            }
        }
    }
}
