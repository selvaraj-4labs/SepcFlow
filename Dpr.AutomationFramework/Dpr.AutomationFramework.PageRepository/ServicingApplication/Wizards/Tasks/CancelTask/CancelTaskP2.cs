using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.CompleteTask;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.CancelTask
{
    public class CancelTaskP2 : CompleteTaskP2
    {
        public CancelTaskP2()
        {
            correspondingDataClass = new CancelTaskP2Data().GetType();
            textName = "Cancel Task Page 2";
        }
    }
    public class CancelTaskP2Data : CompleteTaskP2Data
    {
    }
}
