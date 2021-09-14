using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Complaints.CancelCustomerComplaint
{
    public class CancelCustomerComplaintP2 : GenericFinalWizardPage
    {
        public CancelCustomerComplaintP2()
        {
            correspondingDataClass = new CancelCustomerComplaintP2Data().GetType();
            textName = "Cancel Customer Complaint Page 2";
        }
    }

    public class CancelCustomerComplaintP2Data : GenericFinalWizardPageData
    {
    }
}
