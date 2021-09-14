using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.UpdateThirdParty
{
    public class UpdateThirdPartyP1 : AppBasePage
    {
        public UpdateThirdPartyP1()
        {
            pageLoadedElement = thirdPartyTableBtn;
            correspondingDataClass = new UpdateThirdPartyP1Data().GetType();
            textName = "Update Third Party Page 1";
        }

        public Element thirdPartyTableBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ultraGrid"),
            "/Custom[@AutomationId=\"Data Area\"]" +
            "/Tree[@AutomationId=\"ColScrollRegion: 0, RowScrollRegion: 0\"]" +
            "/DataItem[@Name=\"Representative\"]"))
            .SetIsButtonFlag(true);

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class UpdateThirdPartyP1Data : PageData
    {
    }
}
