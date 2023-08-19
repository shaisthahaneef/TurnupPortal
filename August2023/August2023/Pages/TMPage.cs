using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            //enter code

            IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));
            CodeTextbox.SendKeys("aug");

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
       
        public void EditTimeRecord (IWebDriver driver)
        {
            // Code for edit time record
        }

        public void DeleteTimeRecord (IWebDriver driver)
        {
            // Code for delete time record
        }
    }
}
