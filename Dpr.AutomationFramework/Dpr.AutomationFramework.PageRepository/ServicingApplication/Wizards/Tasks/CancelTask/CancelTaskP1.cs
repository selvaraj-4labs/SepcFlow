using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.CompleteTask;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.CancelTask
{
    public class CancelTaskP1 : CompleteTaskP1
    {
        public CancelTaskP1()
        {
            correspondingDataClass = new CancelTaskP1Data().GetType();
            textName = "Cancel Task Page 1";
        }



    }
    public class CancelTaskP1Data : CompleteTaskP1Data
    {


    }
}
