using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMDB_Case.Base;
using IMDB_Case.Page;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Remote;

namespace IMDB_Case.Test
{
    [TestClass]
    public class FindAndCompareTest : Browser
    {
        [TestInitialize]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.imdb.com/");
        }

        [TestMethod]
        public void CompareForMovie_1()
        {
            FindAndComparePage driver = new FindAndComparePage();
            try
            {
                driver.ClickMenu();
                driver.ClickOscars();
                driver.ClickYear();
                driver.ClickMovie();
                driver.GetDataFromOfMovie();
                driver.ClickHomePage();
                driver.SearchMovie("The Circus");
                driver.ClickMovieAgain();
                driver.CompareTwoMovie();
                driver.ClickAllPhotos();
                driver.CheckLinks();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [TestMethod]
        public void CompareForMovie_2()
        {
            FindAndComparePage driver = new FindAndComparePage();
            try
            {
                driver.ClickMenu();
                driver.ClickOscars();
                driver.ClickYear();
                driver.ClickMovie2();
                driver.GetDataFromOfMovie();
                driver.ClickHomePage();
                driver.SearchMovie("The Jazz Singer");
                driver.ClickMovie2Again();
                driver.CompareTwoMovie();
                driver.ClickAllPhotos();
                driver.CheckLinks();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [TestCleanup]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
