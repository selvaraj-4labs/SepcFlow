using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class MessageCentrePage : WebBasePage
    {
        public MessageCentrePage()
        {
            pageLoadedElement = account;
            correspondingDataClass = new MessageCentrePageData().GetType();
            textName = "EBanking Message Centre";
        }
        public Element account => new Element(FindElement("FromAccount"));
        public Element periodFrom => new Element(FindElement("FromDate"));
        public Element periodTo => new Element(FindElement("ToDate"));      
        public Element filter => new Element(FindElement("Filter", attributeType: Defs.locatorValue))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
    }

    public class MessageCentrePageData : PageData
    {
        public string account { get; set; } = null;
        
        public string periodFrom { get; set; } = null;

        public string periodTo { get; set; } = null;
    }
}
