using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.Core
{
    public class CorePage
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
