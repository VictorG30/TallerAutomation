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
        ActionsMicrosoft AMicrosoft;
        ActionsWindows ActWind;

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
            AMicrosoft = new ActionsMicrosoft();
            ActWind = new ActionsWindows();

        }

        [Test, Order(1)]

        public void T1_ValidateMenu()
        {

            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.ElementToBeClickable((ElementsMicrosoft.Menu)));



            AMicrosoft.ValideElementsByText(ElementsMicrosoft.Menu, By.ClassName("single-link"), ConfigMicrosoft.Words);



        }

        [Test, Order(2)]

        public void T2_PrintElements()
        {
            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.ElementToBeClickable((ElementsMicrosoft.MenuWindows))).Click();

    
            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.ElementToBeClickable((ElementsWindows.MenuWindows10))).Click();




            AMicrosoft.PrintElements(
                By.XPath("//*[@id=\"uhf-g-nav\"]/ul/li[2]/div/ul"),
                By.TagName("li"));


        }

        [Test, Order(3)]

        public void T3_PrintPrices()
        {

            ActWind.SearchAny("Visual Studio");

            ActWind.PrintLastWord(
                By.XPath("//*[@id=\"coreui-productplacement-30l7ywa\"]/div[3]/div/div/ul"),
                By.TagName("li"));




        }

        [Test, Order(4)]

        public void T4_ValidatePrice()
        {
            var Precio1 = ConfigWindows.Prices[0];
            ElementsWindows.CardVSPro.Click();

            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.ElementToBeClickable((ElementsWindows.BtnCerrarX)));

            ElementsWindows.BtnCerrarX.Click();


            Action.compararStrings(By.Id("productPrice"), Precio1);



        }


            [OneTimeTearDown]
        public void CleanUp()
        {
            //Driver.driver.Quit();
        }
    }
}