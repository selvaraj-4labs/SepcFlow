using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerDeceased.ConfirmCustomerDeceased
{
    public class ConfirmCustomerDeceasedClose : GenericWizardClose
    {
        public ConfirmCustomerDeceasedClose()
        {
            correspondingDataClass = new ConfirmCustomerDeceasedCloseData().GetType();
            textName = "Confirm Customer Deceased Close";
        }
    }
    public class ConfirmCustomerDeceasedCloseData : GenericWizardCloseData
    {
    }
}
