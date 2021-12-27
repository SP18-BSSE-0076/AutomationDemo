using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.PracticeAutomation.Contact
{
    public partial class ContactPage
    {
        //Contact Form Locators
        By contactLinkButton = By.Id("contact-link");
        By emailTxt = By.Id("email");
        By orderRefTxt = By.Id("id_order");
        By filePathTxt = By.Id("fileUpload");
        By messageTxt = By.Id("message");
        By submitButton = By.Id("submitMessage");
    }
}
