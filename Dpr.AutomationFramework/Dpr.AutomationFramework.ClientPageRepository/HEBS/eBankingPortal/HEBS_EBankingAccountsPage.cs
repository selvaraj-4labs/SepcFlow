using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_EBankingAccountsPage : EBankingAccountsPage
    {
        public HEBS_EBankingAccountsPage()
        {
            pageLoadedElement = new Element(FindElement("Your accounts", attributeType: Defs.locatorText, tag: "span"));
            correspondingDataClass = new HEBS_EBankingAccountsPageData().GetType();
            textName = "EBanking Login Page";
        }
    }

    public class HEBS_EBankingAccountsPageData : EBankingAccountsPageData
    {
    }
}
