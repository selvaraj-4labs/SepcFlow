using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class CancelCustomerComplaintClose : GenericWizardClose
    {
        public CancelCustomerComplaintClose()
        {
            correspondingDataClass = new CancelCustomerComplaintCloseData().GetType();
            textName = "Close Customer Complaint Close";
        }
    }

    public class CancelCustomerComplaintCloseData : GenericWizardCloseData
    {
    }
}
