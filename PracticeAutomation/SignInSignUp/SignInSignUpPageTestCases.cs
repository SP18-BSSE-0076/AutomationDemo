using AutomationDemo.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.PracticeAutomation.SignInSignUp
{
    [TestClass]
    public class SignInSignUpPageTestCases : CorePage
    {
        #region Setup and Cleanup
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

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

        #region Objects Creations
        SignInSignUpPage signInSignUpPage = new SignInSignUpPage();
        #endregion

        #region Test Case for ( SignIn )
        [TestMethod]
        [TestCategory("SignIn"),TestCategory("Positive")]
        public void TC01_SignIn()
        {
            signInSignUpPage.SignIn("rknight943@gmail.com","abc123");
        }
        #endregion

        #region Test Case for ( SignUp ) using datasource in XML Format
        [TestMethod, TestCategory("SignUp"), TestCategory("XML")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"D:\OneDrive - Constellation HomeBuilder Systems\Automation\AutomationDemo\Data\data.xml", "AutomationPracticeUsingDataSource", DataAccessMethod.Sequential)]
        public void TC02_SignUp()
        {
            #region Read data from datasource
            string email = TestContext.DataRow["email"].ToString();
            string firstName = TestContext.DataRow["firstName"].ToString();
            string lastName = TestContext.DataRow["lastName"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string address = TestContext.DataRow["address"].ToString();
            string city = TestContext.DataRow["city"].ToString();
            string postalCode = TestContext.DataRow["postalCode"].ToString();
            string mobileNo = TestContext.DataRow["mobileNo"].ToString();
            string addressForFuture = TestContext.DataRow["addressForFuture"].ToString();
            #endregion

            #region This code is use to get unique email every time 
            string emailBeforeChar = email.Substring(0, email.IndexOf("@"));
            string emailAfterChar = email.Substring(email.IndexOf("@") + 1);
            email = emailBeforeChar + DateTime.Now.Ticks.ToString() + "@" + emailAfterChar;
            #endregion

            #region Method calling
            signInSignUpPage.SignUp(email, firstName, lastName, password, address, city, postalCode, mobileNo, addressForFuture);
            signInSignUpPage.SignOut();
            #endregion
        }
        #endregion

        #region Test Case for ( SignUp ) using datasource in CSV Format
        [TestMethod, TestCategory("SignUp") , TestCategory("CSV")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"D:\OneDrive - Constellation HomeBuilder Systems\Automation\AutomationDemo\Data\data.csv", "data#csv", DataAccessMethod.Sequential)]
        public void TC03_SignUp()
        {
            #region Read data from datasource
            string email = TestContext.DataRow["email"].ToString();
            string firstName = TestContext.DataRow["firstName"].ToString();
            string lastName = TestContext.DataRow["lastName"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string address = TestContext.DataRow["address"].ToString();
            string city = TestContext.DataRow["city"].ToString();
            string postalCode = TestContext.DataRow["postalCode"].ToString();
            string mobileNo = TestContext.DataRow["mobileNo"].ToString();
            string addressForFuture = TestContext.DataRow["addressForFuture"].ToString();
            #endregion

            #region This code is use to get unique email every time 
            string emailBeforeChar = email.Substring(0, email.IndexOf("@"));
            string emailAfterChar = email.Substring(email.IndexOf("@") + 1);
            email = emailBeforeChar + DateTime.Now.Ticks.ToString() + "@" +  emailAfterChar;
            #endregion

            #region Method calling
            signInSignUpPage.SignUp(email, firstName, lastName, password, address, city, postalCode , mobileNo, addressForFuture);
            signInSignUpPage.SignOut();
            #endregion
        }
        #endregion
    }
}