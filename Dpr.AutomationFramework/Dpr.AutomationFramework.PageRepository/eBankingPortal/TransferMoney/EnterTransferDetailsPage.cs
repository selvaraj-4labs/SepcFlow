using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class EnterTransferDetailsPage : WebBasePage
    {
        public EnterTransferDetailsPage()
        {
            pageLoadedElement = new Element(FindElement("=Enter transfer details", attributeType: Defs.locatorText, tag: "span"));
            correspondingDataClass = new EnterTransferDetailsPageData().GetType();
            textName = "EBanking Enter Transfer Details";
        }       
        public Element fromAccount => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "=container"), "/section[4]/div/div/div/div/div/article/form/div[2]/div[2]/div/div/div[1]/div[2]"))
            .SetCompletePageFlag(false);        
        public Element toAccount => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "PayToAccount")));
        public Element amount => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "Amount")));
        public Element next => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorClass, "=buttonNext")))
            .SetIsButtonFlag(true);        
        public Element back => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorClass, "=buttonBack")))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
    }


    public class EnterTransferDetailsPageData : PageData
    {
       public string toAccount { set; get; } = null;
       public string amount { set; get; } = "100";
    }
}
