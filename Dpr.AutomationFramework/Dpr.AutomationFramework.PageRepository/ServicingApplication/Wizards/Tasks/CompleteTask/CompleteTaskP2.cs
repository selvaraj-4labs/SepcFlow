using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.CompleteTask
{
    public class CompleteTaskP2 : GenericFinalWizardPage
    {
        public CompleteTaskP2()
        {
            correspondingDataClass = new CompleteTaskP2Data().GetType();
            textName = "Complete Task Page 2";
        }
    }
    public class CompleteTaskP2Data : GenericFinalWizardPageData
    {
    }
}
