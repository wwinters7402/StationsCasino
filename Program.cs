using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FaceBook_Logon_Negative
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();


            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.facebook.com");

            driver.FindElement(By.Id("email")).SendKeys("woodrowwinter7402@gmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("Ethan@7403");
            driver.FindElement(By.Name("login")).Click();

            

            



        }
    }
}
