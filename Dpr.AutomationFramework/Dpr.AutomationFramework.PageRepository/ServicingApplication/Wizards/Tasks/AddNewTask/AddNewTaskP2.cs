using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.AddNewTask
{
    public class AddNewTaskP2 : GenericFinalWizardPage
    {
        public AddNewTaskP2()
        {
            correspondingDataClass = new AddNewTaskP2Data().GetType();
            textName = "Add New Task Page 2";
        }
    }
    public class AddNewTaskP2Data : GenericFinalWizardPageData
    {
    }
}
