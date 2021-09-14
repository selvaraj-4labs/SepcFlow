using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerStatus.SetConfirmCustomerStatus
{
    public class SetConfirmCustomerStatusP3 : GenericFinalWizardPage
    {
        public SetConfirmCustomerStatusP3()
        {
            correspondingDataClass = new SetConfirmCustomerStatusP3Data().GetType();
            textName = "Set / Confirm Customer Status Page 3";
        }
    }

    public class SetConfirmCustomerStatusP3Data : GenericFinalWizardPageData
    {
    }
}
