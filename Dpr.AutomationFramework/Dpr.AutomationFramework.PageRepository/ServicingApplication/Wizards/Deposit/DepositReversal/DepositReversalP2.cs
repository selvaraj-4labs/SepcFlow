using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.DepositReversal
{
    public class DepositReversalP2 : AppBasePage
    {
        public DepositReversalP2()
        {
            pageLoadedElement = methodBox;
            correspondingDataClass = new DepositReveralP2Data().GetType();
            textName = "Deposit Reversal Page 2";
        }

        public Element methodBox => new Element(FindElement("txtMethod", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);
        public Element reportReferenceBox => new Element(FindElement("txtReportReference", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);
        // Not displayed on page (needs scrolling).
        public Element lineItemReferenceBox => new Element(FindElement("txtLineItemReference", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);
        public Element entryDateBox => new Element(FindElement("dtpEntryDate", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);
        public Element valueDateBox => new Element(FindElement("dtpValueDate", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);
        public Element paymentAmountBox => new Element(FindElement("txtPaymentAmount", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);
        public Element allocationAmountBox => new Element(FindElement("txtAllocationAmount", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);
        // Not displayed on page (needs scrolling).
        public Element unallocatedAmountBox => new Element(FindElement("txtUnallocatedAmount", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);

        public Element causeOfReversalLookup => new Element(FindElement("ceCauseOfReversal", attributeType: Defs.boLocatorAutomationId));
        public Element targetToSuspenseAccountLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ceTargetToSuspense"),
            "/Edit"));
        public Element reasonForReversalBox => new Element(FindElement("txtReasonForReversal", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class DepositReveralP2Data : PageData
    {
        public string causeOfReversal { get; set; } = "Incorrect Account";
        public string targetToSuspenseAccount { get; set; } = "Suspense";
        public string reasonForReversal { get; set; } = "Test Reason For Reversal";
    }
}
