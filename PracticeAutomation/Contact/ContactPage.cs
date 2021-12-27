using AutomationDemo.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.PracticeAutomation.Contact
{
    public partial class ContactPage : CorePage
    {
        public void ContactForm(string email, string orderRef, string message , string filePath)
        {
            driver.FindElement(contactLinkButton).Click();

            SelectElement selectSubjectHeading = new SelectElement(driver.FindElement(By.Id("id_contact")));
            selectSubjectHeading.SelectByText("Customer service");
            driver.FindElement(emailTxt).SendKeys(email);
            driver.FindElement(orderRefTxt).SendKeys(orderRef);
            driver.FindElement(filePathTxt).SendKeys(filePath);
            driver.FindElement(messageTxt).SendKeys(message);

            driver.FindElement(submitButton).Click();
        }
    }
}
