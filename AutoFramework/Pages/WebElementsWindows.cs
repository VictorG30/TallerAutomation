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
        
        [FindsBy(How = How.XPath, Using = "//button[@id='search']")]
        public IWebElement BtnSearch { get; set; }
                
        [FindsBy(How = How.XPath, Using = "//input[@id='cli_shellHeaderSearchInput']")]
        public IWebElement TxtSearch { get; set; }
                        
        [FindsBy(How = How.CssSelector, Using = "#R1MarketRedirect-1 > button")]
        public IWebElement BtnCerrarX { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[contains(@title,'Visual Studio Professional Subscription')]")]
        public IWebElement CardVSPro { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//button[@id='buttonPanel_AddToCartButton']")]
        public IWebElement BtnAddCart { get; set; }


    }
}
