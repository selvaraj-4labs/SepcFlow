using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class LogComplaintClose : GenericWizardClose
    {
        public LogComplaintClose()
        {
            correspondingDataClass = new LogComplaintCloseData().GetType();
            textName = "Log Complaint Close";
        }
    }

    public class LogComplaintCloseData : GenericWizardCloseData
    {
    }
}
