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
        #endregion

        #region Variables
        public const string ConnectionString = "Data Source=CRKRL-ATIFFMUH1\\KNIGHT;Initial Catalog=DataDrivenTesting;Integrated Security=True";
        public const string DataSourceMSSQL = "System.Data.SqlClient";
        public const string DataSourceXML = "Microsoft.VisualStudio.TestTools.DataSource.XML";
        public const string DataSourceCSV = "Microsoft.VisualStudio.TestTools.DataSource.CSV";
        public const string FilePath = "D:\\OneDrive - Constellation HomeBuilder Systems\\Automation\\AutomationDemo\\Data\\";
        #endregion

        #region Objects Creations
        ProductSearchPage productSearchPage = new ProductSearchPage();
        #endregion

        #region Test Case for ( Search any product ) using datasource in XML Format
        [TestMethod, TestCategory("SearchProduct"), TestCategory("Positive"), TestCategory("XML")]
        [DataSource(DataSourceXML, FilePath + "data.xml", "SearchProduct", DataAccessMethod.Sequential)]
        public void TC03_SearchProduct()
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
