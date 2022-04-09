
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace April2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            IWebElement helloHary = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if(helloHary .Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Login failed, test failed.");
            }

        }
    }
}
