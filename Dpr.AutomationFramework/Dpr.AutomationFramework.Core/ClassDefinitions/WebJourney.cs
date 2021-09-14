using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Savings;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions
{
    public class WebJourney : Journey
    {
        // Revert to private after PAF testing
        public IWebDriver driver;

        private int? taskId = null;

        /// <summary>
        /// Constructor for the WebJourney class.
        /// Creates the 'visitList' and 'journeyData' properties.
        /// </summary>
        /// <param name="standardJourney"></param>
        /// <param name="logAndOutputInput"></param>
        /// <param name="timeOutInSeconds"></param>
        public WebJourney(bool standardJourney = true, bool logAndOutputInput = false, int timeOutInSeconds = 45)
        {
            visitList = new List<BasePage>();
            journeyData = new Data();
            this.logAndOutputInput = logAndOutputInput;
            if (standardJourney == true)
            {
                InitialiseDriver(timeOutInSeconds);
            }
        }

        /// <summary>
        /// Sets the driver to the scope of the current page.
        /// </summary>
        public override void SetCurrenPageDriver()
        {
            currentPage.SetDriver(driver);
        }

        /// <summary>
        /// Start the browser instance.
        /// </summary>
        /// <param name="browserStr">The browser type.</param>
        private void InitialiseWebDriver(string browserStr, int timeOutInSeconds)
        {
            if (browserStr.ToLower() == "chrome")
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("start-maximized");
                driver = new ChromeDriver(options);
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeOutInSeconds);
        }

        /// <summary>
        /// Destroy the driver instance.
        /// </summary>
        public override void DestroyDriver()
        {
            driver.Quit();
        }

        /// <summary>
        /// Define the page from which automation should start.
        /// </summary>
        /// <param name="url">The URL of the start page.</param>
        /// <returns>The journey instance.</returns>
        public override Journey StartFrom(string url)
        {
            this.url = url;
            driver.Navigate().GoToUrl(url);
            return this;
        }

        /// <summary>
        /// Abstract version of the InitialiseDriver method.
        /// </summary>
        /// <returns>The instance of journey object.</returns>
        public override Journey InitialiseDriver(int timeOutInSeconds)
        {
            InitialiseWebDriver("chrome", timeOutInSeconds);
            return this; 
        }

        /// <summary>
        /// Start the process of automation.
        /// </summary>
        public override void Go()
        {
            foreach (WebBasePage s in visitList)
            {
                s.CompletePage(driver, journeyData, logAndOutputInput: logAndOutputInput);
                currentPage = s;
            }
        }

        /// <summary>
        /// Return the Task ID.
        /// </summary>
        /// <returns>The Task ID</returns>
        public int? GetTaskId()
        {
            return taskId;
        }

        // Commented out 04/05/2020
        //public void ScrapeValidation(string validationStartPage)
        //{
        //    taskId = Task.CurrentId;
        //    bool scrapeFlag = false;
        //    WebBasePage currentPage;
        //    for (int i = 0; i < visitList.Count; i++)
        //    {
        //        currentPage = (WebBasePage)visitList.ElementAt(i);
        //        if (currentPage.className == validationStartPage)
        //        {
        //            scrapeFlag = true;
        //        }
        //        if (scrapeFlag == true)
        //        {
        //            currentPage.CompletePage(driver, journeyData, false);
        //            new ValidationScraper(currentPage, journeyData).ScrapeValidation(driver);
        //            currentPage.CompletePage(driver, journeyData, true);
        //            //break;   //Used for debugging individual pages
        //        }
        //        else
        //        {
        //            currentPage.CompletePage(driver, journeyData, true);
        //        }

        //    }
        //}

        // Commented out 04/05/2020
        //public void ScrapeJsonValidation(string validationStartPage)
        //{
        //    taskId = Task.CurrentId;
        //    bool scrapeFlag = false;
        //    WebBasePage currentPage;
        //    JsonValidationOutput validationOutput = new JsonValidationOutput();
        //    ValidationScraper valScraper;

        //    for (int i = 0; i < visitList.Count; i++)
        //    {
        //        currentPage = (WebBasePage)visitList.ElementAt(i);
        //        valScraper = new ValidationScraper(currentPage, journeyData);
        //        if (currentPage.className == validationStartPage)
        //        {
        //            scrapeFlag = true;
        //        }
        //        if (scrapeFlag == true)
        //        {
        //            try
        //            {
        //                //currentPage.CompletePage(driver, journeyData, false);
        //                valScraper.CompletePage(driver, false);
        //            }
        //            catch
        //            { }
        //            validationOutput.Concat(valScraper.ScrapeValidationFromJsonInput());
        //        }
        //        else
        //        {
        //            currentPage.CompletePage(driver, journeyData, true);
        //        }

        //    }
        //    validationOutput.Display();
        //}
    }
}
