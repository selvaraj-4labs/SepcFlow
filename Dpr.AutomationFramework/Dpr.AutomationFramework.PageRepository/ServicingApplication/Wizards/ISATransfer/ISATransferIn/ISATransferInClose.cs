using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ISATransfer.ISATransferIn
{
    public class ISATransferInClose : GenericWizardClose
    {
        public ISATransferInClose()
        {
            correspondingDataClass = new ISATransferInCloseData().GetType();
            textName = "ISA Transfer In Close";
        }
    }

    public class ISATransferInCloseData : GenericWizardCloseData
    {
    }
}
