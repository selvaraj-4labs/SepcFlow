using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.ApplyOnline;
using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.TransferMoney;
using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.ViewAccounts;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.AvailableJourneys;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using static Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.HEBS.AvailableJourneys.AvailableJourneyRepositories.eBankingPortal.HEBS_EBankingJourneyList;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.HEBS.AvailableJourneys.AvailableJourneyRepositories.eBankingPortal
{
    public class HEBS_EBankingJourneyRepository : JourneyRepository
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
            EBJourneys ebJourney;
            HEBS_EBankingJourneyRepository ebRepo = new HEBS_EBankingJourneyRepository();

            // Try to check if the value journeyName is in savingsJourney.
            bool tryParse = Enum.TryParse(journeyName, out ebJourney);
            if (tryParse == false)
                new TestEnder().FailEnd(Defs.failNonAssert,
                    "The journey type '" + journeyName +
                    "' does not exist. Please ensure the " +
                    "provided journey type is correct.");

            pages = ebRepo.EBJourneyRepo(ebJourney, pages);
            return pages;
        }

        public List<BasePage> EBJourneyRepo(EBJourneys journeyName, List<BasePage> pages)
        {
            switch (journeyName)
            {
                case EBJourneys.Login:
                    pages.Add(new HEBS_EBankingLoginPage());
                    pages.Add(new HEBS_MemorableAnswerPage());
                    pages.Add(new HEBS_NewUserIDPage());
                    pages.Add(new HEBS_LoginDetailsConfirmationPage());
                    pages.Add(new HEBS_AccountTypePage());
                    pages.Add(new HEBS_EBankingAccountsPage());
                    break;

                case EBJourneys.ExistingLogin:

                    pages.Add(new HEBS_EBankingLoginPage());
                    pages.Add(new HEBS_MemorableAnswerPage());
                    pages.Add(new HEBS_AccountTypePage());
                    pages.Add(new HEBS_EBankingAccountsPage());
                    break;

                case EBJourneys.ForgottenUserId:
                    pages.Add(new HEBS_ForgottenUserIdPage());
                    break;

                case EBJourneys.ForgottenPassword:
                    pages.Add(new HEBS_ForgottenPasswordPage());
                    break;

                case EBJourneys.ForgottenMemorableAnswer:
                    pages.Add(new HEBS_EBankingLoginPage());
                    pages.Add(new HEBS_MemorableAnswerPage());
                    pages.Add(new HEBS_ForgottenMemorableAnswerPage());
                    break;

                case EBJourneys.ViewAccount:
                    pages.Add(new HEBS_AccountDetailsPage());
                    break;

                case EBJourneys.NewMail:
                    pages.Add(new HEBS_NewMailPage());
                    pages.Add(new HEBS_NewMailConfirmationPage());
                    break;

                case EBJourneys.ViewDocuments:
                    pages.Add(new HEBS_YourDocumentsPage());
                    break;

                case EBJourneys.ChangeYourDetails:
                    pages.Add(new HEBS_YourDetailsPage());
                    break;

                case EBJourneys.YourDetails:
                    pages.Add(new HEBS_YourDetailsPage());
                    break;

                case EBJourneys.ChangeContactDetails:
                    pages.Add(new HEBS_YourContactDetails());
                    pages.Add(new HEBS_YourDetailsPage());
                    break;

                case EBJourneys.ChangePassword:
                    pages.Add(new HEBS_ChangeYourPasswordPage());
                    pages.Add(new HEBS_YourDetailsPage());
                    break;

                case EBJourneys.ChangeYourMobileNumber:
                    pages.Add(new HEBS_ChangeYourMobileNumberPage());
                    pages.Add(new HEBS_YourDetailsPage());
                    break;

                case EBJourneys.TransferMoney:
                    pages.Add(new HEBS_EnterTransferDetailsPage());
                    pages.Add(new HEBS_ConfirmTransferDetails());
                    pages.Add(new HEBS_TransferConfirmation());
                    break;

                case EBJourneys.MakeOneOffPayment:
                    // Removed as input will be manual.
                    // pages.Add(new EBankingAccountsPage());
                    pages.Add(new HEBS_EnterPaymentDetailsPage());
                    pages.Add(new HEBS_ConfirmPaymentDetails());
                    pages.Add(new HEBS_PaymentConfirmationPage());
                    break;

                case EBJourneys.ApplyOnline:
                    pages.Add(new HEBS_AP01());
                    //pages.Add(new EbankingApplyOnline());
                    pages.Add(new HEBS_EAP01Ebanking());
                    pages.Add(new HEBS_EAP02Ebanking());
                    pages.Add(new HEBS_EAP04JointApplicantEbanking());
                    pages.Add(new HEBS_EAP09Ebanking());
                    pages.Add(new HEBS_EAP15Ebanking());
                    pages.Add(new HEBS_EAP19Ebanking());
                    pages.Add(new HEBS_EAP25Ebanking());
                    pages.Add(new HEBS_CreditStubEbanking());
                    pages.Add(new HEBS_DecisionPageEbanking());
                    break;
            }
            return pages;
        }
    }
}
