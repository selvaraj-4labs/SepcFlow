using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AdHocDeposit
{
    public class AdHocDepositP1 : AppBasePage
    {
        public AdHocDepositP1()
        {
            pageLoadedElement = outstandingDebitsOnAccountChbox;
            correspondingDataClass = new AdHocDepositP1Data().GetType();
            textName = "Ad-hoc Deposit Page 1";
        }

        public Element outstandingDebitsOnAccountChbox => new Element(FindElement("cbOutstandingDebits", attributeType: Defs.boLocatorAutomationId));

        public Element adHocDepositChbox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "pnlAdHoc"),
            "/CheckBox", tag: "Pane"));
        
        public Element paymentAmountBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtOtherPaymentAmount"),
            "/Edit[@AutomationId='txtDecimalValue']/Edit"));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AdHocDepositP1Data : PageData
    {
        public string outstandingDebitsOnAccount { get; set; } = null;
        public string adHocDeposit { get; set; } = Defs.checkBoxSelected;
        public string paymentAmount { get; set; } = "1000";
    }
}
