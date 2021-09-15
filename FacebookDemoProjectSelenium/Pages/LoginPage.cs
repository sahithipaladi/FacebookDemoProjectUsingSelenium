/*
 * Project: Using Facebook Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   09/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace FacebookDemoProjectSelenium.Pages
{

    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }



        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement email;



        [FindsBy(How = How.Id, Using = "pass")]
        [CacheLookup]
        public IWebElement password;



        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement loginButton;

    }
}

