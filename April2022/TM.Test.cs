using April2022.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace April2022.Tests
{
    internal class Program
    {
        private static object descriptionTextbox;

        public static object typeCodeDropdown { get; private set; }

        static void Main(string[] args)
        {
            // open brower
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // login page object initialization and definition
            loginPage loginPageObj = new loginPage();
            loginPageObj.LoginSteps(driver);

            // Home page object initialization and definition 
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMpage(driver);

            // TM page object initialization and definition 
            TMPage tMPageObj = new TMPage();
            tMPageObj.Create TM(driver);

            // Edit TM
            tMPageObj.EditTM(driver);

            // Delete TM
            tMPageObj.DeleteTM(driver);
      
         }

     }

}



