using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class YourDocumentsPage : WebBasePage
    {
        public YourDocumentsPage()
        {
            pageLoadedElement = account;
            correspondingDataClass = new YourDocumentsPageData().GetType();
            textName = "EBanking Your Documents";
        }

        public Element account => new Element(FindElement("FromAccount"))
            .SetCompletePageFlag(false);

        public Element periodFrom => new Element(FindElement("FromDate"))
            .SetCompletePageFlag(false);

        public Element periodTo => new Element(FindElement("ToDate"))
            .SetCompletePageFlag(false);

        public Element filter => new Element(FindElement("Filter", attributeType: Defs.locatorValue, tag: "input"))
            .SetIsButtonFlag(true).SetCompletePageFlag(false);
    }

    public class YourDocumentsPageData : PageData
    {
    }
}
