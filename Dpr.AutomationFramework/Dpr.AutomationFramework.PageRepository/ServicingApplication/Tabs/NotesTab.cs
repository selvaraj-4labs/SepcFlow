using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Tabs
{
    public class NotesTab : AppBasePage
    {
        public NotesTab()
        {
            pageLoadedElement = search;
            correspondingDataClass = new NotesTabData().GetType();
            textName = "Notes tab";
        }

        public Element search => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, 
            "allNotesTabControl"), "/Pane[starts-with(@AutomationId,\"ultraTabPageControl\")]/Pane[@AutomationId=\"summaryPanel\"]" +
            "/Group[@Name=\"Search Filter\"][@AutomationId=\"gbSearch\"]/Button[@Name=\"Search\"][@AutomationId=\"btnSearch\"]",
            "Tab")).SetCompletePageFlag(false);

    }

    public class NotesTabData : PageData
    {

    }
}
