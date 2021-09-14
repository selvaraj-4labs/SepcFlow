using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerDeceased.CancelCustomerDeceased
{
    public class CancelCustomerDeceasedClose : GenericWizardClose
    {
        public CancelCustomerDeceasedClose()
        {
            correspondingDataClass = new CancelCustomerDeceasedCloseData().GetType();
            textName = "Cancel Customer Deceased Close";
        }
    }
    public class CancelCustomerDeceasedCloseData : GenericWizardCloseData
    {
    }
}
