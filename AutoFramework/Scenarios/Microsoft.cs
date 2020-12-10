namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using AutoFramework.Pages;
    using OpenQA.Selenium.Support.UI;
    using System;
    using System.Linq;

    public class Microsoft
    {
        
        WebElements Elements;
        WebDriverWait wait;
        ActionsMicrosoft AM;
        public Microsoft()
        {

        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
             wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(60));

            Elements = new WebElements();
            AM = new ActionsMicrosoft();

        }

        [Test]
        public void ValidateMenu()
        {

            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.ElementToBeClickable((Elements.MenuMicrosoft)));

            

            AM.ValideElementsByText(Elements.MenuMicrosoft, By.ClassName("single-link"), ConfigMicrosoft.Words);



        }


        
        [OneTimeTearDown]
        public void CleanUp()
        {
            //Driver.driver.Quit();
        }
    }
}