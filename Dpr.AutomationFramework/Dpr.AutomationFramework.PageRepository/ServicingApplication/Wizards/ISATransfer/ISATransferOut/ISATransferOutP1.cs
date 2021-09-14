using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ISATransfer.ISATransferOut
{
    public class ISATransferOutP1 : AppBasePage
    {
        public ISATransferOutP1()
        {
            pageLoadedElement = transferCurrentYearContributions;
            correspondingDataClass = new ISATransferOutP1Data().GetType();
            textName = "ISA Transfer Out Page 1";
        }

        #region Transfer Amount Section

        public Element transferCurrentYearContributions => new Element(FindElement("chkTransferCurrYear", attributeType: Defs.boLocatorAutomationId));

        public Element accountOnHoldCh => new Element(FindElement("chkAccountOnHold", attributeType: Defs.boLocatorAutomationId));

        #endregion

        #region Transfer Details Section

        public Element transferMethodLookup => new Element(FindElement("ceTrnsfrMethod", attributeType: Defs.boLocatorAutomationId));

        public Element referenceRemittanceNoBox => new Element(FindElement("txtRefRemNo", attributeType: Defs.boLocatorAutomationId));

        public Element firstTransactionDateBox => new Element(FindElement("dtFirstTransactionDate", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);

        public Element payeeBox => new Element(FindElement("txtPayee", attributeType: Defs.boLocatorAutomationId));

        public Element chequeNoBox => new Element(FindElement("txtChequeNo", attributeType: Defs.boLocatorAutomationId));


        #endregion

        public Element nextBtn => new Element(FindElement("pnlNextButton",
            attributeType: Defs.boLocatorAutomationId))
            .SetIsButtonFlag(true);
    }

    public class ISATransferOutP1Data : PageData
    {
        public string transferCurrentYearContributions { get; set; } = Defs.checkBoxSelected;

        public string accountOnHold { get; set; } = Defs.checkBoxNotSelected;

        public string transferMethod { get; set; } = "Cheque";

        public string referenceRemittanceNo { get; set; } = "111";

        public string payee { get; set; } = "TestPayee";

        public string chequeNo { get; set; } = "12345";

    }
}
