using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.SetAmendRetentionAmount
{
    public class SetAmendRetentionAmountP2 : BOWizardBasePage
    {
        public SetAmendRetentionAmountP2()
        {
            pageLoadedElement = next;
            correspondingDataClass = new SetAmendRetentionAmountP2Data().GetType();
            textName = "Set Amend Retention Amount Page 2";
            windowTitle = "Retention Amount";
        }
        public Element next => new Element(FindElement(
                "pnlNextButton",
                attributeType: Defs.boLocatorAutomationId))
            .SetIsButtonFlag(true);
    }

    public class SetAmendRetentionAmountP2Data : PageData
    {
    }
}
