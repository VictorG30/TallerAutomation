namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class WebElementsMicrosoft
    {
        public string Precio1;
        public string Precio2;
        public string Precio3;
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
