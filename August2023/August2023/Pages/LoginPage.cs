using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August2023.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver) 
        {
            driver.Manage().Window.Maximize();

            //Launch turnup portal and navigate to login

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //identify username textbox and enter valid username

            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            //identify password textbox and enter valid password

            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            //identify login button and click on theb button

            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();

            //check if user has logged in successfully

           // IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
           // if (hellohari.Text == "Hello hari!")
            //{
              //  Console.WriteLine("user logged in successfully");

            //}
            //else
            //{
            //    Console.WriteLine("user hasn't logged in successfully");
          //  }
        }
       

    }
}
