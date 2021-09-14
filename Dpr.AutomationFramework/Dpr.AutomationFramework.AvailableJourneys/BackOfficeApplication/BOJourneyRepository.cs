using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.AvailableJourneys;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.CaseSearch;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendAccountSettingsWizard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendApplicantsWizard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendExpenditureWizard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendFactFindWizard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendNominatedAccountDetailsWizard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendReadOnlyCaseAccessWizard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AnonymiseApplicantWizard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.CompleteCaseWizard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.DecisionIntegrityWizard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.DeclineCancelApplicationWizard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.ExtendOfferWizard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.GenerateDataOutputDocumentWizard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.InstructValuationWizard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.IssueOfferWizard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.ProcessCOTWizard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.RunBusinessRulesWizard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.SetAmendRetentionAmount;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.UpdateApplicantConsentsWizard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.ValuationReceiptWizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using static Dpr.AutomationFramework.Dpr.AutomationFramework.AvailableJourneys.BackOfficeApplication.BOJourneyList;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.AvailableJourneys.BackOfficeApplication
{
    public class BOJourneyRepository : JourneyRepository
    {

        // PLACEHOLDER
        public override List<BasePage> GetPagesFor(TestContext testContext)
        {
            List<BasePage> pages = new List<BasePage>();
            return pages;
        }

        public override List<BasePage> GetPagesFor(string journeyName, TestContext testContext)
        {
            List<BasePage> pages = new List<BasePage>();
            BOJourneys boJourney;
            BOJourneyRepository boRepo = new BOJourneyRepository();

            // Try to check if the value journeyName is in savingsJourney.
            bool tryParse = Enum.TryParse(journeyName, out boJourney);
            if (tryParse == false)
                new TestEnder().FailEnd(Defs.failNonAssert, "The journey type '" + journeyName + "' does not exist. " +
                    "Please ensure the provided journey type is correct.");
            pages = boRepo.BOJourneyRepo(boJourney, pages);

            return pages;
        }

        public List<BasePage> BOJourneyRepo(BOJourneys journeyName, List<BasePage> pages)
        {
            switch (journeyName)
            {
                // Basic journey to search for a case in BackOffice.
                case BOJourneys.casesearch:

                    pages.Add(new CaseSearchTab());

                    break;

                case BOJourneys.amendaccountsettingswizard:

                    pages.Add(new AmendAccountSettingsP1());
                    pages.Add(new AmendAccountSettingsP2());
                    pages.Add(new AmendAccountSettingsP3());
                        
                    break;

                case BOJourneys.amendnominatedaccountdetailswizard:

                    pages.Add(new AmendNominatedAccountDetailsP1());
                    pages.Add(new AmendNominatedAccountDetailsP2());
                    pages.Add(new AmendNominatedAccountDetailsP3());

                    break;

                case BOJourneys.anonymiseapplicantwizard:

                    pages.Add(new AnonymiseApplicantP1());
                    pages.Add(new AnonymiseApplicantP2());
                    pages.Add(new AnonymiseApplicantP3());

                    break;

                case BOJourneys.completecasewizard:

                    pages.Add(new CompleteCaseP1());
                    pages.Add(new CompleteCaseP2());
                    pages.Add(new CompleteCaseP3());
                    pages.Add(new CompleteCaseP4());

                    break;

                case BOJourneys.declinecancelapplicationwizard:

                    pages.Add(new DeclineCancelApplicationP1());
                    pages.Add(new DeclineCancelApplicationP2());

                    break;

                case BOJourneys.generatedataoutputdocumentwizard:

                    pages.Add(new GenerateDataOutputDocumentP1());
                    pages.Add(new GenerateDataOutputDocumentP2());
                    pages.Add(new GenerateDataOutputDocumentP3());

                    break;

                case BOJourneys.updateapplicantconsentswizard:

                    pages.Add(new UpdateApplicantConsentsP1());
                    pages.Add(new UpdateApplicantConsentsP2());
                    pages.Add(new UpdateApplicantConsentsP3());
                    pages.Add(new UpdateApplicantConsentsP4());

                    break;

                case BOJourneys.amendapplicantswizard:
                    pages.Add(new AmendApplicantsP1());
                    pages.Add(new AmendApplicantsP2());
                    pages.Add(new AmendApplicantsP3());
                    pages.Add(new AmendApplicantsP4());
                    break;

                case BOJourneys.instructvaluationwizard:

                    pages.Add(new InstructValuationP1());
                    pages.Add(new InstructValuationP2());
                    pages.Add(new InstructValuationP3());

                    break;

                case BOJourneys.issueofferwizard:

                    pages.Add(new IssueOfferP1());
                    pages.Add(new IssueOfferP2());
                    pages.Add(new IssueOfferP3());

                    break;

                case BOJourneys.setamendretentionamountwizard:

                    pages.Add(new SetAmendRetentionAmountP1());
                    pages.Add(new SetAmendRetentionAmountP2());
                    pages.Add(new SetAmendRetentionAmountP3());

                    break;

                case BOJourneys.amendexpenditurewizard:

                    pages.Add(new AmendExpenditureP1());
                    pages.Add(new AmendExpenditureP2());
                    pages.Add(new AmendExpenditureP3());
                    pages.Add(new AmendExpenditureP4());

                    break;

                case BOJourneys.amendfactfindwizard:

                    pages.Add(new AmendFactFindP1());
                    pages.Add(new AmendFactFindP2());

                    break;

                case BOJourneys.amendreadonlycaseaccesswizard:

                    pages.Add(new AmendReadOnlyCaseAccessP1());

                    break;

                case BOJourneys.decisionintegritywizard:

                    pages.Add(new DecisionIntegrityP1());

                    break;

                case BOJourneys.extendofferwizard:

                    pages.Add(new ExtendOfferP1());
                    pages.Add(new ExtendOfferP2());
                    pages.Add(new ExtendOfferP3());

                    break;

                case BOJourneys.processcotwizard:

                    pages.Add(new ProcessCOTP1());
                    pages.Add(new ProcessCOTP2());
                    pages.Add(new ProcessCOTP3());

                    break;

                case BOJourneys.runbusinessruleswizard:

                    pages.Add(new RunBusinessRulesP1());
                    pages.Add(new RunBusinessRulesP2());
                    pages.Add(new RunBusinessRulesP3());

                    break;

                case BOJourneys.valuationreceiptwizard:

                    pages.Add(new ValuationReceiptP1());
                    pages.Add(new ValuationReceiptP2());

                    break;
            }

            return pages;

        }
    }
}
