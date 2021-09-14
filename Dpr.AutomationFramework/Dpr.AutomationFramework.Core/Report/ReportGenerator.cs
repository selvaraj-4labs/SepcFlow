using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Report
{
    public static class ReportGenerator
    {
        private static ExtentReports extent;

        private static string path;
        public static string reportPath;

        private static object hasBeenInitialised_lock = new object();
        private static bool hasBeenInitialised = false;

        private static List<List<string>> threadIdNotesList = new List<List<string>>();
        private static List<List<string>> threadIdScreenshotsList = new List<List<string>>();

        public static void AddNotes(string threadId, string noteText)
        {
            lock (threadIdNotesList)
            {
                List<string> newNoteList = new List<string>();
                newNoteList.Add(threadId);
                newNoteList.Add(noteText);
                threadIdNotesList.Add(newNoteList);
            }
        }

        public static void AddScreenshot(
            string threadId, 
            string screenshotTitle, 
            string screenshotLocation, 
            string screenshotDescription = "")
        {
            lock (threadIdScreenshotsList)
            {
                List<string> newScreenshotList = new List<string>();
                newScreenshotList.Add(threadId);
                newScreenshotList.Add(screenshotTitle);
                newScreenshotList.Add(screenshotLocation);
                newScreenshotList.Add(screenshotDescription);
                threadIdScreenshotsList.Add(newScreenshotList);
            }
        }

        // Run from BeforeTestRun
        public static void InitialiseReport() 
        {
            lock (hasBeenInitialised_lock)
            {
                if (hasBeenInitialised == false)
                {
                    string path1 = AppDomain.CurrentDomain.BaseDirectory
                        .Replace("\\bin\\Debug", "");
                    
                    path = path1 + "\\index.html";
                    ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(path);
                    htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
                    extent = new ExtentReports();

                    htmlReporter.Config.DocumentTitle = "Automation Test Report";
                    htmlReporter.Config.ReportName = "Automation Test Report";
                    extent.AttachReporter(htmlReporter);
                    hasBeenInitialised = true;
                }
            }
        }

        private static List<List<string>> GetNotesForThread(string threadId)
        {
            lock (threadIdNotesList)
            {
                List<List<string>> relevantNotes = new List<List<string>>();
                for (int i = threadIdNotesList.Count - 1; i >= 0; i--)
                {
                    if (threadIdNotesList[i][0] == threadId)
                    {
                        relevantNotes.Add(threadIdNotesList[i]);
                        threadIdNotesList.RemoveAt(i);
                    }
                }
                return relevantNotes;
            }
        }

        private static List<List<string>> GetScreenshotsForThread(string threadId)
        {
            lock (threadIdScreenshotsList)
            {
                List<List<string>> relevantScreenshots = new List<List<string>>();
                for (int i = threadIdScreenshotsList.Count - 1; i >= 0; i--)
                {
                    if (threadIdScreenshotsList[i][0] == threadId)
                    {
                        relevantScreenshots.Add(threadIdScreenshotsList[i]);
                        threadIdScreenshotsList.RemoveAt(i);
                    }
                }
                return relevantScreenshots;
            }
        }

        public static ExtentTest CreateFeature(string featureTitle)
        {
            lock (extent)
            {
                //Create dynamic feature name
                Console.WriteLine("BeforeFeature");
                return extent.CreateTest<Feature>(featureTitle);
            }
        }

        public static ExtentTest CreateScenario(string scenarioTitle)
        {
            lock (hasBeenInitialised_lock)
            {
                if (hasBeenInitialised == false)
                {
                    string path1 = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                    path = path1 + "\\index.html";
                    ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(path);
                    htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
                    extent = new ExtentReports();
                    htmlReporter.Config.DocumentTitle = "Automation Test Report";
                    htmlReporter.Config.ReportName = "Automation Test Report";
                    extent.AttachReporter(htmlReporter);
                    hasBeenInitialised = true;
                }
            }
            lock (extent)
            {
                Console.WriteLine("BeforeScenario");
                return extent.CreateTest<Feature>(scenarioTitle).CreateNode<Scenario>(scenarioTitle);
            }

        }

        public static void AddScreenshotReference(ExtentTest step, string screenshotTitle, string screenshotLocation, string relatedText = "")
        {
            lock (extent)
            {
                step.Log(Status.Info, relatedText, MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotLocation, screenshotTitle).Build());
                extent.Flush();
            }
        }

        public static ExtentTest CreateStep(ExtentTest scenario, string stepType, string stepName)
        {
            lock (extent)
            {
                ExtentTest step = null;
                if (stepType == "Given")
                {
                    step = scenario.CreateNode<Given>(stepType + " " + stepName);
                }
                else if (stepType == "When")
                {
                    step = scenario.CreateNode<When>(stepType + " " + stepName);
                }
                else if (stepType == "Then")
                {
                    step = scenario.CreateNode<Then>(stepType + " " + stepName);
                }
                else if (stepType == "And")
                {
                    step = scenario.CreateNode<And>(stepType + " " + stepName);
                }
                else
                {
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "ReportGenerator.CreateStep - stepType is not Given, " +
                        "When, Then or And.");
                }
                return step;
            }
        }

        public static void UpdateStep(ExtentTest step, Exception testError)
        {
            lock (extent)
            {
                string currentNote = "";
                List<string> formattedAndOrderedNotesList = new List<string>();
                //If failed, set to fail
                if (testError != null)
                    step.Fail(testError.Message);

                //Add any screenshots if relevant
                foreach (List<string> screenshotList in GetScreenshotsForThread(Thread.CurrentThread.ManagedThreadId.ToString()))
                {
                    AddScreenshotReference(step, screenshotList[1], screenshotList[2], screenshotList[3]);
                }
                List<List<string>> test = GetNotesForThread(
                    Thread.CurrentThread.ManagedThreadId.ToString());

                //Add any notes if relevant
                foreach (List<string> notesList in test)
                {
                    currentNote = notesList[1] + currentNote;
                    if (notesList[1].Contains("\r\n") /*&& currentNote != ""*/)
                    {  
                            formattedAndOrderedNotesList.Insert(0, currentNote);
                            currentNote = "";
                    }
                }
                formattedAndOrderedNotesList.Insert(0, currentNote);
                foreach (string note in formattedAndOrderedNotesList)
                    step.Info(note);

                //Update report
                extent.Flush();
            }
        }

        public static void CompleteReport()
        {
            //kill the browser
            //Flush report once test completes
            lock (extent)
            {
                extent.Flush();
            }
            System.Diagnostics.Process.Start(path);
            //kill the browser
        }
    }
}
