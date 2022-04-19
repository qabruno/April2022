using April2022.Pages;
using April2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April2022.Tests
{
    [TestFixture]
    [Parallelizable]
    internal class Employee_Tests : CommonDriver
    {
        [Test, Order(1)]
        public void CreateEmployee_Test()
        {
            // Home page object initialzation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            // Employ page object initialzation and definition
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.CreateEmployee(driver);
        }

        [Test, Order(2)]
        public void EditEmployee_Test()
        {
            // Home page object initialzation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            // Edit employee
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.EditEmployee(driver);
        }

        [Test, Order(3)]
        public void DeleteEmployee_Test()
        {
            // Home page object initialzation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            // Delete employee
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.DeleteEmployee(driver);
        }
    }
}
