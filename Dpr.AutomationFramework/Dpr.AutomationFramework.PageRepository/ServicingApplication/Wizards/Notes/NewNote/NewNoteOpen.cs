using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class NewNoteOpen : GenericWizardOpen
    {
        public NewNoteOpen()
        {
            pageLoadedElement = clickNewProcess;
            correspondingDataClass = new NewNoteOpenData().GetType();
            textName = "New Note Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element openAWorkspace => newProcess.customer;
        public Element clickNotes => ribbon.notes;
        public Element clickNewNote => notes.newNote;

    }

    public class NewNoteOpenData : GenericWizardOpenData
    {
    }
}
