namespace AutoFramework
{
    using OpenQA.Selenium.Chrome;
    using Pages;

    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }


    }
}
