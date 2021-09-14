using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class TransferConfirmation : WebBasePage
    {
        public TransferConfirmation()
        {
            pageLoadedElement = new Element(FindElement("=Transfer confirmation", attributeType: Defs.locatorText, tag: "span"));
            correspondingDataClass = new TransferConfirmationData().GetType();
            textName = "EBanking Transfer Confirmation";
        }
        public Element fromAccount => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "=container"),
            "/section[4]/div/div/div/div/div/article/form/div[2]/div[2]/div/div/div[1]/div[2]"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element toAccount => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "=container"),
            "/section[4]/div/div/div/div/div/article/form/div[2]/div[2]/div/div/div[2]/div[2]"))
            .SetCompletePageFlag(false);
        public Element amount => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "=container"),
            "/section[4]/div/div/div/div/div/article/form/div[2]/div[2]/div/div/div[3]/div[2]"))
            .SetCompletePageFlag(false);        
        public Element date => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "=container"),
            "/section[4]/div/div/div/div/div/article/form/div[2]/div[2]/div/div/div[4]/div[2]"))
            .SetCompletePageFlag(false);
        public Element confirm => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorClass, "=buttonConfirm")))
            .SetCompletePageFlag(false);
        public Element back => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorClass, "=buttonBack")))
            .SetCompletePageFlag(false);
    }

    public class TransferConfirmationData : PageData
    {
    }
}
