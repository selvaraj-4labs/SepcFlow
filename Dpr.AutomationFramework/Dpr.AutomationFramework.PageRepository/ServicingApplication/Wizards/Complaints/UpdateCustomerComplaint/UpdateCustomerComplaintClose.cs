using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class UpdateCustomerComplaintClose : GenericWizardClose
    {
        public UpdateCustomerComplaintClose()
        {
            correspondingDataClass = new UpdateCustomerComplaintCloseData().GetType();
            textName = "Update Customer Complaint Close";
        }
    }

    public class UpdateCustomerComplaintCloseData : GenericWizardCloseData
    {
    }
}
