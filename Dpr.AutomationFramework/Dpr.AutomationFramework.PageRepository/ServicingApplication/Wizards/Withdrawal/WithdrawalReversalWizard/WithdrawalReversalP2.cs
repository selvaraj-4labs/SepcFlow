using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.WithdrawalReversalWizard
{
    public class WithdrawalReversalP2 : AppBasePage
    {

        public WithdrawalReversalP2()
        {
            pageLoadedElement = paymentDetailsSectionHeader;
            correspondingDataClass = new WithdrawalReversalP2Data().GetType();
            textName = "Withdrawal Wizard Page 2";
        }

        public Element paymentDetailsSectionHeader => new Element(FindElement("gbPaymentDetails", attributeType: Defs.boLocatorAutomationId))
            .SetCompletePageFlag(false);

        public Element method => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtMethod"),"/Edit"))
            .SetCompletePageFlag(false);

        public Element chequeNo => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtChequeNumber"), "/Edit"))
            .SetCompletePageFlag(false);

        public Element referenceNo => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtReferenceNumber"), "/Edit"))
            .SetCompletePageFlag(false);

        public Element entryDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtpEntryDate"), "/ComboBox/Edit"))
            .SetCompletePageFlag(false);

        public Element valueDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtpValueDate"), "/ComboBox/Edit"))
            .SetCompletePageFlag(false);

        public Element amount => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtDecimalValue"), "/Edit"))
            .SetCompletePageFlag(false);

        public Element causeOfReversal => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=cboReversalCauseLookUp"), tag: "ComboBox"));

        public Element reasonForReversal => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtReasonForReversal"), "/Edit"));

        public Element nextBtn => new Element(FindElement("=Next", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);

    }


    public class WithdrawalReversalP2Data : PageData
    {
        public string causeOfReversal { set; get; } = "Payment Returned";
        public string reasonForReversal { set; get; } = "Test";
    }
}
