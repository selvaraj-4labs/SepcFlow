using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.AvailableJourneys;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ViewAccounts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using static Dpr.AutomationFramework.Dpr.AutomationFramework.AvailableJourneys.eBankingPortal.EBankingJourneyList;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.AvailableJourneys.eBankingPortal
{
    public class EBankingJourneyRepository : JourneyRepository
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
            EBankingJourneyRepository ebRepo = new EBankingJourneyRepository();

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
                    pages.Add(new EBankingLoginPage());
                    pages.Add(new MemorableAnswerPage());
                    pages.Add(new NewUserIDPage());
                    pages.Add(new LoginDetailsConfirmationPage());
                    pages.Add(new AccountTypePage());
                    pages.Add(new EBankingAccountsPage());
                    break;

                case EBJourneys.ExistingLogin:

                    pages.Add(new EBankingLoginPage());
                    pages.Add(new MemorableAnswerPage());
                    pages.Add(new AccountTypePage());
                    pages.Add(new EBankingAccountsPage());
                    break;
                    
                case EBJourneys.ForgottenUserId:
                    pages.Add(new ForgottenUserIdPage());
                    break;

                case EBJourneys.ForgottenPassword:
                    pages.Add(new ForgottenPasswordPage());
                    break;

                case EBJourneys.ForgottenMemorableAnswer:
                    pages.Add(new EBankingLoginPage());
                    pages.Add(new MemorableAnswerPage());
                    pages.Add(new ForgottenMemorableAnswerPage());
                    break;

                case EBJourneys.ViewAccount:
                    pages.Add(new AccountDetailsPage());
                    break;

                case EBJourneys.NewMail:
                    pages.Add(new NewMailPage());
                    pages.Add(new NewMailConfirmationPage());
                    break;

                case EBJourneys.ViewDocuments:
                    pages.Add(new YourDocumentsPage());
                    break;

                case EBJourneys.ChangeYourDetails:
                    pages.Add(new YourDetailsPage());
                    break;

                case EBJourneys.YourDetails:
                    pages.Add(new YourDetailsPage());
                    break;

                case EBJourneys.ChangeContactDetails:
                    pages.Add(new YourContactDetails());
                    pages.Add(new YourDetailsPage());
                    break;

                case EBJourneys.ChangePassword:
                    pages.Add(new ChangeYourPasswordPage());
                    pages.Add(new YourDetailsPage());
                    break;

                case EBJourneys.ChangeYourMobileNumber:
                    pages.Add(new ChangeYourMobileNumberPage());
                    pages.Add(new YourDetailsPage());
                    break;

                case EBJourneys.TransferMoney:
                    pages.Add(new EnterTransferDetailsPage());
                    pages.Add(new ConfirmTransferDetails());
                    pages.Add(new TransferConfirmation());
                    break;

                case EBJourneys.MakeOneOffPayment:
                    // Removed as input will be manual.
                    // pages.Add(new EBankingAccountsPage());
                    pages.Add(new EnterPaymentDetailsPage());
                    pages.Add(new ConfirmPaymentDetails());
                    pages.Add(new PaymentConfirmationPage());
                    break;

                case EBJourneys.ApplyOnline:
                    pages.Add(new AP01());
                    pages.Add(new BCOB01());
                    pages.Add(new EAP01Ebanking());
                    pages.Add(new EAP02Ebanking());
                    pages.Add(new EAP04JointApplicantEbanking());
                    pages.Add(new EAP09Ebanking());
                    pages.Add(new EAP15Ebanking());
                    pages.Add(new EAP19Ebanking());
                    pages.Add(new EAP25Ebanking());
                    pages.Add(new CreditStubEbanking());
                    pages.Add(new DecisionPageEbanking());
                    break;
            }

            return pages;
        }
    }
}
