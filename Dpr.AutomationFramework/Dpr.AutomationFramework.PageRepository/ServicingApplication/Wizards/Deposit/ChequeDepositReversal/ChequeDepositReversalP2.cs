using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.ChequeDepositReversal
{
    public class ChequeDepositReversalP2 : AppBasePage
    {
        public ChequeDepositReversalP2()
        {
            pageLoadedElement = causeOfReversalLookup;
            correspondingDataClass = new ChequeDepositReversalP2Data().GetType();
            textName = "Cheque Deposit Reversal Page 2";
        }
        public Element causeOfReversalLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ceCauseOfReversal"),
            "/Edit"));
        public Element reasonOfReversalBox => new Element(FindElement("txtReasonForReversal", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }
    public class ChequeDepositReversalP2Data : PageData
    {
        public string causeOfReversal { get; set; } = "Unpaid Cheque";
        public string reasonOfReversal { get; set; } = "TestReversal";
    }
}
