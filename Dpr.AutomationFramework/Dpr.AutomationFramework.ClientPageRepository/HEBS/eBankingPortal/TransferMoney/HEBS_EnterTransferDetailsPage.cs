using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.TransferMoney
{
    public class HEBS_EnterTransferDetailsPage : EnterTransferDetailsPage
    {
        public HEBS_EnterTransferDetailsPage()
        {
            pageLoadedElement = new Element(FindElement("=Enter transfer details", attributeType: Defs.locatorText, tag: "span"));
            correspondingDataClass = new HEBS_EnterTransferDetailsPageData().GetType();
            textName = "EBanking Enter Transfer Details";
        }
    }

    public class HEBS_EnterTransferDetailsPageData : EnterTransferDetailsPageData
    {
    }
}
