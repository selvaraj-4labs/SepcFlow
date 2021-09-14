using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.SetAmendRetentionAmount
{
    public class SetAmendRetentionAmountP3 : BOWizardBasePage
    {
        public SetAmendRetentionAmountP3()
        {
            pageLoadedElement = finish;
            correspondingDataClass = new SetAmendRetentionAmountP3Data().GetType();
            textName = "Set Amend Retention Amount Page 3";
            windowTitle = "Retention Amount";
        }
        public Element finish => new Element(FindElement(
                "Finish",
                attributeType: Defs.boLocatorName))
            .SetIsButtonFlag(true);
    }

    public class SetAmendRetentionAmountP3Data : PageData
    {
    }
}
