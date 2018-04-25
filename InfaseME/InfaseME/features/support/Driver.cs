using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace InfaseME.features.support
{
    public class Driver
    {
        //Difine an Instanse for the driver
        public static IWebDriver Instance;

        //Open the Browser
        public static void Intitialize()
        {
            Instance = new ChromeDriver();
            Wait(5);
            Instance.Manage().Window.Maximize();
        }

        //Go To The Website Link
        public static void visit(string url)
        {
            Instance.Navigate().GoToUrl(url);
        }

        //Close the Browser
        public static void Close()
        {
            Instance.Close();
        }

        public static void Wait(int time)
        {
            WebDriverWait wait = new WebDriverWait(Instance, TimeSpan.FromMinutes(time));
        }
    }
}