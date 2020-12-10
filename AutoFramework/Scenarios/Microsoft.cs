namespace AutoFramework
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;
    using Pages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Configuration;

    public class Microsoft
    {
        
        WebElementsMicrosoft ElementsMicrosoft;
        WebElementsWindows ElementsWindows;
        WebDriverWait wait;
        ActionsMicrosoft AM;
        public Microsoft()
        {

        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Action.InitializeDriver();
             wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(60));

            ElementsMicrosoft = new WebElementsMicrosoft();
            ElementsWindows = new WebElementsWindows();
            AM = new ActionsMicrosoft();

        }

        [Test, Order(1)]

        public void ValidateMenu()
        {

            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.ElementToBeClickable((ElementsMicrosoft.Menu)));

            

            AM.ValideElementsByText(ElementsMicrosoft.Menu, By.ClassName("single-link"), ConfigMicrosoft.Words);



        }

        [Test, Order(2)]

        public void PrintElements()
        {
            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.ElementToBeClickable((ElementsMicrosoft.MenuWindows))).Click();

            //ElementsMicrosoft.MenuWindows.Click();

            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.ElementToBeClickable((ElementsWindows.MenuWindows10))).Click();


           //ElementsWindows.MenuWindows10.Click();

            //Actions actions = new Actions(Driver.driver);

            //actions.MoveToElement(ElementsWindows.MenuWindows10).Click().Build();
            //actions.Perform();


            AM.PrintElements(
                By.XPath("//*[@id=\"uhf-g-nav\"]/ul/li[2]/div/ul"),
                By.TagName("li"));





        }



        [OneTimeTearDown]
        public void CleanUp()
        {
            //Driver.driver.Quit();
        }
    }
}