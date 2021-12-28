using AutomationDemo.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.PracticeAutomation.ProductPurchase
{
    [TestClass]
    public class ProductPurchasePageTestCases : CorePage
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
        ProductPurchasePage productPurchasePage = new ProductPurchasePage();
        #endregion

        #region Test Case for ( Adding an item to cart ) using datasource in XML Format
        [TestMethod, TestCategory("AddToCart"), TestCategory("Positive"), TestCategory("XML")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"D:\OneDrive - Constellation HomeBuilder Systems\Automation\AutomationDemo\Data\data.xml", "ProductPurchase", DataAccessMethod.Sequential)]
        public void TC01_AddToCart()
        {
            #region Read data from datasource
            string quantity = TestContext.DataRow["quantity"].ToString();
            string size = TestContext.DataRow["size"].ToString();
            string color = TestContext.DataRow["color"].ToString();
            #endregion

            #region Method calling
            productPurchasePage.AddItemToCart(quantity,size,color);
            #endregion
        }
        #endregion
    }
}
