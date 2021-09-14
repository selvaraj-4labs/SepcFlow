using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerStatus.CancelCustomerStatus
{
    public class CancelCustomerStatusP2 : GenericFinalWizardPage
    {
        public CancelCustomerStatusP2()
        {
            correspondingDataClass = new CancelCustomerStatusP2Data().GetType();
            textName = "Set / Confirm Customer Status Page 3";
        }
    }

    public class CancelCustomerStatusP2Data : GenericFinalWizardPageData
    { 
    }
}
