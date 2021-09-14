using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendFactFindWizard
{
    public class AmendFactFindP1 : BOWizardBasePage
    {
        public AmendFactFindP1()
        {
            pageLoadedElement = next;
            correspondingDataClass = new AmendFactFindP1Data().GetType();
            textName = "Amend Fact Find Page 1";
            windowTitle = "Amend Fact Find";
        }
        public Element next => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AmendFactFindP1Data : PageData
    {
    }
}
