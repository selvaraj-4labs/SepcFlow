using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ISATransfer.ISATransferOut
{
    public class ISATransferOutP3 : GenericFinalWizardPage
    {
        public ISATransferOutP3()
        {
            correspondingDataClass = new ISATransferOutP3Data().GetType();
            textName = "ISA Transfer Out Page 3";
        }
    }

    public class ISATransferOutP3Data : GenericFinalWizardPageData
    {
    }
}