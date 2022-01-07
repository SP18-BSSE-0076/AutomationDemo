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
        #endregion

        #region Variables
        public const string ConnectionString = "Data Source=CRKRL-ATIFFMUH1\\KNIGHT;Initial Catalog=DataDrivenTesting;Integrated Security=True";
        public const string DataSourceMSSQL = "System.Data.SqlClient";
        public const string DataSourceXML = "Microsoft.VisualStudio.TestTools.DataSource.XML";
        public const string DataSourceCSV = "Microsoft.VisualStudio.TestTools.DataSource.CSV";
        public const string FilePath = "D:\\OneDrive - Constellation HomeBuilder Systems\\Automation\\AutomationDemo\\Data\\";
        #endregion

        #region Objects Creations
        ProductPurchasePage productPurchasePage = new ProductPurchasePage();
        #endregion

        #region Test Case for ( Adding an item to cart ) using datasource in XML Format
        [TestMethod, TestCategory("AddToCart"), TestCategory("Positive"), TestCategory("XML")]
        [DataSource(DataSourceXML, FilePath + "data.xml", "ProductPurchase", DataAccessMethod.Sequential)]
        public void TC04_AddToCart()
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
