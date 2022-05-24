using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using IMDB_Case.Base;
using IMDB_Case.Page;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Net;

namespace IMDB_Case.Page
{
    public class FindAndComparePage : Browser
    {
        public string Director_Name;
        public string Writer_Name;
        public string Star_1;
        public string Star_2;
        public string Star_3;

        public string HOMEPAGE_MENU = "imdbHeader-navDrawerOpen--desktop";
        public string HOMEPAGE_MENU_CATEGORY = "//a[@class='ipc-list__item nav-link sc-fKFyDc nwOmR ipc-list__item--indent-one']//*[text()[contains(.,'Oscars')]]";
        public string OSCARS_YEARS_LINK = "//div[@class='event-history-widget__years-row']//*[text()[contains(.,'1929')]]";
        public string MOVIE_NAME_LINK = "//*//div/div/div[2]/h3/div/div/div/div[1]/div[2]/div[2]/div[1]/span/span/a";
        public string MOVIE_NAME2_LINK = "//div[2]/h3/div/div/div/div[2]/div[2]/div[2]/div[1]/span/span/a";
        public string MOVIE_DIRECTOR_NAME = "//div[@data-testid='title-pc-wide-screen']//li[@class='ipc-metadata-list__item'][1]//a";
        public string MOVIE_WRİTER_NAME = "//div[@data-testid='title-pc-wide-screen']//li[@class='ipc-metadata-list__item'][2]//a";
        public string MOVIE_STAR1_NAME = "//div[@data-testid='title-pc-wide-screen']//li[@class='ipc-metadata-list__item ipc-metadata-list-item--link']//li[1]//a";
        public string MOVIE_STAR2_NAME = "//div[@data-testid='title-pc-wide-screen']//li[@class='ipc-metadata-list__item ipc-metadata-list-item--link']//li[2]//a";
        public string MOVIE_STAR3_NAME = "//div[@data-testid='title-pc-wide-screen']//li[@class='ipc-metadata-list__item ipc-metadata-list-item--link']//li[3]//a";
        public string MOVIE_SEARCH_NAME = "react-autowhatever-1--item-0";
        public string MOVIE2_SEARCH_NAME = "react-autowhatever-1--item-2";
        public string MOVIE_ALL_PHOTOS = "//section[@data-testid='Photos']//h3";
        public string LOGO = "home_img_holder";
        public string SEARCHBAR = "suggestion-search";
        public string CHECK_PHOTO = "//div[@id='media_index_storyline_content']//p";
        public string CHECK_ELEMENTS = "//div[@id='media_index_thumbnail_grid']//a";
        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        private IWebElement HOMEPAGE_MANU_ID => Driver.FindElement(By.Id(HOMEPAGE_MENU));
        private IWebElement HOMEPAGE_MANU_XPATH => Driver.FindElement(By.XPath(HOMEPAGE_MENU_CATEGORY));
        private IWebElement OSCARS_YEARS_LINK_XPATH => Driver.FindElement(By.XPath(OSCARS_YEARS_LINK));
        private IWebElement MOVIE_NAME_LINK_XPATH => Driver.FindElement(By.XPath(MOVIE_NAME_LINK));
        private IWebElement MOVIE_NAME2_LINK_XPATH => Driver.FindElement(By.XPath(MOVIE_NAME2_LINK));
        
        private IWebElement MOVIE_DIRECTOR_NAME_XPATH => Driver.FindElement(By.XPath(MOVIE_DIRECTOR_NAME));
        private IWebElement MOVIE_WRİTER_NAME_XPATH => Driver.FindElement(By.XPath(MOVIE_WRİTER_NAME));
        private IWebElement MOVIE_STAR1_NAME_XPATH => Driver.FindElement(By.XPath(MOVIE_STAR1_NAME));
        private IWebElement MOVIE_STAR2_NAME_XPATH => Driver.FindElement(By.XPath(MOVIE_STAR2_NAME));
        private IWebElement MOVIE_STAR3_NAME_XPATH => Driver.FindElement(By.XPath(MOVIE_STAR3_NAME));
        private IWebElement MOVIE_SEARCH_NAME_ID => Driver.FindElement(By.Id(MOVIE_SEARCH_NAME));
        private IWebElement MOVIE2_SEARCH_NAME_ID => Driver.FindElement(By.Id(MOVIE2_SEARCH_NAME));
        private IWebElement MOVIE_ALL_PHOTOS_XPATH => Driver.FindElement(By.XPath(MOVIE_ALL_PHOTOS));

        private IWebElement LOGO_ID => Driver.FindElement(By.Id(LOGO));
        private IWebElement SEARCHBAR_ID => Driver.FindElement(By.Id(SEARCHBAR));
        //-----------------------------------------------------------------------------------------------
        Browser browser = new Browser(); 

        public void ClickMenu()
        {
            browser.WaitForElementExist(10, By.Id(HOMEPAGE_MENU));
            HOMEPAGE_MANU_ID.Click();
        }

        public void ClickOscars()
        {
            browser.WaitForElementExist(10, By.XPath(HOMEPAGE_MENU_CATEGORY));
            HOMEPAGE_MANU_XPATH.Click();
        }

        public void ClickYear()
        {
            browser.WaitForElementExist(10, By.XPath(OSCARS_YEARS_LINK));
            OSCARS_YEARS_LINK_XPATH.Click();
        }

        public void ClickMovie()
        {
            browser.WaitForElementExist(10, By.XPath(MOVIE_NAME_LINK));
            MOVIE_NAME2_LINK_XPATH.Click();
        }
        public void ClickMovie2()
        {
            browser.WaitForElementExist(10, By.XPath(MOVIE_NAME2_LINK));
            MOVIE_NAME_LINK_XPATH.Click();
        }

        public void GetDataFromOfMovie()
        {
            browser.WaitForElementExist(10, By.XPath(MOVIE_STAR3_NAME));
            Director_Name = MOVIE_DIRECTOR_NAME_XPATH.Text;
            Writer_Name = MOVIE_WRİTER_NAME_XPATH.Text;
            Star_1 = MOVIE_STAR1_NAME_XPATH.Text;
            Star_2 = MOVIE_STAR2_NAME_XPATH.Text;
            Star_3 = MOVIE_STAR3_NAME_XPATH.Text;
        }

        public void ClickHomePage()
        {
            LOGO_ID.Click();
        }

        public void SearchMovie(string m_Name)
        {
            SEARCHBAR_ID.SendKeys(m_Name);
        }

        public void ClickMovieAgain()
        {
            browser.WaitForElementExist(10, By.Id(MOVIE_SEARCH_NAME));
            MOVIE_SEARCH_NAME_ID.Click();
        }
        public void ClickMovie2Again()
        {
            browser.WaitForElementExist(10, By.Id(MOVIE2_SEARCH_NAME));
            MOVIE2_SEARCH_NAME_ID.Click();
        }

        public void CompareTwoMovie()
        {
            Assert.AreEqual(MOVIE_DIRECTOR_NAME_XPATH.Text, Director_Name);
            Assert.AreEqual(MOVIE_WRİTER_NAME_XPATH.Text, Writer_Name);
            Assert.AreEqual(MOVIE_STAR1_NAME_XPATH.Text, Star_1);
            Assert.AreEqual(MOVIE_STAR2_NAME_XPATH.Text, Star_2);
            Assert.AreEqual(MOVIE_STAR3_NAME_XPATH.Text, Star_3);
        }

        public void ClickAllPhotos()
        {
            MOVIE_ALL_PHOTOS_XPATH.Click();
        }

        public void CheckLinks()
        {
            browser.WaitForElementExist(10, By.XPath(CHECK_PHOTO));
            IList<IWebElement> links = Driver.FindElements(By.XPath(CHECK_ELEMENTS));
            foreach (IWebElement link in links)
            {
                var url = link.GetAttribute("href");
                IsLinkWorking(url);
            }
        }

        public static bool IsLinkWorking(string url)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    response.Close();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}