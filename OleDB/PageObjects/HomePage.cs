﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OleDB.PageObjects
{
        class HomePage
        {
            private IWebDriver driver;

            [FindsBy(How = How.Id, Using = "account")]
            [CacheLookup]
            private IWebElement MyAccount { get; set; }

            public HomePage(IWebDriver driver)
            {
                this.driver = driver;
                PageFactory.InitElements(driver, this);
            }

        public void ClickOnMyAccount()
        {
            MyAccount.Click();

        }
    }
}
