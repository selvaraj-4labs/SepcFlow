using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.InternalTransfer
{
    public class InternalTransferClose : GenericWizardClose
    {
        public InternalTransferClose()
        {
            correspondingDataClass = new InternalTransferCloseData().GetType();
            textName = "Internal Transfer Close";
        }
    }

    public class InternalTransferCloseData : GenericWizardCloseData
    {
    }
}
