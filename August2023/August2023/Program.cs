
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open the browser

IWebDriver driver = new ChromeDriver();

//Launch turnup portal and navigate to login

driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
driver.Manage().Window.Maximize();

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

IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (hellohari.Text=="Hello hari!")
{
    Console.WriteLine("user logged in successfully");
    
}
else
{
    Console.WriteLine("user hasn't logged in successfully");
}
