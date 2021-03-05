namespace AutoFramework.Pages
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class LoginPage
    {

        
        public LoginPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(), 'Aceptar')]")]
        private IWebElement BtnIniciarSesion { get; set; }
        
        public void Login()
        {
            BtnIniciarSesion.Click();
            Assert.IsTrue(BtnIniciarSesion.Displayed);

        }

    }
}
