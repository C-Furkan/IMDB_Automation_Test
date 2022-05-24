using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using IMDB_Case.Base;
using SeleniumExtras.WaitHelpers;

namespace IMDB_Case.Base
{
    public class Browser
    {
        public static IWebDriver Driver { get; set; }

        public void WaitForElementExist(int time, By text)
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(time)).Until(ExpectedConditions.ElementExists(text));
        }
    }
}
