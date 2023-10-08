using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using OpenQA.Selenium;
using SpecflowProject1.Drivers;

namespace SpecflowProject1.Pages.HomePage.Components.Profile
{
    public class NotificationAssert : CommonDriver
    {
        

        private static IWebElement notiText => driver.FindElement(By.XPath("/html/body/div[1]/div"));

        public string assertNotification()
        {
            MarsWait.WaitToBeVisible("XPath", 20, "/html/body/div[1]/div");

            return notiText.Text;
        }

    }
}