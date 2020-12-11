namespace AutoFramework
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;

    public abstract class DriversBrowsers
    {


        public abstract void InitDriver();


        public static void SelectDriver(DriversBrowsers Driver)
        {
            Driver.InitDriver();
        }

    }
}
