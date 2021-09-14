using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ISATransfer.ISATransferOut
{
    public class ISATransferOutClose : GenericWizardClose
    {
        public ISATransferOutClose()
        {
            correspondingDataClass = new ISATransferOutCloseData().GetType();
            textName = "ISA Transfer Out Close";
        }
    }

    public class ISATransferOutCloseData : GenericWizardCloseData
    {
    }
}
