using AutomationDemo.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationDemo.PracticeAutomation.SignInSignUp
{
    public partial class SignInSignUpPage : CorePage
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

        public void SignIn(string email, string password)
        {
            driver.FindElement(loginButton).Click();
            driver.FindElement(emailTxt).SendKeys(email);
            driver.FindElement(passwordTxt).SendKeys(password);
            driver.FindElement(submitButton).Click();

            string actual = driver.FindElement(By.ClassName("info-account")).Text;
            string expected = "Welcome to your account. Here you can manage all of your personal information and orders.";

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
            driver.FindElement(logoutButton).Click();
        }

        public void SignUp(string email, string firstName, string lastName, string password, string address, string city, string postalCode, string mobileNo, string addressForFuture)
        {
            driver.FindElement(loginButton).Click();
            driver.FindElement(signUpEmailCreateTxt).SendKeys(email);
            driver.FindElement(submitCreateButton).Click();

            //explicit wait
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(maleGenderRadio));

            driver.FindElement(maleGenderRadio).Click();
            driver.FindElement(customerFirstNameTxt).SendKeys(firstName);
            driver.FindElement(customerLastNameTxt).SendKeys(lastName);
            driver.FindElement(passwordTxt).SendKeys(password);

            driver.FindElement(firstNameTxt).SendKeys(firstName);
            driver.FindElement(lastNameTxt).SendKeys(lastName);
            driver.FindElement(addressTxt).SendKeys(address);
            driver.FindElement(cityTxt).SendKeys(city);

            //state
            SelectElement selectState = new SelectElement(driver.FindElement(By.Name("id_state")));
            selectState.SelectByText("Texas");

            driver.FindElement(postCodeTxt).SendKeys(postalCode);

            SelectElement selectCountry = new SelectElement(driver.FindElement(By.Name("id_country")));
            selectCountry.SelectByText("United States");

            driver.FindElement(mobileNoTxt).SendKeys(mobileNo);

            driver.FindElement(addressReferenceTxt).Clear();
            driver.FindElement(addressReferenceTxt).SendKeys(addressForFuture);

            driver.FindElement(submitAccountButton).Click();
        }
    }
}