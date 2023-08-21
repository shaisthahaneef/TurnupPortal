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

            IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            CreateNewButton.Click();
           


            //select time from dropdown

            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            IWebElement timeTypeCode = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeTypeCode.Click();
            Thread.Sleep(1000);

            //enter code

            IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));
            CodeTextbox.SendKeys("aug");
            Thread.Sleep(1000);

            //enter dscription

            IWebElement DescriptionTextbox = driver.FindElement(By.Id("Description"));
            DescriptionTextbox.SendKeys("month");
            Thread.Sleep(1000);

            //ente price

            IWebElement PriceTexbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            PriceTexbox.SendKeys("12");
            Thread.Sleep(1000);

            //click on save button

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(5000);


            //check if new time record has been created successfully

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

          IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newCode.Text == "aug")
            {
                Console.WriteLine("New time record has been created successfully");

            }

         else
         {
              Console.WriteLine("Time record has not been created");
          }
        }

        public void EditTimeRecord(IWebDriver driver)
        {
            // Code for edit time record



            //click on edit button

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(1000);

            //click on code 

            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.Clear();
            codeTextbox.SendKeys("AUG-I");
            Thread.Sleep(1000);

            //edit description

            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("monthly data");
            Thread.Sleep(1000);

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
            Thread.Sleep(5000);

            //check whether record has been edited

            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotolastpage.Click();


            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newCode.Text == "AUG-I")
            {
                Console.WriteLine("Time record has been edited successfully");

            }

            else

            {
                Console.WriteLine("Time record has not been edited ");
            }

        }


        public void DeleteTimeRecord(IWebDriver driver)
        {
            //click on delete button

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(1000);

            //navigate to pop up window and accept

            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1000);

            //check whether record has been deleted


            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newCode.Text == "AUG-I")
            {
                Console.WriteLine("Time record isn't deleted");

            }

            else

            {
                Console.WriteLine(" Time record has been deleted successfully");
            }


        }

    }
}


