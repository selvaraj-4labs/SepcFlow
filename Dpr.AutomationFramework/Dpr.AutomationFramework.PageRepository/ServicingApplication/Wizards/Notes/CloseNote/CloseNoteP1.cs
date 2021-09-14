using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Notes.CloseNote
{
    public class CloseNoteP1 : AppBasePage
    {
        public CloseNoteP1()
        {
            pageLoadedElement = closeReason;
            correspondingDataClass = new CloseNoteP1Data().GetType();
            textName = "Close Note Page 1";
        }
        public Element closeReason => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtCloseReason")));
        public Element confirm => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CloseNoteP1Data : PageData 
    {
        public string closeReason { get; set; } = "Test Close Reason";
    }
}
