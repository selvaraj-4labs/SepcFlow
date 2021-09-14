using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.RibbonMenu
{
    public class ProcessActions : AppBasePage
    {
        public ProcessActions()
        {
            pageLoadedElement = new Element(By.XPath("//*[]"));
            correspondingDataClass = new ProcessActionsData().GetType();
            textName = "Process Actions";
        }

        #region Sub Menu

        public Element accountActions => new Element(By.XPath("//Group[@Name='Process Actions']/MenuItem[@Name='Account Actions']")).SetIsButtonFlag(true);
        public Element accountAdmin => new Element(By.XPath("//Group[@Name='Process Actions']/MenuItem[@Name='Account Admin']")).SetIsButtonFlag(true);
        public Element customer => new Element(By.XPath("//Group[@Name='Process Actions']/MenuItem[@Name='Customer']")).SetIsButtonFlag(true);
        public Element repayments => new Element(By.XPath("//Group[@Name='Process Actions']/MenuItem[@Name='Repayments']")).SetIsButtonFlag(true);

        #endregion

        #region 'Account Actions' Menu Items
        //public Element adHocDeposit => new Element(By.XPath("//Group[@Name='Process Actions']/MenuItem[@Name='Ad-hoc Deposit']")).SetIsButtonFlag(true);
        public Element adHocDeposit => new Element(By.XPath("//Group[@Name='Account Actions']/MenuItem[@Name='Ad-hoc Deposit']")).SetIsButtonFlag(true);
        public Element depositReversal => new Element(By.XPath("//Group[@Name='Account Actions']/MenuItem[@Name='Deposit Reversal']")).SetIsButtonFlag(true);
        public Element addRegularDeposit => new Element(By.XPath("//Group[@Name='Account Actions']/MenuItem[@Name='Add Regular Deposit']")).SetIsButtonFlag(true);
        public Element cancelRegularDeposit => new Element(By.XPath("//Group[@Name='Account Actions']/MenuItem[@Name='Cancel Regular Deposit']")).SetIsButtonFlag(true);
        public Element adHocWithdrawal => new Element(By.XPath("//Group[@Name='Account Actions']/MenuItem[@Name='Adhoc Withdrawal']")).SetIsButtonFlag(true);
        public Element withdrawalReversal => new Element(By.XPath("//Group[@Name='Account Actions']/MenuItem[@Name='Withdrawal Reversal']")).SetIsButtonFlag(true);
        public Element internalTransfer => new Element(By.XPath("//Group[@Name='Account Actions']/MenuItem[@Name='Internal Transfer']")).SetIsButtonFlag(true);
        public Element cancelRegularScheduledWithdraw => new Element(By.XPath("//Group[@Name='Account Actions']/MenuItem[@Name='Cancel Regular Scheduled Withdraw']")).SetIsButtonFlag(true);
        public Element refundRequest => new Element(By.XPath("//Group[@Name='Account Actions']/MenuItem[@Name='Refund Request']")).SetIsButtonFlag(true);
        public Element redeemBonus => new Element(By.XPath("//Group[@Name='Account Actions']/MenuItem[@Name='Redeem Bonus']")).SetIsButtonFlag(true);
        public Element manageBonus => new Element(By.XPath("//Group[@Name='Account Actions']/MenuItem[@Name='Manage Bonus']")).SetIsButtonFlag(true);
        public Element isaTransferIn => new Element(By.XPath("//Group[@Name='Account Actions']/MenuItem[@Name='ISA Transfer In']")).SetIsButtonFlag(true);
        public Element isaTransferOut => new Element(By.XPath("//Group[@Name='Account Actions']/MenuItem[@Name='ISA Transfer Out']")).SetIsButtonFlag(true);
        public Element chequeDepositReversal => new Element(By.XPath("//Group[@Name='Account Actions']/MenuItem[@Name='Cheque Deposit Reversal']")).SetIsButtonFlag(true);
        #endregion

        #region 'Account Admin' Menu Items
        public Element generateStatement => new Element(By.XPath("//Group[@Name='Account Admin']/MenuItem[@Name='Generate Statement']")).SetIsButtonFlag(true);
        public Element accountSettings => new Element(By.XPath("//Group[@Name='Account Admin']/MenuItem[@Name='Account Settings']")).SetIsButtonFlag(true);
        public Element reopenAccount => new Element(By.XPath("//Group[@Name='Account Admin']/MenuItem[@Name='Reopen Account']")).SetIsButtonFlag(true);
        public Element setLoanAccountStatusDate => new Element(By.XPath("//Group[@Name='Account Admin']/MenuItem[@Name='Set Loan Account Status Date']")).SetIsButtonFlag(true);
        public Element setNominatedBankAccountDetails => new Element(By.XPath("//Group[@Name='Account Admin']/MenuItem[@Name='Set Nominated Bank Account Details']")).SetIsButtonFlag(true);
        public Element accountMaintenance => new Element(By.XPath("//Group[@Name='Account Admin']/MenuItem[@Name='Account Maintenance']")).SetIsButtonFlag(true);
        public Element modifyAccountTags => new Element(By.XPath("//Group[@Name='Account Admin']/MenuItem[@Name='Modify Account Tags']")).SetIsButtonFlag(true);
        public Element addNewFee => new Element(By.XPath("//Group[@Name='Account Admin']/MenuItem[@Name='Add New Fee']")).SetIsButtonFlag(true);
        public Element updateReverseFee => new Element(By.XPath("//Group[@Name='Account Admin']/MenuItem[@Name='Update/Reverse Fee']")).SetIsButtonFlag(true);
        public Element implementProductSwitch => new Element(By.XPath("//Group[@Name='Account Admin']/MenuItem[@Name='Implement Product Switch']")).SetIsButtonFlag(true);
        public Element addAccountLoading => new Element(By.XPath("//Group[@Name='Account Admin']/MenuItem[@Name='Add Account Loading']")).SetIsButtonFlag(true);
        public Element cancelAccountLoading => new Element(By.XPath("//Group[@Name='Account Admin']/MenuItem[@Name='Cancel Account Loading']")).SetIsButtonFlag(true);
        public Element uploadDocument => new Element(By.XPath("//Group[@Name='Account Admin']/MenuItem[@Name='Upload Document']")).SetIsButtonFlag(true);
        public Element manageAccountOnHold => new Element(By.XPath("//Group[@Name='Account Admin']/MenuItem[@Name='Manage Account On Hold']")).SetIsButtonFlag(true);
        public Element updateMaturityOptions => new Element(By.XPath("//Group[@Name='Account Admin']/MenuItem[@Name='Update Maturity Options']")).SetIsButtonFlag(true);
        public Element closeAccount => new Element(By.XPath("//Group[@Name='Account Admin']/MenuItem[@Name='Close Account']")).SetIsButtonFlag(true);
        public Element accountReview => new Element(By.XPath("//Group[@Name='Account Admin']/MenuItem[@Name='Account Review']")).SetIsButtonFlag(true);
        #endregion

        #region 'Customer' Menu Items
        public Element logComplaint => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Log Complaint']")).SetIsButtonFlag(true);
        public Element updateCustomerPreferences => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Update Customer Preferences']")).SetIsButtonFlag(true);
        public Element updatePersonalDetails => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Update Personal Details']")).SetIsButtonFlag(true);
        public Element manageeBankingCredentials => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Manage E-Banking Credentials']")).SetIsButtonFlag(true);
        public Element maintainEmploymentDetails => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Maintain Employment Details']")).SetIsButtonFlag(true);
        public Element contactCustomer => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Contact Customer']")).SetIsButtonFlag(true);
        public Element sendCommunication => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Send Communication']")).SetIsButtonFlag(true);
        public Element addCustomer => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Add Customer']")).SetIsButtonFlag(true);
        public Element addCompany => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Add Company']")).SetIsButtonFlag(true);
        public Element ceaseCustomer => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Cease Customer']")).SetIsButtonFlag(true);
        public Element addCeaseRole => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Add/Cease Role']")).SetIsButtonFlag(true);
        public Element customerInLongTermCareNotification => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Customer in Long Term Care Notification']")).SetIsButtonFlag(true);
        public Element customerDeceasedNotification => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Customer Deceased Notification']")).SetIsButtonFlag(true);
        public Element setConfirmCustomerStatus => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Set/Confirm Customer Status']")).SetIsButtonFlag(true);
        public Element ceaseCustomerStatus => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Cease Customer Status']")).SetIsButtonFlag(true);
        public Element overrideCustomerTaxStatus => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Override Customer Tax Status']")).SetIsButtonFlag(true);
        public Element customerDeduplication => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Customer Deduplication']")).SetIsButtonFlag(true);
        public Element anonymiseCustomer => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Anonymise Customer']")).SetIsButtonFlag(true);
        public Element addNewThirdParty => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Add New Third Party']")).SetIsButtonFlag(true);
        public Element updateThirdParty => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Update Third Party']")).SetIsButtonFlag(true);
        public Element ceaseThirdParty => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Cease Third Party']")).SetIsButtonFlag(true);
        public Element managePayees => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Manage Payees']")).SetIsButtonFlag(true);
        public Element updateTaxResidencyStatus => new Element(By.XPath("//Group[@Name='Customer']/MenuItem[@Name='Update Tax/Residency Status']")).SetIsButtonFlag(true);
        #endregion

        #region 'Repayments' Menu Items
        public Element bankAccountNew => new Element(By.XPath("//Group[@Name='Repayments']/MenuItem[@Name='Bank Account New']")).SetIsButtonFlag(true);
        public Element bankAccountUpdate => new Element(By.XPath("//Group[@Name='Repayments']/MenuItem[@Name='Bank Account Update']")).SetIsButtonFlag(true);
        public Element bankAccountCease => new Element(By.XPath("//Group[@Name='Repayments']/MenuItem[@Name='Bank Account Cease']")).SetIsButtonFlag(true);
        public Element bankAccountUncease => new Element(By.XPath("//Group[@Name='Repayments']/MenuItem[@Name='Bank Account Uncease']")).SetIsButtonFlag(true);
        public Element changeBranchOwnership => new Element(By.XPath("//Group[@Name='Repayments']/MenuItem[@Name='Change Branch Ownership']")).SetIsButtonFlag(true);
        public Element updateCustomerRegisteredCard => new Element(By.XPath("//Group[@Name='Repayments']/MenuItem[@Name='New/Update/Delete Customer Registered Card']")).SetIsButtonFlag(true);
        #endregion

        #region 'Customer Update' Menu Items
        public Element uploadImagesForCustomer => new Element(By.XPath("//Group[@Name='Upload Images For Customer']")).SetIsButtonFlag(true);
        #endregion
    }

    public class ProcessActionsData : PageData
    {
    }
}
