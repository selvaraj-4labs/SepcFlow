using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.RibbonBar;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.RibbonMenu;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages
{
    public class GenericWizardOpen : AppBasePage
    {
        public Ribbon ribbon = new Ribbon();
        public Workspace workspace = new Workspace();
        public ProcessActions processActions = new ProcessActions();
        public NewProcess newProcess = new NewProcess();
        public DocumentsMenu documents = new DocumentsMenu();
        public NotesMenu notes = new NotesMenu();
        public TasksMenu tasks = new TasksMenu();

        public GenericWizardOpen()
        {
            //pageLoadedElement = clickNewProcess;
            correspondingDataClass = new GenericWizardOpenData().GetType();
            textName = "Generic Wizard Open Open";
        }
        
        //public Element clickNewProcess => ribbon.newProcessMenu;
        //public Element clickAccountActions => newProcess.accountActions;
        //public Element clickProcessActions => ribbon.processActionsMenu;
        //public Element clickAccountActions2 => processActions.accountActions;
    }

    public class GenericWizardOpenData : PageData
    {
    }
}
