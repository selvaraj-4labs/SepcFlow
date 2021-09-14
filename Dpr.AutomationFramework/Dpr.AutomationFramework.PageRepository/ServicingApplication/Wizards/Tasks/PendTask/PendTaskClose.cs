using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.PendTask
{
    public class PendTaskClose : GenericWizardClose
    {
        public PendTaskClose()
        {
            correspondingDataClass = new PendTaskCloseData().GetType();
            textName = "Pend Task Close";
        }
    }
    public class PendTaskCloseData : GenericWizardCloseData
    {
    }
}
