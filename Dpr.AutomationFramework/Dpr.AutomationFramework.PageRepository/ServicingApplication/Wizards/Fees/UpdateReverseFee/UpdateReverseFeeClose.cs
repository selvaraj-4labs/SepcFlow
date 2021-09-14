using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AdHocDeposit
{
    public class UpdateReverseFeeClose : GenericWizardClose
    {
        public UpdateReverseFeeClose()
        {
            correspondingDataClass = new UpdateReverseFeeCloseData().GetType();
            textName = "Update Reverse Fee Close";
        }
    }

    public class UpdateReverseFeeCloseData : GenericWizardCloseData
    {
    }
}
