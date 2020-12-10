namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class WebElementsWindows
    {
        public WebElementsWindows()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Windows 10']")]
        public IWebElement MenuWindows10 { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Windows 10']")]
        public IWebElement DDWindows10 { get; set; }


    }
}
