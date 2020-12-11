namespace AutoFramework
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;

     class DriverChrome : DriversBrowsers
    {
  

        public override void InitDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();

            //chromeOptions.AddArgument(@"load-extension=C:\Users\VictorGarcia\AppData\Local\Google\Chrome\User Data\Default\Extensions\ndgimibanhlabgdgjcpbbndiehljcpfh\2.0.8_0");


            Driver.driver = new ChromeDriver(chromeOptions);
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.driver.Manage().Window.Maximize();
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }
    }
}
