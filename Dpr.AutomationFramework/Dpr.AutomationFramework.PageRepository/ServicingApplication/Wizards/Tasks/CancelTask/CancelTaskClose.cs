using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.CancelTask
{
    public class CancelTaskClose : GenericWizardClose
    {
        public CancelTaskClose()
        {
            correspondingDataClass = new CancelTaskCloseData().GetType();
            textName = "Cancel Task Close";
        }
    }
    public class CancelTaskCloseData : GenericWizardCloseData
    {
    }
}
