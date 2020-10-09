using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Selenium
{
    class Program
    {
        static void Main(string[] args)
        {

            var username = "sachithj@99x.io";
            var password = "";
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://app.mihcm.com");
            driver.FindElementByXPath("//*[@id='microsoftSignin']/span").Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 180));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("i0116"))).SendKeys(username);
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("idSIButton9"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("i0118"))).SendKeys(password);
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("idSIButton9"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/aside/div/nav/ul/li"))).Click();

            Console.WriteLine("Hello World!");


        }
    }

}
