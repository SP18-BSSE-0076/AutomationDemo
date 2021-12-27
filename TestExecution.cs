using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AutomationDemo
{
    [TestClass]
    public class TestExecution : TestClasses.BaseClass
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
        TestClasses.SignInSignUpClass signInSignUp = new TestClasses.SignInSignUpClass();
        TestClasses.ProductSearch productSearch = new TestClasses.ProductSearch();
        TestClasses.ProductPurchaseing productPurchaseing = new TestClasses.ProductPurchaseing();
        TestClasses.Contact contact = new TestClasses.Contact();
        #endregion

        #region Test Cases for AutomationPractice.com website

        #region Test Case for ( SignIn )
        [TestMethod,TestCategory("SignIn")]
        [DataRow("rknight943@gmail.com", "abc123")]
        //[DataRow("rknight942@gmail.com", "abc123")]
        //[DataRow("942@gmail.com", "abc123")]
        public void TC01_SignIn(string user , string pass)
        {
            signInSignUp.SignIn(user , pass);
            signInSignUp.SignOut();
        }
        #endregion

        #region Test Case for ( SignUp )
        [TestMethod, TestCategory("SignUp")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"D:\Data\data.xml", "AutomationPracticeUsingDataSource",DataAccessMethod.Sequential)]
        public void TC02_SignUp()
        {
            signInSignUp.SignUp(TestContext.DataRow["email"].ToString(), TestContext.DataRow["firstName"].ToString(), TestContext.DataRow["lastName"].ToString(), TestContext.DataRow["password"].ToString(), TestContext.DataRow["address"].ToString(), TestContext.DataRow["city"].ToString(), TestContext.DataRow["postalCode"].ToString(), TestContext.DataRow["mobileNo"].ToString(), TestContext.DataRow["addressForFuture"].ToString());
            signInSignUp.SignOut();
        }
        #endregion

        #region Test Case for ( Search any product )
        [TestMethod, TestCategory("SearchProduct")]
        public void TC03_SearchProduct()
        {
            productSearch.SearchItem("t-shirts");
        }
        #endregion

        #region Test Case for ( Adding an item to cart )
        [TestMethod, TestCategory("AddToCart")]
        public void TC04_AddToCart()
        {
            
            productPurchaseing.AddItemToCart("5");
        }
        #endregion

        #region Test Case for ( Contact Form )
        [TestMethod, TestCategory("ContactForm")]
        public void TC05_ContactForm()
        {
            contact.ContactForm("rknight943@gmail.com","525","Hi I'm Chuky, wanna play?", "D:\\OneDrive - Constellation HomeBuilder Systems\\Desktop\\Login File.txt");
        }
        #endregion

        #endregion
    }
}