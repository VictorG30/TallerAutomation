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


            DriversBrowsers WD = new DriverChrome();
            DriversBrowsers.SelectDriver(WD);

            wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(15));
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

            Action.TryCloseModal();



            Action.compararStrings(By.Id("productPrice"), Precio1);



        }

        [Test, Order(5)]

        public void T5_Validate3Prices()
        {
            ElementsWindows.BtnAddCart.Click();

            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("c-progress")));

            Action.CompareStrings(ElementsWindows.Price1, ElementsWindows.Price2, ElementsWindows.Price3);


        }

        [Test, Order(6)]

        public void T6_ValidateTotalAmount()
        {
            Action.SelectDropDown(
                By.XPath("//*[@id=\"store-cart-root\"]/div/div/div/section[1]/div/div/div/div/div/div[2]/div[2]/div[1]/select"),
                "20");

            var PrecioUnit = Action.ConvertToDecimal(ConfigWindows.Prices[0]);
            var total = (PrecioUnit * 20);

            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("c-progress")));

            Action.compararStrings(
                By.XPath("//*[@id=\"store-cart-root\"]/div/div/div/section[2]/div/div/div[2]/div/span/span[2]/strong/span"),
                total.ToString());

        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            //Driver.driver.Quit();
        }
    }
}