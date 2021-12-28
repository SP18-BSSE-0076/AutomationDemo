using AutomationDemo.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        ContactPage contactPage = new ContactPage();
        #endregion

        #region Test Case for ( Contact Form ) using datasource in XML Format
        [TestMethod, TestCategory("ContactForm"), TestCategory("Positive"), TestCategory("XML")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"D:\OneDrive - Constellation HomeBuilder Systems\Automation\AutomationDemo\Data\data.xml", "ContactForm", DataAccessMethod.Sequential)]
        public void TC01_ContactForm()
        {
            #region Read data from datasource
            string email = TestContext.DataRow["email"].ToString();
            string orderRef = TestContext.DataRow["orderReference"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            string filePath = TestContext.DataRow["filePath"].ToString();
            #endregion

            #region Method calling
            contactPage.ContactForm(email,orderRef,message,filePath);
            #endregion
        }
        #endregion
    }
}