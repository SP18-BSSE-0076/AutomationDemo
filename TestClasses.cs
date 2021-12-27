using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationDemo
{
    public class TestClasses
    {
        public class SignInSignUpClass : BaseClass
        {
            /// <summary>
            /// this method is use to login from externel resource
            /// </summary>
            public void SignIn( string email , string password)
            {
                driver.FindElement(By.ClassName("login")).Click();
                driver.FindElement(By.Id("email")).SendKeys(email);
                driver.FindElement(By.Name("passwd")).SendKeys(password);
                driver.FindElement(By.Name("SubmitLogin")).Click();

                string actual = driver.FindElement(By.ClassName("info-account")).Text;
                string expected = "Welcome to your account. Here you can manage all of your personal information and orders";
                
                Assert.AreEqual(expected, actual);
                
                if (actual == expected)
                {
                    MessageBox.Show("Login Successfull");
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }

            public void SignOut()
            {
                driver.FindElement(By.ClassName("logout")).Click();
            }

            public void SignUp(string email, string firstName , string lastName, string password, string address , string city , string postalCode ,string mobileNo , string addressForFuture)
            {
                driver.FindElement(By.ClassName("login")).Click();
                driver.FindElement(By.Id("email_create")).SendKeys(email);
                driver.FindElement(By.Name("SubmitCreate")).Click();

                //explicit wait
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("id_gender1")));

                driver.FindElement(By.Id("id_gender1")).Click();
                driver.FindElement(By.Name("customer_firstname")).SendKeys(firstName);
                driver.FindElement(By.Name("customer_lastname")).SendKeys(lastName);
                driver.FindElement(By.Name("passwd")).SendKeys(password);

                driver.FindElement(By.Name("firstname")).SendKeys(firstName);
                driver.FindElement(By.Name("lastname")).SendKeys(lastName);
                driver.FindElement(By.Name("address1")).SendKeys(address);
                driver.FindElement(By.Name("city")).SendKeys(city);

                //state
                SelectElement selectState = new SelectElement(driver.FindElement(By.Name("id_state")));
                selectState.SelectByText("Texas");

                driver.FindElement(By.Name("postcode")).SendKeys(postalCode);

                SelectElement selectCountry = new SelectElement(driver.FindElement(By.Name("id_country")));
                selectCountry.SelectByText("United States");

                driver.FindElement(By.Name("phone_mobile")).SendKeys(mobileNo);

                driver.FindElement(By.Name("alias")).Clear();
                driver.FindElement(By.Name("alias")).SendKeys(addressForFuture);
                
                driver.FindElement(By.Name("submitAccount")).Click();
            }
        }

        public class Contact : BaseClass
        {
            public void ContactForm(string email , string orderRef , string message , string filePath)
            {
                driver.FindElement(By.Id("contact-link")).Click();
                
                SelectElement selectSubjectHeading = new SelectElement(driver.FindElement(By.Id("id_contact")));
                selectSubjectHeading.SelectByText("Customer service");
                driver.FindElement(By.Id("email")).SendKeys(email);
                driver.FindElement(By.Id("id_order")).SendKeys(orderRef);
                driver.FindElement(By.Id("fileUpload")).SendKeys(filePath);
                driver.FindElement(By.Id("message")).SendKeys(message);

                driver.FindElement(By.Id("submitMessage")).Click();
            }
        }

        public class ProductSearch : BaseClass
        {
            public void SearchItem(string search)
            {
                driver.FindElement(By.Id("search_query_top")).SendKeys(search);
                driver.FindElement(By.Name("submit_search")).Click();
            }
        }

        public class ProductPurchaseing : BaseClass
        {
            public void AddItemToCart(string quanity)
            {
                //driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div[1]/ul[1]/li[1]/div/div[1]/div/a[1]/img")).Click();

                //explicit wait
                //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                //IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/div/div/div[3]/form/div/div[2]/p[1]/input")));
                //Thread.Sleep(5000);

                driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div[1]/ul[1]/li[1]/div/div[2]/div[2]/a[2]/span")).Click();
                driver.FindElement(By.Id("quantity_wanted")).SendKeys(quanity);
                //driver.FindElement(By.ClassName("icon-plus")).Click();
                //driver.FindElement(By.ClassName("icon-plus")).Click();

                //SelectElement selectSize = new SelectElement(driver.FindElement(By.Id("group_1")));
                //selectSize.SelectByText("M");

                //driver.FindElement(By.Name("Blue")).Click();

                //driver.FindElement(By.Name("Submit")).Click();
            }
        }

        public class BaseClass
        {
            public static IWebDriver driver;
            public static IWebDriver SeleniumInitialization(string browser, string url)
            {
                if (browser == "Chrome")
                {
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArguments(new List<string>() { "start-maximized" });
                    driver = new ChromeDriver(chromeOptions);
                    driver.Url = url;
                }
                else if (browser == "Edge")
                {
                    EdgeOptions edgeOptions = new EdgeOptions();
                    edgeOptions.AddArguments(new List<string>() { "start-maximized" });
                    driver = new EdgeDriver(edgeOptions);
                    driver.Url = url;
                }
                else if (browser == "Firefox")
                {
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    firefoxOptions.AddArguments(new List<string>() { "start-maximized" });
                    driver = new FirefoxDriver(firefoxOptions);
                    driver.Url = url;
                }
                return driver;
            }
        }
    }
}
