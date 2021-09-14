using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class ConfirmTransferDetails : WebBasePage
    {
        public ConfirmTransferDetails()
        {
            pageLoadedElement = fromAccount;
            correspondingDataClass = new ConfirmTransferDetailsData().GetType();
            textName = "EBanking Confirm Transfer Details";
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
            .SetIsButtonFlag(true);

        public Element back => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorClass, "=buttonBack")))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);
    }

    public class ConfirmTransferDetailsData : PageData
    {
    }
}
