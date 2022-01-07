using AutomationDemo.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

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
        #endregion

        #region Variables
        public const string ConnectionString = "Data Source=CRKRL-ATIFFMUH1\\KNIGHT;Initial Catalog=DataDrivenTesting;Integrated Security=True";
        public const string DataSourceMSSQL = "System.Data.SqlClient";
        public const string DataSourceXML = "Microsoft.VisualStudio.TestTools.DataSource.XML";
        public const string DataSourceCSV = "Microsoft.VisualStudio.TestTools.DataSource.CSV";
        public const string FilePath = "D:\\OneDrive - Constellation HomeBuilder Systems\\Automation\\AutomationDemo\\Data\\";
        #endregion

        #region Objects Creations
        SqlConnection con = new SqlConnection("Data Source=CRKRL-ATIFFMUH1\\KNIGHT;Initial Catalog=DataDrivenTesting;Integrated Security=True");
        SignInSignUpPage signInSignUpPage = new SignInSignUpPage();
        #endregion

        #region Test Case for ( SignIn ) using datasource in XML Format
        [TestMethod, TestCategory("SignIn"), TestCategory("Positive"), TestCategory("XML")]
        [DataSource(DataSourceXML, FilePath + "data.xml", "SignIn", DataAccessMethod.Sequential)]
        public void TC01_SignIn()
        {
            #region Read data from datasource
            string email = TestContext.DataRow["email"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            #endregion

            #region Method calling
            signInSignUpPage.SignIn(email,password);
            signInSignUpPage.SignOut();
            #endregion
        }
        #endregion

        #region Test Case for ( SignUp ) using datasource in XML Format
        [TestMethod, TestCategory("SignUp"), TestCategory("Positive"), TestCategory("XML")]
        [DataSource(DataSourceXML, FilePath + "data.xml", "SignUp", DataAccessMethod.Sequential)]
        public void TC02_SignUp()
        {
            #region Read data from datasource
            string email = TestContext.DataRow["email"].ToString();
            string firstName = TestContext.DataRow["firstName"].ToString();
            string lastName = TestContext.DataRow["lastName"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string address = TestContext.DataRow["address"].ToString();
            string city = TestContext.DataRow["city"].ToString();
            string state = TestContext.DataRow["state"].ToString();
            string postalCode = TestContext.DataRow["postalCode"].ToString();
            string country = TestContext.DataRow["country"].ToString();
            string mobileNo = TestContext.DataRow["mobileNo"].ToString();
            string addressForFuture = TestContext.DataRow["addressForFuture"].ToString();
            #endregion

            #region This code is use to get unique email every time 
            string emailBeforeChar = email.Substring(0, email.IndexOf("@"));
            string emailAfterChar = email.Substring(email.IndexOf("@") + 1);
            email = emailBeforeChar + DateTime.Now.Ticks.ToString() + "@" + emailAfterChar;
            #endregion

            #region Method calling
            signInSignUpPage.SignUp(email, firstName, lastName, password, address, city, state , postalCode, country , mobileNo, addressForFuture);
            signInSignUpPage.SignOut();
            #endregion
        }
        #endregion

        #region Test Case for ( SignUp ) using datasource in CSV Format
        [TestMethod, TestCategory("SignUp"), TestCategory("Positive"), TestCategory("CSV")]
        [DataSource(DataSourceCSV, FilePath + "data.csv", "data#csv", DataAccessMethod.Sequential)]
        public void TC03_SignUp()
        {
            #region Read data from datasource
            string email = TestContext.DataRow["email"].ToString();
            string firstName = TestContext.DataRow["firstName"].ToString();
            string lastName = TestContext.DataRow["lastName"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string address = TestContext.DataRow["address"].ToString();
            string city = TestContext.DataRow["city"].ToString();
            string state = TestContext.DataRow["state"].ToString();
            string postalCode = TestContext.DataRow["postalCode"].ToString();
            string country = TestContext.DataRow["country"].ToString();
            string mobileNo = TestContext.DataRow["mobileNo"].ToString();
            string addressForFuture = TestContext.DataRow["addressForFuture"].ToString();
            #endregion

            #region This code is use to get unique email every time 
            string emailBeforeChar = email.Substring(0, email.IndexOf("@"));
            string emailAfterChar = email.Substring(email.IndexOf("@") + 1);
            email = emailBeforeChar + DateTime.Now.Ticks.ToString() + "@" +  emailAfterChar;
            #endregion

            #region Method calling
            signInSignUpPage.SignUp(email, firstName, lastName, password, address, city, state, postalCode, country, mobileNo, addressForFuture);
            signInSignUpPage.SignOut();
            #endregion
        }
        #endregion

        #region Test Case for ( SignUp ) using MSSQL as datasource 
        [TestMethod, TestCategory("SignUp"), TestCategory("Positive"), TestCategory("MSSQL")]
        [DataSource(DataSourceMSSQL, ConnectionString , "SignUp", DataAccessMethod.Sequential)]
        public void TC04_SignUp()
        {
            #region Read data from datasource
            string email = TestContext.DataRow["email"].ToString();
            string firstName = TestContext.DataRow["firstName"].ToString();
            string lastName = TestContext.DataRow["lastName"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string address = TestContext.DataRow["address"].ToString();
            string city = TestContext.DataRow["city"].ToString();
            string state = TestContext.DataRow["state"].ToString();
            string postalCode = TestContext.DataRow["postalCode"].ToString();
            string country = TestContext.DataRow["country"].ToString();
            string mobileNo = TestContext.DataRow["mobileNo"].ToString();
            string addressForFuture = TestContext.DataRow["addressForFuture"].ToString();
            #endregion

            #region This code is use to get unique email every time 
            string emailBeforeChar = email.Substring(0, email.IndexOf("@"));
            string emailAfterChar = email.Substring(email.IndexOf("@") + 1);
            email = emailBeforeChar + DateTime.Now.Ticks.ToString() + "@" + emailAfterChar;
            #endregion

            #region Method calling
            signInSignUpPage.SignUp(email, firstName, lastName, password, address, city, state, postalCode, country, mobileNo, addressForFuture);
            signInSignUpPage.SignOut();
            #endregion
        }
        #endregion

        #region Test Case for ( SignIn ) using datasource in Excel Format
        [TestMethod, TestCategory("SignIn"), TestCategory("Positive"), TestCategory("Excel")]
        [DynamicData(nameof(ReadExcel),DynamicDataSourceType.Method)]
        public void TC05_SignIn(string email, string password)
        {
            //#region Read data from datasource
            //string email = TestContext.DataRow["email"].ToString();
            //string password = TestContext.DataRow["password"].ToString();
            //#endregion

            #region Method calling
            signInSignUpPage.SignIn(email, password);
            signInSignUpPage.SignOut();

            //"//*[@id='homefeatured']/li[2]/div/div[1]/div/a[1]/img"
            #endregion
        }
        #endregion

        public static IEnumerable <object[]> ReadExcel()
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo("data.xlsx")))
            {
                //get the first worksheet in the workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                int rowCount = worksheet.Dimension.End.Row;     //get row count
                for (int row = 2; row <= rowCount; row++)
                {
                    yield return new object[] 
                    {
                        worksheet.Cells[row, 1].Value?.ToString().Trim(), // Email
                        worksheet.Cells[row, 2].Value?.ToString().Trim() // Password
                    };
                }
            }
        }

        #region Test Case for INSERTING Data into SignIn Table using MSSQL
        [TestMethod, TestCategory("Insert"), TestCategory("Positive"), TestCategory("MSSQL")]
        [DataSource(DataSourceMSSQL, ConnectionString, "SignIn", DataAccessMethod.Sequential)]
        public void TC06_InsertIntoSignInTable()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[SignIn] (email,password) VALUES ('sampleUsingQuery','sampleUsingQuery')", con);
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region Test Case for DELETING Data From SignIn Table using MSSQL
        [TestMethod, TestCategory("Delete"), TestCategory("Positive"), TestCategory("MSSQL")]
        [DataSource(DataSourceMSSQL, ConnectionString, "SignIn", DataAccessMethod.Sequential)]
        public void TC07_DeleteFromSignInTable()
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[SignIn] WHERE Id= '1'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region Test Case for UPDATING Data For SignIn Table using MSSQL
        [TestMethod, TestCategory("Update"), TestCategory("Positive"), TestCategory("MSSQL")]
        [DataSource(DataSourceMSSQL, ConnectionString, "SignIn", DataAccessMethod.Sequential)]
        public void TC08_UpdateFromSignInTable()
        {
            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[SignIn] SET email = 'updatedsample@gmail.com' , password = 'updatedsample123' WHERE Id= '2'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
    }
}