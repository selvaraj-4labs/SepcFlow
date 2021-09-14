using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.CancelAccountReview
{
    public class CancelAccountReviewP1 : AppBasePage
    {
        public CancelAccountReviewP1()
        {
            pageLoadedElement = remarksBox;
            correspondingDataClass = new CancelAccountReviewP1Data().GetType();
            textName = "Cancel Account Review Page 1";
        }
        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element confirmBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }
    public class CancelAccountReviewP1Data : PageData
    {
        public string remarks { get; set; } = "TestRemarks";
    }
}
