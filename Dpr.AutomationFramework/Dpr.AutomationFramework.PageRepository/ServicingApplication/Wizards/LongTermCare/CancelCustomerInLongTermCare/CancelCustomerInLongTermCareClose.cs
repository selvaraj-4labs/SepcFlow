using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.CancelCustomerInLongTermCare
{
    public class CancelCustomerInLongTermCareClose : GenericWizardClose
    {
        public CancelCustomerInLongTermCareClose()
        {
            correspondingDataClass = new CancelCustomerInLongTermCareCloseData().GetType();
            textName = "Cancel Customer In Long Term Care Close";
        }
    }
    public class CancelCustomerInLongTermCareCloseData : GenericWizardCloseData
    {
    }
}
