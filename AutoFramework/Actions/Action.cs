namespace AutoFramework
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using Pages;
    using System.Linq;

    public  class Action
    {
        public static void InitializeDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();

            chromeOptions.AddArgument(@"load-extension=C:\Users\VictorGarcia\AppData\Local\Google\Chrome\User Data\Default\Extensions\ndgimibanhlabgdgjcpbbndiehljcpfh\2.0.7_0");


            Driver.driver = new ChromeDriver(chromeOptions);
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.driver.Manage().Window.Maximize();
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }


    }
}
