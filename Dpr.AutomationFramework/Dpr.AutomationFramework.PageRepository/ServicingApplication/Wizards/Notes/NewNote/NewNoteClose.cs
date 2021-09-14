using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class NewNoteClose : GenericWizardClose
    {
        public NewNoteClose()
        {
            correspondingDataClass = new NewNoteCloseData().GetType();
            textName = "New Note Close";
        }
    }

    public class NewNoteCloseData : GenericWizardCloseData
    {
    }
}
