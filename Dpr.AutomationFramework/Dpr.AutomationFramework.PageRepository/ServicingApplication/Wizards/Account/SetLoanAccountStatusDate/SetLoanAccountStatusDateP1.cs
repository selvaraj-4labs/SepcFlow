using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.SetLoanAccountStatusDate
{
    public class SetLoanAccountStatusDateP1 : AppBasePage
    {
        public SetLoanAccountStatusDateP1()
        {
            pageLoadedElement = statusTypelookup;
            correspondingDataClass = new SetLoanAccountStatusDateP1Data().GetType();
            textName = "Set Account Status Date Page 1";
        }
        public Element statusTypelookup => new Element(FindElement("cmbStatusType", attributeType: Defs.boLocatorAutomationId));
        public Element dateBox => new Element(FindElement("dtStatusEffectiveDate", attributeType: Defs.boLocatorAutomationId));
        public Element confirmBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

    }

    public class SetLoanAccountStatusDateP1Data : PageData
    {
        public string statusType { get; set; } = "Dormancy Override";
        public string date { get; set; } = null;
    }
}
