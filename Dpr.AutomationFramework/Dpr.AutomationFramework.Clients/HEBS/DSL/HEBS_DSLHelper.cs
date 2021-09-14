using Dpr.AutomationFramework.Dpr.AutomationFramework.AvailableJourneys.BackOfficeApplication;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.HEBS.AvailableApplicants;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.HEBS.AvailableJourneys.AvailableJourneyRepositories.eBankingPortal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.HEBS.AvailableJourneys.AvailableJourneyRepositories.SavingsPortal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.HEBS.AvailableJourneys.SavingsProductTypes;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.PersistentData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Savings.DSL.StepDefinition;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.HEBS.DSL.StepDefinition
{
    public class HEBS_DSLHelper : DSLHelper
    {
        public HEBS_DSLHelper(PersistentData persistentData, TestContext testContext) : base (persistentData, testContext)
        {
            _persistentData = persistentData;
            _testContext = testContext;
        }

        #region HEBS BackOffice Helper Method Section
        /// <summary>
        /// Select an option on an specific account.
        /// Required so that the overridden 'SeleSelectWizardBackoffice' 
        /// method is called rather than the base method.
        /// </summary>
        /// <param name="optionName">The name of the new option/journey</param>
        /// <param name="whichAccount">The index of the account (1st, 2nd, 3rd)</param>
        /// <param name="toAccount">The n</param>
        public new void PerformOptionToAccout(string optionName, string whichAccount, string toAccount)
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
        /// Find and select a certain BackOffice wizard.
        /// Different to the default one in that the data override fields are HEBS specific.
        /// </summary>
        /// <param name="wizardType">The target wizard name.</param>
        public new void SelectWizardBackoffice(string wizardType)
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
                        "HEBS_SaveAndRestore",
                        "title") + " " +
                        _persistentData.wholeScenarioJourneyData.GetScenarioData(
                            "HEBS_SaveAndRestore",
                            "firstName") + " " +
                        _persistentData.wholeScenarioJourneyData.GetScenarioData(
                            "HEBS_EAP04",
                            "middleName") + " " +
                        _persistentData.wholeScenarioJourneyData.GetScenarioData(
                            "HEBS_SaveAndRestore",
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
                        "HEBS_SaveAndRestore",
                        "title") + " " +
                        _persistentData.wholeScenarioJourneyData.GetScenarioData(
                            "HEBS_SaveAndRestore",
                            "firstName") + " " +
                        _persistentData.wholeScenarioJourneyData.GetScenarioData(
                            "HEBS_EAP04",
                            "middleName") + " " +
                        _persistentData.wholeScenarioJourneyData.GetScenarioData(
                            "HEBS_SaveAndRestore",
                            "lastName");

                    _persistentData.appAutomationJourney.ChangeJourneyData(
                        "UpdateApplicantConsentsP1",
                        "applicantName",
                        CapitaliseFirstChar(name));
                    break;
            }
        }
        #endregion

        #region HEBS Savings Portal Helper Method Section
        /// <summary>
        /// Defines the means by which the applicant deposits funds into the account.
        /// </summary>
        /// <param name="depositType">The deposit type</param>
        public new void ChooseDepositType(string depositType)
        {
            string pageName;
            if (_persistentData.journeyType.ToLower() == "savings")
            {
                pageName = "HEBS_EAP19";
            }
            else
            {
                pageName = "HEBS_EAP19Ebanking";
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
        public new void DeduplicationTrigger()
        {
            _persistentData.webAutomationJourney.ChangeJourneyData("HEBS_EAP12", "dedupe", "true");
        }
        #endregion

        #region HEBS eBanking Portal Helper Method Section
        /// <summary>
        /// Log into an eBanking account.
        /// </summary>
        /// <param name="dedupeAccountSelectOption">Determine whenther the account selected is a dedupe acocunt</param>
        public new void LogIntoNewAccount(string dedupeAccountSelectOption = null)
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
                "HEBS_EBankingLoginPage",
                "userName",
                _persistentData.userId[0]);

            // Changing the eBanking password to password entered in the Savings portal.
            _persistentData.webAutomationJourney.ChangeJourneyData(
                "HEBS_EBankingLoginPage",
                "password",
                _persistentData.wholeScenarioJourneyData.GetScenarioData(
                    "HEBS_EAP12",
                    "enterPassword"));

            _persistentData.webAutomationJourney.ChangeJourneyData(
                "HEBS_NewUserIDPage",
                "userName",
                _persistentData.wholeScenarioJourneyData.GetScenarioData("HEBS_SaveAndRestore", "lastName")
                    .ToString().Replace("-", ""));

            _persistentData.webAutomationJourney.ChangeJourneyData(
                "HEBS_AccountTypePage",
                "dedupe",
                _persistentData.wholeScenarioJourneyData.GetScenarioData(
                    "HEBS_EAP12",
                    "dedupe"));

            if (dedupeAccountSelectOption != null)
            {
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "HEBS_AccountTypePage",
                    "accountToSelect",
                    dedupeAccountSelectOption);
            }

            _persistentData.userId[0] =
                _persistentData.wholeScenarioJourneyData
                    .GetScenarioData("HEBS_SaveAndRestore", "lastName")
                    .ToString()
                    .Replace("-", "");

            _persistentData.webAutomationJourney.StartFrom(
                    _testContext.Properties["eBankingLoginPageUrl"].ToString())
                .Visit(_persistentData.webAutomationJourney.visitList)
                .Go();
        }
        #endregion

        #region HEBS Portal Helper Method Section
        /// <summary>
        /// Select a type of Savings product.
        /// </summary>
        /// <param name="productType">The name of the target product type</param>
        public new void ChooseProductType(string productType)
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
                "corporate"};

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
                    HEBS_RetailProductList retailProductList = new HEBS_RetailProductList();
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
                    HEBS_ChildProductList childProductList = new HEBS_ChildProductList();
                    if (childProductList.childProducts[0] == null)
                    {
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "The '" + productType + "' product list contains " +
                            "no products!");
                    }
                    defaultCaseName = childProductList.childProducts[0];
                    break;
                // Uncomment if required in future.
                /*
                case "childisa":
                    HEBS_ChildIsaProductList childIsaProductList = new HEBS_ChildIsaProductList();
                    if (childIsaProductList.childIsaProducts[0] == null)
                    {
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "The '" + productType + "' product list contains " +
                            "no products!");
                    }
                    defaultCaseName = childIsaProductList.childIsaProducts[0];
                    break;
                    */
                case "corporate":
                    HEBS_CorporateProductList corporateProductList = new HEBS_CorporateProductList();
                    if (corporateProductList.corporateProducts[0] == null)
                    {
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "The '" + productType + "' product list contains " +
                            "no products!");
                    }
                    defaultCaseName = corporateProductList.corporateProducts[0];
                    break;
                // Uncomment if required in future.
                /*
                case "isa":
                    HEBS_ISAProductList isaProductList = new HEBS_ISAProductList();
                    if (isaProductList.isaProducts[0] == null)
                    {
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "The '" + productType + "' product list contains " +
                            "no products!");
                    }
                    defaultCaseName = isaProductList.isaProducts[0];
                    break;
                    */
            }

            if (_persistentData.journeyType.ToLower() == "savings")
            {
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "HEBS_EAP00",
                    "productName",
                    defaultCaseName);
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "HEBS_EAP00",
                    "productType",
                    productType);
            }
            else if (_persistentData.journeyType.ToLower() == "ebanking")
            {
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "HEBS_AP01",
                    "productName",
                    defaultCaseName);
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    "HEBS_AP01",
                    "productType",
                    productType);
            }
        }

        /// <summary>
        /// Defines the product that should be selected.
        /// </summary>
        /// <param name="productName">The target product name</param>
        public new void ChooseSavingsOption(string productName)
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

            if (new HEBS_CorporateProductList().corporateProducts.Contains(productName))
            {
                productExists = true;
                productType = "Corporate";

            }
            else if (new HEBS_ChildProductList().childProducts.Contains(productName))
            {
                productExists = true;
                productType = "Child";

            }
            // Uncomment if required in future.
            
            else if (new HEBS_ChildISAProductList().childIsaProducts.Contains(productName))
            {
                productExists = true;
                productType = "ChildISA";

            }

            else if (new HEBS_ISAProductList().isaProducts.Contains(productName))
            {
                productExists = true;
                productType = "ISA";
            }
            
            else if (new HEBS_RetailProductList().retailProducts.Contains(productName))
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
                    productSelectPage = "HEBS_EAP00";
                }

                else
                {
                    productSelectPage = "HEBS_AP01";
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
        /// Higher level method used to complete the journey that has been defined.
        /// </summary>
        /// <param name="untilPage">An optional page to stop the completion of the journey</param>
        public new void CompleteJourney(string untilPage)
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
                    if (_persistentData.targetRepo.GetType().Name == "HEBS_ServicingJourneyRepository")
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

            else if (_persistentData.targetRepo.GetType().Name == "HEBS_EBankingJourneyRepository" || _persistentData.targetRepo.GetType().Name == "HEBS_SavingsJourneyRepository")
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
        /// Collect and save the eBanking credentials from the portal.
        /// </summary>
        public new void RetrieveEBankingDetails()
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

            _persistentData.applicationReference.Add(Regex.Replace(wholeText, @"[^\d]", String.Empty));

            if (_persistentData.targetRepo.GetType().Name != "HEBS_SavingsJourneyRepository" &&
                _persistentData.targetRepo.GetType().Name != "HEBS_EBankingJourneyRepository")
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
        /// Set the number of shareholders to be entered during the portal journey.
        /// </summary>
        /// <param name="numberOfShareholders">The number of shareholders</param>
        public new void SetShareholderNumber(int numberOfShareholders)
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
                "HEBS_EAP06",
                "numberOfOtherApplicants",
                numberOfShareholders.ToString());
        }

        /// <summary>
        /// Set the number of signatories to be entered during the portal journey.
        /// </summary>
        /// <param name="numberOfSignatories">The number of signatories</param>
        public new void SetSignatoryNumber(int numberOfSignatories)
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
                "HEBS_EAP05",
                "numberOfSignatories",
                numberOfSignatories.ToString());
        }


        #endregion

        #region HEBS Global Helper Method Section

        // TODO: Update this method as and when BO, eBanking and Servicing sections are completed.
        /// <summary>
        /// Create a default data journey.
        /// </summary>
        /// <param name="journeyName">The name of the target journey</param>
        public new void CreateJourney(string journeyName)
        {
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
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The journey type '" + journeyName + "' does not exist." +
                    " Please review the journey name.");


            // Defining the type of journey required.
            switch (journeyName)
            {
                case "savings":
                case "ebanking":

                    // COMMENT OUT 'IF' STATEMENT TO CHECK SAME TIME PARALLEL EXECUTION.
                    //if (journeyName == "savings")
                    //{
                    //    int testOffsetNumberOfSeconds = 10;
                    //    double differenceInSeconds;
                    //    lock (lastSavingsTestStart_lock)
                    //    {
                    //        while ((differenceInSeconds = DateTime.Now.Subtract(lastSavingsTestStart).TotalSeconds) < testOffsetNumberOfSeconds)
                    //        {
                    //            Thread.Sleep(((int)Math.Ceiling(differenceInSeconds)) * 1000);
                    //        }
                    //        lastSavingsTestStart = DateTime.Now;
                    //    }
                    //}
                    if (_persistentData.webAutomationJourney != null)
                    {
                        _persistentData.webAutomationJourney.DestroyDriver();
                    }

                    _persistentData.webAutomationJourney = new WebJourney(logAndOutputInput: true);

                    // if/else clause to be editted so that 
                    if (journeyName == "savings")
                    {
                        _persistentData.targetRepo = new HEBS_SavingsJourneyRepository();
                        _persistentData.webAutomationJourney.visitList = _persistentData.targetRepo.GetPagesFor(_testContext);

                    }
                    else
                    {
                        _persistentData.targetRepo = new HEBS_EBankingJourneyRepository();
                    }

                    if (journeyName == "savings")
                    {
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
                            logAndOutputInput: true);
                    }

                    else
                    {
                        //_persistentData.targetRepo = new ServicingJourneyRepository();
                        _persistentData.appAutomationJourney = new AppJourney(
                            Defs.appJourneyApplicationServicing,
                            _testContext.Properties["servicingFilePath"].ToString(),
                            _testContext.Properties["servicingWindowLocator"].ToString(),
                            _testContext.Properties["WindowsApplicationDriverUrlServicing1"].ToString(),
                            logAndOutputInput: true);
                    }

                    break;
            }
            _persistentData.journeyType = journeyName;
        }

        /// <summary>
        /// Override the fields in the currect journey with values from the previously run journey.
        /// </summary>
        /// <param name="valueTable">Contains the values that will override the currenct fields</param>
        public new void PreviousJourneyValueOverride(Table valueTable)
        {
            string prevData;

            switch (_persistentData.targetRepo.GetType().Name)
            {
                case "HEBS_ServicingJourneyRepository":
                case "HEBS_BOJourneyRepository":

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

                case "HEBS_EBankingJourneyRepository":
                case "HEBS_SavingsJourneyRepository":

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
        /// Select a specific applicant from a list of predefined applicants
        /// </summary>
        /// <param name="applicantName">The target applicant name</param>
        public new void SetApplicant(string applicantName)
        {
            HEBS_ApplicantTypeRepository applicantRepo = new HEBS_ApplicantTypeRepository();
            _persistentData.updatedValues = applicantRepo.GetApplicantType(applicantName);

            for (int i = 0; i <= _persistentData.updatedValues.Count - 1; i++)
            {
                _persistentData.webAutomationJourney.ChangeJourneyData(
                    _persistentData.updatedValues[i][0],
                    _persistentData.updatedValues[i][1],
                    _persistentData.updatedValues[i][2]);
            }
        }

        /// <summary>
        /// Override the default data with values housed in this table.
        /// </summary>
        /// <param name="valueTable">Contains the values to update the default data with</param>
        public new void ValueOverride(Table valueTable)
        {
            string dataToUse = null;
            switch (_persistentData.targetRepo.GetType().Name)
            {
                case "HEBS_ServicingJourneyRepository":
                case "HEBS_BOJourneyRepository":
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

                case "HEBS_EBankingJourneyRepository":
                case "HEBS_SavingsJourneyRepository":
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
