using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class LoginDetailsConfirmationPage : WebBasePage
    {
        public LoginDetailsConfirmationPage()
        {
            pageLoadedElement = hereBtn;
            correspondingDataClass = new EBankingLoginPageData().GetType();
            textName = "EBanking Login Details Confirmation Page";
        }

        public Element hereBtn => new Element(FindElement(new LocatorList()
                                    .Add(Defs.locatorText, "here")))
                                    .SetIsButtonFlag(true);
    }

    public class LoginDetailsConfirmationPageData : PageData
    {
    }
}
