
using August2023.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private static void Main(string[] args)
    {
        //open the  browser

        IWebDriver driver = new ChromeDriver();

        //login page object initialization and definition

        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        //Home page object initialization and definition

        HomePage homePageObj = new HomePage();
        homePageObj.GoToTMPage(driver);

        //TM page object initialization and definition

        TMPage tmPageObj = new TMPage();
        tmPageObj.CreateTimeRecord(driver);

        tmPageObj.EditTimeRecord(driver);
        tmPageObj.DeleteTimeRecord(driver);


    }
}

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            