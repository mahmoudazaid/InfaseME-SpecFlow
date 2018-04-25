using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace InfaseME.features.support
{
    public class Driver
    {
        public static IWebDriver Instance;

        public static void Intitialize()
        {
            Instance = new ChromeDriver();
            Wait(5);
            Instance.Manage().Window.Maximize();
        }

        public static void visit(string url)
        {
            Instance.Navigate().GoToUrl(url);
        }

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