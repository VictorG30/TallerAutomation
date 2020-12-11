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

    public  class ActionsWindows : ActionsMicrosoft
    {
        WebDriverWait wait;
        WebElementsWindows ElementsWindows;

            public ActionsWindows()
        {
            wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(60));
            ElementsWindows = new WebElementsWindows();
        }

              
        
        public void SearchAny(String Texto)
        {


            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.ElementToBeClickable((ElementsWindows.BtnSearch))).Click();

            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.ElementToBeClickable((ElementsWindows.TxtSearch))).Click();

            ElementsWindows.TxtSearch.SendKeys(Texto);
            ElementsWindows.BtnSearch.Click();


            Action.TryCloseModal();

        }


    }
}
