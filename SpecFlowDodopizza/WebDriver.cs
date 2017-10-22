using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowDodopizza
{
    public class WebDriver
    {
        public static IWebDriver Instance { get; set }

    }
        public static string BaseAddress
        {
            get { return ConstantsUtils.Url; }

        }

        public static object ConstantsUtils { get; private set; }

        public static void Intialize()
        {
            Instance = new ChromeDriver();
            TurnOnWait();
            Instance.Manage().Window.Maximize();
        }
        public static void Navigate()
        {
            Instance.Navigate().GoToUrl(BaseAddress);
        }
        public static void Close()
        {
            Instance.Close();
        }
        private static void TurnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

        }
        
    }
}
