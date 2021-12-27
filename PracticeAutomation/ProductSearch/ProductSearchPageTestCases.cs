using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.PracticeAutomation.ProductSearch
{
    [TestClass]
    public class ProductSearchPageTestCases
    {
        ProductSearchPage productSearchPage = new ProductSearchPage();

        #region Test Case for ( Search any product )
        [TestMethod, TestCategory("SearchProduct")]
        public void TC03_SearchProduct()
        {
            productSearchPage.SearchItem("t-shirts");
        }
        #endregion
    }
}
