using Dpr.AutomationFramework.Dpr.AutomationFramework.AvailableJourneys.BackOfficeApplication;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.CoreDSL;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.PersistentData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Report;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Intermediary.AvailableJourneys;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Intermediary.MortgageProductsTypes;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.CaseSearch;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.CaseSummaryTabs;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Tabs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using TechTalk.SpecFlow;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Intermediary.DSL.StepDefinition
{
    public class DSLHelper : CoreDSLHelpers
    {
        private static object lastTestStart_lock = new object();
        private static DateTime lastTestStart = DateTime.Now.AddDays(-1);
        public PersistentData _persistentData;
        public TestContext _testContext;


        public DSLHelper(PersistentData persistentData, TestContext testContext)
        {
            _persistentData = persistentData;
            _testContext = testContext;
        }

        #region Intermediary Portal Section

        #endregion

        #region BackOffice Application Section
        /// <summary>
        /// Search for the case in BackOffice using the case ID.
        /// SAME AS SAVINGS VERSION - MOVE TO 'CoreDSLHelpers'
        /// </summary>
        /// <param name="caseId">The target case ID</param>
        public void BackOfficeCaseSearch(string caseId = null)
        {
            _persistentData.appAutomationJourney.SetCurrentPage(new CaseSearchTab());
            _persistentData.appAutomationJourney.SetCurrenPageDriver();
            if (caseId == null)
            {
                caseId = _persistentData.intermediaryCaseID[0];
            }

            ReportGenerator.AddNotes(
                Thread.CurrentThread.ManagedThreadId.ToString(),
                "\r\nOpening case '" + caseId + "'");

            CaseSearchTab caseSearchTab =
                (CaseSearchTab)_persistentData.appAutomationJourney.currentPage;

            caseSearchTab.CompleteElement(
                caseId,
                caseSearchTab.caseIdSearchBox.locator);
            caseSearchTab.ClickElement(caseSearchTab.searchBtn.locator);
        }

        /// <summary>
        /// Open a BackOffice case.
        /// SAME AS SAVINGS VERSION - MOVE TO 'CoreDSLHelpers'
        /// </summary>
        public void BackOfficeOpenCase()
        {
            CaseSearchTab caseSearchTab =
                (CaseSearchTab)_persistentData.appAutomationJourney.currentPage;
            _persistentData.appAutomationJourney.SetCurrenPageDriver();

            // Moving the case ID value into the caseSearchTab Page Object instance.
            caseSearchTab.caseId = _persistentData.intermediaryCaseID[0];

            _persistentData.appAutomationJourney.currentPage.DoubleClickElement(
                ((CaseSearchTab)_persistentData.appAutomationJourney.currentPage).firstRowBoxID.locator);
        }

        /// <summary>
        /// Check if a BackOffice case is displayed correctly.
        /// SAME AS SAVINGS VERSION - MOVE TO 'CoreDSLHelpers'
        /// </summary>
        /// <param name="caseId"></param>
        public void CaseSearchVerification(string caseId = null)
        {
            CaseSearchTab caseSearchTab =
                (CaseSearchTab)_persistentData.appAutomationJourney.currentPage;
            if (caseId == null)
            {
                caseId = _persistentData.intermediaryCaseID[0];
            }
            // Moving the case ID value into the caseSearchTab Page Object instance.
            caseSearchTab.caseId = caseId;

            string displayedValue =
                caseSearchTab.GetUniqueInputElement(
                    caseSearchTab.firstRowBoxID.locator)
                    .GetAttribute("Value.Value");

            if (caseId != displayedValue)
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "Case ref does not match. Expected: '" + caseId +
                    "'. Actual: '" + displayedValue + "'.",
                    _persistentData.appAutomationJourney.appDriver,
                    _testContext);
            }
            // Console.WriteLine("Case is displayed in BackOffice successfully.");
        }

        /// <summary>
        /// Find and opens the wizard with a given name.
        /// </summary>
        /// <param name="wizardName">The name of the target wizard</param>
        public void OpenBackofficeWizard(string wizardName)
        {
            if (_persistentData.targetRepo.GetType().Name != "BOJourneyRepository")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Cannot open backoffice wizard '" + wizardName +
                    "' because the journey type is not Backoffice.");
            }

            _persistentData.appAutomationJourney.SetCurrentPage(new BackOfficeRibbonBar());

            _persistentData.appAutomationJourney.currentPage.ClickElement(
                ((BackOfficeRibbonBar)_persistentData.appAutomationJourney.currentPage).wizard.locator);

            Element wizardMenuElement = _persistentData.appAutomationJourney.currentPage.GetPageElement(wizardName);
            _persistentData.appAutomationJourney.currentPage.ClickElement(wizardMenuElement.locator);

        }

        /// <summary>
        /// Find and select a certain BackOffice wizard.
        /// </summary>
        /// <param name="wizardType">The target wizard name.</param>
        public void SelectWizardBackoffice(string wizardType)
        {
            wizardType = wizardType.ToLower().Replace(" ", "").Replace("/", "");

            OpenBackofficeWizard(wizardType);

            string windowLocatorXpath =
                "//*[@" + Defs.boLocatorName + "='" +
                ((BOWizardBasePage)_persistentData.targetRepo.GetPagesFor(wizardType, _testContext)[0]).windowTitle + "']";

            _persistentData.appAutomationJourney.SetDriverToSubWindow(windowLocatorXpath);

            _persistentData.appAutomationJourney.visitList =
                _persistentData.targetRepo.GetPagesFor(wizardType, _testContext);
            string name;

            switch (wizardType)
            {
                case "generatedataoutputdocumentwizard":
                    name = _persistentData.wholeScenarioJourneyData.GetScenarioData(
                        "SaveAndRestore",
                        "title") + " " +
                        _persistentData.wholeScenarioJourneyData.GetScenarioData(
                            "SaveAndRestore",
                            "firstName") + " " +
                        _persistentData.wholeScenarioJourneyData.GetScenarioData(
                            "EAP04",
                            "middleName") + " " +
                        _persistentData.wholeScenarioJourneyData.GetScenarioData(
                            "SaveAndRestore",
                            "lastName");

                    // Name entered in portal may not be of the 'TitleCase' form.
                    // BO converts it to 'Title Case' .: the data also 
                    // needs to be converted.
                    _persistentData.appAutomationJourney.ChangeJourneyData(
                        "GenerateDataOutputDocumentP1",
                        "selectApplicant",
                        CapitaliseFirstChar(name));
                    break;

                case "updateapplicantconsentswizard":
                    name = _persistentData.wholeScenarioJourneyData.GetScenarioData(
                        "SaveAndRestore",
                        "title") + " " +
                        _persistentData.wholeScenarioJourneyData.GetScenarioData(
                            "SaveAndRestore",
                            "firstName") + " " +
                        _persistentData.wholeScenarioJourneyData.GetScenarioData(
                            "EAP04",
                            "middleName") + " " +
                        _persistentData.wholeScenarioJourneyData.GetScenarioData(
                            "SaveAndRestore",
                            "lastName");

                    _persistentData.appAutomationJourney.ChangeJourneyData(
                        "UpdateApplicantConsentsP1",
                        "applicantName",
                        CapitaliseFirstChar(name));
                    break;
            }
        }

        /// <summary>
        /// Find, select and satisfy a checklist item with a given name.
        /// </summary>
        /// <param name="checklistName">The name of the target checklist</param>
        public void SatisfyChecklistItem(string checklistName)
        {
            // Searching for the checklist item.
            WindowsElement foundChecklist = null;
            foreach (WindowsElement we in _persistentData.appAutomationJourney.appDriver.FindElementsByXPath("//DataItem[@Name=\"Item Detail\"]"))
            {
                if (we.GetAttribute("Value.Value") == checklistName)
                {
                    foundChecklist = we;
                    break;
                }
            }
            if (foundChecklist == null)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The checklist '" + checklistName + "' cannot be found.",
                    _persistentData.appAutomationJourney.appDriver,
                    _testContext);
            }
            // Adding to the XPath.
            ContextClickElementAndSelectContextMenuOption(foundChecklist, "Satisfy");
        }
        #endregion

        #region Global Helper Method Section

        #endregion

        #region App Specfic Section
        /// <summary>
        /// Close the current case open in BackOffice.
        /// SAME AS SAVINGS VERSION - MOVE TO 'CoreDSLHelpers'
        /// </summary>
        public void CloseBOCase()
        {
            switch (_persistentData.journeyType.ToLower())
            {
                case "backoffice":
                    _persistentData.appAutomationJourney.SetCurrentPage(new BackOfficeRibbonBar());

                    _persistentData.appAutomationJourney.currentPage.ClickElement(
                        ((BackOfficeRibbonBar)_persistentData.appAutomationJourney.currentPage).closeTab.locator);
                    break;

                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "Invalid journey type. The specflow command '...the " +
                        "case is closed' is only valid for the BackOffice journey type .");
                    break;
            }
        }

        public void OpenCase()
        {
            if (_persistentData.journeyType.ToLower() == "backoffice")
            {
                BackOfficeCaseSearch();
                CaseSearchVerification();
                BackOfficeOpenCase();
            }
        }

        public void ContextClickElementAndSelectContextMenuOption(WindowsElement element, string menuOptionName)
        {
            _persistentData.appAutomationJourney.appDriver.Mouse.MouseMove(element.Coordinates);
            _persistentData.appAutomationJourney.appDriver.Mouse.ContextClick(null);

            WindowsDriver<WindowsElement> tempAppDriverStorage = _persistentData.appAutomationJourney.appDriver;
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", "Root");

            _persistentData.appAutomationJourney.appDriver =
                new WindowsDriver<WindowsElement>(
                    new Uri(_persistentData.appAutomationJourney.url),
                    appCapabilities);

            _persistentData.appAutomationJourney.appDriver
                .FindElementByXPath("//Menu[@Name='Context']/MenuItem[@Name='" + menuOptionName + "']").Click();

            _persistentData.appAutomationJourney.appDriver = tempAppDriverStorage;
        }

        /// <summary>
        /// Open the Nth case that is displayed within the application
        /// </summary>
        /// <param name="whichAccount">The ordinal number of the account</param>
        public void OpenNthCase(string whichAccount)
        {
            if (_persistentData.journeyType.ToLower() == "backoffice")
            {
                int whichCaseId = GetWhichIterationOfAccount(whichAccount);
                BackOfficeCaseSearch(_persistentData.applicationReference[whichCaseId]);
                CaseSearchVerification(_persistentData.applicationReference[whichCaseId]);
                BackOfficeOpenCase();
            }

            else
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Specflow command: '...I open the XXX case' can only be " +
                    "used with the backoffice journey type. " +
                    "Please review the scenario.");
            }
        }

        public void NavigateToTab(string tabName)
        {
            if (_persistentData.journeyType.ToLower() != "backoffice" &&
                _persistentData.journeyType.ToLower() != "servicing")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The specflow command '...I navigate to the \"\" tab' " +
                    "can only be used for the backoffice or servicing journies.");
            }

            By locator = _persistentData.appAutomationJourney.currentPage.FindElement(
                "=" + tabName,
                attributeType: Defs.boLocatorName,
                tag: "TabItem");

            _persistentData.appAutomationJourney.currentPage.ClickElement(locator);
            AppBasePage tabPage = null;
            switch (tabName.ToLower())
            {
                case "notes":
                    tabPage = new NotesTab();
                    break;
            }
            if (tabPage != null)
            {
                _persistentData.appAutomationJourney.SetCurrentPage(tabPage);
            }
        }
        #endregion

        #region Portal Specfic Section
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

        /// <summary>
        /// Checks if the decision displayed on the 'DecisionPage'
        /// matches the decision defined in the test.
        /// </summary>
        /// <param name="decisionType">The result expected on the decision page</param>
        public void CheckDecision(string decisionType)
        {
            if (_persistentData.journeyType.ToLower().Replace(" ", "") != "mortgageoriginations")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid journey type. The specflow command '...the decision is \"\"' " +
                    "can only be used with the savings or ebanking or mortgage originations journey types.");
            }

            List<string> acceptedValues = new List<string>() { "accept", "refer", "decline" };

            if (!acceptedValues.Contains(decisionType.ToLower()))
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The decision type '" + decisionType + "' is not " +
                    "a valid decision type. Please review.");
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

        /// <summary>
        /// Selects a mortgage journey option (DIP, FMA, Instruct Valuation).
        /// </summary>
        /// <param name="optionName">The name of the option to be selected</param>
        public void ChooseMortgageOption(string optionName)
        {
            _persistentData.webAutomationJourney.visitList =
                _persistentData.targetRepo.GetPagesFor(
                    optionName
                        .Replace(" ", "")
                        .Replace("/", "")
                        .Replace("-", "")
                        .ToLower(),
                _testContext);

            _persistentData.journeyName = optionName;

            if (_persistentData.journeyName.Replace(" ", "").ToLower() == "fma")
            {
                // Retrieve the number of apps from the DIP journey
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "DIP_ApplicationSummaryPage",
                    "_numberOfApplicants",
                    _persistentData.wholeScenarioJourneyData.GetScenarioData(
                        "Applicant1DetailsPage",
                        "numberOfApplicants"));

                // Retrieve journey type from the DIP journey
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "DIP_ApplicationSummaryPage",
                    "_loanType",
                    _persistentData.wholeScenarioJourneyData.GetScenarioData(
                        "ApplicantAndLoanTypePage",
                        "loanType"));

                // Retrieve the loan purpose from the DIP journey
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "DIP_ApplicationSummaryPage",
                    "_loanPurpose",
                    _persistentData.wholeScenarioJourneyData.GetScenarioData(
                        "LoanDetailsPage",
                        "loanPurpose"));

                // Retrieve the app 1 employment status from the DIP journey
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "DIP_ApplicationSummaryPage",
                    "_app1EmploymentType",
                    _persistentData.wholeScenarioJourneyData.GetScenarioData(
                        "Applicant1EmploymentInitialisationPage",
                        "employmentStatus"));

                // Retrieve the app 2 employment status from the DIP journey
                if (_persistentData.wholeScenarioJourneyData.GetScenarioData("Applicant1DetailsPage", "numberOfApplicants") == "2")
                {
                    _persistentData.webAutomationJourney.ChangeJourneyData(
                        "DIP_ApplicationSummaryPage",
                        "_app2EmploymentType",
                        _persistentData.wholeScenarioJourneyData.GetScenarioData(
                            "Applicant2EmploymentInitialisationPage",
                            "employmentStatus"));
                }
            }
        }

        /// <summary>
        /// Select a mortgage product using the product name.
        /// </summary>
        /// <param name="productName">The mortgage product name, as displayed in the portal</param>
        public void ChooseMortgageProduct(string productName)
        {
            if (_persistentData.journeyType.ToLower() != "mortgageoriginations")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid journey type. The specflow command '... I choose " +
                    "the \"\" product' can only be used with journey types " +
                    "Mortgage Originations.");
            }

            bool productExists = false;
            string productType = string.Empty;

            // Checks if the product is in one of the product lists.
            if (new ResidentialList().residentialProducts.Contains(productName))
            {
                productExists = true;
                productType = "Residential";
            }
            else if (new BuyToLetList().buyToLetProducts.Contains(productName))
            {
                productExists = true;
                productType = "Buy To Let";
            }

            if (productExists == false)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The product '" + productName + "' cannot be found within " +
                    "the POM. Please review the product name or, if new, add to " +
                    "the relevant product category.");
            }

            // Update the journey data.
            if (_persistentData.webAutomationJourney != null)
            {
                string productSelectPage = string.Empty;
                if (_persistentData.journeyType.ToLower() == "mortgageoriginations")
                {
                    productSelectPage = "ProductSelectionPage";
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

        /// <summary>
        /// Higher level function to determine what type of journey has been selected.
        /// </summary>
        /// <param name="optionName">The name of the option to be selected</param>
        public void ChooseOption(string optionName)
        {
            if (_persistentData.journeyType.ToLower() == "mortgageoriginations")
            {
                ChooseMortgageOption(optionName);
            }
            // TBC
            else if (_persistentData.journeyType.ToLower() == "backoffice")
            {
                SelectWizardBackoffice(optionName);
            }
        }

        /// <summary>
        /// Starts and completes a journey, up to a point if required. 
        /// </summary>
        /// <param name="untilPage">The name of the page that the journey should be 'broken' around</param>
        public void CompleteJourney(string untilPage)
        {
            (List<BasePage>, List<BasePage>) separatedVisitLists;
            List<BasePage> visitList;
            BasePage untilPageBasePage = null;

            // Determing the journey type.
            if (_persistentData.targetRepo.GetType().Name == "BOJourneyRepository" ||
                _persistentData.targetRepo.GetType().Name == "ServicingJourneyRepository")
            {
                // Complete journey straight through.
                if (untilPage == null && _persistentData.remainingVisitList == null)
                {
                    visitList = _persistentData.appAutomationJourney.visitList;
                    _persistentData.remainingVisitList = null;
                }

                // No more pages to vist.
                else if (untilPage == null && _persistentData.remainingVisitList != null)
                {
                    visitList = _persistentData.remainingVisitList;
                    _persistentData.remainingVisitList = null;
                }

                // Complete journey up to a point.
                else if (untilPage != null && _persistentData.remainingVisitList != null)
                {
                    separatedVisitLists = SeparateVisitList(
                        _persistentData.remainingVisitList, untilPage);
                    visitList = separatedVisitLists.Item1;
                    _persistentData.remainingVisitList = separatedVisitLists.Item2;
                    untilPageBasePage = separatedVisitLists.Item2[0];
                }

                // Split the visitList into two sections. 
                else
                {
                    separatedVisitLists = SeparateVisitList(
                        _persistentData.appAutomationJourney.visitList,
                        untilPage);
                    visitList = separatedVisitLists.Item1;
                    _persistentData.remainingVisitList = separatedVisitLists.Item2;
                    untilPageBasePage = separatedVisitLists.Item2[0];
                }

                // Complete the journey.
                _persistentData.appAutomationJourney.Visit(_persistentData.appAutomationJourney.visitList)
                    .Visit(visitList)
                    .Go();

                if (untilPage == null)
                {
                    if (_persistentData.targetRepo.GetType().Name == "ServicingJourneyRepository")
                    {
                        _persistentData.appAutomationJourney.currentPage.WaitForNextScreen(
                            _persistentData.appAutomationJourney.currentPage.pageLoadedElement);
                    }

                    // Replace the contents of 'wholeScenarioJourneyData'
                    _persistentData.wholeScenarioJourneyData.AddScenarioData(
                        _persistentData.appAutomationJourney.journeyData);

                    _persistentData.appAutomationJourney.journeyData = new Data();
                    _persistentData.appAutomationJourney.InitialiseDriver(int.Parse(_testContext.Properties["appImplicitTimeoutInSeconds"].ToString()));
                }
                else
                {
                    _persistentData.appAutomationJourney.currentPage = untilPageBasePage;
                    _persistentData.appAutomationJourney.SetCurrenPageDriver();
                    _persistentData.appAutomationJourney.currentPage.WaitForNextScreen(
                        _persistentData.appAutomationJourney.currentPage.pageLoadedElement);
                }
            }

            else if (_persistentData.targetRepo.GetType().Name == "MortgageOriginationsJourneyRepository")
            {
                // Complete journey straight through
                if (untilPage == null &&
                    _persistentData.remainingVisitList == null)
                {
                    visitList = _persistentData.webAutomationJourney.visitList;
                    _persistentData.remainingVisitList = null;
                }

                // No more pages to vist
                else if (untilPage == null &&
                    _persistentData.remainingVisitList != null)
                {
                    visitList = _persistentData.remainingVisitList;
                    _persistentData.remainingVisitList = null;
                }

                // Complete journey up to a point
                else if (untilPage != null &&
                    _persistentData.remainingVisitList != null)
                {
                    separatedVisitLists = SeparateVisitList(
                        _persistentData.remainingVisitList,
                        untilPage);
                    visitList = separatedVisitLists.Item1;
                    _persistentData.remainingVisitList = separatedVisitLists.Item2;
                    untilPageBasePage = separatedVisitLists.Item2[0];
                }

                // Complete the journey.
                else
                {
                    separatedVisitLists = SeparateVisitList(
                        _persistentData.webAutomationJourney.visitList,
                        untilPage);
                    visitList = separatedVisitLists.Item1;
                    _persistentData.remainingVisitList = separatedVisitLists.Item2;
                    untilPageBasePage = separatedVisitLists.Item2[0];
                }

                // Complete the journey
                _persistentData.webAutomationJourney.Visit(_persistentData.webAutomationJourney.visitList)
                    .Visit(visitList)
                    .Go();

                // If 'untilPage' is empty then journey is going to be completely finished.
                // Then 'wholeScenarioJourneyData' data is replaced.
                if (untilPage == null)
                {
                    _persistentData.wholeScenarioJourneyData.AddScenarioData(
                        _persistentData.webAutomationJourney.journeyData);
                    _persistentData.webAutomationJourney.journeyData = new Data();
                }

                // Else, we are on the 'untilPage'.
                else
                {
                    _persistentData.webAutomationJourney.currentPage = untilPageBasePage;
                    _persistentData.webAutomationJourney.SetCurrenPageDriver();
                    _persistentData.webAutomationJourney.currentPage.WaitForNextScreen(
                        _persistentData.webAutomationJourney.currentPage.pageLoadedElement);
                }
            }
        }

        /// <summary>
        /// Create the basic journey object required for the test.
        /// </summary>
        /// <param name="journeyName">The name of the journey type.</param>
        public void CreateJourney(string journeyName)
        {
            // List of accepted journeys
            List<string> acceptedJourneys = new List<string>(new string[]
                {
                    "mortgageoriginations",
                    "backoffice"
                });

            journeyName = journeyName.ToLower().Replace(" ", "");

            if (!acceptedJourneys.Contains(journeyName))
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The journey type'" + journeyName + "' does not exist." +
                    "Please review the journey name.");
            }

            // Defining the type of journey required
            switch (journeyName)
            {
                // Remove the offset ASAP (after testing)
                case "mortgageoriginations":
                    int testOffsetNumberOfSeconds = 10;
                    double differenceInSeconds;
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
                    _persistentData.targetRepo = new BrokerMortgageOriginationsJourneyRepository();
                    // To be updated depending on journey type (broker/store).
                    _persistentData.webAutomationJourney.StartFrom(_testContext.Properties["brokerUrl"].ToString());
                    break;

                case "backoffice":
                    _persistentData.targetRepo = new BOJourneyRepository();
                    _persistentData.appAutomationJourney = new AppJourney(
                        Defs.appJourneyApplicationBackoffice,
                        _testContext.Properties["backOfficeFilePath"].ToString(),
                        _testContext.Properties["backOfficeWindowLocator"].ToString(),
                        _testContext.Properties["WindowsApplicationDriverUrlOriginations1"].ToString(),
                        _testContext.Properties["WindowsApplicationDriverUrlOriginations2"].ToString(),
                        logAndOutputInput: true);
                    break;
            }
            _persistentData.journeyType = journeyName;
        }

        /// <summary>
        /// Check whether the decision displayed in the portal matches the expected result.
        /// </summary>
        /// <param name="targetPage">The page on which the decision output is displayed</param>
        /// <param name="expectedResult">Self explanatory.</param>
        /// <returns></returns>
        public bool DoesDecisionMessageMatchExpected(WebBasePage targetPage, string expectedResult)
        {
            string expectedMessage = string.Empty;
            bool queryResult = false;

            string decisionResult = targetPage.GetTextFromElement(targetPage.GetPageElement("decisionResult"));
            if (expectedResult.ToLower() == "accept")
            {
                queryResult = targetPage.AreStringsEqual(
                    "The mortgage application has been accepted.",
                    decisionResult);
            }

            else if (expectedResult.ToLower() == "refer")
            {
                queryResult = targetPage.AreStringsEqual(
                    "The mortgage application has been referred.",
                    decisionResult);
            }

            else if (expectedResult.ToLower() == "decline")
            {
                queryResult = targetPage.AreStringsEqual(
                    "The mortgage application has been declined.",
                    decisionResult);
            }

            return queryResult;
        }

        /// <summary>
        /// Checks to see if the presence of an element with the POM name 'elementName' matches the expected result.
        /// </summary>
        /// <param name="elementName">The target element</param>
        /// <param name="expectedResult">The expected display value (true = displayed, false = not displayed)</param>
        public void ElementPresenceCheck(string elementName, bool expectedResult)
        {
            Element targetElement = null;
            bool isDisplayed = false;

            // Searches for the element.
            switch (_persistentData.journeyType.ToLower())
            {
                case "mortgageoriginations":
                    _persistentData.webAutomationJourney.currentPage.WaitForNextScreen(
                        _persistentData.webAutomationJourney.currentPage.pageLoadedElement);

                    targetElement = _persistentData.webAutomationJourney.currentPage.GetPageElement(elementName);
                    isDisplayed = _persistentData.webAutomationJourney.currentPage.IsElementDisplayed(targetElement);
                    break;

                case "backoffice":
                case "servicing":
                    _persistentData.appAutomationJourney.currentPage.WaitForNextScreen(
                        _persistentData.appAutomationJourney.currentPage.pageLoadedElement);

                    targetElement = _persistentData.appAutomationJourney.currentPage.GetPageElement(elementName);
                    isDisplayed = _persistentData.appAutomationJourney.currentPage.IsElementDisplayed(targetElement);
                    break;

                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "Invalid journey type. The " +
                        "specflow command '...the element \"\" is displayed' " +
                        "can only be used with journey types mortgage " +
                        "originations, backoffice.");
                    break;
            }

            if (isDisplayed != expectedResult && 
                (_persistentData.journeyType.ToLower() == "mortgageoriginations"))
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "The element presence check performed on the element: " +
                    "'" + elementName + "' returned an unexpected result. " +
                    "Expected: '" + expectedResult + "' Recieved: '" + isDisplayed + "'.",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }
            else if (isDisplayed != expectedResult && 
                (_persistentData.journeyType.ToLower() == "backoffice" || _persistentData.journeyType.ToLower() == "servicing"))
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "The element presence check performed on the element: " +
                    "'" + elementName + "' returned an unexpected result. " +
                    "Expected: '" + expectedResult + "' Recieved: '" + isDisplayed + "'.",
                    _persistentData.appAutomationJourney.appDriver,
                    _testContext);
            }
        }

        /// <summary>
        /// Deduct the element with the name...
        /// </summary>
        /// <param name="feeName">The name of the target fee</param>
        public void FeeDeduction(string feeName)
        {
            // Checking if the journeyType is correct
            if (_persistentData.journeyType.ToLower() != "mortgageoriginations" &&
                _persistentData.journeyName.ToLower() != "dip")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid journey type. The specflow command '...I deduct the " +
                    "fee with the name \"\"' can only be used with the " +
                    "mortgage originations 'DIP' journey type.");
            }

            // Adding the user input to feeName fields.
            for (int i = 0; i < 10; i++)
            {
                string tempFeeName = _persistentData.wholeScenarioJourneyData.GetScenarioData(
                    "FeesAndFeaturesPage",
                    "_feeName_" + (i + 1).ToString());

                if (tempFeeName == null)
                {
                    _persistentData.webAutomationJourney.ChangeJourneyData(
                        "FeesAndFeaturesPage",
                        "_feeName_" + (i + 1).ToString(),
                        tempFeeName);
                    break;
                }
            }
        }

        /// <summary>
        /// Replace the data that has been entered into the data manipulation table with data that is dynamic.
        /// </summary>
        /// <param name="dynamicText">The value that was entered into the table.</param>
        /// <returns></returns>
        public string GetDynamicText(string dynamicText)
        {
            // Remove the spaces + asterisks from the string.
            string dynamicTextSanitised =
                dynamicText.ToLower().Replace("*", "").Replace(" ", "");
            string returnText = null;
            // Calls the old version of 'GetDateRelativeToToday'
            switch (dynamicTextSanitised)
            {
                case "today":
                    returnText = GetDateRelativeToToday("todaysdate");
                    break;

                case "tomorrow":
                    returnText = GetDateRelativeToToday("tomorrowsdate");
                    break;

                case "one month from today":
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
                    if (_persistentData.journeyType.ToLower() == "backoffice" ||
                        _persistentData.journeyType.ToLower() == "servicing")
                    {
                        returnText = @"C:" + Keys.Alt + Keys.NumberPad9 + Keys.NumberPad2
                            + Keys.Alt + "Program Files (x86)" + Keys.Alt 
                            + Keys.NumberPad9 + Keys.NumberPad2 + Keys.Alt + 
                            "Windows Application Driver" + Keys.Alt + Keys.NumberPad9 + 
                            Keys.NumberPad2 + Keys.Alt + "TestFiles" + Keys.Alt + 
                            Keys.NumberPad9 + Keys.NumberPad2 + Keys.Alt + 
                            dynamicTextSanitised + "." + dynamicTextSanitised;
                    }
                    else
                    {
                        returnText = Path.GetFullPath(
                            @"..\..\TestFiles\"  + dynamicTextSanitised + "." 
                            + dynamicTextSanitised);
                    }
                    break;

                default:
                    //new TestEnder().FailEnd(
                    //    Defs.failNonAssert,
                    //    "A dynamic text entry for '" + 
                    //    dynamicTextSanitised + "' does not exist.");
                    break;
            }

            if (returnText == null)
            {
                string negativeSplitString = "ago";
                char numberOfUnits = dynamicTextSanitised.ToCharArray()[0];

                // Check if the first character is of an integer type.
                if (!Char.IsDigit(numberOfUnits))
                {
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "The dynamic text entry for '" +
                        dynamicText + "' is not of the correct form.");
                }

                // Retrieve the time frame (resolution) of the string.
                string timeFrame = dynamicTextSanitised.Substring(1, dynamicTextSanitised.IndexOf(negativeSplitString) - 1);

                // Get the date. NOTE: The '-' before the 'numberOfUints' parameter.
                returnText = GetDateRelativeToToday(
                    -int.Parse(numberOfUnits.ToString()),
                    timeFrame);

                string suffix = dynamicTextSanitised.Substring(dynamicTextSanitised.IndexOf(negativeSplitString) + negativeSplitString.Length);

                switch (suffix)
                {
                    case "mm/yyyy":
                        // Remove the 'dd/' section of the date.
                        returnText = returnText.Remove(0, 3);
                        break;

                    case "yyyy":
                        returnText = returnText.Remove(0, returnText.Length - 4);
                        break;

                    default:
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "The suffix for the dynamic text entry '" +
                            dynamicText + "' is not of the correct form. Please review");
                        break;
                }
            }

            return returnText;
        }

        /// <summary>
        /// Override the happy path default data.
        /// </summary>
        /// <param name="newDataTable">The table that houses the page, element and new data values</param>
        public void OverrideDefaultData(Table newDataTable)
        {
            string dataToUse = null;
            switch (_persistentData.targetRepo.GetType().Name)
            {
                // Not yet implemented.
                case "ServicingJourneyRepository":
                case "BOJourneyRepository":
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

                        _persistentData.appAutomationJourney.ChangeJourneyData(
                            newDataTable.Rows[i][0],
                            newDataTable.Rows[i][1],
                            dataToUse);
                    }
                    break;

                case "MortgageOriginationsJourneyRepository":
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
        
        /// <summary>
        /// Verifies that a page is displayed
        /// </summary>
        /// <param name="expectedPageName">The name of the page that is expected to display.</param>
        public void PagePresenceCheck(string expectedPageName, bool expectedResult)
        {
            string sanitisedExpectedPageName = expectedPageName.ToLower();

            BasePage objInstance = null;
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in types.Where(t => t.IsSubclassOf(typeof(BasePage))))
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

                // Currently not implemented.
                case "backoffice":
                case "servicing":
                    isDisplayed = _persistentData.appAutomationJourney.currentPage.IsElementDisplayed(
                        objInstance.pageLoadedElement);

                    if (objInstance.GetType().Name != _persistentData.appAutomationJourney.currentPage.GetType().Name)
                    {
                        _persistentData.appAutomationJourney.currentPage = objInstance;
                        _persistentData.appAutomationJourney.SetCurrenPageDriver();
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
            else if (isDisplayed != expectedResult && 
                (_persistentData.journeyType.ToLower() == "backoffice" ||
                _persistentData.journeyType.ToLower() == "servicing"))
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "The page presence check performed on the page: " +
                    "'" + expectedPageName + "' returned an unexpected result. " +
                    "Expected Page Display Status: '" + expectedResult + 
                    "' Actaul Page Display Status: '" + isDisplayed + "'.",
                    _persistentData.appAutomationJourney.appDriver,
                    _testContext);
            }
        }

        /// <summary>
        /// Complete a field on the present page with a value.
        /// </summary>
        /// <param name="elementName">The name of the target element</param>
        /// <param name="value">The new updated value.</param>
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

                case "backoffice":
                case "servicing":
                    element = _persistentData.appAutomationJourney.currentPage.GetPageElement(elementName);
                    data = _persistentData.appAutomationJourney.journeyData;
                    _persistentData.appAutomationJourney.currentPage.CompleteElement(value,
                        element,
                        data);
                    break;

                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "Given I set \"x\" to \"y\" - Journey type is not set " +
                        "to a valid type, the test therefore cannot be continued. " +
                        "Valid types are mortgage originations, backoffice.");
                    break;
            }
        }

        /// <summary>
        /// Update  the journey with the number of applicants.
        /// </summary>
        /// <param name="numberOfApplicants">Self explanatory</param>
        public void SetApplicantNumber(int numberOfApplicants)
        {
            if (_persistentData.journeyType.ToLower() != "mortgageoriginations" &&
                _persistentData.journeyName.ToLower() != "dip")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid journey type. The SpecFlow command '...the number " +
                    "of applicants is equal to \"\"' " +
                    "can only be used with the mortgage originations 'DIP' journey type.");
            }

            // Check 'numberOfApplicants' equals 1 or 2.
            List<int> acceptedInputs = new List<int>() { 1, 2 };
            if (!acceptedInputs.Contains(numberOfApplicants))
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "'... the number of applicants is equal to '" +
                    numberOfApplicants.ToString() + "' - " +
                    "Invalid input. Please review.");
            }

            // Setting 'Applicant1DetailsPage.numberOfApplicants'
            _persistentData.webAutomationJourney.ChangeJourneyData(
                "Applicant1DetailsPage",
                "numberOfApplicants",
                numberOfApplicants.ToString());
        }

        /// <summary>
        /// Checks to see if the a string of text is present on the web page.
        /// </summary>
        /// <param name="targetText">The text to be checked</param>
        /// <param name="expectedResult">The expected display value (true = displayed, false = not displayed)</param>
        public void TextPresenceCheck(string targetText, bool expectedResult)
        {
            // Creates a composite XPath that checks if every word in the targetText is displayed in a single element in order.
            string remainingText = targetText;
            string locatorType;
            int currentIndex = 0;
            LocatorList locatorList = new LocatorList();
            if (_persistentData.journeyType.ToLower() == "mortgageoriginations")
                locatorType = Defs.locatorText;
            else
                locatorType = Defs.boLocatorText;
            currentIndex = remainingText.IndexOf(" ");
            while (currentIndex != -1)
            {
                locatorList.Add(locatorType, remainingText.Substring(0, currentIndex));
                remainingText = remainingText.Substring(currentIndex + 1);
                currentIndex = remainingText.IndexOf(" ");
            }
            locatorList.Add(locatorType, remainingText);


            int stringOccurrence = 0;
            if (_persistentData.journeyType.ToLower() == "mortgageoriginations")
            {
                stringOccurrence = _persistentData.webAutomationJourney.currentPage.GetNumberOfElements(
                     _persistentData.webAutomationJourney.currentPage.FindElement(locatorList));
            }

            // TODO: Look into this.
            else if (_persistentData.journeyType.ToLower() == "backoffice" ||
                _persistentData.journeyType.ToLower() == "servicing")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The 'Given/When/Then/And the text \"x\" is displayed' " +
                    "cannot be used for application automation.");
            }

            // If greater than 1 fail no matter what.
            if (stringOccurrence > 1)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert, 
                    "ERROR: Text - '" + targetText + "' is displayed more " +
                    "than once. This means that the test result could be ambiguous.",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }

            // If the text does not display and was expected
            else if (stringOccurrence == 0 && expectedResult == true)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "ERROR: Text - '" + targetText +
                    "' is not displayed.",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }

            // If the text displays at all and was not expected.
            else if (stringOccurrence > 0 && expectedResult == false)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "ERROR: Text - '" + targetText + "' is displayed.",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }
        }

        /// <summary>
        /// Verify if the text displayed in a certain element matches the expected value.
        /// </summary>
        /// <param name="targetElement">The element to be checked</param>
        /// <param name="expectedText">The expected value the element contains.</param>
        public void ElementTextCheck(string targetElement, string expectedText)
        {
            string portalValue;
            WebBasePage targetPage = (WebBasePage)_persistentData.webAutomationJourney.currentPage;

            // Retrieve value from the portal
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
        #endregion
    }
} 
