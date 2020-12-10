namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class WebElements
    {
        public WebElements()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "uhf-g-nav")]
        public IWebElement MenuMicrosoft { get; set; }


    }
}
