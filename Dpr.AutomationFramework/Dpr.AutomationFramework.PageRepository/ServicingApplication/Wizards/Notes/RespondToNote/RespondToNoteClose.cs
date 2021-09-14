using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class RespondToNoteClose : GenericWizardClose
    {
        public RespondToNoteClose()
        {
            correspondingDataClass = new RespondToNoteCloseData().GetType();
            textName = "Respond to Note Close";
        }
    }

    public class RespondToNoteCloseData : GenericWizardCloseData
    {
    }
}
