using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.AvailableJourneys;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountMaintenance;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.CancelAccountReview;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.ModifyAccountTags;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.SetLoanAccountStatusDate;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.UpdateAccountReview;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountCease;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountNew;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountUncease;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountUpdate;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.ChangeBranchOwnership;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Complaints.CancelCustomerComplaint;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Complaints.LogComplaint;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Complaints.UpdateCustomerComplaint;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.AddCustomer;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.ContactCustomer;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.CustomerDeduplication;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.MaintainEmploymentDetails;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.ManageEBankingCredentials;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdateCustomerPreferences;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdateCustomerRegisteredCard;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdatePersonalDetails;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerDeceased.CancelCustomerDeceased;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerDeceased.ConfirmCustomerDeceased;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerDeceased.CustomerDeceasedNotification;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerDeceased.UpdateConfirmCustomerDeceased;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerStatus.SetConfirmCustomerStatus;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AddRegularDeposit;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AdHocDeposit;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.CancelRegularDeposit;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.ChequeDepositReversal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.DepositReversal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.AddNewDocument;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.DocumentHistory;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.ManageDocument;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.PreviewDocument;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.SendToThirdParty;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.UploadDocument;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Fees.AddNewFee;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Fees.UpdateReverseFee;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ISATransfer.ISATransferIn;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ISATransfer.ISATransferOut;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.CancelCustomerInLongTermCare;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.ConfirmCustomerInLongTermCare;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.CustomerInLongTermCareNotification;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.UpdateConfirmCustomerInLongTermCare;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Notes.AddNewNote;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Notes.CloseNote;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Notes.RespondToNote;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.AddNewTask;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.CancelTask;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.CompleteTask;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.PendTask;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.CancelOverrideCustomerTaxStatus;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.CancelTaxResidencyStatus;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.OverrideCustomerTaxStatus;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.UpdateOverrideCustomerTaxStatus;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.UpdateTaxResidencyStatus;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.UpdateTaxStatusUpdateRequest;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.AddNewThirdParty;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.CeaseThirdParty;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.UpdateThirdParty;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.AdHocWithdrawal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.CancelWithdrawal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.InternalTransfer;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.WithdrawalReversalWizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using static Dpr.AutomationFramework.Dpr.AutomationFramework.AvailableJourneys.ServicingApplication.ServicingJourneyList;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.AvailableJourneys.ServicingApplication
{
    public class ServicingJourneyRepository : JourneyRepository
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
            ServicingJourneys servicingJourney;
            ServicingJourneyRepository ServicingRepo = new ServicingJourneyRepository();

            bool tryParse = Enum.TryParse(journeyName, out servicingJourney);
            if (tryParse == false)
                new TestEnder().FailEnd(Defs.failNonAssert, "The journey type '" + journeyName + "' does not exist. " +
                    "Please ensure the provided journey type is correct.");

            pages = ServicingRepo.ServicingJourneyRepo(servicingJourney, pages);

            return pages;
        }

        public List<BasePage> ServicingJourneyRepo(ServicingJourneys journeyName, List<BasePage> pages)
        {

            switch (journeyName)
            {
                case ServicingJourneys.withdrawalreversal:

                    pages.Add(new WithdrawalReversalOpen());
                    pages.Add(new WithdrawalReversalP1());
                    pages.Add(new WithdrawalReversalP2());
                    pages.Add(new WithdrawalReversalP3());
                    pages.Add(new WithdrawalReversalClose());
                    break;

                case ServicingJourneys.updatereversefee:
                    pages.Add(new UpdateReverseFeeOpen());
                    pages.Add(new UpdateReverseFeeP1());
                    pages.Add(new UpdateReverseFeeP2());
                    pages.Add(new UpdateReverseFeeP3());
                    pages.Add(new UpdateReverseFeeClose());
                    break;

                case ServicingJourneys.uploaddocument:
                    pages.Add(new UploadDocumentOpen());
                    pages.Add(new UploadDocumentP1());
                    pages.Add(new UploadDocumentP2());
                    pages.Add(new UploadDocumentP3());
                    pages.Add(new UploadDocumentClose());
                    break;

                case ServicingJourneys.updatepersonaldetails:
                    pages.Add(new UpdatePersonalDetailsOpen());
                    pages.Add(new UpdatePersonalDetailsP1());
                    pages.Add(new UpdatePersonalDetailsP2());
                    pages.Add(new UpdatePersonalDetailsP3());
                    pages.Add(new UpdatePersonalDetailsClose());
                    break;

                case ServicingJourneys.documenthistory:
                    pages.Add(new DocumentHistoryP1());
                    pages.Add(new DocumentHistoryClose());
                    break;

                case ServicingJourneys.updatetaxresidencystatus:
                    pages.Add(new UpdateTaxResidencyStatusOpen());
                    pages.Add(new UpdateTaxResidencyStatusP1());
                    pages.Add(new UpdateTaxResidencyStatusP2());
                    pages.Add(new UpdateTaxResidencyStatusP3());
                    pages.Add(new UpdateReverseFeeClose());
                    break;

                case ServicingJourneys.updateoverridecustomertaxstatus:
                    pages.Add(new UpdateOverrideCustomerTaxStatusP1());
                    pages.Add(new UpdateOverrideCustomerTaxStatusP2());
                    pages.Add(new UpdateOverrideCustomerTaxStatusClose());
                    break;


                case ServicingJourneys.cancelcustomerdeceased:
                    pages.Add(new CancelCustomerDeceasedP1());
                    pages.Add(new CancelCustomerDeceasedP2());
                    pages.Add(new CancelCustomerDeceasedClose());
                    break;

                case ServicingJourneys.canceloverridecustomertaxstatus:
                    pages.Add(new CancelOverrideCustomerTaxStatusP1());
                    pages.Add(new CancelOverrideCustomerTaxStatusP2());
                    pages.Add(new CancelOverrideCustomerTaxStatusClose());
                    break;


                case ServicingJourneys.internaltransfer:
                    pages.Add(new InternalTransferOpen());
                    pages.Add(new InternalTransferP1());
                    pages.Add(new InternalTransferP2());
                    pages.Add(new InternalTransferP3());
                    pages.Add(new InternalTransferClose());
                    break;

                case ServicingJourneys.updateaccountreview:
                    pages.Add(new UpdateAccountReviewP1());
                    pages.Add(new UpdateAccountReviewP2());
                    pages.Add(new UpdateAccountReviewClose());
                    break;

                case ServicingJourneys.cancelaccountreview:
                    pages.Add(new CancelAccountReviewP1());
                    pages.Add(new CancelAccountReviewP2());
                    pages.Add(new CancelAccountReviewClose());
                    break;

                case ServicingJourneys.cancelwithdrawal:
                    pages.Add(new CancelWithdrawalP1());
                    pages.Add(new CancelWithdrawalP2());
                    pages.Add(new CancelWithdrawalClose());
                    break;

                case ServicingJourneys.overridecustomertaxstatus:
                    pages.Add(new OverrideCustomerTaxStatusOpen());
                    pages.Add(new OverrideCustomerTaxStatusP1());
                    pages.Add(new OverrideCustomerTaxStatusP2());
                    pages.Add(new OverrideCustomerTaxStatusP3());
                    pages.Add(new OverrideCustomerTaxStatusClose());
                    break;

                case ServicingJourneys.updatetaxstatusupdaterequest:
                    pages.Add(new UpdateTaxStatusUpdateRequestP1());
                    pages.Add(new UpdateTaxStatusUpdateRequestP2());
                    pages.Add(new UpdateTaxStatusUpdateRequestClose());
                    break;

                case ServicingJourneys.canceltaxstatusupdaterequest:

                    pages.Add(new CancelTaxStatusUpdateRequestP1());
                    pages.Add(new CancelTaxStatusUpdateRequestP2());
                    pages.Add(new CancelTaxStatusUpdateRequestClose());
                    break;

                case ServicingJourneys.newnote:
                    pages.Add(new NewNoteOpen());
                    pages.Add(new NewNoteP1());
                    pages.Add(new NewNoteP2());
                    pages.Add(new NewNoteClose());
                    break;

                case ServicingJourneys.respondtonote:
                    pages.Add(new RespondToNoteP1());
                    pages.Add(new RespondToNoteP2());
                    pages.Add(new RespondToNoteClose());
                    break;

                case ServicingJourneys.closenote:
                    pages.Add(new CloseNoteP1());
                    pages.Add(new CloseNoteP2());
                    pages.Add(new CloseNoteClose());
                    break;

                case ServicingJourneys.versions:
                    pages.Add(new VersionsP1());
                    pages.Add(new VersionsClose());
                    break;

                case ServicingJourneys.preview:
                    pages.Add(new PreviewP1());
                    pages.Add(new PreviewClose());
                    break;

                case ServicingJourneys.managedocument:
                    pages.Add(new ManageDocumentP1());
                    pages.Add(new ManageDocumentP2());
                    pages.Add(new ManageDocumentClose());
                    break;

                case ServicingJourneys.adhocdeposit:
                    pages.Add(new AdHocDepositOpen());
                    pages.Add(new AdHocDepositP1());
                    //pages.Add(new AdHocDepositP2());
                    pages.Add(new AdHocDepositP2());
                    pages.Add(new AdHocDepositP3());
                    pages.Add(new AdHocDepositP4());
                    pages.Add(new AdHocDepositClose());
                    break;

                case ServicingJourneys.cancelregulardeposit:
                    pages.Add(new CancelRegularDepositOpen());
                    pages.Add(new CancelRegularDepositP1());
                    pages.Add(new CancelRegularDepositP2());
                    pages.Add(new CancelRegularDepositClose());
                    break;

                case ServicingJourneys.addregulardeposit:
                    pages.Add(new AddRegularDepositOpen());
                    pages.Add(new AddRegularDepositP1());
                    pages.Add(new AddRegularDepositP2());
                    pages.Add(new AddRegularDepositClose());
                    break;

                case ServicingJourneys.logcomplaint:
                    pages.Add(new LogComplaintOpen());
                    pages.Add(new LogComplaintP1());
                    pages.Add(new LogComplaintP2());
                    pages.Add(new LogComplaintP3());
                    pages.Add(new LogComplaintClose());
                    break;

                case ServicingJourneys.depositreversal:
                    pages.Add(new DepositReversalOpen());
                    pages.Add(new DepositReversalP1());
                    pages.Add(new DepositReversalP2());
                    pages.Add(new DepositReversalP3());
                    pages.Add(new DepositReversalClose());
                    break;

                case ServicingJourneys.managebonus:
                    pages.Add(new ManageBonusOpen());
                    pages.Add(new ManageBonusP1());
                    pages.Add(new ManageBonusP2());
                    pages.Add(new ManageBonusClose());
                    break;

                case ServicingJourneys.addnewfee:
                    pages.Add(new AddNewFeeOpen());
                    pages.Add(new AddNewFeeP1());
                    pages.Add(new AddNewFeeP2());
                    pages.Add(new AddNewFeeP3());
                    pages.Add(new AddNewFeeP4());
                    pages.Add(new AddNewFeeClose());
                    break;

                case ServicingJourneys.accountsettings:
                    pages.Add(new AccountSettingsOpen());
                    pages.Add(new AccountSettingsP1());
                    pages.Add(new AccountSettingsP2());
                    pages.Add(new AccountSettingsP3());
                    pages.Add(new AccountSettingsP4());
                    pages.Add(new AccountSettingsP5());
                    pages.Add(new AccountSettingsClose());
                    break;

                case ServicingJourneys.adhocwithdrawal:
                    pages.Add(new AdHocWithdrawalOpen());
                    pages.Add(new AdHocWithdrawalP1());
                    pages.Add(new AdHocWithdrawalP2());
                    pages.Add(new AdHocWithdrawalP3());
                    pages.Add(new AdHocWithdrawalP4());
                    pages.Add(new AdHocWithdrawalClose());
                    break;

                case ServicingJourneys.isatransferin:
                    pages.Add(new ISATransferInOpen());
                    pages.Add(new ISATransferInP1());
                    pages.Add(new ISATransferInP2());
                    pages.Add(new ISATransferInClose());
                    break;

                case ServicingJourneys.isatransferout:
                    pages.Add(new ISATransferOutOpen());
                    pages.Add(new ISATransferOutP1());
                    pages.Add(new ISATransferOutP2());
                    pages.Add(new ISATransferOutP3());
                    pages.Add(new ISATransferOutClose());
                    break;

                case ServicingJourneys.modifyaccounttags:
                    pages.Add(new ModifyAccountTagsOpen());
                    pages.Add(new ModifyAccountTagsP1());
                    pages.Add(new ModifyAccountTagsP2());
                    pages.Add(new ModifyAccountTagsClose());
                    break;

                case ServicingJourneys.accountreview:
                    pages.Add(new AccountReviewOpen());
                    pages.Add(new AccountReviewP1());
                    pages.Add(new AccountReviewP2());
                    pages.Add(new AccountReviewP3());
                    pages.Add(new AccountReviewClose());
                    break;

                case ServicingJourneys.updatecustomerpreferences:
                    pages.Add(new UpdateCustomerPreferencesOpen());
                    pages.Add(new UpdateCustomerPreferencesP1());
                    pages.Add(new UpdateCustomerPreferencesP2());
                    pages.Add(new UpdateCustomerPreferencesP3());
                    pages.Add(new UpdateCustomerPreferencesP4());
                    pages.Add(new UpdateCustomerPreferencesP5());
                    pages.Add(new UpdateCustomerPreferencesP6());
                    pages.Add(new UpdateCustomerPreferencesClose());
                    break;

                case ServicingJourneys.updatecustomerregisteredcard:
                    pages.Add(new UpdateCustomerRegisteredCardOpen());
                    pages.Add(new UpdateCustomerRegisteredCardP1());
                    pages.Add(new UpdateCustomerRegisteredCardP2());
                    pages.Add(new UpdateCustomerRegisteredCardP3());
                    pages.Add(new UpdateCustomerRegisteredCardClose());
                    break;

                case ServicingJourneys.customerdeceasednotification:
                    pages.Add(new CustomerDeceasedNotificationOpen());
                    pages.Add(new CustomerDeceasedNotificationP1());
                    pages.Add(new CustomerDeceasedNotificationP2());
                    pages.Add(new CustomerDeceasedNotificationClose());
                    break;

                case ServicingJourneys.setconfirmcustomerstatus:
                    pages.Add(new SetConfirmCustomerStatusOpen());
                    pages.Add(new SetConfirmCustomerStatusP1());
                    pages.Add(new SetConfirmCustomerStatusP2());
                    pages.Add(new SetConfirmCustomerStatusP3());
                    pages.Add(new SetConfirmCustomerStatusClose());
                    break;

                case ServicingJourneys.maintainemploymentdetails:
                    pages.Add(new MaintainEmploymentDetailsOpen());
                    pages.Add(new MaintainEmploymentDetailsP1());
                    pages.Add(new MaintainEmploymentDetailsP2());
                    pages.Add(new MaintainEmploymentDetailsP3());
                    pages.Add(new MaintainEmploymentDetailsP4());
                    pages.Add(new MaintainEmploymentDetailsP5());
                    pages.Add(new MaintainEmploymentDetailsP6());
                    pages.Add(new MaintainEmploymentDetailsP7());
                    pages.Add(new MaintainEmploymentDetailsP8());
                    pages.Add(new MaintainEmploymentDetailsP9());
                    pages.Add(new MaintainEmploymentDetailsClose());
                    break;

                case ServicingJourneys.manageebankingcredentials:
                    pages.Add(new ManageEBankingCredentialsOpen());
                    pages.Add(new ManageEBankingCredentialsP1());
                    pages.Add(new ManageEBankingCredentialsP2());
                    pages.Add(new ManageEBankingCredentialsClose());
                    break;

                case ServicingJourneys.updatecustomercomplaint:
                    pages.Add(new UpdateCustomerComplaintP1());
                    pages.Add(new UpdateCustomerComplaintP2());
                    pages.Add(new UpdateCustomerComplaintClose());
                    break;

                case ServicingJourneys.cancelcustomercomplaint:
                    pages.Add(new CancelCustomerComplaintP1());
                    pages.Add(new CancelCustomerComplaintP2());
                    pages.Add(new CancelCustomerComplaintClose());
                    break;

                case ServicingJourneys.bankaccountnew:
                    pages.Add(new BankAccountNewOpen());
                    pages.Add(new BankAccountNewP1());
                    pages.Add(new BankAccountNewP2());
                    pages.Add(new BankAccountNewClose());
                    break;
                case ServicingJourneys.bankaccountupdate:
                    pages.Add(new BankAccountUpdateOpen());
                    pages.Add(new BankAccountUpdateP1());
                    pages.Add(new BankAccountUpdateP2());
                    pages.Add(new BankAccountUpdateClose());
                    break;

                case ServicingJourneys.bankaccountcease:
                    pages.Add(new BankAccountCeaseOpen());
                    pages.Add(new BankAccountCeaseP1());
                    pages.Add(new BankAccountCeaseP2());
                    pages.Add(new BankAccountCeaseClose());
                    break;

                case ServicingJourneys.accountmaintenance:
                    pages.Add(new AccountMaintenanceOpen());
                    pages.Add(new AccountMaintenanceP1());
                    pages.Add(new AccountMaintenanceP2());
                    pages.Add(new AccountMaintenanceClose());
                    break;

                case ServicingJourneys.addcustomer:
                    pages.Add(new AddCustomerOpen());
                    pages.Add(new AddCustomerP1());
                    pages.Add(new AddCustomerP2());
                    pages.Add(new AddCustomerP3());
                    pages.Add(new AddCustomerP4());
                    pages.Add(new AddCustomerP5());
                    pages.Add(new AddCustomerClose());
                    break;

                case ServicingJourneys.addnewdocument:
                    pages.Add(new AddNewDocumentOpen());
                    pages.Add(new AddNewDocumentP1());
                    pages.Add(new AddNewDocumentP2());
                    pages.Add(new AddNewDocumentClose());
                    break;

                case ServicingJourneys.setloanaccountstatusdate:
                    pages.Add(new SetLoanAccountStatusDateOpen());
                    pages.Add(new SetLoanAccountStatusDateP1());
                    pages.Add(new SetLoanAccountStatusDateP2());
                    pages.Add(new SetLoanAccountStatusDateClose());
                    break;

                case ServicingJourneys.addnewthirdparty:
                    pages.Add(new AddNewThirdPartyOpen());
                    pages.Add(new AddNewThirdPartyP1());
                    pages.Add(new AddNewThirdPartyP2());
                    pages.Add(new AddNewThirdPartyP3());
                    pages.Add(new AddNewThirdPartyP4());
                    pages.Add(new AddNewThirdPartyP5());
                    pages.Add(new AddNewThirdPartyP6());
                    pages.Add(new AddNewThirdPartyClose());
                    break;

                case ServicingJourneys.addnewtask:
                    pages.Add(new AddNewTaskOpen());
                    pages.Add(new AddNewTaskP1());
                    pages.Add(new AddNewTaskP2());
                    pages.Add(new AddNewTaskClose());
                    break;

                case ServicingJourneys.customerinlongtermcarenotification:
                    pages.Add(new CustomerInLongTermCareNotificationOpen());
                    pages.Add(new CustomerInLongTermCareNotificationP1());
                    pages.Add(new CustomerInLongTermCareNotificationP2());
                    pages.Add(new CustomerInLongTermCareNotificationP3());
                    pages.Add(new CustomerInLongTermCareNotificationP4());
                    pages.Add(new CustomerInLongTermCareNotificationP5());
                    pages.Add(new CustomerInLongTermCareNotificationP6());
                    pages.Add(new CustomerInLongTermCareNotificationP7());
                    pages.Add(new CustomerInLongTermCareNotificationClose());
                    break;

                case ServicingJourneys.confirmcustomerinlongtermcare:
                    pages.Add(new ConfirmCustomerInLongTermCareP1());
                    pages.Add(new ConfirmCustomerInLongTermCareP2());
                    pages.Add(new ConfirmCustomerInLongTermCareP3());
                    pages.Add(new ConfirmCustomerInLongTermCareClose());
                    break;

                case ServicingJourneys.pendtask:
                    pages.Add(new PendTaskP1());
                    pages.Add(new PendTaskP2());
                    pages.Add(new PendTaskClose());
                    break;

               case ServicingJourneys.canceltask:
                    pages.Add(new CancelTaskP1());
                    pages.Add(new CancelTaskP2());
                    pages.Add(new CancelTaskClose());
                    break;

                case ServicingJourneys.completetask:
                    pages.Add(new CompleteTaskP1());
                    pages.Add(new CompleteTaskP2());
                    pages.Add(new CompleteTaskClose());
                    break;

                case ServicingJourneys.contactcustomer:
                    pages.Add(new ContactCustomerOpen());
                    pages.Add(new ContactCustomerP1());
                    pages.Add(new ContactCustomerP2());
                    pages.Add(new ContactCustomerClose());
                    break;

                case ServicingJourneys.updateconfirmcustomerinlongtermcare:
                    pages.Add(new UpdateConfirmCustomerInLongTermCareP1());
                    pages.Add(new UpdateConfirmCustomerInLongTermCareP2());
                    pages.Add(new UpdateConfirmCustomerInLongTermCareClose());
                    break;

                case ServicingJourneys.cancelcustomerinlongtermcare :
                    pages.Add(new CancelCustomerInLongTermCareP1());
                    pages.Add(new CancelCustomerInLongTermCareP2());
                    pages.Add(new CancelCustomerInLongTermCareClose());
                    break;
                    
                case ServicingJourneys.confirmcustomerdeceased:
                    pages.Add(new ConfirmCustomerDeceasedP1());
                    pages.Add(new ConfirmCustomerDeceasedP2());
                    pages.Add(new ConfirmCustomerDeceasedP3());
                    pages.Add(new ConfirmCustomerDeceasedClose());
                    break;

                case ServicingJourneys.updateconfirmationofcustomerdeceased:
                    pages.Add(new UpdateConfirmCustomerDeceasedP1());
                    pages.Add(new UpdateConfirmCustomerDeceasedP2());
                    pages.Add(new UpdateConfirmCustomerDeceasedClose());
                    break;

                case ServicingJourneys.chequedepositreversal:
                    pages.Add(new ChequeDepositReversalOpen());
                    pages.Add(new ChequeDepositReversalP1());
                    pages.Add(new ChequeDepositReversalP2());
                    pages.Add(new ChequeDepositReversalP3());
                    pages.Add(new ChequeDepositReversalClose());
                    break;

                case ServicingJourneys.updatethirdparty:
                    pages.Add(new UpdateThirdPartyOpen());
                    pages.Add(new UpdateThirdPartyP1());
                    pages.Add(new UpdateThirdPartyP2());
                    pages.Add(new UpdateThirdPartyP3());
                    pages.Add(new UpdateThirdPartyP4());
                    pages.Add(new UpdateThirdPartyP5());
                    pages.Add(new UpdateThirdPartyClose());
                    break;

                case ServicingJourneys.ceasethirdparty:
                    pages.Add(new CeaseThirdPartyOpen());
                    pages.Add(new CeaseThirdPartyP1());
                    pages.Add(new CeaseThirdPartyP2());
                    pages.Add(new CeaseThirdPartyClose());
                    break;

                case ServicingJourneys.bankaccountuncease:
                    pages.Add(new BankAccountUnceaseOpen());
                    pages.Add(new BankAccountUnceaseP1());
                    pages.Add(new BankAccountUnceaseP2());
                    pages.Add(new BankAccountUnceaseClose());
                    break;

                case ServicingJourneys.changebranchownership:
                    pages.Add(new ChangeBranchOwnershipOpen());
                    pages.Add(new ChangeBranchOwnershipP1());
                    pages.Add(new ChangeBranchOwnershipP2());
                    pages.Add(new ChangeBranchOwnershipClose());
                    break;

                case ServicingJourneys.sendtothirdparty:
                    pages.Add(new SendToThirdPartyP1());
                    pages.Add(new SendToThirdPartyClose());
                    break;

                case ServicingJourneys.customerdeduplication:
                    pages.Add(new CustomerDeduplicationOpen());
                    pages.Add(new CustomerDeduplicationP1());
                    pages.Add(new CustomerDeduplicationP2());
                    pages.Add(new CustomerDeduplicationClose());
                    break;
            }

            return pages;
        }

    }
}
