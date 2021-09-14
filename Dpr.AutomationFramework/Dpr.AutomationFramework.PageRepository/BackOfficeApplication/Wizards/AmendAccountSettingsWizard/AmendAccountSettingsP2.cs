using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendAccountSettingsWizard
{
    public class AmendAccountSettingsP2 : BOWizardBasePage
    {

        public AmendAccountSettingsP2()
        {
            pageLoadedElement = nextBtn.SetCompletePageFlag(false);
            correspondingDataClass = new AmendAccountSettingsP2Data().GetType();
            textName = "Amend Account Setting Page 2";
        }

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

    }


    public class AmendAccountSettingsP2Data : PageData
    {
    }

}
