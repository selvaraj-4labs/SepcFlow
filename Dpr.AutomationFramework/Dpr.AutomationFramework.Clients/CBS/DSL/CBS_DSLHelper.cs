using Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.CBS.AvailableApplicants;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.CBS.AvailableJourneys.AvailbleJourneyRepositories.BranchPortal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.CBS.AvailableJourneys.AvailbleJourneyRepositories.BrokerPortal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.CBS.CBS_MortgageProductTypes;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.CoreDSL;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.PersistentData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using TechTalk.SpecFlow;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.CBS.DSL.StepDefinition
{
    public class CBS_DSLHelper : CoreDSLHelpers
    {
        private static object lastTestStart_lock = new object();
        private static DateTime lastTestStart = DateTime.Now.AddDays(-1);
        public PersistentData _persistentData;
        public TestContext _testContext;

        public CBS_DSLHelper(PersistentData persistentData, TestContext testContext)
        {
            _persistentData = persistentData;
            _testContext = testContext;
        }

        #region Intermediary Portal Section

        #endregion

        #region Portal Specific Section
        public void RetrieveCaseID()
        {
            if (_persistentData.journeyType.ToLower() != "mortgageoriginations")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid journey type. The specflow command '...the " +
                    "case ID is recorded' can only be used " +
                    "with the mortgage journey type.");
            }

            // Check if the case reference box is displayed within the portal
            bool isCaseReferenceDisplayed =
                _persistentData.webAutomationJourney.currentPage.IsElementDisplayed(
                    _persistentData.webAutomationJourney.currentPage.GetPageElement("caseReference"));

            if (!isCaseReferenceDisplayed)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Case Reference is not displayed!'",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }
            _persistentData.intermediaryCaseID.Add(
                _persistentData.webAutomationJourney.currentPage.GetTextFromElement(
                    _persistentData.webAutomationJourney.currentPage.GetPageElement("caseReference")));

            Console.WriteLine("Bank Account Number: " +
            _persistentData.intermediaryCaseID[0]);

        }
        #endregion

        #region Helper Method Section
        public void CheckDecision(string decisionType)
        {
            if (_persistentData.journeyType.ToLower().Replace(" ", "") != "mortgageoriginations")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid journey type. The SpecFlow command '... the " +
                    "decision is \"\"' can only be used with the mortgage " +
                    "originations journey type.");
            }

            List<string> acceptedValues = new List<string>() { "accept", "refer", "decline" };

            if (!acceptedValues.Contains(decisionType.ToLower()))
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The decision type '" + decisionType + "' is not a valid " +
                    "decision type. Please review.");
            }
            _persistentData.journeyResult = decisionType;

            WebBasePage decisionPage = (WebBasePage)_persistentData.webAutomationJourney.currentPage;

            if (!DoesDecisionMessageMatchExpected(decisionPage, decisionType))
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "Decision does not match expected decision '" + decisionType + "'.",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }
        }

        public void ChooseOption(string optionName)
        {
            if (_persistentData.journeyType.ToLower() == "brokermortgageoriginations" ||
                _persistentData.journeyType.ToLower() == "branchmortgageoriginations")
            {
                ChooseMortgageOption(optionName);
            }
        }

        public void ChooseMortgageOption(string optionName)
        {
            List<string> acceptedMortgageOptions = new List<string>(new string[]
            {
                "ill",
                "dip",
                "fma"
            });

            optionName = optionName.ToLower().Replace(" ", "");

            if (!acceptedMortgageOptions.Contains(optionName))
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The mortgage option: '" + optionName +
                    "' does not exist.Please review the " +
                    "mortgage option.");
            }

            _persistentData.webAutomationJourney.visitList =
                _persistentData.targetRepo.GetPagesFor(
                    optionName
                        .Replace(" ", "")
                        .Replace("/", "")
                        .Replace("-", "")
                        .ToLower(),
                    _testContext);

            if (!acceptedMortgageOptions.Contains(optionName))
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The mortgage option: '" + optionName +
                    "' does not exist.Please review the " +
                    "mortgage option.");
            }

            _persistentData.webAutomationJourney.visitList =
                _persistentData.targetRepo.GetPagesFor(
                    optionName
                        .Replace(" ", "")
                        .Replace("/", "")
                        .Replace("-", "")
                        .ToLower(),
                    _testContext);

            _persistentData.journeyName = optionName;

            // Will probably need to be expanded upon when the DIP journey is automated.

            if (_persistentData.journeyName.Replace(" ", "").ToLower() == "dip" && 
                _persistentData.journeyType.ToLower() == "brokermortgageoriginations")
            {
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "CBS_BrokerHomePage",
                    "brokerHomeOption",
                    "DIP");
            }
            else if (_persistentData.journeyType.Replace(" ", "").ToLower() == "dip" &&
                    _persistentData.journeyType.ToLower() == "branchmortgageoriginations")
            {
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "CBS_BranchHomePage",
                    "branchHomeOption",
                    "Customer Search");
            }
        }

        public void ChooseMortgageProduct(string productName)
        {
            if (_persistentData.journeyType.ToLower() != "mortgageoriginations")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid journey type. The SpecFlow command '... I choose " +
                    "the \"\" product can only be used with the 'Mortgage " +
                    "Originations' journey type.");
            }

            bool productExists = false;
            string productType = string.Empty;

            if (new CBS_ResidentialList().residentialProducts.Contains(productName))
            {
                productExists = true;
                productType = "Residential";
            }
            else if (new CBS_BuyToLetList().buyToLetProducts.Contains(productName))
            {
                productExists = true;
                productType = "Buy To Let";
            }

            if (productExists == false)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The product '" + productName + "cannot be found withn " +
                    "the POM. Please review the product name or, if new, " +
                    "add to the relevant product category.");
            }

            if (_persistentData.webAutomationJourney != null)
            {
                string productSelectPage = string.Empty;
                if (_persistentData.journeyType.ToLower() == "mortgageoriginations" && 
                    _persistentData.journeyName.ToLower() == "ill")
                {
                    productSelectPage = "CBS_ILL05";
                }

                else if (_persistentData.journeyType.ToLower() == "mortgageoriginations" &&
                    _persistentData.journeyName.ToLower() == "dip")
                {
                    productSelectPage = "CBS_PBD01";
                }

                _persistentData.webAutomationJourney.ChangeJourneyData(
                    productSelectPage,
                    "_userInputProductName",
                    productName);

                _persistentData.webAutomationJourney.ChangeJourneyData(
                    productSelectPage,
                    "selectFirstProduct",
                    "0");
            }
        }

        public void CreateJourney(string journeyName)
        {
            List<string> acceptedJourneys = new List<string>(new string[]
            {
                "brokermortgageoriginations",
                "branchmortgageoriginations"
            });

            journeyName = journeyName.ToLower().Replace(" ", "");

            if (!acceptedJourneys.Contains(journeyName))
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The journey type'" + journeyName + "' does not exist." +
                    "Please review the journey name.");
            }

            int testOffsetNumberOfSeconds;
            double differenceInSeconds;

            switch (journeyName)
            {
                case "brokermortgageoriginations":
                    testOffsetNumberOfSeconds = 10;
                    lock (lastTestStart_lock)
                    {
                        while ((differenceInSeconds = DateTime.Now.Subtract(lastTestStart).TotalSeconds) < testOffsetNumberOfSeconds)
                        {
                            Thread.Sleep(((int)Math.Ceiling(differenceInSeconds)) * 1000);
                        }

                        DateTime lastIntermediaryTestStart = DateTime.Now;
                    }

                    if (_persistentData.webAutomationJourney != null)
                    {
                        _persistentData.webAutomationJourney.DestroyDriver();
                    }

                    _persistentData.webAutomationJourney = new WebJourney(logAndOutputInput: true);
                    _persistentData.targetRepo = new CBS_BrokerMortgageOriginationsJourneyRepository();
                    _persistentData.webAutomationJourney.StartFrom(_testContext.Properties["brokerUrl"].ToString());
                    break;

                case "branchmortgageoriginations":
                    testOffsetNumberOfSeconds = 10;
                    lock (lastTestStart_lock)
                    {
                        while ((differenceInSeconds = DateTime.Now.Subtract(lastTestStart).TotalSeconds) < testOffsetNumberOfSeconds)
                        {
                            Thread.Sleep(((int)Math.Ceiling(differenceInSeconds)) * 1000);
                        }

                        DateTime lastIntermediaryTestStart = DateTime.Now;
                    }

                    if (_persistentData.webAutomationJourney != null)
                    {
                        _persistentData.webAutomationJourney.DestroyDriver();
                    }

                    _persistentData.webAutomationJourney = new WebJourney(logAndOutputInput: true);
                    _persistentData.targetRepo = new CBS_BranchMortgageOriginationsJourneyRepository();
                    _persistentData.webAutomationJourney.StartFrom(_testContext.Properties["branchUrl"].ToString());
                    break;
            }
            _persistentData.journeyType = journeyName;
        }

        public void CompleteJourney(string untilPage)
        {
            (List<BasePage>, List<BasePage>) separatedVisitLists;
            List<BasePage> visitList;
            BasePage untilPageBasePage = null;

            if (_persistentData.targetRepo.GetType().Name == "CBS_BrokerMortgageOriginationsJourneyRepository" ||
                _persistentData.targetRepo.GetType().Name == "CBS_BranchMortgageOriginationsJourneyRepository")
            {
                if (untilPage == null &&
                    _persistentData.remainingVisitList == null)
                {
                    visitList = _persistentData.webAutomationJourney.visitList;
                    _persistentData.remainingVisitList = null;
                }

                else if (untilPage == null && 
                    _persistentData.remainingVisitList != null)
                {
                    //separatedVisitLists = SeparateVisitList(
                    //    _persistentData.remainingVisitList,
                    //    untilPage);
                    //visitList = separatedVisitLists.Item1;
                    //_persistentData.remainingVisitList = separatedVisitLists.Item2;
                    //untilPageBasePage = separatedVisitLists.Item2[0];

                    visitList = _persistentData.remainingVisitList;
                    _persistentData.remainingVisitList = null;
                }
                else if (untilPage != null && _persistentData.remainingVisitList != null)
                {
                    separatedVisitLists = SeparateVisitList(
                        _persistentData.remainingVisitList,
                        untilPage);
                    visitList = separatedVisitLists.Item1;
                    _persistentData.remainingVisitList = separatedVisitLists.Item2;
                    untilPageBasePage = separatedVisitLists.Item2[0];
                }
                else
                {
                    separatedVisitLists = SeparateVisitList(
                        _persistentData.webAutomationJourney.visitList,
                        untilPage);
                    visitList = separatedVisitLists.Item1;
                    _persistentData.remainingVisitList = separatedVisitLists.Item2;
                    untilPageBasePage = separatedVisitLists.Item2[0];
                }

                _persistentData.webAutomationJourney.Visit(visitList).Go() ;

                if (untilPage == null)
                {
                    _persistentData.wholeScenarioJourneyData.AddScenarioData(
                        _persistentData.webAutomationJourney.journeyData);
                    _persistentData.webAutomationJourney.journeyData = new Data();
                }
                else
                {
                    _persistentData.webAutomationJourney.currentPage = untilPageBasePage;
                    _persistentData.webAutomationJourney.SetCurrenPageDriver();
                    _persistentData.webAutomationJourney.currentPage.WaitForNextScreen(
                        _persistentData.webAutomationJourney.currentPage.pageLoadedElement);
                }
            }
        }

        public bool DoesDecisionMessageMatchExpected(WebBasePage targetPage, string expectedResult)
        {
            string expectedMessage = string.Empty;
            bool queryResult = false;

            string decisionResult = targetPage.GetTextFromElement(targetPage.GetPageElement("decisionResult"));

            if (expectedResult.ToLower() == "accept")
            {
                queryResult = targetPage.AreStringsEqual(
                    "The mortgage application has been accepted",
                    decisionResult);
            }
            else if (expectedResult.ToLower() == "refer")
            {
                queryResult = targetPage.AreStringsEqual(
                    "The mortgage application has been referred",
                    decisionResult);
            }
            else if (expectedResult.ToLower() == "decline")
            {
                queryResult = targetPage.AreStringsEqual(
                    "The mortgage application has been declined",
                    decisionResult);
            }
            return queryResult;
        }

        public void ElementPresenceCheck(string elementName, bool expectedResult)
        {
            Element targetElement = null;
            bool isDisplayed = false;

            switch (_persistentData.journeyName.ToLower())
            {
                case "mortgageoriginations":
                    _persistentData.webAutomationJourney.currentPage.WaitForNextScreen(
                        _persistentData.webAutomationJourney.currentPage.pageLoadedElement);

                    targetElement = _persistentData.webAutomationJourney.currentPage.GetPageElement(elementName);
                    isDisplayed = _persistentData.webAutomationJourney.currentPage.IsElementDisplayed(targetElement);
                    break;

                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "Invalid journey type. The SpecFlo command '...the " +
                        "element \"\" id displayed can only be used with the" +
                        " 'Mortgage Originations' journey type.");
                    break;
            }
        }

        public void ElementTextCheck(string targetElement, string expectedText)
        {
            string portalValue;
            WebBasePage targetPage = (WebBasePage)_persistentData.webAutomationJourney.currentPage;

            portalValue = targetPage.GetTextFromElement(targetPage.GetPageElement(targetElement));

            if (portalValue.ToLower().Replace(" ", "") != expectedText.ToLower().Replace(" ", ""))
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The element" + targetElement + "displays" +
                    portalValue + "instead of the expected" +
                    expectedText);
            }
        }

        public void FeeDeduction(string feeName)
        {
            if (_persistentData.journeyType.ToLower() != "mortgageoriginations" &&
                _persistentData.journeyName.ToLower() != "ill")
            {
                for (int i = 0; i < 10; i++)
                {
                    string tempFeeName = _persistentData.wholeScenarioJourneyData.GetScenarioData(
                        "CBS_ILL06",
                        "_feeName_" + (i + 1).ToString());

                    if (tempFeeName == null)
                    {
                        _persistentData.webAutomationJourney.ChangeJourneyData(
                            "CBS_ILL06",
                            "_feeName_" + (i + 1).ToString(),
                            tempFeeName);
                        break;
                    }
                }
            }
        }

        public string GetDynamicText(string dynamicText)
        {
            string dynamicTextSanitised = dynamicText.ToLower().Replace("*", "").Replace(" ", "");
            string returnText = null;

            switch (dynamicTextSanitised)
            {
                case "today":
                    returnText = GetDateRelativeToToday("todaysdate");
                    break;

                case "tomorrow":
                    returnText = GetDateRelativeToToday("tomorrowsdate");
                    break;

                case "onemonthfromtoday":
                    returnText = GetDateRelativeToToday("onemonthfromtoday");
                    break;

                case "16today":
                case "16tomorrow":
                case "21today":
                case "21tomorrow":
                    returnText = GetDateRelativeToToday(dynamicTextSanitised);
                    break;

                case "docx":
                case "pdf":
                case "jpg":
                case "png":
                case "gif":
                    returnText = Path.GetFullPath(@"..\..\TestFiles\" +
                                        dynamicTextSanitised + "." + dynamicTextSanitised);
                    break;
            }

            if (returnText == null)
            {
                string negativeSplitString = "ago";
                char numberOfUnits = dynamicTextSanitised.ToCharArray()[0];
                if (!Char.IsDigit(numberOfUnits))
                {
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "The dynamic text entry for '" + dynamicText +
                        "' is not of the correct form.");
                }

                string timeFrame = dynamicTextSanitised.Substring(1, dynamicTextSanitised.IndexOf(negativeSplitString) - 1);

                returnText = GetDateRelativeToToday(
                    -int.Parse(numberOfUnits.ToString()),
                    timeFrame);

                string suffix = dynamicTextSanitised.Substring(dynamicTextSanitised.IndexOf(negativeSplitString) + negativeSplitString.Length);

                switch (suffix)
                {
                    case "mm/yyyy":
                        returnText = returnText.Remove(0, 3);
                        break;

                    case "yyyy":
                        returnText = returnText.Remove(0, returnText.Length - 4);
                        break;

                    default:
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "The suffix for the dynamic text entry '" + dynamicText +
                            "' is not of the correct form. Please review");
                        break;
                }
            }
            return returnText;
        }

        public void OverrideDefaultData(Table newDataTable)
        {
            string dataToUse = null;
            switch (_persistentData.targetRepo.GetType().Name)
            {
                case "CBS_BrokerMortgageOriginationsJourneyRepository":
                case "CBS_BranchMortgageOriginationsJourneyRepository":
                    for (int i = 0; i <= newDataTable.Rows.Count - 1; i++)
                    {
                        if (newDataTable.Rows[i][2].ToLower() == "null" ||
                            newDataTable.Rows[i][2] == "")
                        {
                            dataToUse = null;
                        }
                        else if (newDataTable.Rows[i][2].StartsWith("*"))
                        {
                            dataToUse = GetDynamicText(newDataTable.Rows[i][2]);
                        }

                        else
                        {
                            dataToUse = newDataTable.Rows[i][2];
                        }

                        _persistentData.webAutomationJourney.ChangeJourneyData(
                            newDataTable.Rows[i][0],
                            newDataTable.Rows[i][1],
                            dataToUse);
                    }
                    break;
            }
        }

        public void OverridePresentData(string elementName, string value)
        {
            Element element = null;
            Data data = null;

            value = GetDateRelativeToToday(value);

            switch (_persistentData.journeyType.ToLower())
            {
                case "mortgageoriginations":
                    element = _persistentData.webAutomationJourney.currentPage.GetPageElement(elementName);
                    data = _persistentData.webAutomationJourney.journeyData;
                    _persistentData.webAutomationJourney.currentPage.CompleteElement(
                        value,
                        element,
                        data);
                    break;

                default:
                    new TestEnder().FailEnd(Defs.failNonAssert,
                        "Given I set \"x\" to \"y\" - Journey type " +
                        "is not set to a valid type. Accepted types" +
                        " are 'Mortgage Originations'.");
                    break;
            }
        }

        public void PagePresenceCheck(string expectedPageName, bool expectedResult)
        {
            string sanitisedExpectedPageName = expectedPageName.ToLower();

            BasePage objInstance = null;
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();

            foreach(Type type in types.Where(t => t.IsSubclassOf(typeof(BasePage))))
            {
                if (type.Name.ToLower() == sanitisedExpectedPageName)
                {
                    objInstance = (BasePage)Activator.CreateInstance(type);
                }
            }

            bool isDisplayed = false;
            switch (_persistentData.journeyType.ToLower())
            {
                case "mortgageoriginations":
                    isDisplayed = _persistentData.webAutomationJourney.currentPage.IsElementDisplayed(
                        objInstance.pageLoadedElement);

                    if (objInstance.GetType().Name != _persistentData.webAutomationJourney.currentPage.GetType().Name)
                    {
                        _persistentData.webAutomationJourney.currentPage = objInstance;
                        _persistentData.webAutomationJourney.SetCurrenPageDriver();
                    }
                    break;

                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "Invalid journey type. The specflow command '...the " +
                        "\"\" is displayed' can only be used with journey " +
                        "types mortgage originations or backoffice.");
                    break;
            }
            if (isDisplayed != expectedResult && (_persistentData.journeyType.ToLower() == "mortgageoriginations"))
            {
                new TestEnder().FailEnd(
                   Defs.failAssert,
                   "The page presence check performed on the page: " +
                   "'" + expectedPageName + "' returned an unexpected result. " +
                   "Expected Page Display Status: '" + expectedResult +
                   "' Actaul Page Display Status: '" + isDisplayed + "'.",
                   _persistentData.webAutomationJourney.driver,
                   _testContext);
            }
        }

        public void SetApplicantNumber(int numberOfApplicants)
        {
            if ((_persistentData.journeyType.ToLower() != "mortgageoriginations" && _persistentData.journeyName.ToLower() != "ill") ||
                (_persistentData.journeyType.ToLower() != "mortgageoriginations" && _persistentData.journeyName.ToLower() != "dip"))
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid journey type. The SpecFlow command " +
                    "'...the number of applicants is equal to \"\"'" +
                    " can only be used with the mortgage originatiions " +
                    "'ILL', 'DIP' or 'FMA' journey types.");
            }

            List<int> acceptedInputs = new List<int>() { 1, 2, 3, 4 };
            if (!acceptedInputs.Contains(numberOfApplicants))
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "'... the number of applicants is equal to '" +
                    numberOfApplicants.ToString() + "' - " +
                    "Invalid input. Please review.");
            }

            if (_persistentData.journeyName.ToLower() == "ill")
            {
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "CBS_ILL04",
                    "numberOfApplicants",
                    numberOfApplicants.ToString());
            }
            else if (_persistentData.journeyName.ToLower() == "dip")
            {
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "CBS_DIP06",
                    "numberOfApplicants",
                    numberOfApplicants.ToString());
            }

        }

        public void SetApplicant(string applicantName)
        {
            CBS_ApplicantTypeRepository applicantRepo = new CBS_ApplicantTypeRepository();
            _persistentData.updatedValues = applicantRepo.GetApplicantType(applicantName);

            for (int i = 0; i <= _persistentData.updatedValues.Count - 1; i++)
            {
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    _persistentData.updatedValues[i][0],
                    _persistentData.updatedValues[i][1],
                    _persistentData.updatedValues[i][2]);
            }
        }

        public void TextPresenceCheck(string targetText, bool expectedResult)
        {
            string remainingText = targetText;
            string locatorType = Defs.locatorText;
            int currentIndex = 0;
            LocatorList locatorList = new LocatorList();

            currentIndex = remainingText.IndexOf(" ");

            while (currentIndex != -1)
            {
                locatorList.Add(locatorType, remainingText.Substring(0, currentIndex));
                remainingText = remainingText.Substring(currentIndex + 1);
                currentIndex = remainingText.IndexOf(" ");
            }
            locatorList.Add(locatorType, remainingText);

            int stringOccurence = 0;
            if (_persistentData.journeyType.ToLower().Contains("mortgageoriginations"))
            {
                stringOccurence = _persistentData.webAutomationJourney.currentPage.GetNumberOfElements(
                    _persistentData.webAutomationJourney.currentPage.FindElement(locatorList));
            }

            if (stringOccurence > 1)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "ERROR: Ambiguous result: Text - '" + targetText + "' is displayed more than once.",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }

            else if (stringOccurence == 0 && expectedResult == true)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "ERROR: Text - '" + targetText + "' is not displayed.",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }
            else if (stringOccurence > 0 && expectedResult == false)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "ERRORL Text - '" + targetText + "' is displayed.",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }
        }
        #endregion
    }
}
