using AutomationDemo.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.PracticeAutomation.ProductPurchase
{
    public partial class ProductPurchasePage : CorePage
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
}
