using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class ForgottenUserIdPage : WebBasePage
    {
        public ForgottenUserIdPage()
        {
            pageLoadedElement = forgottenLoginDetailsHeader;
            correspondingDataClass = new ForgottenUserIdPageData().GetType();
            textName = "EBanking Forgotten User ID Page";
        }        
        public Element forgottenLoginDetailsHeader => new Element(FindElement("=Forgotten login details", attributeType: Defs.locatorText, tag: "span"))
            .SetCompletePageFlag(false);
    }

    public class ForgottenUserIdPageData : PageData
    {

    }
}
