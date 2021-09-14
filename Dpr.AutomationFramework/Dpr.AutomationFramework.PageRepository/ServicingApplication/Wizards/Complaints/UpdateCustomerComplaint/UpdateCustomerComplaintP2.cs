using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Complaints.UpdateCustomerComplaint
{
    public class UpdateCustomerComplaintP2 : GenericFinalWizardPage
    {
        public UpdateCustomerComplaintP2()
        {
            correspondingDataClass = new UpdateCustomerComplaintP2Data().GetType();
            textName = "Update Customer Complaint Page 2";
        }
    }

    public class UpdateCustomerComplaintP2Data : GenericFinalWizardPageData
    {
    }
}
