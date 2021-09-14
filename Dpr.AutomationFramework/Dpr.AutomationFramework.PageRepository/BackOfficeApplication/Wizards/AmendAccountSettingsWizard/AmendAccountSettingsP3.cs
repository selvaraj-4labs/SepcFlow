using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendAccountSettingsWizard
{
    public class AmendAccountSettingsP3 : BOWizardBasePage
    {
        public AmendAccountSettingsP3()
        {
            pageLoadedElement = new Element(FindElement("=Processing  complete", attributeType: Defs.boLocatorName, tag: "Text")).SetCompletePageFlag(false);
            correspondingDataClass = new AmendAccountSettingsP3Data().GetType();
            textName = "Amend Account Setting Page 3";
        }
        public Element finishBtn => new Element(FindElement("Finish", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);
    }


    public class AmendAccountSettingsP3Data : PageData
    {
    }
}
