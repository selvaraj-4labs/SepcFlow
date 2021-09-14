using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.CompleteTask
{
    public class CompleteTaskClose : GenericWizardClose
    {
        public CompleteTaskClose()
        {
            correspondingDataClass = new CompleteTaskCloseData().GetType();
            textName = "Complete Task Close";
        }
    }
    public class CompleteTaskCloseData : GenericWizardCloseData
    {
    }
}
