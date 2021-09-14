using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.PreviewDocument
{
    public class PreviewP1 : AppBasePage
    {
        public PreviewP1()
        {
            pageLoadedElement = documentWindow;
            correspondingDataClass = new PreviewP1Data().GetType();
            textName = "Preview Document Page 1";
        }
        public Element documentWindow => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=viewerTabs"), "/Pane/Pane/Document[@AutomationId=\"richTextBox\"]"))
            .SetCompletePageFlag(false);
        public Element closeAllBtn => new Element(FindElement("btnCloseAll", attributeType: Defs.boLocatorAutomationId))
            .SetIsButtonFlag(true);
    }

    public class PreviewP1Data : PageData
    {
    }
}
