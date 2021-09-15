/*
 * Project: Using Facebook Application and checking the modules using selenium
 * Author:  p.sahithi
 * Date :   09/09/2021
 */
using NUnit.Framework;

namespace FacebookDemoProjectSelenium
{

    public class Tests : Base.BaseClass
    {
        [Test, Order(0)]
        public void RegistrationOfFb()
        {
            Registration.RegistrationPage.AssertForNewAccount(driver);

            Registration.RegistrationPage.CreateNewAccount(driver);
        }

        [Test, Order(1)]
        public void InputEmailAndPassword()
        {
            ActionDo.ActionDo.AssertAfterLauching(driver);

            ActionDo.ActionDo.LoginToFacebook(driver);
        }
    }
}
