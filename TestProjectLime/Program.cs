using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProjectLime
{
    class Program
    {
        protected static string LimeUrl = "http://www.lime-cap.com/en/";
        protected static string PortfolioUrl = "http://www.lime-cap.com/en/current-investment-portfolio";
        protected static string TeamUrl = "http://www.lime-cap.com/en/team";
        protected static string ContactUrl = "http://www.lime-cap.com/en/contact-us";

        public static string LimeLink = ".//*[@id='sp-main-menu']/ul/li[1]/a/span/span";
        public static string PortfolioLink = ".//*[@id='sp-main-menu']/ul/li[2]/a/span/span";
        public static string TeamLink = ".//*[@id='sp-main-menu']/ul/li[3]/a/span/span";
        public static string ContactLink = ".//*[@id='sp-main-menu']/ul/li[4]/a/span/span";

        public static void Main(string[] args)
        {
            
        }

        [Test]
        public void FollowToPortfolioTest()
        {
            // create wed driver
            IWebDriver driver = new ChromeDriver();
            // go to home page
            driver.Url = LimeUrl;
            // open window in max size
            driver.Manage().Window.Maximize();
            // following to Current Investment Portfolio page
            driver.FindElement(By.XPath(PortfolioLink)).Click();
            // get actual url
            string actualUrl = driver.Url;
            // checked url  
            Assert.IsTrue(PortfolioUrl == actualUrl);
            driver.Quit();
        }

        [Test]
        public void FollowToTeamTest()
        {
            // create wed driver
            IWebDriver driver = new ChromeDriver();
            // go to home page
            driver.Url = LimeUrl;
            // open window in max size
            driver.Manage().Window.Maximize();
            // following to Current Investment Portfolio page
            driver.FindElement(By.XPath(TeamLink)).Click();
            // get actual url
            string actualUrl = driver.Url;
            // checked url  
            Assert.IsTrue(TeamUrl == actualUrl);
            driver.Quit();
        }

        [Test]
        public void FollowToContacTest()
        {
            // create wed driver
            IWebDriver driver = new ChromeDriver();
            // go to home page
            driver.Url = LimeUrl;
            // open window in max size
            driver.Manage().Window.Maximize();
            // following to Current Investment Portfolio page
            driver.FindElement(By.XPath(ContactLink)).Click();
            // get actual url
            string actualUrl = driver.Url;
            // checked url  
            Assert.IsTrue(ContactUrl == actualUrl);

            driver.Quit();
        }
    }
}
