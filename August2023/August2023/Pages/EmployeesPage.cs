using August2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August2023.Pages
{
    public class EmployeesPage
    {
        public void CreateEmployee(IWebDriver driver)
        {

            //Click on create new button

            Wait.WaitToBeClickable(driver, "xPath", "//*[@id=\"container\"]/p/a", 5);
            Thread.Sleep(2000);

            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            //click on name textbox

            IWebElement nameTextbox = driver.FindElement(By.Id("Name"));
            nameTextbox.SendKeys("Sha");

            //click on username textbox

            IWebElement usernameTextbox = driver.FindElement(By.Id("Username"));
            usernameTextbox.SendKeys("shai");

            //click on edit contact texbox

            IWebElement contactTextbox = driver.FindElement(By.Id("ContactDisplay"));
            contactTextbox.SendKeys("aaa");

            //click on password

            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("1234");

            //click on re type password

            IWebElement retypePasswordTextbox = driver.FindElement(By.Id("RetypePassword"));
            retypePasswordTextbox.SendKeys("1234");

            //click on vehicle textbox

            IWebElement vehicleTextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicleTextbox.SendKeys("i10");

            //click on groups
            IWebElement groupsTextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            groupsTextbox.Click();

            Thread.Sleep(2000);

            IWebElement groupsSelect = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[3]"));
            groupsSelect.Click();

            //click on save button

            Wait.WaitToBeClickable(driver, "Id", "SaveButton", 5);

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            //click on back to list

            IWebElement backToList = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToList.Click();

            //Click on go to last page button
            Thread.Sleep(5000);
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"usersGrid\"]/div[4]/a[4]/span", 5);

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();


            //check if new time record has been created successfully


            IWebElement name = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(3000);

            Assert.That(name.Text == "Sha", "Employee record has not been created");


        }

        public void EditEmployee(IWebDriver driver)
        {
            Thread.Sleep(2000);
            //Click on edit button
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            editButton.Click();

            //click on name textbox
            IWebElement nameTextbox = driver.FindElement(By.Id("Name"));
            nameTextbox.Clear();
            nameTextbox.SendKeys("Shani");

            //click on username textbox
            IWebElement usernameTextbox = driver.FindElement(By.Id("Username"));
            usernameTextbox.Clear();
            usernameTextbox.SendKeys("shani123");

            //click on contact textbox
            IWebElement contactTextbox = driver.FindElement(By.Id("ContactDisplay"));
            contactTextbox.Clear();
            contactTextbox.SendKeys("sydney");

            //click on password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.Clear();
            passwordTextbox.SendKeys("S@s123456");

            //click on retype password
            IWebElement retypePasswordTextbox = driver.FindElement(By.Id("RetypePassword"));
            retypePasswordTextbox.Clear();
            retypePasswordTextbox.SendKeys("S@s123456");
           

            //click on isadmin

            //click on vehicle
            IWebElement vehicleTextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicleTextbox.Clear();
            vehicleTextbox.SendKeys("i1110");
            Thread.Sleep(2000);

            //click on groups
            //IWebElement closeButton = driver.FindElement(By.XPath("//*[@id=\"groupList_taglist\"]/li/span[2]"));
         // closeButton.Click();
       //    IWebElement groupsTextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
       //    groupsTextbox.Click();
       //     Thread.Sleep(2000);
        //  IWebElement groupsSelect = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[6]"));
        //  groupsSelect.Click();

            //click on save button
            Wait.WaitToBeClickable(driver, "Id", "SaveButton", 5);
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            //click on back to list
            IWebElement backToList = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToList.Click();


          //Click on go to last page button
            Thread.Sleep(5000);
       //    Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"usersGrid\"]/div[4]/a[4]/span", 5);
       //   IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
       //     goToLastPageButton.Click();

            //check if new Employee record has been edited successfully
            IWebElement name = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(3000);
            Assert.That(name.Text == "Shani", "Time record has not been edited");

        }

        public void DeleteEmployee(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "XPath", " //*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 7);

            // check the last element

            IWebElement gotolastEnteredData = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            string lastEnteredElement = gotolastEnteredData.Text;
           
            //click on delete button

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            deleteButton.Click();


            //navigate to pop up window and accept

            driver.SwitchTo().Alert().Accept();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 5);
            Thread.Sleep(5000);

            //check whether record has been deleted


            IWebElement name = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(name.Text != lastEnteredElement, "Employee record isn't deleted");

        }

    }
}
