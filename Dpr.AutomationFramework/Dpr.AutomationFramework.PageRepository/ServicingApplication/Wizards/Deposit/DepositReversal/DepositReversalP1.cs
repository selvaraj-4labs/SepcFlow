using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.DepositReversal
{
    public class DepositReversalP1 : AppBasePage
    {
        public DepositReversalP1()
        {
            pageLoadedElement = next;
            correspondingDataClass = new DepositReversalP1Data().GetType();
            textName = "Deposit Reversal Page 1";
        }

        // First row of the table, may need to be changed in future.
        //public Element regaularDepositAccountReveralRow => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "ultraGrid")
        //    .Add(Defs.boLocatorName, "List`1 row 1")
        //    .Add(Defs.boLocatorName, "Entry Date")))
        //    .SetIsButtonFlag(true);

        //public Element regaularDepositAccountReveralRow => new Element(By.XPath(
        //    "//Pane[@AutomationId =\"PaymentReversalEntry\"]" +
        //    "/Pane[@AutomationId =\"unallocatedPaymentEntry\"]" +
        //    "/Group[@Name =\"Payments\"][@AutomationId=\"gbSearchDetail\"]" +
        //    "/MenuItem[@AutomationId =\"dgSearchDetail\"]" +
        //    "/Table[@AutomationId =\"ultraGrid\"]" +
        //    "/Custom[@AutomationId=\"Data Area\"]" +
        //    "/Tree[@AutomationId=\"ColScrollRegion: 0, RowScrollRegion: 0\"]"))
        //    .SetIsButtonFlag(true);

        public Element next => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class DepositReversalP1Data : PageData
    {
    }
}
