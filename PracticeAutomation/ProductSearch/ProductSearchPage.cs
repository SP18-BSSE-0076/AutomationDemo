using AutomationDemo.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.PracticeAutomation.ProductSearch
{
    public partial class ProductSearchPage : CorePage
    {
        public void SearchItem(string search)
        {
            driver.FindElement(searchTxt).SendKeys(search);
            driver.FindElement(submitButton).Click();
        }
    }
}
