using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{

    public class ForgottenMemorableAnswerPage : WebBasePage
    {
        public ForgottenMemorableAnswerPage()
        {
            pageLoadedElement = userId;
            correspondingDataClass = new ForgottenMemorableAnswerPageData().GetType();
            textName = "Ebanking forgotten memorable answer page";
        }
        public Element userId => new Element(FindElement("Username"));
        public Element submit => new Element(FindElement("Submit", attributeType: Defs.locatorValue)).SetIsButtonFlag(true);
    }


    public class ForgottenMemorableAnswerPageData : PageData
    {
        public string userId { set; get; } = null;                                                  
    }
}
