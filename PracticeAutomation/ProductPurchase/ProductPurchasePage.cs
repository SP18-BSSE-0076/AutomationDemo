using AutomationDemo.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.PracticeAutomation.ProductPurchase
{
    public partial class ProductPurchasePage : CorePage
    {
        public By selectColor(string color)
        {
            if (color == "Blue")
            {
                return blueColorButton;
            }
            else
            {
                return orangeColorButton;
            }
        }

        public void AddItemToCart(string quanity , string size , string color )
        {
            
            Actions action = new Actions(driver);

            action.MoveToElement(driver.FindElement(moveToProduct)).Perform();
            driver.FindElement(moreButton).Click();

            driver.FindElement(quantityTxt).Clear();
            driver.FindElement(quantityTxt).SendKeys(quanity);

            SelectElement selectSize = new SelectElement(driver.FindElement(sizeSelect));
            selectSize.SelectByText(size);

            driver.FindElement(selectColor(color)).Click();

            driver.FindElement(addToCartButton).Click();
        }
    }
}
