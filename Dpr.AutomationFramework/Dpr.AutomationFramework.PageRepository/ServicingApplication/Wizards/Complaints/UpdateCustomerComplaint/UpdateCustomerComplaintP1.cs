using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Complaints.LogComplaint;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Complaints.UpdateCustomerComplaint
{
    public class UpdateCustomerComplaintP1 : LogComplaintP2
    {
        public UpdateCustomerComplaintP1()
        {
            correspondingDataClass = new UpdateCustomerComplaintP1Data().GetType();
            textName = "Update Customer Complaint Page 1";
        }
    }

    public class UpdateCustomerComplaintP1Data : LogComplaintP2Data
    {
    }
}
