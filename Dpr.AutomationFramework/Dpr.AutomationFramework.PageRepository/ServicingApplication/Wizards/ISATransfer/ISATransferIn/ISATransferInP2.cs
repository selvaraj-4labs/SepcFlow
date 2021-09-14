using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ISATransfer.ISATransferIn
{
    public class ISATransferInP2 : GenericFinalWizardPage
    {
        public ISATransferInP2()
        {
            correspondingDataClass = new ISATransferInP2Data().GetType();
            textName = "ISA Transfer In Page 2";
        }
    }

    public class ISATransferInP2Data : GenericFinalWizardPageData
    {
    }
}
