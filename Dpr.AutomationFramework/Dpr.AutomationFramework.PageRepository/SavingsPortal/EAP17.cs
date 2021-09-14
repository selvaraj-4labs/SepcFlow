using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP17 : WebBasePage
    {
        public EAP17()
        {
            pageLoadedElement = homePageBtn;
            correspondingDataClass = new EAP17Data().GetType();
            textName = "Thank You Fail EID";
        }

        public Element caseIdBox => new Element(FindElement(
            new LocatorList()
            .Add("divApplicationRef", Defs.locatorId),
            "/text()"));

        public Element homePageBtn => new Element(FindElement("ThankYou_ReturnHome"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
    }

    public class EAP17Data : PageData
    {
        string caseId { set; get; } = null;
    }
}