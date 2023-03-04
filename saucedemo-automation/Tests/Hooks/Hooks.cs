using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo_automation
{
    [TestClass]
    public class Hooks
    {
        [TestInitialize]
        public void InitializeBrowser()
        {
            BrowserConfigurations.InitializeWebDriver();
        }

        [TestCleanup]
        public void CleanupBrowser()
        {
            BrowserConfigurations.CloseWebDriver();
        }
    }
}
