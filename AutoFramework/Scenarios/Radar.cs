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

    public class Radar
    {

        LoginPage User;



        public Radar()
        {

        }

        [OneTimeSetUp]
        public void Initialize()
        {


            DriversBrowsers WD = new DriverChrome();
            DriversBrowsers.SelectDriver(WD);
            User = new LoginPage();


        }

        [Test, Order(1)]

        public void T1_Login()
        {

            User.Login();



        }

        

        [OneTimeTearDown]
        public void CleanUp()
        {
            //Driver.driver.Quit();
        }
    }
}