using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Complaints.LogComplaint
{
    public class LogComplaintP3 : GenericFinalWizardPage
    {
        public LogComplaintP3()
        {
            correspondingDataClass = new LogComplaintP3Data().GetType();
            textName = "Log Complaint Page 3";
        }
    }

    public class LogComplaintP3Data : GenericFinalWizardPageData
    {
    }
}
