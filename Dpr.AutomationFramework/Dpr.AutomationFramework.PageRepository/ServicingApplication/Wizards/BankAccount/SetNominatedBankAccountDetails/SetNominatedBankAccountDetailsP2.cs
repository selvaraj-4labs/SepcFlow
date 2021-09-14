using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.SetNominatedBankAccountDetails
{
    public class SetNominatedBankAccountDetailsP2 : GenericFinalWizardPage
    {
        public SetNominatedBankAccountDetailsP2()
        {
            correspondingDataClass = new SetNominatedBankAccountDetailsP2Data().GetType();
            textName = "Set Nominated Bank Account Details Page 2";
        }
    }

    public class SetNominatedBankAccountDetailsP2Data : GenericFinalWizardPageData
    {
    }
}
