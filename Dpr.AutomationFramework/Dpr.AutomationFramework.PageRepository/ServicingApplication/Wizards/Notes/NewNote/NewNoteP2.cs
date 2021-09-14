using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Notes.AddNewNote
{
    public class NewNoteP2 : GenericFinalWizardPage
    {
        public NewNoteP2()
        {
            correspondingDataClass = new NewNoteP2Data().GetType();
            textName = "Add New Note Page 2";
        }
    }

    public class NewNoteP2Data : GenericFinalWizardPageData
    {
    }
}
