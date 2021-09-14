using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Notes.CloseNote
{
    public class CloseNoteP2 : GenericFinalWizardPage
    {
        public CloseNoteP2()
        {
            correspondingDataClass = new CloseNoteP2Data().GetType();
            textName = "Close Note Page 2";
        }
    }

    public class CloseNoteP2Data : GenericFinalWizardPageData
    {
    }
}
