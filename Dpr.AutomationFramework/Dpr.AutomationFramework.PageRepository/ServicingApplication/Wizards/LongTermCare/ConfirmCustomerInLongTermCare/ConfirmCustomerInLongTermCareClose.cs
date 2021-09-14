using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.ConfirmCustomerInLongTermCare
{
    public class ConfirmCustomerInLongTermCareClose : GenericWizardClose
    {
        public ConfirmCustomerInLongTermCareClose()
        {
            correspondingDataClass = new ConfirmCustomerInLongTermCareCloseData().GetType();
            textName = "Confirm Customer In Long Term Care  Close";
        }
    }
    public class ConfirmCustomerInLongTermCareCloseData : GenericWizardCloseData
    {
    }
}
