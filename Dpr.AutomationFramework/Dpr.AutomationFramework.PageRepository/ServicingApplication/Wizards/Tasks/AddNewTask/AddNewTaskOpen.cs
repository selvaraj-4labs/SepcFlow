using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.AddNewTask
{
    public class AddNewTaskOpen : GenericWizardOpen
    { 
        public AddNewTaskOpen()
        {
            pageLoadedElement = clickNewTask;
            correspondingDataClass = new AddNewTaskOpenData().GetType();
            textName = "Add New Task Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.accountActions;
        public Element clickNotes => ribbon.tasks;
        public Element clickNewTask => tasks.newTask;
    }
    public class AddNewTaskOpenData : GenericWizardOpenData
    {
    }
}
