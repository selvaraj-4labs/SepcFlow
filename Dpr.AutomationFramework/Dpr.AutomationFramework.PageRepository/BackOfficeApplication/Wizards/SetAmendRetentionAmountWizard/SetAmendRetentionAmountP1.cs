using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.SetAmendRetentionAmount
{
    public class SetAmendRetentionAmountP1 : BOWizardBasePage
    {
        public SetAmendRetentionAmountP1()
        {
            pageLoadedElement = next;
            correspondingDataClass = new SetAmendRetentionAmountP1Data().GetType();
            textName = "Set Amend Retention Amount Page 1";
            windowTitle = "Retention Amount";
        }
        public Element retentionAmount => new Element(FindElement(Defs.boLocatorAutomationId, "dprCurrencyEditor"));
        public Element next => new Element(FindElement(
                "pnlNextButton",
                attributeType: Defs.boLocatorAutomationId))
            .SetIsButtonFlag(true);
    }
    
    public class SetAmendRetentionAmountP1Data : PageData
    {
        public string retentionAmount { get; set; } = "1000";
    }
}
