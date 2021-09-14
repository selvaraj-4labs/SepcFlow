using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.ChequeDepositReversal
{
    public class ChequeDepositReversalP1 : AppBasePage
    {
        public ChequeDepositReversalP1()
        {
            pageLoadedElement = next;
            correspondingDataClass = new ChequeDepositReversalP1Data().GetType();
            textName = "Cheque Deposit Reversal Page 1";
        }
        public Element next => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }
    public class ChequeDepositReversalP1Data : PageData
    {
    }
}
