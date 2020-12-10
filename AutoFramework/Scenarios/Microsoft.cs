namespace AutoFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using AutoFramework.Pages;

    public class Microsoft
    {
        
        WebElements Elements;

        public Microsoft()
        {

        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();

            Elements = new WebElements();

        }

        [Test]
        public void Microsoft1()
        {
            Elements.MenuMicrosoft.Click();

        }


        
        [OneTimeTearDown]
        public void CleanUp()
        {
            //Driver.driver.Quit();
        }
    }
}