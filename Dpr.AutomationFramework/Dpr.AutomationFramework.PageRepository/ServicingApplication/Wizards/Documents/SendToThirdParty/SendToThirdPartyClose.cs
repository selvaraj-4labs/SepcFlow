using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.SendToThirdParty
{
    public class SendToThirdPartyClose : AppBasePage
    {
        public SendToThirdPartyClose()
        {
            pageLoadedElement = ok;
            correspondingDataClass = new SendToThirdPartyCloseData().GetType();
            textName = "Send To Third Party Close";
        }

        public Element ok => new Element(FindElement("okUltraButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }
    public class SendToThirdPartyCloseData : PageData
    {
    }
}
