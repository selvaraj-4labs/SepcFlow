using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Notes.CloseNote
{
    public class CloseNoteClose : GenericWizardClose
    {
        public CloseNoteClose()
        {
            correspondingDataClass = new CloseNoteCloseData().GetType();
            textName = "Close Note Close";
        }
    }

    public class CloseNoteCloseData : GenericWizardCloseData
    {
    }
}
