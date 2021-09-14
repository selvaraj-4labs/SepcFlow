using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.SetLoanAccountStatusDate
{
    public class SetLoanAccountStatusDateClose : GenericWizardClose
    {
        public SetLoanAccountStatusDateClose()
        {
            correspondingDataClass = new SetLoanAccountStatusDateCloseData().GetType();
            textName = "Set Loan Account Status Date Close";
        }
    }
    public class SetLoanAccountStatusDateCloseData : GenericWizardCloseData
    {
    }
}
