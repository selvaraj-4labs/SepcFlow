using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.PreviewDocument
{
    public class VersionsP1 : AppBasePage
    {
        public VersionsP1()
        {
            pageLoadedElement = versions;
            correspondingDataClass = new VersionsP1Data().GetType();
            textName = "Preview Document Page 1";
        }
        public Element versions => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Versions")
            .Add(Defs.boLocatorAutomationId, "=historyGroupBox"), tag: "Group"))
            .SetCompletePageFlag(false);

        public Element cancelBtn => new Element(FindElement("cancelButton", attributeType: Defs.boLocatorAutomationId))
            .SetIsButtonFlag(true);
    }

    public class VersionsP1Data : PageData
    {
    }
}
