using August2023.Pages;
using August2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August2023.Tests
{
    [Parallelizable]
    [TestFixture]                                                                                                       
    public class EmployeeTests: CommonDriver
    {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
        [SetUp]
        public void EmployeesSetup()
        {
            driver = new ChromeDriver();

            //login page object initialization and definition

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //Home page object initialization and definition

            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeesPage(driver);

        }
        [Test, Order(1)]
        public void CreateEmployee_Test()
        {
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.CreateEmployee(driver);
           
        }
        [Test, Order(2)]
        public void EditEmployee_Test()
        {
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.EditEmployee(driver);
        }
        [Test, Order(3)]
        public void DeleteEmployee_Test()
        {
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.DeleteEmployee(driver);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }

}
