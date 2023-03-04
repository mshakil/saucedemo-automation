using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace saucedemo_automation
{
    public class BrowserConfigurations : MainCalls
    {
        public static void InitializeWebDriver()
        {
            string browserType = "firefox";

            if (browserType.Equals("chrome"))
            {
                InitializeChromeDriver();
            }
            else if (browserType.Equals("firefox"))
            {
                InitializeFirefoxDriver();
            }
        }

        public static void CloseWebDriver()
        {
            WebDriver.Close();
            WebDriver.Quit();
        }

        private static void InitializeChromeDriver()
        {
            if (WebDriver == null)
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                WebDriver = new ChromeDriver();
                WebDriver.Manage().Window.Maximize();
            }
        }

        private static void InitializeFirefoxDriver()
        {
            if (WebDriver == null)
            {
                new DriverManager().SetUpDriver(new FirefoxConfig());
                WebDriver = new FirefoxDriver();
                WebDriver.Manage().Window.Maximize();
            }
        }
    }
}
