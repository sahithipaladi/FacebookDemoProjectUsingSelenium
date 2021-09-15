/*
 * Project: Using Facebook Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   09/09/2021
 */
using FacebookDemoProjectSelenium.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace FacebookDemoProjectSelenium.ActionDo

{
    public class ActionDo
    {
        public static LoginPage login;
        public static void AssertAfterLauching(IWebDriver driver)
        {
            string title1 = "Facebook - లాగిన్ లేదా సైన్ అప్";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void LoginToFacebook(IWebDriver driver)
        {
            login = new LoginPage(driver);

            login.email.SendKeys("kupp17207.cs@rmkec.ac.in");
            System.Threading.Thread.Sleep(1000);



            login.password.SendKeys("likitha00");
            System.Threading.Thread.Sleep(1000);



            login.loginButton.Click();
            System.Threading.Thread.Sleep(9000);
        }
    }
}









