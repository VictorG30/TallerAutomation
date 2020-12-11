namespace AutoFramework
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using System;

     class DriverFireFox : DriversBrowsers
    {
  

        public override void InitDriver()
        {
            

            Driver.driver = new FirefoxDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.driver.Manage().Window.Maximize();
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }
    }
}
