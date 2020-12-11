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

        [FindsBy(How = How.CssSelector, Using = "#store-cart-root > div > div > div > section._3a6I5TkT > div > div > div > div > div > div.item-details > div.item-quantity-price > div.item-price > div > span > span:nth-child(3) > span")]
        public IWebElement Price1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#store-cart-root > div > div > div > section._3LWrsBIG > div > div > div:nth-child(2) > div > span:nth-child(1) > span:nth-child(2) > div > span > span:nth-child(3) > span")]
        public IWebElement Price2 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#store-cart-root > div > div > div > section._3LWrsBIG > div > div > div:nth-child(4) > div > span > span:nth-child(2) > strong > span")]
        public IWebElement Price3 { get; set; }


    }
}
