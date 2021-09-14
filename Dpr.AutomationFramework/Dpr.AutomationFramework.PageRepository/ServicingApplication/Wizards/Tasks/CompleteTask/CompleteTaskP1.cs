using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.CompleteTask
{
    public class CompleteTaskP1 : AppBasePage
    {
        public CompleteTaskP1()
        {
            pageLoadedElement = reasonBox;
            correspondingDataClass = new CompleteTaskP1Data().GetType();
            textName = "Complete Task Page 1";
        }


        public Element reasonBox => new Element(FindElement("txtReason", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

    }
    public class CompleteTaskP1Data : PageData
    {

        public string reason { get; set; } = "TestReason";
    }
}
