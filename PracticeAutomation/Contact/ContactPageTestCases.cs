using AutomationDemo.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationDemo.PracticeAutomation.Contact
{
    [TestClass]
    public class ContactPageTestCases : CorePage
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
        ContactPage contactPage = new ContactPage();
        #endregion

        #region Test Case for ( Contact Form ) using datasource in XML Format
        [TestMethod, TestCategory("ContactForm"), TestCategory("Positive"), TestCategory("XML")]
        [DataSource(DataSourceXML, FilePath + "data.xml", "ContactForm", DataAccessMethod.Sequential)]
        public void TC05_ContactForm()
        {
            #region Read data from datasource
            string subjectHeading = TestContext.DataRow["subjectHeading"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string orderRef = TestContext.DataRow["orderReference"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string filePath = TestContext.DataRow["filePath"].ToString();
            #endregion

            #region Method calling
            contactPage.ContactForm(subjectHeading, email, orderRef, message, filePath);
            Thread.Sleep(5000);
            #endregion
        }
        #endregion
    }
}