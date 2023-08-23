using August2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace August2023.Pages
{
    public class TMPage
    {
        public void CreateTimeRecord( IWebDriver driver )
        {
            //Create a new time record



            //click on create new button

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"container\"]/p/a", 5);

            IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            CreateNewButton.Click();
           


            //select time from dropdown

            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            IWebElement timeTypeCode = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeTypeCode.Click();
            

            //enter code

            IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));
            CodeTextbox.SendKeys("aug2");
            

            //enter dscription

            IWebElement DescriptionTextbox = driver.FindElement(By.Id("Description"));
            DescriptionTextbox.SendKeys("month");
            

            //ente price

            IWebElement PriceTexbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            PriceTexbox.SendKeys("12");
           

            //click on save button

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

           

            Thread.Sleep(5000);


            //check if new time record has been created successfully

           

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(newCode.Text == "aug2","Time record has not been created");

         
        }

        public void EditTimeRecord(IWebDriver driver)
        {
            // Code for edit time record

            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 5);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            //click on edit button

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            

            //click on code 

            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.Clear();
            codeTextbox.SendKeys("AUG-I");
           

            //edit description

            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("monthly data");
           

            //edit price

            IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            overlappingTag.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));


            priceTextbox.Clear();
            overlappingTag.Click();
            priceTextbox.SendKeys("1200");

            //click on save button

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span",5);

            //check whether record has been edited

            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotolastpage.Click();


            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(newCode.Text== "AUG-I", "Time record has not been edited ");


        }


        public void DeleteTimeRecord(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 7);
            Thread.Sleep(5000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            // check the code of the last element

            IWebElement gotolastEnteredData = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            string lastEnteredElement = gotolastEnteredData.Text;

            //click on delete button

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            

            //navigate to pop up window and accept

            driver.SwitchTo().Alert().Accept();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 5);
            Thread.Sleep(5000);

            //check whether record has been deleted


            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newCode.Text != lastEnteredElement , "Time record isn't deleted");

            


        }

    }
}


