using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.PracticeAutomation.ProductPurchase
{
    public partial class ProductPurchasePage
    {
        By moveToProduct = By.XPath("/html/body/div/div[2]/div/div[2]/div/div[1]/ul[1]/li[1]/div/div[1]/div/a[1]/img");
        By moreButton = By.XPath("/html/body/div/div[2]/div/div[2]/div/div[1]/ul[1]/li[1]/div/div[2]/div[2]/a[2]");
        By quantityTxt = By.Id("quantity_wanted");
        By sizeSelect = By.Id("group_1");
        By orangeColorButton = By.Name("Orange");
        By blueColorButton = By.Name("Blue");
        By addToCartButton = By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div/div[4]/form/div/div[3]/div[1]/p/button/span");
    }
}