using April2022.Pages;
using April2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace April2022.Tests
{
    [TestFixture]
    [Parallelizable]
    internal class TM_Tests : CommonDriver
    {
        [Test, Order (1)]
        public void CreateTM_Test()
        {
            // Home page object initialzation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TM page object initialzation and definition
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateTM(driver);
        }

        [Test, Order (2)]
        public void EditTM_Test()
        {
            // Home page object initialzation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // Edit TM
            TMPage tMPageObj = new TMPage();
            tMPageObj.EditTM(driver, "bruno");
        }

        [Test, Order (3)]
        public void DeleteTM_Test()
        {
            // Home page object initialzation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // Delete TM
            TMPage tMPageObj = new TMPage();
            tMPageObj.DeleteTM(driver);
        }
    }
}
