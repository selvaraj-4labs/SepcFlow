using Dpr.AutomationFramework.Dpr.AutomationFramework.AvailableJourneys.BackOfficeApplication;
using Dpr.AutomationFramework.Dpr.AutomationFramework.AvailableJourneys.eBankingPortal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.AvailableJourneys.SavingsPortal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.AvailableJourneys.ServicingApplication;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.CoreDSL;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.PersistentData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Report;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.CaseSearch;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.CaseSummaryTabs;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.RibbonMenu;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Tabs;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Savings.AvailableApplicants;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Savings.SavingsProductTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using TechTalk.SpecFlow;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Savings.DSL.StepDefinition
{
    public class DSLHelper : CoreDSLHelpers
    {
        private static object lastSavingsTestStart_lock = new object();
        private static DateTime lastSavingsTestStart = DateTime.Now.AddDays(-1);
        public PersistentData _persistentData;
        public TestContext _testContext;


        public DSLHelper(PersistentData persistentData, TestContext testContext)
        {
            _persistentData = persistentData;
            _testContext = testContext;
        }

        #region Savings Portal Section
        /// <summary>
        /// Verify the decision recieved in the portal matches the expected decision.
        /// </summary>
        /// <param name="decisionType">The expected decision. (Accept, Refer or Decline)</param>
        public void CheckDecision(string decisionType)
        {
            if (_persistentData.journeyType.ToLower() != "savings" && 
                _persistentData.journeyType.ToLower() != "ebanking")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert, 
                    "Invalid journey type. The specflow command '...the decision is \"\"' " +
                    "can only be used with the savings or ebanking journey types.");
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
        /// Defines the means by which the applicant deposits funds into the account.
        /// </summary>
        /// <param name="depositType">The deposit type</param>
        public void ChooseDepositType(string depositType)
        {
            string pageName;
            if (_persistentData.journeyType.ToLower() == "savings")
            {
                pageName = "EAP19";
            }
            else
            {
                pageName = "EAP19Ebanking";
            }

            switch (depositType)
            {
                case ("Debit Card"):
                    _persistentData.webAutomationJourney.ChangeJourneyData(
                        pageName,
                        "debitCardDeposit",
                        "11000");
                    _persistentData.webAutomationJourney.ChangeJourneyData(
                        pageName,
                        "depositType",
                        "Debit Card");
                    break;

                case ("Bank or Building Society"):
                    _persistentData.webAutomationJourney.ChangeJourneyData(
                        pageName,
                        "depositType",
                        "Bank Transfer");
                    break;

                case ("Cheque"):
                    _persistentData.webAutomationJourney.ChangeJourneyData(
                        pageName,
                        "depositType",
                        "Cheque");
                    break;
            }
        }

        /// <summary>
        /// Determines as to whether deduplication will be present in the journey.
        /// </summary>
        public void DeduplicationTrigger()
        {
            _persistentData.webAutomationJourney.ChangeJourneyData("EAP12", "dedupe", "true");
        }

        /// <summary>
        /// Compares the expected decision with the actaul decision recieved.
        /// </summary>
        /// <param name="decisionPage">The page that the decision result appears on</param>
        /// <param name="decisionType">The expected decision value</param>
        /// <returns></returns>
        public bool DoesDecisionMessageMatchExpected(WebBasePage decisionPage, string decisionType)
        {
            string expectedMessage = string.Empty;
            bool queryResult = false;

            if (decisionType.ToLower() == "accept")
            {
                expectedMessage = decisionPage.passExpectedMessage;
                queryResult = decisionPage.AreStringsEqual(
                    expectedMessage,
                    decisionPage.GetTextFromElement(decisionPage.passDecisionMessageBox.locator));
            }
            else if (decisionType.ToLower() == "refer")
            {
                expectedMessage = decisionPage.failExpectedMessage;
                queryResult = decisionPage.AreStringsEqual(
                    expectedMessage,
                    decisionPage.GetTextFromElement(decisionPage.failDecisionMessageBox.locator));
            }

            return queryResult;
        }

        /// <summary>
        /// Collect and save the eBanking credentials from the portal.
        /// </summary>
        public void RetrieveEBankingDetails()
        {
            if (_persistentData.journeyType.ToLower() != "savings" &&
                _persistentData.journeyType.ToLower() != "ebanking")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid journey type. The specflow command '...the " +
                    "eBanking credentials are displayed' can only be used " +
                    "with the journey types ebanking or savings.");
            }

            // Retrieving 'applicationReference' from portal.
            string wholeText =
                _persistentData.webAutomationJourney.currentPage.GetTextFromElement(
                    _persistentData.webAutomationJourney.currentPage.GetPageElement("applicationReferenceBox"));

            _persistentData.applicationReference.Insert(0, Regex.Replace(wholeText, @"[^\d]", String.Empty));

            if (_persistentData.targetRepo.GetType().Name != "SavingsJourneyRepository" &&
                _persistentData.targetRepo.GetType().Name != "EBankingJourneyRepository")
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "Ebanking details cannot be retrieved for the journey " +
                    "type '" + _persistentData.targetRepo.GetType().Name + "'.");
            }

            Console.WriteLine("ApplicationReference: " +
                _persistentData.applicationReference);


            bool bankAcctDisplayed =
                _persistentData.webAutomationJourney.currentPage.IsElementDisplayed(
                    _persistentData.webAutomationJourney.currentPage.GetPageElement("bankAccNumberBox"));

            bool userIdDisplayed =
                _persistentData.webAutomationJourney.currentPage.IsElementDisplayed(
                    _persistentData.webAutomationJourney.currentPage.GetPageElement("userIDBox"));

            bool sortCodeDisplayed =
                _persistentData.webAutomationJourney.currentPage.IsElementDisplayed(
                    _persistentData.webAutomationJourney.currentPage.GetPageElement("sortCodeBox"));

            if (!bankAcctDisplayed ||
                !userIdDisplayed ||
                !sortCodeDisplayed)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Ebanking Details are not displayed!'",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }

            _persistentData.bankAccountNumber.Add(
                _persistentData.webAutomationJourney.currentPage.GetTextFromElement(
                    _persistentData.webAutomationJourney.currentPage.GetPageElement("bankAccNumberBox")));

            Console.WriteLine("Bank Account Number: " +
                _persistentData.bankAccountNumber[0]);


            // Retrieving 'userId' from portal.
            _persistentData.userId.Add(
                _persistentData.webAutomationJourney.currentPage.GetTextFromElement(
                        _persistentData.webAutomationJourney.currentPage.GetPageElement("userIDBox")));

            Console.WriteLine("User ID: " +
                _persistentData.userId);


            // Retriving 'sortCode' from portal.
            _persistentData.sortCode =
                _persistentData.webAutomationJourney.currentPage.GetTextFromElement(
                        _persistentData.webAutomationJourney.currentPage.GetPageElement("sortCodeBox"));

            Console.WriteLine("Sort Code: " +
                _persistentData.sortCode);

        }

        /// <summary>
        /// Select a specific applicant from a list of predefined applicants
        /// </summary>
        /// <param name="applicantName">The target applicant name</param>
        public void SetApplicant(string applicantName)
        {
            ApplicantTypeRepository applicantRepo = new ApplicantTypeRepository();
            _persistentData.updatedValues = applicantRepo.GetApplicantType(applicantName);

            for (int i = 0; i <= _persistentData.updatedValues.Count - 1; i++)
            {
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    _persistentData.updatedValues[i][0],
                    _persistentData.updatedValues[i][1],
                    _persistentData.updatedValues[i][2]);
            }
        }

        #endregion

        #region BackOffice Section
        /// <summary>
        /// Search for the case in BackOffice using the case ID.
        /// </summary>
        /// <param name="caseId">The target case ID</param>
        public void BackOfficeCaseSearch(string caseId = null)
        {
            _persistentData.appAutomationJourney.SetCurrentPage(new CaseSearchTab());
            _persistentData.appAutomationJourney.SetCurrenPageDriver();
            if (caseId == null)
            {
                caseId = _persistentData.applicationReference[0];
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
        /// </summary>
        public void BackOfficeOpenCase()
        {
            CaseSearchTab caseSearchTab =
                (CaseSearchTab)_persistentData.appAutomationJourney.currentPage;
            _persistentData.appAutomationJourney.SetCurrenPageDriver();

            // Moving the case ID value into the caseSearchTab Page Object instance.
            caseSearchTab.caseId = _persistentData.applicationReference[0];

            _persistentData.appAutomationJourney.currentPage.DoubleClickElement(
                ((CaseSearchTab)_persistentData.appAutomationJourney.currentPage).firstRowBoxID.locator);
        }

        /// <summary>
        /// Check if a BackOffice case is displayed correctly.
        /// </summary>
        public void CaseDisplayedVerification()
        {
            if (_persistentData.journeyType.ToLower() != "backoffice")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid journey type. The specflow command '...the case is displayed " +
                    "successfully' can only be used with the backoffice journey type.");
            }
            string boCaseNumber = string.Empty;

            if (_persistentData.appAutomationJourney.currentPage.className != "CaseSearchTab")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The specflow command '...the case is displayed successfully' can only be used " +
                    "when the 'Case Search' tab is displayed. currentPage must be set to caseSearchTab.");
            }

            CaseSearchTab caseSearchTab = (CaseSearchTab)_persistentData.appAutomationJourney.currentPage;
            caseSearchTab.ClickElement(caseSearchTab.firstRowBoxID.locator);
            boCaseNumber = caseSearchTab.GetUniqueInputElement(caseSearchTab.firstRowBoxID.locator).GetAttribute("Value.Value");

            if (_persistentData.applicationReference[0] != boCaseNumber)
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "The case is not displayed in BackOffice.",
                    _persistentData.appAutomationJourney.appDriver,
                    _testContext);
            }
        }

        /// <summary>
        /// Higher level function that combines the search for and verification 
        /// of a BackOffice case.
        /// </summary>
        public void CaseIdentification()
        {
            BackOfficeCaseSearch();
            CaseSearchVerification();
        }

        /// <summary>
        /// Compares the case status displayed in BackOffice matches the expected case status.
        /// </summary>
        /// <param name="expectedStatus">The expected case status</param>
        public void CaseStatusCheck(string expectedStatus)
        {
            if (_persistentData.journeyType.ToLower() != "backoffice")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The specflow command '...the case status is equal to " +
                    "\"\"' can only be used for the journey type backoffice.");
            }

            _persistentData.appAutomationJourney.SetCurrentPage(new BackOfficeRibbonBar());
            _persistentData.appAutomationJourney.currentPage.ExplicitWait(
                _persistentData.appAutomationJourney.currentPage.GetPageElement("caseStatusLbl").locator);

            string actualVal =
                ((AppBasePage)_persistentData.appAutomationJourney.currentPage).GetAttribute(
                    _persistentData.appAutomationJourney.currentPage.GetPageElement("caseStatusLbl").locator,
                    "Name");


            if (!_persistentData.appAutomationJourney.currentPage.AreStringsEqual(expectedStatus, actualVal))
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "Case status is incorrect. Expected: '" + expectedStatus +
                    "'. Actual: '" + actualVal + "'.",
                    _persistentData.appAutomationJourney.appDriver,
                    _testContext);
            }
        }

        /// <summary>
        /// Close the current case open in BackOffice.
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

        /// <summary>
        /// Completes the final page of any wizard journey.
        /// </summary>
        /// <param name="finalWizardPage">The default/constant final BO wizard page</param>
        public void CloseBOWizard(BasePage finalWizardPage)
        {
            finalWizardPage.ClickElement(finalWizardPage.GetPageElement("finishBtn").locator);
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
        /// Find, select and satisfy a checklist item with a given name.
        /// </summary>
        /// <param name="checklistName">The name of the target checklist</param>
        public void SatisfyChecklistItem(string checklistName)
        {
            // Searching for the checklist item.
            WindowsElement foundChecklist = null;
            foreach (WindowsElement we in _persistentData.appAutomationJourney.appDriver.FindElementsByXPath("//DataItem[@Name=\"Back Office\"]/Edit[@Name=\"Item Detail\"]"))
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
        #endregion

        #region eBanking Section
        /// <summary>
        /// Select the process that should be selected within the eBanking portal.
        /// </summary>
        /// <param name="optionName">The target process name</param>
        /// <param name="whichAccount">The case to perform the process on</param>
        /// <param name="toAccount">The case that will recieve the result of the process performed</param>
        public void ChooseEBankingOption(string optionName, string whichAccount, string toAccount)
        {
            Element requiredElement = null;
            optionName = optionName.ToLower().Replace(" ", "");

            switch (optionName)
            {
                case "makeapayment":
                    requiredElement =
                        ((EBankingAccountsPage)_persistentData.webAutomationJourney.currentPage)
                            .GetMakeAPaymentElement(GetAccountNumber(whichAccount));

                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("MakeOneOffPayment", _testContext);
                    break;

                case "transfermoney":
                    if (toAccount == null)
                    {
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "The account to which the transfer is to be sent " +
                            "must be supplied. eg 'I perform the \"Transfer " +
                            "Money\" option from the \"first\" to the \"" +
                            "second\" account'.");
                    }

                    requiredElement =
                        ((EBankingAccountsPage)_persistentData.webAutomationJourney.currentPage)
                            .GetTransferMoneyElement(GetAccountNumber(whichAccount));

                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("TransferMoney", _testContext);

                    _persistentData.webAutomationJourney.currentPage = new EBankingAccountsPage();
                    _persistentData.webAutomationJourney.SetCurrenPageDriver();

                    string accountType =
                        _persistentData.webAutomationJourney.currentPage.GetTextFromElement(
                            ((EBankingAccountsPage)_persistentData.webAutomationJourney.currentPage)
                            .GetProductTypeElement(GetAccountNumber(whichAccount)));

                    _persistentData.webAutomationJourney.ChangeJourneyData(
                        "EnterTransferDetailsPage",
                        "toAccount",
                         accountType + " - " + GetAccountNumber(toAccount));
                    break;

                case "changeyourdetails":
                    requiredElement =
                        ((EBankingAccountsPage)_persistentData.webAutomationJourney.currentPage)
                            .changeYourDetailsBtn;
                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("ChangeYourDetails", _testContext);
                    break;

                case "changehomephone":
                    requiredElement =
                        ((YourDetailsPage)_persistentData.webAutomationJourney.currentPage).homePhoneChange;

                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("ChangeContactDetails", _testContext);
                    break;

                case "changeworkphone":
                    requiredElement =
                        ((YourDetailsPage)_persistentData.webAutomationJourney.currentPage).workPhoneChange;

                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("ChangeContactDetails", _testContext);
                    break;

                case "changemobilephone":
                    requiredElement =
                        ((YourDetailsPage)_persistentData.webAutomationJourney.currentPage).mobilePhoneChange;

                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("ChangeYourMobileNumber", _testContext);
                    break;

                case "changeemail":
                    requiredElement =
                        ((YourDetailsPage)_persistentData.webAutomationJourney.currentPage).emailChange;

                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("ChangeContactDetails", _testContext);
                    break;

                case "forgottenpassword":
                    _persistentData.webAutomationJourney.currentPage = new EBankingLoginPage();
                    _persistentData.webAutomationJourney
                        .StartFrom(_testContext.Properties["eBankingLoginPageUrl"].ToString())
                        .SetCurrenPageDriver();
                    requiredElement =
                        ((EBankingLoginPage)_persistentData.webAutomationJourney.currentPage).forgottenYourPassword;

                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("ForgottenPassword", _testContext);
                    break;

                case "forgottenmemorableanswer":
                    _persistentData.webAutomationJourney.StartFrom(_testContext.Properties["eBankingLoginPageUrl"].ToString());
                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("ForgottenMemorableAnswer", _testContext);
                    
                    _persistentData.webAutomationJourney.ChangeJourneyData(
                        "EBankingLoginPage",
                        "userName",
                        _persistentData.userId[0]);
                    _persistentData.webAutomationJourney.ChangeJourneyData(
                        "MemorableAnswerPage",
                        "firstChar",
                        null);
                    _persistentData.webAutomationJourney.ChangeJourneyData(
                        "MemorableAnswerPage",
                        "secondChar",
                        null);
                    _persistentData.webAutomationJourney.ChangeJourneyData(
                        "MemorableAnswerPage",
                        "thirdChar",
                        null);
                    _persistentData.webAutomationJourney.ChangeJourneyData(
                        "MemorableAnswerPage",
                        "logon",
                        null);
                    _persistentData.webAutomationJourney.ChangeJourneyData(
                        "MemorableAnswerPage",
                        "forgottenYourMemorableAnswer",
                        "ForgottenYourMemorableAnswer");
                    _persistentData.webAutomationJourney.ChangeJourneyData(
                        "ForgottenMemorableAnswerPage",
                        "userId",
                        _persistentData.userId[0]);
                    break;

                case "changecontactpreferences":
                    requiredElement =
                        ((YourDetailsPage)_persistentData.webAutomationJourney.currentPage)
                        .changeContactPreferences;
                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("ChangeContactDetails", _testContext);
                    break;

                case "changemarketingpreferences":
                    requiredElement =
                        ((YourDetailsPage)_persistentData.webAutomationJourney.currentPage)
                        .changeMarketingPreferences;
                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("ChangeContactDetails", _testContext);
                    break;

                case "changepassword":
                    requiredElement =
                        ((YourDetailsPage)_persistentData.webAutomationJourney.currentPage)
                        .changePassword;
                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("ChangePassword", _testContext);
                    break;

                case "viewaccount":
                    requiredElement =
                        ((EBankingAccountsPage)_persistentData.webAutomationJourney.currentPage)
                        .GetViewAccountElement(GetAccountNumber(whichAccount));
                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("ViewAccount", _testContext);
                    break;

                case "forgottenuserid":
                    _persistentData.webAutomationJourney.currentPage = new EBankingLoginPage();
                    _persistentData.webAutomationJourney.StartFrom(_testContext.Properties["eBankingLoginPageUrl"].ToString())
                        .SetCurrenPageDriver();
                    requiredElement =
                        ((EBankingLoginPage)_persistentData.webAutomationJourney.currentPage)
                        .forgottenYourUserId;
                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("ForgottenUserId", _testContext);
                    break;

                case "savings":
                    requiredElement =
                        ((EBankingAccountsPage)_persistentData.webAutomationJourney.currentPage)
                        .savingsBtn;
                    break;

                case "accountsummary":
                    requiredElement =
                        ((EBankingAccountsPage)_persistentData.webAutomationJourney.currentPage)
                        .accountSummaryBtn;
                    break;

                case "yourdetails":
                    requiredElement =
                        ((EBankingAccountsPage)_persistentData.webAutomationJourney.currentPage)
                        .yourDetailsBtn;
                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("YourDetails", _testContext);
                    break;

                case "viewdocuments":
                    requiredElement =
                        ((EBankingAccountsPage)_persistentData.webAutomationJourney.currentPage)
                        .viewDocumentsBtn;
                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("ViewDocuments", _testContext);
                    break;

                case "messagecentre":
                    requiredElement =
                        ((EBankingAccountsPage)_persistentData.webAutomationJourney.currentPage)
                        .messageCentreBtn;
                    break;

                case "home":
                    requiredElement =
                        ((EBankingAccountsPage)_persistentData.webAutomationJourney.currentPage)
                        .homeBtn;
                    break;

                case "newmail":
                    requiredElement =
                        ((EBankingAccountsPage)_persistentData.webAutomationJourney.currentPage)
                        .newMail;
                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("NewMail", _testContext);
                    break;

                case "applyonline":
                    requiredElement =
                        ((EBankingAccountsPage)_persistentData.webAutomationJourney.currentPage)
                        .savingsBtn;
                    _persistentData.webAutomationJourney.visitList =
                        _persistentData.targetRepo.GetPagesFor("ApplyOnline", _testContext);
                    break;

                case "signout":
                    requiredElement = new EBankingAccountsPage().signOutBtn;
                    break;

                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "The option '" + optionName + "' does not exist. " +
                        "Please review the option name.");
                    break;
            }

            if (requiredElement != null)
            {
                if (!_persistentData.webAutomationJourney.currentPage.IsElementDisplayed(requiredElement))
                {
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "Unable to perform the '" + optionName + "' because " +
                        "the required element with locator " + requiredElement.locator.ToString() +
                        "is not displayed.", _persistentData.webAutomationJourney.driver,
                        _testContext);
                }

                _persistentData.webAutomationJourney.currentPage.ClickElement(requiredElement.locator);
            }
        }

        /// <summary>
        /// Log out of the eBanking portal.
        /// </summary>
        public void EBankingAccountLogOut()
        {
            _persistentData.webAutomationJourney.currentPage = new EBankingAccountsPage();
            _persistentData.webAutomationJourney.SetCurrenPageDriver();
            _persistentData.webAutomationJourney.currentPage.WaitForNextScreen(_persistentData.webAutomationJourney.currentPage.pageLoadedElement);

            Element e = _persistentData.webAutomationJourney.currentPage.GetPageElement("signOutBtn");
            _persistentData.webAutomationJourney.currentPage.ClickElement(e.locator);
        }

        /// <summary>
        /// Log into an eBanking account.
        /// </summary>
        /// <param name="dedupeAccountSelectOption">Determine whenther the account selected is a dedupe acocunt</param>
        public void LogIntoNewAccount(string dedupeAccountSelectOption = null)
        {
            if (_persistentData.journeyType.ToLower() != "ebanking")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The specflow command '...I log into a new account, " +
                    "selecting \"\" accounts' can only be used for the " +
                    "journey type ebanking.");
            }

            // Obtaining the visitList for the Login Journey.
            _persistentData.webAutomationJourney.visitList = _persistentData.targetRepo.GetPagesFor("Login", _testContext);

            // Changing the eBanking username to userID displayed in the portal.

            //_persistentData.webAutomationJourney.Visit(new List<BasePage>(new EBankingLoginPage()));
            _persistentData.webAutomationJourney.ChangeJourneyData(
                "EBankingLoginPage",
                "userName",
                _persistentData.userId[0]);

            // Changing the eBanking password to password entered in the Savings portal.
            _persistentData.webAutomationJourney.ChangeJourneyData(
                "EBankingLoginPage",
                "password",
                _persistentData.wholeScenarioJourneyData.GetScenarioData(
                    "EAP12",
                    "enterPassword"));

            _persistentData.webAutomationJourney.ChangeJourneyData(
                "NewUserIDPage",
                "userName",
                _persistentData.wholeScenarioJourneyData.GetScenarioData("SaveAndRestore", "lastName")
                    .ToString().Replace("-", ""));

            _persistentData.webAutomationJourney.ChangeJourneyData(
                "AccountTypePage",
                "dedupe",
                _persistentData.wholeScenarioJourneyData.GetScenarioData(
                    "EAP12",
                    "dedupe"));

            if (dedupeAccountSelectOption != null)
            {
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "AccountTypePage",
                    "accountToSelect",
                    dedupeAccountSelectOption);
            }

            _persistentData.userId[0] =
                _persistentData.wholeScenarioJourneyData
                    .GetScenarioData("SaveAndRestore","lastName")
                    .ToString()
                    .Replace("-", "");

            _persistentData.webAutomationJourney.StartFrom(
                    _testContext.Properties["eBankingLoginPageUrl"].ToString())
                .Visit(_persistentData.webAutomationJourney.visitList)
                .Go();
        }

        /// <summary>
        /// Log into a pre-exisiting eBanking account.
        /// </summary>
        /// <param name="dedupeAccountSelectOption">Determine whenther the account selected is a dedupe acocunt</param>
        public void LogIntoExistingAccount(string dedupeAccountSelectOption = null)
        {
            if (_persistentData.journeyType.ToLower() != "ebanking")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The specflow command '...I log into an existing account, " +
                    "selecting \"\" accounts' can only be used for the " +
                    "journey type ebanking.");
            }

            _persistentData.webAutomationJourney.visitList =
                _persistentData.targetRepo.GetPagesFor("ExistingLogin", _testContext);

            // Changing the eBanking username to userID displayed in the portal.
            _persistentData.webAutomationJourney.ChangeJourneyData(
                "EBankingLoginPage",
                "userName",
                _persistentData.userId[0]);

            _persistentData.webAutomationJourney.ChangeJourneyData(
                "EBankingLoginPage",
                "password",
                _persistentData.wholeScenarioJourneyData.GetScenarioData(
                    "EAP12",
                    "enterPassword"));

            _persistentData.webAutomationJourney.ChangeJourneyData(
                "AccountTypePage",
                "dedupe",
                _persistentData.wholeScenarioJourneyData.GetScenarioData(
                    "EAP12",
                    "dedupe"));

            if (dedupeAccountSelectOption != null)
            {
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "AccountTypePage",
                    "accountToSelect",
                    dedupeAccountSelectOption);
            }


            _persistentData.webAutomationJourney.StartFrom(
                    _testContext.Properties["eBankingLoginPageUrl"].ToString())
                .Visit(_persistentData.webAutomationJourney.visitList)
                .Go();
        }
        #endregion

        #region Servicing Section
        public void AccountBalanceUpdate(string whichAccount = "first")
        {
            if (_persistentData.journeyType.ToLower() != "ebanking")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid journey type. Specflow command " +
                    "'...the account balance is updated successfully' " +
                    "can only be used with the ebanking journey type.");
            }
            _persistentData.webAutomationJourney.currentPage = new EBankingAccountsPage();
            _persistentData.webAutomationJourney.SetCurrenPageDriver();
            _persistentData.webAutomationJourney.currentPage.WaitForNextScreen(_persistentData.webAutomationJourney.currentPage.pageLoadedElement);

            double result;
            double? originalBalance = null;
            double? withdrawAmount = null;
            double? newBalance = null;

            if (double.TryParse(_persistentData.wholeScenarioJourneyData.GetScenarioData("EAP19", "pledgeAmount"), out result))
            {
                originalBalance = result;
            }
            if (double.TryParse(_persistentData.wholeScenarioJourneyData.GetScenarioData("EnterPaymentDetailsPage", "amount"), out result))
            {
                withdrawAmount = result;
            }

            Element e = ((EBankingAccountsPage)_persistentData.webAutomationJourney.currentPage).GetFundsAmountElement(GetAccountNumber(whichAccount));
            string sanitisedFundsText = _persistentData.webAutomationJourney.currentPage.GetTextFromElement(e);

            if (double.TryParse(sanitisedFundsText.Replace("£", "").Replace(",", ""), out result))
            {
                newBalance = result;
            }
            if (originalBalance == null)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Specflow command: '...the account balance is updated " +
                    "successfully for the \"\" account'.'originalBalance' " +
                    "not found!");
            }
            if (withdrawAmount == null)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Specflow command: '...the account balance is updated " +
                    "successfully for the \"\" account'.'withdrawAmount'" +
                    " not found!");
            }
            if (newBalance == null)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Specflow command: '...the account balance is updated " +
                    "successfully for the \"\" account'. 'newBalance' " +
                    "not found!");
            }
            if (newBalance != originalBalance - withdrawAmount)
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "The new account balance is incorrect!",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }
        }

        /// <summary>
        /// Close an open account in the Servicing application.
        /// </summary>
        public void CloseAccountServicing()
        {
            _persistentData.appAutomationJourney.currentPage = new Ribbon();
            _persistentData.appAutomationJourney.SetCurrenPageDriver();
            Element tempElement = ((Ribbon)_persistentData.appAutomationJourney.currentPage).exitAccountBtn;
            _persistentData.appAutomationJourney.currentPage.ClickElement(tempElement.locator);
        }

        /// <summary>
        /// Close an active workspace in the Servicing application.
        /// </summary>
        public void CloseWorkspaceServicing()
        {
            _persistentData.appAutomationJourney.currentPage = new Ribbon();
            _persistentData.appAutomationJourney.SetCurrenPageDriver();
            Element tempElement = ((Ribbon)_persistentData.appAutomationJourney.currentPage).workspaceMenu;
            _persistentData.appAutomationJourney.currentPage.ClickElement(tempElement.locator);
            tempElement = new Workspace().exitWorkspace;
            _persistentData.appAutomationJourney.currentPage.ClickElement(tempElement.locator);
        }

        /// <summary>
        /// Right click and select an option from the menu.
        /// </summary>
        /// <param name="element">The element to be right clicked.</param>
        /// <param name="menuOptionName">The option to select from the context menu.</param>
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
        /// Retrieve the customer number from the Servicing Summary Tab.
        /// </summary>
        /// <param name="customerIndex">The target index (number of the) customer</param>
        public void RetrieveCustomerNumber(string customerIndex)
        {
            List<string> availableCustomerIndexes = new List<string>() { "1st", "2nd", "3rd", "4th" };

            if (_persistentData.journeyType.ToLower() != "servicing")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "This SpecFlow statement can only be used for Servicing journeys.");
            }

            if (availableCustomerIndexes.Contains(customerIndex))
            {
                string customerNo = null;
                _persistentData.appAutomationJourney.SetCurrentPage(new SummaryTab());
                _persistentData.appAutomationJourney.SetCurrenPageDriver();

                SummaryTab summaryTab = (SummaryTab)_persistentData.appAutomationJourney.currentPage;
                _persistentData.appAutomationJourney.currentPage.WaitForNextScreen(summaryTab.pageLoadedElement);

                switch (customerIndex)
                {
                    case "1st":
                        customerNo = summaryTab
                            .GetUniqueInputElement(summaryTab.firstCustomerNo.locator)
                            .GetAttribute("Value.Value");
                        break;

                    case "2nd":
                        customerNo = summaryTab
                            .GetUniqueInputElement(summaryTab.secoundCustomerNo.locator)
                            .GetAttribute("Value.Value");
                        break;

                    case "3rd":
                        customerNo = summaryTab
                            .GetUniqueInputElement(summaryTab.thirdCustomerNo.locator)
                            .GetAttribute("Value.Value");
                        break;

                    case "4th":
                        customerNo = summaryTab
                            .GetUniqueInputElement(summaryTab.fourthCustomerNo.locator)
                            .GetAttribute("Value.Value");
                        break;
                }
                _persistentData.customerNumberList.Add(customerNo);
                Console.WriteLine("Customer Number: " + customerNo);
            }
            else
            {
                new TestEnder().FailEnd(Defs.failNonAssert,
                    "The value supplied: '" + customerIndex + "' is not a " +
                    "supported input for the current SpecFlow command.");
            }
        }

        /// <summary>
        /// Select the servicing wizard with the given name.
        /// </summary>
        /// <param name="wizardType">The name of the target wizard</param>
        public void SelectWizardServicing(string wizardType)
        {
            _persistentData.appAutomationJourney.visitList =
                _persistentData.targetRepo.GetPagesFor(
                    wizardType.Replace(" ", "").Replace("/", "").Replace("-", "").ToLower(), 
                    _testContext);

            if (wizardType.ToLower().Replace(" ", "") == "adhocdeposit")
            {
                _persistentData.appAutomationJourney.ChangeJourneyData(
                    "AdHocDepositOpen",
                    "productType",
                    _persistentData.wholeScenarioJourneyData.GetScenarioData(
                        "ProductSelection",
                        "productType"));
            }
        }

        /// <summary>
        /// Search of a case using a given parameter. 
        /// </summary>
        /// <param name="searchData">The data used to search for the target case.</param>
        /// <param name="searchUsing">The method used to search (by default this is set to account number)</param>
        public void ServicingCaseSearch(string searchData, string searchUsing = "accountno")
        {
            _persistentData.appAutomationJourney.SetCurrentPage(new AccountSearchCriteriaPage());
            _persistentData.appAutomationJourney.SetCurrenPageDriver();
            Element elementToEnterSearchDataInto = null;
            switch (searchUsing.ToLower().Replace(" ", ""))
            {
                case "accountno":
                    elementToEnterSearchDataInto =
                        ((AccountSearchCriteriaPage)_persistentData.appAutomationJourney.currentPage).accountNumberBox;
                    break;
                    //further switch statements to go here
            }
            if (elementToEnterSearchDataInto == null)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Unable to search servicing accounts based on the " +
                    "parameter '" + searchUsing + "'. Please review.");
            }

            _persistentData.appAutomationJourney.currentPage.CompleteElement(
                searchData,
                elementToEnterSearchDataInto.locator);
            _persistentData.appAutomationJourney.currentPage.ClickElement(
                ((AccountSearchCriteriaPage)_persistentData.appAutomationJourney.currentPage)
                    .accountsSearchBtn.locator);

        }

        /// <summary>
        /// Select an option to perform on a document
        /// </summary>
        /// <param name="documentName">The target document</param>
        /// <param name="contextMenuOption">The name of the option to perform</param>
        public void ServicingDocumentOptionSelection(string documentName, string contextMenuOption)
        {
            string targetElementLocator = "Descriptions";
            string targetElementType = "Document";
            
            ServicingOptionSelection("Document", documentName, targetElementLocator, contextMenuOption, targetElementType);
        }

        /// <summary>
        /// Select an option to perform on a note
        /// </summary>
        /// <param name="noteName">The target note</param>
        /// <param name="contextMenuOption">The name of the option to perform</param>
        public void ServicingNoteOptionSelection(string noteName, string contextMenuOption)
        {
            string targetElementLocator = "FormattedTitle";
            string targetElementType = "Note";

            ServicingOptionSelection("Note", noteName, targetElementLocator, contextMenuOption, targetElementType);
        }

        /// <summary>
        /// Open a case using a given parameter.
        /// </summary>
        public void ServicingOpenCase()
        {
            // Updated Version
            AccountSearchCriteriaPage accountSearchCriteriaPage = (AccountSearchCriteriaPage)_persistentData.appAutomationJourney.currentPage;
            _persistentData.appAutomationJourney.SetCurrenPageDriver();
            
            accountSearchCriteriaPage.caseId = _persistentData.applicationReference.Last();

            _persistentData.appAutomationJourney.currentPage.DoubleClickElement(
                ((AccountSearchCriteriaPage)_persistentData.appAutomationJourney.currentPage).accountsGridFirstRow.locator);
            //

            //_persistentData.appAutomationJourney.currentPage.DoubleClickElement(
            //    ((AccountSearchCriteriaPage)_persistentData.appAutomationJourney.currentPage).accountsGridFirstRow.locator);

            _persistentData.appAutomationJourney.SetCurrentPage(new AuthenticateCustomerPage());
            _persistentData.appAutomationJourney.SetCurrenPageDriver();
            _persistentData.appAutomationJourney.currentPage.ExplicitWait(((AuthenticateCustomerPage)_persistentData.appAutomationJourney.currentPage).authenticateInPerson.locator);
            _persistentData.appAutomationJourney.currentPage.ClickElement(((AuthenticateCustomerPage)_persistentData.appAutomationJourney.currentPage).authenticateInPerson.locator);
        }
        
        /// <summary>
        /// Higher level function used to select the correct option completion method.
        /// </summary>
        /// <param name="targetElementName">The name of the element</param>
        /// <param name="targetElementLocator">The locator of the target element</param>
        /// <param name="contextMenuOption">The name of the option.</param>
        /// <param name="targetElementType">The 'type' of the target element.</param>
        public void ServicingOptionSelection(string sectionName, string targetElementName, string targetElementLocator, string contextMenuOption, string targetElementType)
        {
            string sanitisedSectionName = sectionName.ToLower().Replace(" ", "");

            switch (sanitisedSectionName)
            {
                case "note":

                    if (_persistentData.journeyType.ToLower() == "servicing")
                    {
                        // /Edit[@Name=\"FormattedTitle\"] - Notes list of elements XPath
                        System.Collections.ObjectModel.ReadOnlyCollection<WindowsElement> listOfElements =
                            _persistentData.appAutomationJourney.appDriver.FindElementsByXPath("//Edit[@Name=\"FormattedTitle\"]");

                        WindowsElement requiredElement = null;
                        foreach (WindowsElement we in listOfElements)
                        {
                            if (we.FindElementByName(targetElementLocator).GetAttribute("Value.Value").ToLower().Contains(targetElementName.ToLower()))
                            {
                                requiredElement = we;
                                break;
                            }
                        }

                        if (requiredElement == null)
                        {
                            new TestEnder().FailEnd(
                                Defs.failNonAssert,
                                "The " + targetElementType + "with the title '" + targetElementName +
                                "' cannot be found to perform a context click on.",
                                _persistentData.appAutomationJourney.appDriver,
                                _testContext);
                        }

                        ContextClickElementAndSelectContextMenuOption(requiredElement, contextMenuOption);
                    }
                    else
                    {
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "The SpecFlow command '... I context click the Servicing" + targetElementType +
                            "\"\" and select the option \"\"' can only be used with Servicing journeys.",
                            _persistentData.appAutomationJourney.appDriver,
                            _testContext);
                    }
                    break;

                case "document":
                case "task":

                    if (_persistentData.journeyType.ToLower() == "servicing")
                    {
                        // //DataItem[@Name=\"System.Drawing.Bitmap\"] - Task list of elements XPath

                        System.Collections.ObjectModel.ReadOnlyCollection<WindowsElement> listOfElements =
                            _persistentData.appAutomationJourney.appDriver.FindElementsByXPath("//DataItem[@Name=\"System.Drawing.Bitmap\"]");

                        WindowsElement requiredElement = null;
                        foreach (WindowsElement we in listOfElements)
                        {
                            if (we.FindElementByName(targetElementLocator).GetAttribute("Value.Value").ToLower().Contains(targetElementName.ToLower()))
                            {
                                requiredElement = we;
                                break;
                            }
                        }

                        if (requiredElement == null)
                        {
                            new TestEnder().FailEnd(
                                Defs.failNonAssert,
                                "The " + targetElementType + "with the title '" + targetElementName +
                                "' cannot be found to perform a context click on.",
                                _persistentData.appAutomationJourney.appDriver,
                                _testContext);
                        }

                        ContextClickElementAndSelectContextMenuOption(requiredElement, contextMenuOption);
                    }
                    else
                    {
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "The SpecFlow command '... I context click the Servicing" + targetElementType +
                            "\"\" and select the option \"\"' can only be used with Servicing journeys.",
                            _persistentData.appAutomationJourney.appDriver,
                            _testContext);
                    }
                    break;
            }

        }

        /// <summary>
        /// Select an option to perform on a process
        /// </summary>
        /// <param name="processName">The name of the target process</param>
        /// <param name="contextMenuOption">The name of the option to perform</param>
        public void ServicingProcressOptionSelection(string processName, string contextMenuOption)
        {
            if (_persistentData.journeyType.ToLower() == "servicing")
            {
                _persistentData.appAutomationJourney.SetCurrentPage(new CurrentWorkspaceTab());
                _persistentData.appAutomationJourney.currentPage.ClickElement(
                    _persistentData.appAutomationJourney.currentPage.GetPageElement("viewProcessesInitiatedChbox").locator);

                //System.Collections.ObjectModel.ReadOnlyCollection<WindowsElement> listOfProcesses =
                //    _persistentData.appAutomationJourney.appDriver.FindElementsByXPath(
                //        "//Custom[contains(@Name, 'ProcessViewBinder')]/DataItem[@Name='Description']");

                //System.Collections.ObjectModel.ReadOnlyCollection<WindowsElement> listOfProcesses =
                //    _persistentData.appAutomationJourney.appDriver.FindElementsByXPath(
                //        _persistentData.appAutomationJourney.currentPage.GetPageElement("processList").locator.ToString());
                




                WindowsElement processesTable = _persistentData.appAutomationJourney.appDriver.FindElementByXPath("//Pane[@AutomationId=\"processesGrid\"]" +
                    "/Custom[@AutomationId=\"ultraGrid\"]" +
                    "/Custom[@AutomationId=\"Data Area\"]" +
                    "/Tree[@AutomationId=\"ColScrollRegion: 0, RowScrollRegion: 0\"]");

                System.Collections.ObjectModel.ReadOnlyCollection<OpenQA.Selenium.Appium.AppiumWebElement> listOfProcesses = 
                    processesTable.FindElementsByXPath("//DataItem/Edit[@Name=\"Description\"]");
                

                if (listOfProcesses.Count == 0)
                {
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "A process with the name '" + processName +
                        "' cannot be found to perform a context click on.",
                        _persistentData.appAutomationJourney.appDriver,
                        _testContext);
                }

                WindowsElement reqElement = null;
                foreach (WindowsElement we in listOfProcesses)
                {
                    string description = we.FindElementByName("Description").GetAttribute("Value.Value");
                    if (we.GetAttribute("Value.Value").ToLower() == processName.ToLower())
                    {
                        reqElement = we;
                        break;
                    }
                }
                if (reqElement == null)
                {
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "A process with the name '" + processName +
                        "' cannot be found to perform a context click on.",
                        _persistentData.appAutomationJourney.appDriver,
                        _testContext);
                }
                
                ContextClickElementAndSelectContextMenuOption(reqElement, contextMenuOption);
            }
            else
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The specflow command '...I context click the process " +
                    "\"\" and select the option \"\"' can only be " +
                    "used with Servicing");
            }
        }
        
        /// <summary>
        /// Select an option to perform on a task
        /// </summary>
        /// <param name="taskName">The name of the target task</param>
        /// <param name="contextMenuOption">The name of the option to perform</param>
        public void ServicingTaskOptionSelection(string taskName, string contextMenuOption)
        {

            string targetElementLocator = "Description";
            string targetElementType = "Task";

            ServicingOptionSelection("Task", taskName, targetElementLocator, contextMenuOption, targetElementType);
        }
        #endregion

        #region App Specific Section

        /// <summary>
        /// Check if a BackOffice case is displayed correctly.
        /// </summary>
        /// <param name="caseId"></param>
        public void CaseSearchVerification(string caseId = null)
        {
            string displayedValue = string.Empty;

            if (_persistentData.journeyType.ToLower() == "backoffice")
            {
                CaseSearchTab caseSearchTab =
                (CaseSearchTab)_persistentData.appAutomationJourney.currentPage;
                if (caseId == null)
                {
                    caseId = _persistentData.applicationReference[0];
                }
                // Moving the case ID value into the caseSearchTab Page Object instance.
                caseSearchTab.caseId = caseId;

                displayedValue =
                    caseSearchTab.GetUniqueInputElement(
                        caseSearchTab.firstRowBoxID.locator).GetAttribute("Value.Value");

            }
            else if(_persistentData.journeyType.ToLower() == "servicing")
            {
                AccountSearchCriteriaPage accountSearchCriteriaPage =
                    (AccountSearchCriteriaPage)_persistentData.appAutomationJourney.currentPage;
                if(caseId == null)
                {
                    caseId = _persistentData.applicationReference.Last();
                }
                accountSearchCriteriaPage.caseId = caseId;

                displayedValue =
                    accountSearchCriteriaPage.GetUniqueInputElement(
                        accountSearchCriteriaPage.accountsGridFirstRow.locator).GetAttribute("Value.Value");
            }

            if (caseId != displayedValue)
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "Case ref does not match. Expected: '" + caseId +
                    "'. Actual: '" + displayedValue + "'.",
                    _persistentData.appAutomationJourney.appDriver,
                    _testContext);
            }
        }
        /// <summary>
        /// Navigate to a specfic tab within the application.
        /// </summary>
        /// <param name="tabName">The name of the target tab</param>
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

        /// <summary>
        /// Open a case within an application
        /// </summary>
        public void OpenCase(int ordinalCaseNumber = 0)
        {
            if (_persistentData.journeyType.ToLower() == "backoffice")
            {
                BackOfficeCaseSearch();
                CaseSearchVerification();
                BackOfficeOpenCase();
            }
            else if (_persistentData.journeyType.ToLower() == "servicing")
            {
                if(ordinalCaseNumber == 0)
                {
                    ServicingCaseSearch(_persistentData.applicationReference[0]);
                    CaseSearchVerification();
                    ServicingOpenCase();
                }
                else
                {
                    ServicingCaseSearch(_persistentData.bankAccountNumber[ordinalCaseNumber]);
                    CaseSearchVerification();
                    ServicingOpenCase();
                }

                
                // Old
                //ServicingOpenCase(_persistentData.bankAccountNumber[0]);
            }
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
            else if (_persistentData.journeyType.ToLower() == "servicing")
            {
                int whichAccountNum = GetWhichIterationOfAccount(whichAccount);
                OpenCase(whichAccountNum);
            }
            else
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Specflow command: '...I open the XXX case' can only be " +
                    "used with the journey types backoffice or servicing. " +
                    "Please review the scenario.");
            }
        }

        /// <summary>
        /// TODO: Complete when required
        /// </summary>
        /// <param name="searchType"></param>
        public void SearchForCaseUsingParameters(string searchType)
        {
            // TODO: Complete.
            if (_persistentData.journeyType.ToLower() == "backoffice")
            {
            }
            else if (_persistentData.journeyType.ToLower() == "servicing")
            {
                switch (searchType.ToLower())
                {
                    case "surname":
                        break;
                    case "customerno":
                        break;
                    case "dob":
                    case "dateofbith":
                        break;
                    case "phoneno":
                        break;
                    case "firstname":
                        break;
                    case "businessname":
                        break;
                    case "nino":
                    case "nationalinsurnacenumber":
                    case "ninumber":
                    case "nationalinsurnaceno":
                        break;
                    case "postalcode":
                    case "postcode":
                        break;
                    case "towncity":
                    case "town/city":
                    case "town":
                    case "city":
                        break;
                    case "iddocumentno":
                        break;
                    case "accountno":
                    case "accountnumber":
                        break;
                    case "orirefno":
                    case "ori.ref.no":
                    case "originationrefno":
                        break;
                    case "securitytown/city":
                    case "securitytowncity":
                    case "securitytown":
                    case "securitycity":
                        break;
                    case "securitypostalcode":
                    case "securitypostcode":
                        break;

                }
            }
        }
        #endregion

        #region Portal Specficic Section
        /// <summary>
        /// Select a Savings product by name.
        /// </summary>
        /// <param name="productName">The name of the target product</param>
        public void ChooseProduct(string productName)
        {
            if (_persistentData.journeyType.ToLower() != "savings" &&
                _persistentData.journeyType.ToLower() != "ebanking")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid journey type. The specflow command '... I choose " +
                    "the \"\" product' can only be used with journey types " +
                    "ebanking and savings.");
            }
            ChooseSavingsOption(productName);
        }

        /// <summary>
        /// Select a type of Savings product.
        /// </summary>
        /// <param name="productType">The name of the target product type</param>
        public void ChooseProductType(string productType)
        {
            if (_persistentData.journeyType.ToLower() != "savings" &&
                _persistentData.journeyType.ToLower() != "ebanking")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid journey type. The specflow command '...I choose " +
                    "a \"\" product' is only valid for the journey types " +
                    "ebanking and savings.");
            }

            productType = productType.ToLower().Replace(" ", "");
            List<string> acceptedProductTypes = new List<string>() {
                "retail",
                "child",
                "corporate",
                "isa",
                "childisa" };

            string defaultCaseName = string.Empty;

            if (!acceptedProductTypes.Contains(productType))
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid product type provided in the specflow command '...I " +
                    "choose a \"\" product'." + "'" + productType + "' is not valid.");
            }

            // Setting the defaultCase for each product type.
            switch (productType)
            {
                case "retail":
                    RetailProductList retailProductList = new RetailProductList();
                    if (retailProductList.retailProducts[0] == null)
                    {
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "The '" + productType + "' product list contains " +
                            "no products!");
                    }
                    defaultCaseName = retailProductList.retailProducts[0];
                    break;

                case "child":
                    ChildProductList childProductList = new ChildProductList();
                    if (childProductList.childProducts[0] == null)
                    {
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "The '" + productType + "' product list contains " +
                            "no products!");
                    }
                    defaultCaseName = childProductList.childProducts[0];
                    break;

                case "childisa":
                    ChildIsaProductList childIsaProductList = new ChildIsaProductList();
                    if (childIsaProductList.childIsaProducts[0] == null)
                    {
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "The '" + productType + "' product list contains " +
                            "no products!");
                    }

                    defaultCaseName = childIsaProductList.childIsaProducts[0];
                    break;


                case "corporate":
                    CorporateProductList corporateProductList = new CorporateProductList();
                    if (corporateProductList.corporateProducts[0] == null)
                    {
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "The '" + productType + "' product list contains " +
                            "no products!");
                    }
                    defaultCaseName = corporateProductList.corporateProducts[0];
                    break;


                case "isa":
                    ISAProductList isaProductList = new ISAProductList();
                    if (isaProductList.isaProducts[0] == null)
                    {
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "The '" + productType + "' product list contains " +
                            "no products!");
                    }
                    defaultCaseName = isaProductList.isaProducts[0];
                    break;

            }

            if (_persistentData.journeyType.ToLower() == "savings")
            {
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "ProductSelection",
                    "productName",
                    defaultCaseName);
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "ProductSelection",
                    "productType",
                    productType);
            }
            else if (_persistentData.journeyType.ToLower() == "ebanking")
            {
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "AP01",
                    "productName",
                    defaultCaseName);
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "AP01",
                    "productType",
                    productType);
            }
        }

        /// <summary>
        /// Defines the product that should be selected.
        /// </summary>
        /// <param name="productName">The target product name</param>
        public void ChooseSavingsOption(string productName)
        {
            if (_persistentData.journeyType.ToLower() != "savings" &&
                _persistentData.journeyType.ToLower() != "ebanking")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid journey type. The specflow command '... I choose " +
                    "the \"\" product' can only be used with journey types " +
                    "ebanking and savings.");
            }

            bool productExists = false;
            string productType = string.Empty;

            if (new CorporateProductList().corporateProducts.Contains(productName))
            {
                productExists = true;
                productType = "Corporate";

            }
            else if (new ChildProductList().childProducts.Contains(productName))
            {
                productExists = true;
                productType = "Child";

            }
            else if (new ChildIsaProductList().childIsaProducts.Contains(productName))
            {
                productExists = true;
                productType = "ChildIsa";

            }
            else if (new ISAProductList().isaProducts.Contains(productName))
            {
                productExists = true;
                productType = "ISA";
            }
            else if (new RetailProductList().retailProducts.Contains(productName))
            {
                productExists = true;
                productType = "Retail";
            }

            if (productExists == false)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The product '" + productName + "' cannot be found within " +
                    "the POM. Please review the product name or, if new, add to " +
                    "the relevant product category.");
            }
            // Update the journeyData
            if (_persistentData.webAutomationJourney != null)
            {
                string productSelectPage;
                if (_persistentData.journeyType.ToLower() == "savings")
                {
                    productSelectPage = "ProductSelection";
                }

                else
                {
                    productSelectPage = "AP01";
                }
                    
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    productSelectPage,
                    "productName",
                    productName);

                _persistentData.webAutomationJourney.ChangeJourneyData(
                    productSelectPage,
                    "productType",
                    productType);
            }
        }

        /// <summary>
        /// Compares the eBanking credientials of the account with the value recieved from the portal.
        /// </summary>
        /// <param name="whichAccount">The target account</param>
        public void EbankingCredentialComparison(string whichAccount)
        {
            if (_persistentData.journeyType.ToLower() == "ebanking" ||
                _persistentData.journeyType.ToLower() == "savings")
            {
                if (_persistentData.userId[_persistentData.bankAccountNumber.Count - 1] != _persistentData.userId[GetWhichIterationOfAccount(whichAccount)])
                {
                    new TestEnder().FailEnd(
                        Defs.failAssert,
                        "'...the ebanking User id matches the \"\" application' " +
                        "- The account numbers do not match. Expected: '" +
                        _persistentData.userId[GetWhichIterationOfAccount(whichAccount)] +
                        "'. Actual: '" + _persistentData.userId[_persistentData.bankAccountNumber.Count - 1] + "'.",
                        _persistentData.webAutomationJourney.driver,
                        _testContext);
                }
            }
            else
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "'...the ebanking User id matches the \"\" application' " +
                    "- This specflow command is only available for ebanking " +
                    "and savings journeys.");
            }
        }

        /// <summary>
        /// In the event the portal dies bit display the eBanking credentials, output the correct error.
        /// </summary>
        public void EBankingCredentialsNotDisplayed()
        {
            if (_persistentData.journeyType.ToLower() != "savings" &&
                _persistentData.journeyType.ToLower() != "ebanking")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid journey type. The specflow command '...the " +
                    "eBanking credentials are not displayed' can only be used " +
                    "with the journey types ebanking or savings.");
            }

            string wholeText = _persistentData.webAutomationJourney.currentPage.GetTextFromElement(
                _persistentData.webAutomationJourney.currentPage.GetPageElement("applicationReferenceBox"));

            _persistentData.applicationReference.Insert(0, Regex.Replace(wholeText, @"[^\d]", String.Empty));

            //Console.WriteLine("ApplicationReference: " + _persistentData.applicationReference);

            // Assert certain values do not display

            _persistentData.webAutomationJourney.currentPage = new DecisionPage();
            _persistentData.webAutomationJourney.SetCurrenPageDriver();


            if (_persistentData.webAutomationJourney.currentPage.IsElementDisplayed(_persistentData.webAutomationJourney.currentPage.GetPageElement("userIDBox")))
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "Specflow command: '...the ebanking credentials are not " +
                    "displayed' has failed - the 'userIDBox' is displayed.",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }
            if (_persistentData.webAutomationJourney.currentPage.IsElementDisplayed(_persistentData.webAutomationJourney.currentPage.GetPageElement("sortCodeBox")))
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "Specflow command: '...the ebanking credentials are not " +
                    "displayed' has failed - the 'sortCodeBox' is displayed.",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }
            if (_persistentData.webAutomationJourney.currentPage.IsElementDisplayed(_persistentData.webAutomationJourney.currentPage.GetPageElement("bankAccNumberBox")))
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "Specflow command: '...the ebanking credentials are not " +
                    "displayed' has failed - the 'bankAccNumberBox' is displayed.",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }
        }

        /// <summary>
        /// Set the number of shareholders to be entered during the portal journey.
        /// </summary>
        /// <param name="numberOfShareholders">The number of shareholders</param>
        public void SetShareholderNumber(int numberOfShareholders)
        {
            if (_persistentData.journeyType.ToLower() != "savings" && 
                _persistentData.journeyType.ToLower() != "ebanking")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid journey type. The specflow command '...the number " +
                    "of shareholders is equal to \"\"' " + "can only be used with " +
                    "the journey types ebanking or savings.");
            }
            List<int> acceptedInputs = new List<int>() { 0, 1, 2, 3, 4 };

            if (!acceptedInputs.Contains(numberOfShareholders))
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "'Given the number of shareholders is equal to '" +
                    numberOfShareholders.ToString() + "' - " +
                    "Invalid input. Please review.");
            }


            _persistentData.webAutomationJourney.ChangeJourneyData(
                "EAP06",
                "numberOfOtherApplicants",
                numberOfShareholders.ToString());
        }

        /// <summary>
        /// Set the number of signatories to be entered during the portal journey.
        /// </summary>
        /// <param name="numberOfSignatories">The number of signatories</param>
        public void SetSignatoryNumber(int numberOfSignatories)
        {
            if (_persistentData.journeyType.ToLower() != "savings" &&
                _persistentData.journeyType.ToLower() != "ebanking")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Invalid journey type. The specflow command '...the number " +
                    "of signatories is equal to \"\"' " +
                    "can only be used with the journey types ebanking or savings.");
            }

            List<int> acceptedInputs = new List<int>() { 1, 2, 3, 4 };
            if (!acceptedInputs.Contains(numberOfSignatories))
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "'Given the number of signatories is equal to '" +
                    numberOfSignatories.ToString() + "' - " +
                    "Invalid input. Please review.");
            }

            _persistentData.webAutomationJourney.ChangeJourneyData(
                "EAP05",
                "numberOfSignatories",
                numberOfSignatories.ToString());
        }
        #endregion

        #region Global Helper Method Section

        /// <summary>
        /// Checks to see if text is displayed on the screen.
        /// </summary>
        /// <param name="targetText">The text to be searched for</param>
        public void CheckTextIsDisplayed(string targetText)
        {
            string remainingText = targetText;
            string locatorType;
            int currentIndex = 0;
            LocatorList locatorList = new LocatorList();

            if (_persistentData.journeyType.ToLower() == "savings" ||
                _persistentData.journeyType.ToLower() == "ebanking")
            {
                locatorType = Defs.locatorText;
            }
            else
            {
                locatorType = Defs.boLocatorText;
            }

            currentIndex = remainingText.IndexOf(" ");
            while (currentIndex != -1)
            {
                locatorList.Add(locatorType, remainingText.Substring(0, currentIndex));
                remainingText = remainingText.Substring(currentIndex + 1);
                currentIndex = remainingText.IndexOf(" ");
            }
            locatorList.Add(locatorType, remainingText);


            int stringOccurrence = 0;
            if (_persistentData.journeyType.ToLower() == "savings" ||
                _persistentData.journeyType.ToLower() == "ebanking")
            {
                stringOccurrence = _persistentData.webAutomationJourney.currentPage.GetNumberOfElements(
                     _persistentData.webAutomationJourney.currentPage.FindElement(locatorList));
            }

            else if (_persistentData.journeyType.ToLower() == "backoffice" ||
                _persistentData.journeyType.ToLower() == "servicing")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The 'Given/When/Then/And the text \"x\" " +
                    "cannot be used for application automation.");
            }

            if (stringOccurrence > 1)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "ERROR: Text - '" + targetText + "' is displayed more than once. " +
                    "This means that the test result could be ambiguous.",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }

            else if (stringOccurrence == 0)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "ERROR: Text - '" + targetText + "' is not displayed.",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }
        }

        /// <summary>
        /// Click the target element.
        /// </summary>
        /// <param name="elementName">The name of the target element</param>
        public void ClickElement(string elementName)
        {
            switch (_persistentData.journeyType.ToLower())
            {
                case "ebanking":
                case "savings":
                    _persistentData.webAutomationJourney.currentPage.ClickElement(
                        _persistentData.webAutomationJourney.currentPage.GetPageElement(elementName).locator);
                    break;

                case "backoffice":
                case "servicing":
                    _persistentData.appAutomationJourney.currentPage.ClickElement(
                        _persistentData.appAutomationJourney.currentPage.GetPageElement(elementName).locator);
                    break;

                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "Invalid journey type. The specflow command '...I " +
                        "click \"\"' can only be used with journey types " +
                        "ebanking, savings, backoffice or servicing.");
                    break;
            }
        }

        /// <summary>
        /// Check that the target element satisfies a certain condition.
        /// </summary>
        /// <param name="elementName">The name of the target element</param>
        /// <param name="compareType">The method of comparison</param>
        /// <param name="value">The comparison value</param>
        public void ConditionalValueCheck(string elementName, string compareType, string value)
        {
            string pageName;
            double result = 0;
            compareType = compareType.ToLower();
            if ((compareType == "greater than" || compareType == "less than") && 
                double.TryParse(value, out result))
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert, 
                    "The specflow command '...I am not able to continue " +
                    "whilst \"\" is \"\" \"\"' cannot complete because " +
                    "comparison type is '" + compareType + "' but '" + 
                    value + "' cannot be converted to a number.");
            }
            List<string> comparisonTypeList = new List<string>();
            bool isDisplayed;
            string newData = null;
            if (compareType == "greater than")
            {
                comparisonTypeList.Add(">");
                comparisonTypeList.Add("=");
            }
            else if (compareType == "less than")
            {
                comparisonTypeList.Add("<");
                comparisonTypeList.Add("=");
            }

            switch (_persistentData.journeyType.ToLower())
            {
                case "ebanking":
                case "savings":
                    pageName = _persistentData.webAutomationJourney.currentPage.className;
                    for (int i = 0; i < comparisonTypeList.Count; i++)
                    {
                        if (comparisonTypeList[i] == "=")
                        {
                            newData = value;
                        }
                        else if (comparisonTypeList[i] == ">")
                        {
                            newData = (result + 1).ToString();
                        }
                        else if (comparisonTypeList[i] == "<")
                        {
                            newData = (result - 1).ToString();
                        }
                        _persistentData.webAutomationJourney.ChangeJourneyData(
                            pageName, 
                            elementName, 
                            newData);

                        _persistentData.webAutomationJourney.UpdateJourneyData();

                        ((WebBasePage)_persistentData.webAutomationJourney.currentPage).CompletePage(
                            _persistentData.webAutomationJourney.driver,
                            _persistentData.webAutomationJourney.journeyData);

                        isDisplayed = _persistentData.webAutomationJourney.currentPage.IsElementDisplayed(
                            _persistentData.webAutomationJourney.currentPage.pageLoadedElement);
                        if (i == comparisonTypeList.Count - 1)
                        {
                            if (isDisplayed)
                            {
                                new TestEnder().FailEnd(
                                    Defs.failAssert, 
                                    "'" + pageName + "' is displayed when '" + 
                                    elementName + "'" + "is " + comparisonTypeList[i] + 
                                    " '" + value + "'", 
                                    _persistentData.webAutomationJourney.driver,
                                    _testContext);
                            }
                        }
                        else
                        {
                            if (!isDisplayed)
                            {
                                new TestEnder().FailEnd(
                                    Defs.failAssert, 
                                    "'" + pageName + "' is not displayed when '" + 
                                    elementName + "'" + "is " + comparisonTypeList[i] + 
                                    " '" + value + "'", 
                                    _persistentData.webAutomationJourney.driver,
                                    _testContext);
                            }
                        }
                    }
                    _persistentData.remainingVisitList.Remove(_persistentData.webAutomationJourney.currentPage);
                    break;

                case "backoffice":
                case "servicing":
                    pageName = _persistentData.appAutomationJourney.currentPage.className;
                    for (int i = 0; i < comparisonTypeList.Count; i++)
                    {
                        if (comparisonTypeList[i] == "=")
                        {
                            newData = value;
                        }
                        else if (comparisonTypeList[i] == ">")
                        {
                            newData = (result + 1).ToString();
                        }
                        else if (comparisonTypeList[i] == "<")
                        {
                            newData = (result - 1).ToString();
                        }

                        _persistentData.appAutomationJourney.ChangeJourneyData(
                            pageName, 
                            elementName, 
                            newData);
                        _persistentData.appAutomationJourney.UpdateJourneyData();

                        isDisplayed = _persistentData.appAutomationJourney.currentPage.IsElementDisplayed(
                            _persistentData.appAutomationJourney.currentPage.pageLoadedElement);
                        if (i == comparisonTypeList.Count - 1)
                        {
                            if (isDisplayed)
                            {
                                new TestEnder().FailEnd(
                                    Defs.failAssert, 
                                    "'" + pageName + "' is displayed when '" + 
                                    elementName + "'" +"is " + comparisonTypeList[i] + 
                                    " '" + value + "'",
                                    _persistentData.webAutomationJourney.driver,
                                    _testContext);
                            }
                        }
                        else
                        {
                            if (!isDisplayed)
                            {
                                new TestEnder().FailEnd(
                                    Defs.failAssert, 
                                    "'" + pageName + "' is not displayed when '" + 
                                    elementName + "'" + "is " + comparisonTypeList[i] + 
                                    " '" + value + "'", 
                                    _persistentData.webAutomationJourney.driver,
                                    _testContext);
                            }
                        }
                    }
                    break;

                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert, 
                        "Invalid journey type. The specflow command '...I am " +
                        "not able to continue whilst \"\" is \"\" \"\"' is only" +
                        "valid for the journey types ebanking, servicing, backoffice, savings.");
                    break;
            }
        }

        /// <summary>
        /// Higher level method used to complete the journey that has been defined.
        /// </summary>
        /// <param name="untilPage">An optional page to stop the completion of the journey</param>
        public void CompleteJourney(string untilPage)
        {
            (List<BasePage>, List<BasePage>) separatedVisitLists;
            List<BasePage> visitList;
            BasePage untilPageBasePage = null;

            if (_persistentData.targetRepo.GetType().Name == "BOJourneyRepository" ||
                _persistentData.targetRepo.GetType().Name == "ServicingJourneyRepository")
            {
                // Straight journey.
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
                    separatedVisitLists = SeparateVisitList(_persistentData.remainingVisitList, untilPage);
                    visitList = separatedVisitLists.Item1;
                    _persistentData.remainingVisitList = separatedVisitLists.Item2;
                    untilPageBasePage = separatedVisitLists.Item2[0];
                }
                else
                {
                    separatedVisitLists = SeparateVisitList(_persistentData.appAutomationJourney.visitList, untilPage);
                    visitList = separatedVisitLists.Item1;
                    _persistentData.remainingVisitList = separatedVisitLists.Item2;
                    untilPageBasePage = separatedVisitLists.Item2[0];
                }

                _persistentData.appAutomationJourney.Visit(_persistentData.appAutomationJourney.visitList).Visit(visitList).Go();
                if (untilPage == null)
                {
                    if (_persistentData.targetRepo.GetType().Name == "ServicingJourneyRepository")
                    {
                        _persistentData.appAutomationJourney.currentPage.WaitForNextScreen(
                            _persistentData.appAutomationJourney.currentPage.pageLoadedElement);
                    }

                    _persistentData.wholeScenarioJourneyData.AddScenarioData(_persistentData.appAutomationJourney.journeyData);
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

            else if (_persistentData.targetRepo.GetType().Name == "EBankingJourneyRepository" || _persistentData.targetRepo.GetType().Name == "SavingsJourneyRepository")
            {
                if (untilPage == null && _persistentData.remainingVisitList == null)
                {
                    visitList = _persistentData.webAutomationJourney.visitList;
                    _persistentData.remainingVisitList = null;
                }
                else if (untilPage == null && _persistentData.remainingVisitList != null)
                {
                    visitList = _persistentData.remainingVisitList;
                    _persistentData.remainingVisitList = null;
                }
                else if (untilPage != null && _persistentData.remainingVisitList != null)
                {
                    separatedVisitLists = SeparateVisitList(
                        _persistentData.remainingVisitList, untilPage);

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

                _persistentData.webAutomationJourney
                    .Visit(_persistentData.webAutomationJourney.visitList)
                    .Visit(visitList)
                    .Go();

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
                }
            }
        }

        /// <summary>
        /// Create a default data journey.
        /// </summary>
        /// <param name="journeyName">The name of the target journey</param>
        public void CreateJourney(string journeyName)
        {
            //, TestContext testContext

            // List of accepted journeys.
            List<string> acceptedJourneys = new List<string>(new string[]
            {
                "savings",
                "backoffice",
                "ebanking",
                "servicing"
            });

            journeyName = journeyName.ToLower();

            if (!acceptedJourneys.Contains(journeyName))
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The journey type '" + journeyName + "' does not exist." +
                    " Please review the journey name.");
            }

            
            // Defining the type of journey required.
            switch (journeyName)
            {
                case "savings":
                case "ebanking":

                    // COMMENT OUT 'IF' STATEMENT TO CHECK SAME TIME PARALLEL EXECUTION.
                    if (journeyName == "savings")
                    {
                        int testOffsetNumberOfSeconds = 10;
                        double differenceInSeconds;
                        lock (lastSavingsTestStart_lock)
                        {
                            while ((differenceInSeconds = DateTime.Now.Subtract(lastSavingsTestStart).TotalSeconds) < testOffsetNumberOfSeconds)
                            {
                                Thread.Sleep(((int)Math.Ceiling(differenceInSeconds)) * 1000);
                            }
                            lastSavingsTestStart = DateTime.Now;
                        }
                    }
                    if (_persistentData.webAutomationJourney != null)
                    {
                        _persistentData.webAutomationJourney.DestroyDriver();
                    }
                        
                    _persistentData.webAutomationJourney = new WebJourney(logAndOutputInput: true, timeOutInSeconds: Int32.Parse(_testContext.Properties["webImplicitTimeoutInSeconds"].ToString()));
                    
                    
                    if (journeyName == "savings")
                    {
                        _persistentData.targetRepo = new SavingsJourneyRepository();
                        _persistentData.webAutomationJourney.visitList = _persistentData.targetRepo.GetPagesFor(_testContext);

                    }
                    else
                    {
                        _persistentData.targetRepo = new EBankingJourneyRepository();
                    }

                    if (journeyName == "savings")
                    {
                        //_persistentData.webAutomationJourney.StartFrom(SavingsStaticInfo.savingsProductSelectionPageUrl);

                        _persistentData.webAutomationJourney.StartFrom(_testContext.Properties["savingsProductSelectionPageUrl"].ToString());
                    }

                    break;

                case "backoffice":
                case "servicing":
                    if (journeyName == "backoffice")
                    {
                        _persistentData.targetRepo = new BOJourneyRepository();
                        _persistentData.appAutomationJourney = new AppJourney(
                            Defs.appJourneyApplicationBackoffice,
                            _testContext.Properties["backOfficeFilePath"].ToString(),
                            _testContext.Properties["backOfficeWindowLocator"].ToString(),
                            _testContext.Properties["WindowsApplicationDriverUrlOriginations1"].ToString(),
                            _testContext.Properties["WindowsApplicationDriverUrlOriginations2"].ToString(),
                            logAndOutputInput: true); 
                    }
                    else
                    {
                        _persistentData.targetRepo = new ServicingJourneyRepository();
                        _persistentData.appAutomationJourney = new AppJourney(
                            Defs.appJourneyApplicationServicing,
                            _testContext.Properties["servicingFilePath"].ToString(),
                            _testContext.Properties["servicingWindowLocator"].ToString(),
                            _testContext.Properties["WindowsApplicationDriverUrlServicing1"].ToString(),
                            _testContext.Properties["WindowsApplicationDriverUrlServicing2"].ToString(),
                            logAndOutputInput: true);
                    }

                    break;
            }
            _persistentData.journeyType = journeyName;
        }

        /// <summary>
        /// Compare the text of an element with an expected value.
        /// </summary>
        /// <param name="elementName">The name of the target element</param>
        /// <param name="expectedValue">The expected value of the target element</param>
        public void ElementTextConfirmation(string elementName, string expectedValue)
        {
            expectedValue = GetDateRelativeToToday(expectedValue);
            string actualValue = null;
            Element element;
            switch (_persistentData.journeyType.ToLower())
            {
                case "ebanking":
                case "savings":
                    element = _persistentData.webAutomationJourney.currentPage.GetPageElement(elementName);
                    actualValue = _persistentData.webAutomationJourney.currentPage.GetTextFromElement(element);
                    break;
                case "backoffice":
                case "servicing":
                    element = _persistentData.appAutomationJourney.currentPage.GetPageElement(elementName);
                    actualValue = _persistentData.appAutomationJourney.currentPage.GetTextFromElement(element);
                    break;
                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "Journey type '" + _persistentData.journeyType +
                        "' is not valid for this step definition.");
                    break;
            }

            if (!actualValue.Contains(expectedValue))
            {
                if (_persistentData.journeyType.ToLower() == "ebanking" ||
                    _persistentData.journeyType.ToLower() == "savings")
                {
                    new TestEnder().FailEnd(
                        Defs.failAssert,
                        "The value of '" + elementName + "' is '" + actualValue +
                        "', but the expected value was '" + expectedValue + "'",
                        _persistentData.webAutomationJourney.driver,
                        _testContext);
                }
                else if (_persistentData.journeyType.ToLower() == "ebanking" || 
                    _persistentData.journeyType.ToLower() == "savings")
                {
                    new TestEnder().FailEnd(
                        Defs.failAssert,
                        "The value of '" + elementName + "' is '" + actualValue +
                        "', but the expected value was '" + expectedValue + "'",
                        _persistentData.appAutomationJourney.appDriver,
                        _testContext);
                }
            }

        }

        /// <summary>
        /// Checks to see if the presence of an element with the POM name 'elementName' matches the expected result.
        /// </summary>
        /// <param name="elementName">The target element</param>
        /// <param name="expectedResult">The expected display value (true = displayed, false = not displayed)</param>
        public void ElementPresenceCheck(string elementName, bool expectedResult)
        {
            bool isDisplayed = false;

            Element element;
            switch (_persistentData.journeyType.ToLower())
            {
                case "ebanking":
                case "savings":
                    _persistentData.webAutomationJourney.currentPage.WaitForNextScreen(
                        _persistentData.webAutomationJourney.currentPage.pageLoadedElement);
                    element = _persistentData.webAutomationJourney.currentPage.GetPageElement(elementName);
                    isDisplayed = _persistentData.webAutomationJourney.currentPage.IsElementDisplayed(element);
                    break;

                case "backoffice":
                case "servicing":
                    _persistentData.appAutomationJourney.currentPage.WaitForNextScreen(
                        _persistentData.appAutomationJourney.currentPage.pageLoadedElement);
                    element = _persistentData.appAutomationJourney.currentPage.GetPageElement(elementName);
                    isDisplayed = _persistentData.appAutomationJourney.currentPage.IsElementDisplayed(element);
                    break;

                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "Invalid journey type. The specflow command '...the " +
                        "element \"\" is displayed' can only be used with " +
                        "journey types ebanking, savings, backoffice or servicing.");
                    break;
            }

            if (isDisplayed != expectedResult &&
                (_persistentData.journeyType.ToLower() == "ebanking" ||
                _persistentData.journeyType.ToLower() == "savings"))
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
                (_persistentData.journeyType.ToLower() == "backoffice" || 
                _persistentData.journeyType.ToLower() == "servicing"))
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
        /// Check an element reads the correct value.
        /// </summary>
        /// <param name="elementName">The name of the target element</param>
        /// <param name="expectedValue">The expected value of the target element</param>
        public void ElementValueCheck(string elementName, string expectedValue)
        {
            expectedValue = GetDateRelativeToToday(expectedValue);
            string actualValue = null;
            Element element;
            switch (_persistentData.journeyType.ToLower())
            {
                case "ebanking":
                case "savings":
                    element = _persistentData.webAutomationJourney.currentPage.GetPageElement(elementName);
                    actualValue = _persistentData.webAutomationJourney.currentPage.GetTextFromElement(element);
                    break;

                case "backoffice":
                case "servicing":
                    element = _persistentData.appAutomationJourney.currentPage.GetPageElement(elementName);
                    actualValue = _persistentData.appAutomationJourney.currentPage.GetTextFromElement(element);
                    break;

                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "Journey type not valid. The specflow command '...\"\" " +
                        "displays \"\"' is valid for the journey types " +
                        "ebanking, savings, backoffice or servicing.");
                    break;
            }

            if (expectedValue != actualValue)
            {
                if (_persistentData.journeyType.ToLower() == "ebanking" ||
                    _persistentData.journeyType.ToLower() == "savings")
                {
                    new TestEnder().FailEnd(
                        Defs.failAssert,
                        "The value of '" + elementName + "' is '" + actualValue +
                        "', but the expected value was '" + expectedValue + "'",
                        _persistentData.webAutomationJourney.driver,
                        _testContext);
                }

                else if (_persistentData.journeyType.ToLower() == "ebanking" ||
                    _persistentData.journeyType.ToLower() == "savings")
                {
                    new TestEnder().FailEnd(
                        Defs.failAssert,
                        "The value of '" + elementName + "' is '" + actualValue +
                        "', but the expected value was '" + expectedValue + "'",
                        _persistentData.appAutomationJourney.appDriver,
                        _testContext);
                }
            }
        }

        /// <summary>
        /// Retrieve the account number from the persistentData object.
        /// </summary>
        /// <param name="whichAccount">The ordinal number of the target account</param>
        /// <returns>The account number of the target account</returns>
        public string GetAccountNumber(string whichAccount)
        {
            return _persistentData.bankAccountNumber[GetWhichIterationOfAccount(whichAccount)];
        }

        /// <summary>
        /// Updates the value entered by the user into the table.
        /// </summary>
        /// <param name="dynamicText">The value to be updated</param>
        /// <returns>The updated value</returns>
        public string GetDynamicText(string dynamicText)
        {
            string dynamicTextSanitised = dynamicText.ToLower().Replace("*", "").Replace(" ", "");
            string returnText = null;

            switch (dynamicTextSanitised)
            {
                case "2ndaccount":
                case "secondaccount":
                    returnText = _persistentData.bankAccountNumber[1];
                    break;

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
                    returnText = GetDateRelativeToToday(dynamicTextSanitised);
                    break;

                case "1strecordedcustomernumber":
                case "firstrecordedcustomernumber":
                    returnText = _persistentData.customerNumberList[0];
                    break;

                case "2ndrecordedcustomernumber":
                case "secondrecordedcustomernumber":
                    returnText = _persistentData.customerNumberList[1];
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
                            + Keys.NumberPad9 + Keys.NumberPad2 + Keys.Alt
                            + "Windows Application Driver" + Keys.Alt + Keys.NumberPad9
                            + Keys.NumberPad2 + Keys.Alt + "TestFiles" + Keys.Alt 
                            + Keys.NumberPad9 + Keys.NumberPad2 + Keys.Alt 
                            + dynamicTextSanitised + "." + dynamicTextSanitised;
                    }
                    else
                    {
                        returnText = Path.GetFullPath(
                            @"..\..\TestFiles\" 
                            + dynamicTextSanitised + "."
                            + dynamicTextSanitised);
                    }
                    break;

                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "A dynamic text entry for '" +
                        dynamicTextSanitised +
                        "' does not exist.");
                    break;
            }

            return returnText;
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
                case "ebanking":
                case "savings":
                    isDisplayed = _persistentData.webAutomationJourney.currentPage.IsElementDisplayed(objInstance.pageLoadedElement);

                    if (objInstance.GetType().Name != _persistentData.webAutomationJourney.currentPage.GetType().Name)
                    {
                        _persistentData.webAutomationJourney.currentPage = objInstance;
                        _persistentData.webAutomationJourney.SetCurrenPageDriver();
                    }
                    break;

                case "backoffice":
                case "servicing":
                    isDisplayed = _persistentData.appAutomationJourney.currentPage.IsElementDisplayed(objInstance.pageLoadedElement);
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
                        "types ebanking, savings, backoffice or servicing.");
                    break;
            }

            if (isDisplayed != expectedResult && 
                (_persistentData.journeyType.ToLower() == "ebanking" || 
                _persistentData.journeyType.ToLower() == "savings"))
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "The page presence check performed on the page: " +
                    "'" + expectedPageName + "' returned an unexpected result. " +
                    "Expected Page Display Status: '" + expectedResult + 
                    "' Actaul Page Display Status: '" + isDisplayed + "'.",
                    _persistentData.webAutomationJourney.driver,
                    _testContext    );
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
        /// Select an option on an specific account.
        /// </summary>
        /// <param name="optionName">The name of the new option/journey</param>
        /// <param name="whichAccount">The index of the account (1st, 2nd, 3rd)</param>
        /// <param name="toAccount">The n</param>
        public void PerformOptionToAccout(string optionName, string whichAccount, string toAccount)
        {
            if (_persistentData.journeyType.ToLower() == "savings")
            {
                ChooseSavingsOption(optionName);
            }
            else if (_persistentData.journeyType.ToLower() == "backoffice")
            {
                SelectWizardBackoffice(optionName);
            }
            else if (_persistentData.journeyType.ToLower() == "ebanking")
            {
                ChooseEBankingOption(optionName, whichAccount, toAccount);
            }
            else if (_persistentData.journeyType.ToLower() == "servicing")
            {
                SelectWizardServicing(optionName);
            }
        }

        /// <summary>
        /// Check if the value that an element is prepopulated with is equal to the expected value.
        /// </summary>
        /// <param name="elementName">The target element</param>
        /// <param name="expectedValue">The expected value of the target element</param>
        public void PrePopulatedFieldCheck(string elementName, string expectedValue)
        {
            string elementValue = null;

            switch (_persistentData.journeyType.ToLower())
            {
                case "ebanking":
                case "savings":
                    elementValue = _persistentData.webAutomationJourney.currentPage.GetTextFromElement(
                        _persistentData.webAutomationJourney.currentPage.GetPageElement(elementName));
                    break;

                case "backoffice":
                case "servicing":
                    elementValue = _persistentData.appAutomationJourney.currentPage.GetTextFromElement(
                        _persistentData.appAutomationJourney.currentPage.GetPageElement(elementName));
                    break;

                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "Invalid journey type. The specflow command '...\"\" " +
                        "is pre-populated with \"\"' can only be used with " +
                        "journey types ebanking, savings, backoffice or servicing.");
                    break;
            }
            string sanitisedElementValue = elementValue.Replace("_", "").Replace("-", "").Replace(",", "").Replace("£", "");

            if ((elementValue != expectedValue && sanitisedElementValue != expectedValue) &&
                (_persistentData.journeyType.ToLower() == "ebanking" || _persistentData.journeyType.ToLower() == "savings"))
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "Element '" + elementName + "' is not pre-populated with '" +
                    expectedValue + "'.",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }
            else if ((elementValue != expectedValue && sanitisedElementValue != expectedValue) && 
                (_persistentData.journeyType.ToLower() == "servicing" || _persistentData.journeyType.ToLower() == "backoffice"))
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "Element '" + elementName + "' is not pre-populated with '"
                    + expectedValue + "'.",
                    _persistentData.appAutomationJourney.appDriver,
                    _testContext);
            }
        }

        /// <summary>
        /// Check the elements with the element names housed in the table have been prepopulated correctly.
        /// </summary>
        /// <param name="table">Contains the elementName and expectedValue</param>
        public void MultiplePrepopulationCheck(Table table)
        {
            for (int i = 0; i <= table.Rows.Count - 1; i++)
            {
                PrePopulationCheck(table.Rows[i][0]);
            }
        }

        /// <summary>
        /// Verify if a field has been prepopulated.
        /// </summary>
        /// <param name="elementName">The target element</param>
        public void PrePopulationCheck(string elementName)
        {
            string elementValue = null;
            switch (_persistentData.journeyType.ToLower())
            {
                case "ebanking":
                case "savings":
                    elementValue = _persistentData.webAutomationJourney.currentPage.GetTextFromElement(
                        _persistentData.webAutomationJourney.currentPage.GetPageElement(elementName));
                    break;
                case "backoffice":
                case "servicing":
                    elementValue = _persistentData.appAutomationJourney.currentPage.GetTextFromElement(
                        _persistentData.appAutomationJourney.currentPage.GetPageElement(elementName));
                    break;
                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "Invalid journey type. The specflow command '...\"\" is " +
                        "pre-populated' can only be used with journey types ebanking, " +
                        "savings, backoffice or servicing.");
                    break;
            }

            elementValue = elementValue.Replace(" ", "");
            if ((elementValue == null || elementValue == "") &&
                (_persistentData.journeyType.ToLower() == "ebanking" || _persistentData.journeyType.ToLower() == "savings"))
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "Element '" + elementName + "' is not pre-populated.",
                    _persistentData.webAutomationJourney.driver,
                    _testContext);
            }

            else if ((elementValue == null || elementValue == "") &&
                (_persistentData.journeyType.ToLower() == "servicing" || _persistentData.journeyType.ToLower() == "backoffice"))
            {
                new TestEnder().FailEnd(
                    Defs.failAssert,
                    "Element '" + elementName + "' is not pre-populated.",
                    _persistentData.appAutomationJourney.appDriver,
                    _testContext);
            }
        }

        /// <summary>
        /// Override the fields in the currect journey with values from the previously run journey.
        /// </summary>
        /// <param name="valueTable">Contains the values that will override the currenct fields</param>
        public void PreviousJourneyValueOverride(Table valueTable)
        {
            string prevData;

            switch (_persistentData.targetRepo.GetType().Name)
            {
                case "ServicingJourneyRepository":
                case "BOJourneyRepository":

                    for (int i = 0; i <= valueTable.Rows.Count - 1; i++)
                    {
                        prevData = _persistentData.wholeScenarioJourneyData.GetScenarioData(
                            valueTable.Rows[i][0], 
                            valueTable.Rows[i][1]);
                        _persistentData.appAutomationJourney.ChangeJourneyData(
                            valueTable.Rows[i][0],
                            valueTable.Rows[i][1],
                            prevData);
                    }
               break;

                case "EBankingJourneyRepository":
                case "SavingsJourneyRepository":

                    for (int i = 0; i <= valueTable.Rows.Count - 1; i++)
                    {
                        prevData = _persistentData.wholeScenarioJourneyData.GetScenarioData(
                            valueTable.Rows[i][0], 
                            valueTable.Rows[i][1]);
                        _persistentData.webAutomationJourney.ChangeJourneyData(
                            valueTable.Rows[i][0],
                            valueTable.Rows[i][1],
                            prevData);
                    }
               break;
            }
        }

        /// <summary>
        /// Update the value of an element displayed on the screen.
        /// </summary>
        /// <param name="elementName">The name of the target element</param>
        /// <param name="value">The updated value</param>
        public void SetElementValue(string elementName, string value)
        {
            value = GetDateRelativeToToday(value);

            Data data;
            Element element;
            switch (_persistentData.journeyType.ToLower())
            {
                case "ebanking":
                case "savings":
                    element = _persistentData.webAutomationJourney.currentPage.GetPageElement(elementName);
                    data = _persistentData.webAutomationJourney.journeyData;
                    _persistentData.webAutomationJourney.currentPage.CompleteElement(value, element, data);
                    break;

                case "backoffice":
                case "servicing":
                    element = _persistentData.appAutomationJourney.currentPage.GetPageElement(elementName);
                    data = _persistentData.appAutomationJourney.journeyData;
                    _persistentData.appAutomationJourney.currentPage.CompleteElement(value, element, data);
                    break;

                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "Given I set \"x\" to \"y\" - Journey type is not set " +
                        "to a valid type, the test therefore cannot be continued. " +
                        "Valid types are ebanking, savings, backoffice or servicing");
                    break;
            }
        }

        /// <summary>
        /// Take a screenshot of the current page
        /// </summary>
        public void TakeScreenshot()
        {
            string screenshotPath;
            switch (_persistentData.journeyType.ToLower())
            {
                case "ebanking":
                case "savings":
                    screenshotPath = new ScreenCapture().Capture(
                        _persistentData.webAutomationJourney.driver,
                        _testContext.Properties["automationScreenshotFolder"].ToString());
                    Console.WriteLine("Screenshot taken - '{0}'", screenshotPath);
                    ReportGenerator.AddScreenshotReference(
                        _persistentData.currentStep,
                        "Screenshot",
                        screenshotPath);
                    break;

                case "servicing":
                case "backoffice":
                    screenshotPath = new ScreenCapture().Capture(
                        _persistentData.appAutomationJourney.appDriver,
                        _testContext.Properties["automationScreenshotFolder"].ToString());

                    Console.WriteLine("Screenshot taken - '{0}'", screenshotPath);
                    ReportGenerator.AddScreenshotReference(
                        _persistentData.currentStep,
                        "Screenshot",
                        screenshotPath);
                    break;

                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "Specflow command '...I take a screenshot' can only " +
                        "be used with the journey types savings, ebanking, " +
                        "servicing or backoffice. Please review the " +
                        "specflow for this screnario");
                    break;
            }
        }

        /// <summary>
        /// Override the default data with values housed in this table.
        /// </summary>
        /// <param name="valueTable">Contains the values to update the default data with</param>
        public void ValueOverride(Table valueTable)
        {
            string dataToUse;
            switch (_persistentData.targetRepo.GetType().Name)
            {
                case "ServicingJourneyRepository":
                case "BOJourneyRepository":
                    for (int i = 0; i <= valueTable.Rows.Count - 1; i++)
                    {
                        if (valueTable.Rows[i][2].ToLower() == "null" ||
                            valueTable.Rows[i][2] == "")
                        {
                            dataToUse = null;
                        }
                        else if (valueTable.Rows[i][2].StartsWith("*"))
                        {
                            dataToUse = GetDynamicText(valueTable.Rows[i][2]);
                        }

                        else
                        {
                            dataToUse = valueTable.Rows[i][2];
                        }
                        _persistentData.appAutomationJourney.ChangeJourneyData(
                            valueTable.Rows[i][0],
                            valueTable.Rows[i][1],
                            dataToUse);
                    }
                    break;

                case "EBankingJourneyRepository":
                case "SavingsJourneyRepository":
                    for (int i = 0; i <= valueTable.Rows.Count - 1; i++)
                    {
                        if (valueTable.Rows[i][2].ToLower() == "null" ||
                            valueTable.Rows[i][2] == "")
                        {
                            dataToUse = null;
                        }

                        else if (valueTable.Rows[i][2].StartsWith("*"))
                        {
                            dataToUse = GetDynamicText(valueTable.Rows[i][2]);
                        }

                        else
                        {
                            dataToUse = valueTable.Rows[i][2];
                        }

                        _persistentData.webAutomationJourney.ChangeJourneyData(
                            valueTable.Rows[i][0],
                            valueTable.Rows[i][1],
                            dataToUse);
                    }
                    break;
            }
        }

        #endregion
    }
}
