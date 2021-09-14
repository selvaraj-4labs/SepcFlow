using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.PendTask
{
    public class PendTaskP2 : GenericFinalWizardPage
    {
        public PendTaskP2()
        {
            correspondingDataClass = new PendTaskP2Data().GetType();
            textName = "Pend Task Page 2";
        }
    }
    public class PendTaskP2Data : GenericFinalWizardPageData
    {
    }
}
