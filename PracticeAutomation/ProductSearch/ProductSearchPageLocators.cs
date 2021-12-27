using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.PracticeAutomation.ProductSearch
{
    public partial class ProductSearchPage
    {
        By searchTxt = By.Id("search_query_top");
        By submitButton = By.Name("submit_search");
    }
}