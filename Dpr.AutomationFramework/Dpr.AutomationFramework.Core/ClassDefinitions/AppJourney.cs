using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Savings;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions
{
    public class AppJourney : Journey
    {
        string application;

        #region Paramter Definition / 'AppJourney' Constructor

        private string scenarioId;
 
        public WindowsDriver<WindowsElement>  appDriver { set; get; }

        public string targetApplicationFilePath;
        public string targetApplicationWindowLocator;

        public AppAutomationQueue appQueue = new AppAutomationQueue();

        public AppJourney(string application, string applicationFilePath, string applicationWindowLocator, string appDriverUrl1, string appDriverUrl2 = null, string appDriverUrl3 = null, string appDriverUrl4 = null, bool logAndOutputInput = false, int timeOutInSeconds = 120) 
        {
            this.logAndOutputInput = logAndOutputInput;
            scenarioId = Guid.NewGuid().ToString("N");

            targetApplicationFilePath = applicationFilePath;
            targetApplicationWindowLocator = applicationWindowLocator;

            if (application.ToLower() == "backoffice")
            {
                PopulateAppDriverQueue(appDriverUrl1, appDriverUrl2, appDriverUrl3, appDriverUrl4);
            }
            else if (application.ToLower() == "servicing")
            {
                PopulateAppDriverQueue(appDriverUrl1, appDriverUrl2, appDriverUrl3, appDriverUrl4);
            }

            url = appQueue.WaitForAvailableDriver(scenarioId);

            this.application = application;
            InitialiseDriver(timeOutInSeconds);

            visitList = new List<BasePage>();
            journeyData = new Data();
        }
        #endregion

        #region Abstract Method Definition
        /// <summary>
        /// Define the page from which automation should start.
        /// </summary>
        public override void DestroyDriver()
        {
            if (application == "backoffice")
            {
                appDriver.CloseApp();
                appDriver.Quit();
                WindowsDriver<WindowsElement> session;
                DesiredCapabilities appCapabilities = new DesiredCapabilities();
                appDriver.Quit();
                appCapabilities.SetCapability(
                    "app", 
                    @"C:\Program Files (x86)\Windows Application Driver\closeBo.bat");
                
                //session = new WindowsDriver<WindowsElement>(
                //    new Uri(url),
                //    appCapabilities,
                //    TimeSpan.FromMinutes(1));
            }

            else if (application == "servicing")
            {
                appDriver.CloseApp();
                appDriver.Quit();

            }

            appQueue.NotifyEndOfScenario(scenarioId);
        }

        /// <summary>
        /// Start the process of automation.
        /// </summary>
        public override void Go()
        {
            foreach (AppBasePage s in visitList)
            {
                if (s.GetType().Name == "BOWizardBasePage" && 
                    ((BOWizardBasePage)s).firstPage)
                {
                    //TODO: Define the method to retrieve the session ID.
                }

                s.CompletePage(appDriver, journeyData, logAndOutputInput: logAndOutputInput);
                currentPage = s;
            }
        }

        /// <summary>
        /// Start the browser instance.
        /// </summary>
        /// <returns>The journey object</returns>
        public override Journey InitialiseDriver(int timeOutInSeconds)
        {
            if (application.ToLower() == Defs.appJourneyApplicationBackoffice)
            {
                InitialiseBackOfficeSession(targetApplicationFilePath, targetApplicationWindowLocator);
            }
            else if (application.ToLower() == Defs.appJourneyApplicationServicing)
            {
                InitialiseServicingSession(targetApplicationFilePath, targetApplicationWindowLocator);
            }
            this.appDriver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 0);

            return this;
        }

        /// <summary>
        /// IGNORE.
        /// Not implemented method.
        /// </summary>
        /// <param name="url">Ignore.</param>
        /// <returns>Ignore.</returns>
        public override Journey StartFrom(string url)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Sets the driver to the scope of the current page.
        /// </summary>
        /// <param name="currentPage">The target page.</param>
        public void SetCurrentPage(AppBasePage currentPage)
        {
            this.currentPage = currentPage;
            currentPage.driver = this.appDriver;
        }

        /// <summary>
        /// Set the driver to the current application page displayed 
        /// </summary>
        public override void SetCurrenPageDriver()
        {
            currentPage.SetDriver(appDriver);
        }

        #endregion

        #region Private Methods

        private WindowsDriver<WindowsElement> WindowsAppInitialisation(
            WindowsDriver<WindowsElement> driver, 
            string windowsAppFilePath, 
            string windowIdentifier)
        {
            WindowsDriver<WindowsElement> session;
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", windowsAppFilePath);
            try
            {
                session = new WindowsDriver<WindowsElement>(
                    new Uri(url), 
                    appCapabilities, 
                    TimeSpan.FromMinutes(1));
            }
            catch
            {
            }

            return GetWindowSession(driver, windowIdentifier);
        }


        public void SetDriverToSubWindow(string windowIdentifier)
        {
            System.Collections.ObjectModel.ReadOnlyCollection<string> winHandles = appDriver.WindowHandles;

            int count = 0;
            WindowsElement window = null;
            bool foundFlag = false;
            

            while (count < 40 && foundFlag == false)
            {
                try
                {
                    window = appDriver.FindElementByXPath(windowIdentifier);
                    foundFlag = true;
                }
                catch
                {
                    count = +1;
                    Thread.Sleep(25);
                    if (count > 40)
                        new TestEnder().FailEnd(
                            Defs.failNonAssert, 
                            "AppJourney.SetDriverToSubWindow(string " +
                            "windowIdentifier). Unable to locate sub window" +
                            "with the windowIdenfifier '"+windowIdentifier+"'.");
                }
            }

            foreach (string winHandle in winHandles)
            {
                if (winHandle == window.GetAttribute("NativeWindowHandle"))
                {
                    appDriver.SwitchTo().Window(winHandle);
                    break;
                }
            }
        }

        /// <summary>
        /// Set the AppDriver instance to the app instance.
        /// </summary>
        /// <param name="driver">The target driver.</param>
        /// <param name="windowIdentifier">The target window (BO or Serv)</param>
        /// <returns>The update AppDriver instance</returns>
        private WindowsDriver<WindowsElement> GetWindowSession(
            WindowsDriver<WindowsElement> driver, 
            string windowIdentifier)
        {
            int count = 0;
            WindowsElement window = null;
            bool foundFlag = false;

            while (count < 40 && foundFlag == false)
            {
                try
                {
                    window = driver.FindElementByXPath(windowIdentifier);
                    foundFlag = true;
                }
                catch
                {
                    count = +1;
                    Thread.Sleep(25);
                    if (count > 40)
                    {
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "AppJourney.GetWindowSession. Unable to locate window" +
                            "with the windowIdenfifier '" + windowIdentifier + "'.");
                    }
                }
            }
            string windowHandle = window.GetAttribute("NativeWindowHandle");
            windowHandle = int.Parse(windowHandle).ToString("x");

            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("appTopLevelWindow", windowHandle);
            new WindowsDriver<WindowsElement>(new Uri(url), appCapabilities);

            return new WindowsDriver<WindowsElement>(new Uri(url), appCapabilities);
        }

        /// <summary>
        /// Start a BackOffice session
        /// </summary>
        private void InitialiseBackOfficeSession(string backOfficeFilePath, string backOfficeWindowLocator)
        {
            // Define the 'appCapabilities' for the BO instantiaiton. 
            DesiredCapabilities appCapabilities = new DesiredCapabilities();

            // Populate 'appCapabilities'.
            appCapabilities.SetCapability("app", "Root");
            //appCapabilities.SetCapability("ms:experimental-webdriver", false);
            // Instanitate a new WindowsDriver.
            appDriver = new WindowsDriver<WindowsElement>(new Uri(url), appCapabilities);

            appDriver = WindowsAppInitialisation(
                appDriver, 
                backOfficeFilePath, 
                backOfficeWindowLocator);
        }

        /// <summary>
        /// Start a Servicing Session
        /// </summary>
        private void InitialiseServicingSession(string targetApplicationFilePath, string targetApplicationWindowLocator)
        {
            DesiredCapabilities appCapabilities = new DesiredCapabilities();

            appCapabilities.SetCapability("app", "Root");
            appDriver = new WindowsDriver<WindowsElement>(new Uri(url), appCapabilities);

            appDriver = WindowsAppInitialisation(
                appDriver,
                targetApplicationFilePath,
                targetApplicationWindowLocator);
        }

        private void PopulateAppDriverQueue(string appDriverUrl1, string appDriverUrl2 = null, string appDriverUrl3 = null, string appDriverUrl4 = null)
        {
            appQueue.AddDriver(appDriverUrl1);
            if (appDriverUrl2 != null)
            {
                appQueue.AddDriver(appDriverUrl2);
            }

            if (appDriverUrl3 != null)
            {
                appQueue.AddDriver(appDriverUrl3);
            }

            if (appDriverUrl4 != null)
            {
                appQueue.AddDriver(appDriverUrl4);
            }
        }
        #endregion
    }
}
