using August2023.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using August2023.Utilities;

namespace August2023.Tests
{
    [TestFixture]
    public class TM_Tests:CommonDriver 
    {
        [SetUp]
        public void setUpTM()
        {
            driver = new ChromeDriver();

            //login page object initialization and definition

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //Home page object initialization and definition

            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }
        [Test,Order(1)]
        public void createTime_Test()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTimeRecord(driver);
        }
        [Test,Order(2)]
        public void editTime_Test()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTimeRecord(driver, "whatever", "p1");
        }
        [Test,Order(3)]
        public void deleteTime_Test()
        {

            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTimeRecord(driver);

        }
        [TearDown]
        public void closeTestRun()
        {
            driver.Quit();
        }
    }
}
