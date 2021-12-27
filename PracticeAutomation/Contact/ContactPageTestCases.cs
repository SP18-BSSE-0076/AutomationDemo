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

        #region Test Case for ( Contact Form )
        [TestMethod, TestCategory("ContactForm")]
        public void TC05_ContactForm()
        {
            contactPage.ContactForm("rknight943@gmail.com", "525", "Hi I'm Chuky, wanna play?", "D:\\OneDrive - Constellation HomeBuilder Systems\\Desktop\\Login File.txt");
        }
        #endregion
    }
}