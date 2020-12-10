namespace AutoFramework
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using Pages;
    using System.Linq;

    public  class ActionsMicrosoft
    {


        public void ValideElementsByText(IWebElement Element, By Identify, string[] Words)
        {


            //var x = Element.FindElements(By.ClassName("single-link"));
            var x = Element.FindElements(Identify);

            //string[] Words = { "Microsoft 365", "Office", "Windows", "Surface", "Xbox", "Deals", "Support" };

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
    }
}
