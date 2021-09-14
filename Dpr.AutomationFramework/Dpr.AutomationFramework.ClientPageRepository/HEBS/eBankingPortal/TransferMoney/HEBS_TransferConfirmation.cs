using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.TransferMoney
{
    public class HEBS_TransferConfirmation : TransferConfirmation
    {
        public HEBS_TransferConfirmation()
        {
            pageLoadedElement = new Element(FindElement("=Transfer confirmation", attributeType: Defs.locatorText, tag: "span"));
            correspondingDataClass = new TransferConfirmationData().GetType();
            textName = "EBanking Transfer Confirmation";
        }
    }

    public class HEBS_TransferConfirmationData : TransferConfirmationData
    {
    }
}
