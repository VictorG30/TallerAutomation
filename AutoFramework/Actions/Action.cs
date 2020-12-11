namespace AutoFramework
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;
    using Pages;
    using System;
    using System.Linq;
    using System.Threading;

    public static class Action
    {
        static WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(15));
        static WebElementsWindows ElementsWindows = new WebElementsWindows();

        public static void TryCloseModal()
        {
            try
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.ElementToBeClickable((ElementsWindows.BtnCerrarX)));

                ElementsWindows.BtnCerrarX.SafeWaitForDisplayed().Click();
            }
            catch
            {

            }
        }

        public static void compararStrings(By Element, string text2)
        {
            var wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(60));


            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.VisibilityOfAllElementsLocatedBy((Element)));


            string _text2 = text2.Trim().Replace("$", "").Replace(",", "");
            IWebElement Elemento = Driver.driver.FindElement(Element);
            string texto = Elemento.Text.Trim().Replace("$", "").Replace(",", "");

            if (texto != _text2)
            {
                Assert.IsFalse(true);
            }
            else
            {
                Assert.IsTrue(true);
            }


        }

        public static string GetTextElemt(By Element)
        {

            IWebElement Elemento = Driver.driver.FindElement(Element);
            string texto = Elemento.Text;

            //string texto = Elemento.Text;
            return texto;


        }

        public static string GetTextElemt(IWebElement Element)
        {

            //IWebElement Elemento = Driver.driver.FindElement(Element);
            string texto = Element.Text;

            //string texto = Elemento.Text;
            return texto;


        }

        public static void CompareStrings(IWebElement Element1, IWebElement Element2, IWebElement Element3)
        {

            var str1 = Action.GetTextElemt(Element1);
            var str2 = Action.GetTextElemt(Element2);
            var str3 = Action.GetTextElemt(Element3);

            if (String.Compare(str1, str2) == 0 &&
                String.Compare(str2, str3) == 0)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.False(true);

            }


        }

        public static void SelectDropDown(By Element, string Value)
        {

            var ElementDD = Driver.driver.FindElement(Element);
            new SelectElement(ElementDD).SelectByValue(Value);
        }

        public static decimal ConvertToDecimal(String Number)
        {

            var x = Number;
            var y = x.Replace("$", "").Replace(",", "");
            var num = Convert.ToDecimal(y);
            

            return num;
        }

        public static IWebElement SafeWaitForDisplayed(this IWebElement webElement)
        {

            var w = new DefaultWait<IWebElement>(webElement);
            w.Timeout = TimeSpan.FromSeconds(30);

            w.IgnoreExceptionTypes(
                typeof(NoSuchElementException),
                typeof(StaleElementReferenceException),
                typeof(System.Reflection.TargetInvocationException)
                );

            return w.Until(ctx =>
            {
                var elem = webElement;
                if (elem.Displayed)
                {
                    Thread.Sleep(1000);
                    return elem;
                }
                else
                    return null;
            });

            //Thread.Sleep(100);


        }





    }
}
