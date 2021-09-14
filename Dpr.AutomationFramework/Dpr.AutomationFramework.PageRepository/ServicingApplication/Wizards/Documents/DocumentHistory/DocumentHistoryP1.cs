using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.DocumentHistory
{
    public class DocumentHistoryP1 : AppBasePage
    {
        public DocumentHistoryP1()
        {
            pageLoadedElement = propertiesSectionHeader;
            correspondingDataClass = new DocumentHistoryP1Data().GetType();
            textName = "Document History Page 1";
        }

         public Element propertiesSectionHeader => new Element(FindElement(new LocatorList()
            //.Add(Defs.boLocatorName, "=Properties")
            .Add(Defs.boLocatorAutomationId, "=propertiesGroupBox"), tag: "Group"))
            .SetCompletePageFlag(false);

        public Element propertiesFirstRow => new Element(FindElement(new LocatorList()
            //.Add(Defs.boLocatorName, "=Properties")
            .Add(Defs.boLocatorAutomationId, "propertiesGrid"), "/Custom[@AutomationId=\"ultraGrid\"]/Custom[@AutomationId=\"Data Area\"]/Tree[@AutomationId=\"ColScrollRegion: 0, RowScrollRegion: 0\"]/DataItem[@Name=\"Title\"]/Edit[@Name=\"Value\"]"))
            .SetCompletePageFlag(false); 

        public Element eventsFirstRow => new Element(FindElement(new LocatorList()
            //.Add(Defs.boLocatorName, "=Events")
            .Add(Defs.boLocatorAutomationId, "historyGrid"), "/Custom[@AutomationId=\"ultraGrid\"]/Custom[@AutomationId=\"Data Area\"]/Tree[@AutomationId=\"ColScrollRegion: 0, RowScrollRegion: 0\"]/DataItem[1]"))
            .SetCompletePageFlag(false);

        public Element cancelBtn => new Element(FindElement("cancelButton", attributeType: Defs.boLocatorAutomationId))
            .SetIsButtonFlag(true);
    }

    public class DocumentHistoryP1Data : PageData
    {
    }
}
