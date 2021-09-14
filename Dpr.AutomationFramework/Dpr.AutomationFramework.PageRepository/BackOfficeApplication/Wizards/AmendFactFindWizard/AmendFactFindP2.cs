using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendFactFindWizard
{
    public class AmendFactFindP2 : BOWizardBasePage
    {
        public AmendFactFindP2()
        {
            pageLoadedElement = finish;
            correspondingDataClass = new AmendFactFindP2Data().GetType();
            textName = "Amend Fact Find Page 2";
            windowTitle = "Amend Fact Find";
        }
        public Element finish => new Element(FindElement("Finish", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);
    }

    public class AmendFactFindP2Data : PageData
    {
    }
}
