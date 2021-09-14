using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{

    public class ForgottenPasswordPage : WebBasePage
    {
        public ForgottenPasswordPage()
        {
            pageLoadedElement = userId;
            correspondingDataClass = new ForgottenPasswordPageData().GetType();
            textName = "Ebanking forgotten password page";
        }
        public Element userId => new Element(FindElement("Username"));
        public Element submit => new Element(FindElement("Submit", attributeType: Defs.locatorValue)).SetIsButtonFlag(true);       
    }


    public class ForgottenPasswordPageData : PageData
    {
        public string userId { set; get; } = null;                                                  
    }
}
