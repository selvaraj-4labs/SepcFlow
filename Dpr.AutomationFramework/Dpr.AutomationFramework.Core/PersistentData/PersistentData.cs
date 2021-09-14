using AventStack.ExtentReports;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.AvailableJourneys;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using System.Collections.Generic;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.PersistentData
{
    /// <summary>
    /// POCO to store the persistent data.
    /// </summary>
    public class PersistentData
    {
        // Instantiating values.

        public WebJourney webAutomationJourney;
        public AppJourney appAutomationJourney;
        public JourneyRepository targetRepo;
        public List<BasePage> visitList;
        public List<BasePage> remainingVisitList;
        public List<List<string>> updatedValues;
        public BasePage currentPage;

        public WholeScenarioData wholeScenarioJourneyData;

        public string journeyType;
        public string productName;

        public string journeyResult;

        public List<string> applicationReference;
        public List<string> bankAccountNumber;
        public List<string> userId;
        public List<string> customerNumberList;
        public string sortCode;
        public string surname;


        public string journeyName;
        public List<string> intermediaryCaseID;

        //Related to report generation
        public ExtentTest featureName;
        public ExtentTest scenario;
        public ExtentTest currentStep;

        public PersistentData()
        {
            // Setting default values.
            appAutomationJourney = null;
            webAutomationJourney = null;
            targetRepo = null;
            // A list of values that are to be changed from the happy path data
            updatedValues = null;
            // A list of the pages to be visited
            visitList = null;
            // Name of the current page
            currentPage = null;
            wholeScenarioJourneyData = new WholeScenarioData();
            journeyType = string.Empty;
            productName = string.Empty;
            journeyResult = string.Empty;
            applicationReference = new List<string>();

            #region Savings / eBanking Specific Section
            bankAccountNumber = new List<string>();
            userId = new List<string>();
            customerNumberList = new List<string>();
            sortCode = string.Empty;
            #endregion

            #region Intermediary Specific Section
            journeyName = string.Empty;
            intermediaryCaseID = new List<string>();
            #endregion

            // Used to split the journey into sections
            remainingVisitList = null;
        }
    }
}
