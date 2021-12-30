using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.Core
{
    [TestClass]
    public class Initialization : CorePage
    {
        #region Setup and Cleanup
        [AssemblyInitialize()]
        public static void TestInit(TestContext context)
        {
            SeleniumInitialization("Chrome", "http://automationpractice.com/index.php");
        }

        [AssemblyCleanup()]
        public static void TestCleanUp()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
        #endregion

        //selenium
        //database
        //cleanup
        //external
    }
}
