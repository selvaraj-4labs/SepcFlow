using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Report;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System.Threading;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses
{
    public class TestEnder 
    { 
        
        //Webautomation overload
        // TODO: Rewrite method making 'testContext' a required parameter (will require rework of Web/App BasePages)
        public void FailEnd(string errorType, string failMessage, IWebDriver driver, TestContext testContext = null  )
         {
            string screenshotPath = new ScreenCapture().Capture(driver);

            ReportGenerator.AddScreenshot(
                Thread.CurrentThread.ManagedThreadId.ToString(), 
                "Error screenshot", 
                screenshotPath);

            if (testContext != null)
            {
                testContext.AddResultFile(screenshotPath);
            }

            Assert.Fail(GetFailEndTypeText(errorType)+failMessage +" - See screenshot '"+ screenshotPath+"'.");
            // errorType to potentially be used later to distinguish 
            // between an actual test assert fail and other causes of failure
            // Add report entry
            // Take screenshot
            // CreateReport
        }


        // AppAutomation overload
        // TODO: Rewrite method making 'testContext' a required parameter (will require rework of Web/App BasePages)
        public void FailEnd(string errorType, string failMessage, WindowsDriver<WindowsElement> driver, TestContext testContext = null)
        {
            string screenshotPath = null;
            string screenshotMessageAddOn = "";
            if (!ImplicitTimerTracker.IsScenarioUsingImplicitTimer(driver.SessionId.ToString()))
            {
                screenshotPath = new ScreenCapture().Capture(driver);
                
                ReportGenerator.AddScreenshot(
                    Thread.CurrentThread.ManagedThreadId.ToString(),
                    "Error screenshot", 
                    screenshotPath);

                if (testContext != null)
                {
                    testContext.AddResultFile(screenshotPath);
                }

                screenshotMessageAddOn = " - See screenshot '" + screenshotPath + "'.";
            }

            Assert.Fail(GetFailEndTypeText(errorType) + failMessage + screenshotMessageAddOn);
            // errorType to potentially be used later to distinguish 
            // between an actual test assert fail and other causes of failure
            // Add report entry
            // Take screenshot
            // CreateReport
        }

        //Use if no ss required overload
        public void FailEnd(string errorType, string failMessage)
        {
            Assert.Fail(GetFailEndTypeText(errorType) + failMessage);
            // errorType to potentially be used later to distinguish 
            // between an actual test assert fail and other causes of failure
            // Add report entry
            // Take screenshot
            // CreateReport
        }

        private string GetFailEndTypeText(string errorType)
        {
            string failTypeText;
            if (errorType == Defs.failNonAssert) failTypeText = "TEST ERROR: ";
            else failTypeText = "TEST FAIL: ";

            return failTypeText;
        }

        private void End()
        {
            //CreateReport
        }
    }
}
