using AutomationDemo.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.PracticeAutomation.ProductSearch
{
    [TestClass]
    public class ProductSearchPageTestCases : CorePage
    {
        #region Setup and Cleanup
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [TestInitialize()]
        public void TestInit()
        {
            SeleniumInitialization("Chrome", "http://automationpractice.com/index.php");
        }

        [TestCleanup()]
        public void TestCleanUp()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

        //[AssemblyInitialize()]
        //public static void TestInit(TestContext context)
        //{
        //    SeleniumInitialization("Chrome", "http://automationpractice.com/index.php");
        //}

        //[AssemblyCleanup()]
        //public static void TestCleanUp()
        //{
        //    driver.Close();
        //    driver.Quit();
        //    driver.Dispose();
        //}
        #endregion

        #region Objects Creations
        ProductSearchPage productSearchPage = new ProductSearchPage();
        #endregion

        #region Test Case for ( Search any product ) using datasource in XML Format
        [TestMethod, TestCategory("SearchProduct"), TestCategory("Positive"), TestCategory("XML")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"D:\OneDrive - Constellation HomeBuilder Systems\Automation\AutomationDemo\Data\data.xml", "SearchProduct", DataAccessMethod.Sequential)]
        public void TC01_SearchProduct()
        {
            #region Read data from datasource
            string searchText = TestContext.DataRow["searchText"].ToString();
            #endregion

            #region Method calling
            productSearchPage.SearchItem(searchText);
            #endregion
        }
        #endregion
    }
}
