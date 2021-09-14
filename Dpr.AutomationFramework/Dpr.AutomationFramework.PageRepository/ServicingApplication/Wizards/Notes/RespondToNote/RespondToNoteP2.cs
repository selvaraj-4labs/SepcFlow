using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Notes.RespondToNote
{
    public class RespondToNoteP2 : GenericFinalWizardPage
    {
        public RespondToNoteP2()
        {
            correspondingDataClass = new RespondToNoteP2Data().GetType();
            textName = "Respond To Note Page 2";
        }
    }

    public class RespondToNoteP2Data : GenericFinalWizardPageData
    {
    }
}
