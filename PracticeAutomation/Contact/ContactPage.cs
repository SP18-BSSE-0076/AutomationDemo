//using AutoItX3Lib;
using AutomationDemo.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationDemo.PracticeAutomation.Contact
{
    public partial class ContactPage : CorePage
    {
        public void ContactForm(string subjectHeading, string email, string orderRef, string message, string filePath)
        {
            driver.FindElement(contactLinkButton).Click();

            SelectElement selectSubjectHeading = new SelectElement(driver.FindElement(By.Id("id_contact")));
            selectSubjectHeading.SelectByText(subjectHeading);
            driver.FindElement(emailTxt).SendKeys(email);
            driver.FindElement(orderRefTxt).SendKeys(orderRef);

            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(filePathTxt)).Click().Perform();

            //AutoItX3 auto = new AutoItX3();
            //auto.WinWaitActive("Open"); //activate window so that next action happens to window
            //auto.Send(filePath);
            //auto.ControlClick("Open", "", "Button1");

            driver.FindElement(messageTxt).SendKeys(message);

            driver.FindElement(submitButton).Click();
        }
    }
}