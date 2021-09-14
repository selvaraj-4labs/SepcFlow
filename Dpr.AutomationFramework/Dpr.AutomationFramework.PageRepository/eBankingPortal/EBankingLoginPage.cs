using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class EBankingLoginPage : WebBasePage
    {
        public EBankingLoginPage()
        {
            pageLoadedElement = continueBtn;
            correspondingDataClass = new EBankingLoginPageData().GetType();
            textName = "EBanking Login Page";
        }

        public Element userNameBox => new Element(FindElement("txtUserName"));
        public Element passwordBox => new Element(FindElement("txtPassword"));
        public Element continueBtn => new Element(FindElement("cmdLogon")).SetIsButtonFlag(true);
        public Element forgottenYourUserId => new Element(FindElement("Forgotten your User ID?", attributeType: Defs.locatorText))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element forgottenYourPassword => new Element(FindElement("Forgotten your Password?", attributeType: Defs.locatorText))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
    }

    public class EBankingLoginPageData : PageData
    {
        public string userName { get; set; } = null;
        
        public string password { get; set; } = "Password1";
    }
}
