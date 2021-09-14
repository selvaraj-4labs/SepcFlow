using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.AddNewTask
{
    public class AddNewTaskClose : GenericWizardClose
    {
        public AddNewTaskClose()
        {
            correspondingDataClass = new AddNewTaskCloseData().GetType();
            textName = "Add New Task Close";
        }
    }
    public class AddNewTaskCloseData : GenericWizardCloseData
    {
    }
}
