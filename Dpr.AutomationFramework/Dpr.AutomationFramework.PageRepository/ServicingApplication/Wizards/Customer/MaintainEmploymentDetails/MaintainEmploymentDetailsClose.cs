using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class MaintainEmploymentDetailsClose : GenericWizardClose
    {
        public MaintainEmploymentDetailsClose()
        {
            correspondingDataClass = new MaintainEmploymentDetailsCloseData().GetType();
            textName = "Manage Employment Details Close";
        }
    }

    public class MaintainEmploymentDetailsCloseData : GenericWizardCloseData
    {
    }
}
