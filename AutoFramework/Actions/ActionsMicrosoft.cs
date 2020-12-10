namespace AutoFramework
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using Pages;
    using System;
    using System.Linq;

    public  class ActionsMicrosoft
    {


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
            var Element = Driver.driver.FindElement(WebElement);
            var Elements = Element.FindElements(IdentifyBy);

            

            foreach (var ele in Elements)
            {
                var texto = ele.Text;
                Console.Write(texto);


            }
        }
    }
}
