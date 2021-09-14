using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerStatus.SetConfirmCustomerStatus
{
    public class SetConfirmCustomerStatusClose : GenericWizardClose
    {
        public SetConfirmCustomerStatusClose()
        {
            correspondingDataClass = new SetConfirmCustomerStatusCloseData().GetType();
            textName = "Account Review Close";
        }
    }
    public class SetConfirmCustomerStatusCloseData : GenericWizardCloseData
    {
    }
}
