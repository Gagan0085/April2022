using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April2022.utilities
{
    internal class Wait
    {
        public static void WaitTobeClickable(IWebDriver driver, string locator, string locatervalue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 2));

            if (locator == "XPath")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("")));
            }
            if (locator == "Id")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("")));
            }
            if (locator == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("")));
            }
        }

        public static void WaitTobeVisible(IWebDriver driver, string locator, string locatervalue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 2));

            if (locator == "XPath")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("")));
            }
            if (locator == "Id")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("")));
            }
            if (locator == "CssSelector")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("")));
            }
        }
    }
}


          


