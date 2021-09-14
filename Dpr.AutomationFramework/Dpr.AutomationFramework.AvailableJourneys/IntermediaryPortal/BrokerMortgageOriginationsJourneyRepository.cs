using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.AvailableJourneys;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.InstructValuation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using static Dpr.AutomationFramework.Dpr.AutomationFramework.AvailableJourneys.IntermediaryPortal.BrokerMortgageOriginationsJourneyList;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Intermediary.AvailableJourneys
{
    public class BrokerMortgageOriginationsJourneyRepository : JourneyRepository
    {

        //Placeholder
        public override List<BasePage> GetPagesFor(TestContext testContext)
        {
            List<BasePage> pages = new List<BasePage>();
            return pages;
        }

        public override List<BasePage> GetPagesFor(string journeyName, TestContext testContext)
        {
            List<BasePage> pages = new List<BasePage>();
            BrokerMortgageOriginationsJourneys brokerMOJourney;
            BrokerMortgageOriginationsJourneyRepository moRepo = new BrokerMortgageOriginationsJourneyRepository();

            // Try to check if the value journeyName is in savingsJourney.
            bool tryParse = Enum.TryParse(journeyName, out brokerMOJourney);
            if (tryParse == false)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert, 
                    "The journey type '" + journeyName + "' does not exist. " +
                    "Please ensure the provided journey type is correct.");
            }
            pages = moRepo.MOJourneyRepo(brokerMOJourney, pages, testContext);

            return pages;
        }

        public List<BasePage> MOJourneyRepo(BrokerMortgageOriginationsJourneys journeyName, List<BasePage> pages, TestContext testContext)
        {
            switch (journeyName)
            {
                case BrokerMortgageOriginationsJourneys.dip:

                    pages.Add(new LoginPage());
                    pages.Add(new MemorableWordPage());
                    pages.Add(new BrokerHomePage());
                    pages.Add(new PreReqQuestionsPage());
                    pages.Add(new ApplicantAndLoanTypePage());
                    pages.Add(new SubmissionRoutePage());
                    pages.Add(new LoanDetailsPage());
                    pages.Add(new CompanyDetailsPage());
                    pages.Add(new Applicant1DetailsPage());
                    pages.Add(new Applicant1AddressHistoryPage());
                    pages.Add(new Applicant1EmploymentInitialisationPage());
                    pages.Add(new Applicant1PrimaryEmploymentPageEmployed());
                    pages.Add(new Applicant1PrimaryEmploymentPageFixedTermContract());
                    pages.Add(new Applicant1PrimaryEmploymentPageSelfEmployed());
                    // Additional copy of employment pages for secondary employment
                    pages.Add(new Applicant1SecondaryEmploymentPageEmployed());
                    pages.Add(new Applicant1SecondaryEmploymentPageFixedTermContract());
                    pages.Add(new Applicant1SecondaryEmploymentPageSelfEmployed());
                    pages.Add(new Applicant1EmploymentSummaryPage());
                    pages.Add(new Applicant1CreditCommitmentsPage());
                    pages.Add(new Applicant1BTLPortfolioPage());
                    pages.Add(new Applicant2DetailsPage());
                    pages.Add(new Applicant2AddressHistoryPage());
                    pages.Add(new Applicant2EmploymentInitialisationPage());
                    pages.Add(new Applicant2PrimaryEmploymentPageEmployed());
                    pages.Add(new Applicant2PrimaryEmploymentPageFixedTermContract());
                    pages.Add(new Applicant2PrimaryEmploymentPageSelfEmployed());
                    // Additional copy of employment pages for secondary employment
                    pages.Add(new Applicant2SecondaryEmploymentPageEmployed());
                    pages.Add(new Applicant2SecondaryEmploymentPageFixedTermContract());
                    pages.Add(new Applicant2SecondaryEmploymentPageSelfEmployed());
                    pages.Add(new Applicant2EmploymentSummaryPage());
                    pages.Add(new Applicant2CreditCommitmentsPage());
                    pages.Add(new Applicant2BTLPortfolioPage());
                    pages.Add(new HouseholdExpenditurePage());
                    pages.Add(new PropertyDetailsPage());
                    pages.Add(new ProductSelectionPage(testContext));
                    pages.Add(new DPACreditSearchPermissionPage());
                    pages.Add(new DecisionPage());
                    pages.Add(new FeesAndFeaturesPage(testContext));
                    pages.Add(new ApplicationSummaryPage());
                    break;

                case BrokerMortgageOriginationsJourneys.fma:
                    pages.Add(new DIP_ApplicationSummaryPage());
                    pages.Add(new FMA_ProductValidityPage());
                    //pages.Add(new FMA_LoanDetailsPage()); Add Page Conds for this page.
                    pages.Add(new FMA_Applicant1DetailsPage());
                    //pages.Add(new FMA_Applicant1PrimaryEmploymentDetailsPage()); OLD
                    pages.Add(new FMA_Applicant1PrimaryEmploymentPageEmployed());
                    pages.Add(new FMA_Applicant1PrimaryEmploymentPageFixedTermContract());
                    pages.Add(new FMA_Applicant1PrimaryEmploymentPageSelfEmployed());
                    pages.Add(new FMA_Applicant2DetailsPage());
                    //pages.Add(new FMA_Applicant2PrimaryEmploymentDetailsPage()); OLD
                    pages.Add(new FMA_Applicant2PrimaryEmploymentPageEmployed());
                    pages.Add(new FMA_Applicant2PrimaryEmploymentPageFixedTermContract());
                    pages.Add(new FMA_Applicant2PrimaryEmploymentPageSelfEmployed());
                    pages.Add(new FMA_PropertyDetailsPage());
                    pages.Add(new FMA_AccessDetailsPage());
                    pages.Add(new FMA_SolicitorDetailsPage());
                    pages.Add(new FMA_DirectDebitDetailsPage());
                    pages.Add(new FMA_ProductSelectionPage());
                    pages.Add(new FMA_DeclarationsPage());
                    pages.Add(new FMA_DecisionResultPage());
                    pages.Add(new FMA_FeesAndFeaturesPage());
                    pages.Add(new FMA_PaymentDetailsPage());
                    pages.Add(new FMA_CreditStub());
                    pages.Add(new FMA_ApplicationSummaryPage());
                    break;

                case BrokerMortgageOriginationsJourneys.instructvaluation:
                    pages.Add(new IV_ApplicationSummaryPage());
                    pages.Add(new ValuationInstructionPage());
                    // Added so the driver waits for the Instruct 
                    // Valuation journey to fully complete
                    // (Depending on testing this could be removed).
                    pages.Add(new FMA_ApplicationSummaryPage());
                    break;
            }

            return pages;
        }
    }
}
