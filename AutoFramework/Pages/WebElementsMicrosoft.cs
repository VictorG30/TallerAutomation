namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class WebElementsMicrosoft
    {
        public WebElementsMicrosoft()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "uhf-g-nav")]
        public IWebElement Menu { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='shellmenu_2']")]
        public IWebElement MenuWindows { get; set; }


    }
}
