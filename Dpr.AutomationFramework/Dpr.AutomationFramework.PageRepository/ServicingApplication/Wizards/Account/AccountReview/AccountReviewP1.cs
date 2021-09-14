using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;


namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class AccountReviewP1 : AppBasePage
    {
        public AccountReviewP1()
        {
            pageLoadedElement = reviewTypeLookup;
            correspondingDataClass = new AccountReviewP1Data().GetType();
            textName = "Account Review Page 1";
        }
        public Element reviewTypeLookup => new Element(FindElement("cboReviewType", attributeType: Defs.boLocatorAutomationId));
        public Element updateBtn => new Element(FindElement("btnUpdate", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
        public Element nextReviewDateBox => new Element(FindElement("dtNextReviewDate", attributeType: Defs.boLocatorAutomationId));
        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element confirmBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AccountReviewP1Data : PageData
    {
        public string reviewType { get; set; } = "Other";
        public string remarks { get; set; } = "TestRemarks";
    }
}
