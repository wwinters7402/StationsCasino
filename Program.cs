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
            driver.FindElement(By.Id("pass")).SendKeys("Ethan@7402");
            driver.FindElement(By.Name("login")).Click();

           

            driver.FindElement(By.ClassName("ijkhr0an pnx7fd3z sgqwj88q hzruof5a pmk7jnqg rnx8an3s fcg2cn6m")).SendKeys("Lacie Winters");

            

            



        }
    }
}
