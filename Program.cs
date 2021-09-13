using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Stations

{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();


            driver.Manage().Window.Maximize();
           
            driver.Navigate().GoToUrl("https://www.sclv.com/Account/Login?_ga=2.132721550.1425800835.1631491623-287469639.1631491623");

            driver.FindElement(By.CssSelector("#maincontent_0_pageform_0_loginControl_UserName")).SendKeys("woodrowwinters");

            driver.FindElement(By.XPath("//input[@id='maincontent_0_pageform_0_loginControl_Password']")).SendKeys("Lacie@7402");

            driver.FindElement(By.Id("maincontent_0_pageform_0_loginControl_LoginButton")).Click();

            driver.FindElement(By.Id("maincontent_0_twocolumncontent_1_btnLogout")).Click();

            driver.Close();

            


            
            

            



        }
    }
}
