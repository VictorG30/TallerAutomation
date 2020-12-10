namespace AutoFramework
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;
    using Pages;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public  class ActionsMicrosoft
    {
        WebDriverWait wait; 

            public ActionsMicrosoft()
        {
            wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(60));
        }


        public void ValideElementsByText(IWebElement Element, By Identify, string[] Words)
        {


        
            var x = Element.FindElements(Identify);

           

            foreach (var element in x)
            {
                var s = element.Text;
                bool hasElement = Words.Contains(s);

                if (hasElement == false)
                {
                    Assert.False(true);
                }
            }
        }        
        
        public void PrintElements(By WebElement, By IdentifyBy)
        {


            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.ElementToBeClickable(WebElement));

            var Element = Driver.driver.FindElement(WebElement);
            var Elements = Element.FindElements(IdentifyBy);

            

            foreach (var ele in Elements)
            {
                var texto = ele.Text;
                
                TestContext.Out.WriteLine(texto);
                


            }
        }

        public void PrintLastWord(By WebElement, By IdentifyBy)
        {


            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.ElementToBeClickable(WebElement));

            var Element = Driver.driver.FindElement(WebElement);
            var Elements = Element.FindElements(IdentifyBy);



            foreach (var ele in Elements)
            {
                var texto = ele.Text;
                string last = texto.Split(' ').LastOrDefault();
                //TestContext.Out.WriteLine(texto);
                TestContext.Out.WriteLine(last.Trim());

                ConfigWindows.Prices.Add(last.Trim());




            }
        }
    }
}
