using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ISATransfer.ISATransferIn
{
    public class ISATransferInP1 : AppBasePage
    {
        public ISATransferInP1()
        {
            pageLoadedElement = currentYearContributionBox;
            correspondingDataClass = new ISATransferInP1Data().GetType();
            textName = "ISA Transfer In Page 1";
        }

        #region Payment Details Section

        public Element currentYearContributionBox => new Element(FindElement("txtCurrentYearContribution", attributeType: Defs.boLocatorAutomationId));

        public Element otherContributionsBox => new Element(FindElement("txtOtherContribution", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);

        public Element receivedMethodLookup => new Element(FindElement("cboReceivedMethod", attributeType: Defs.boLocatorAutomationId));

        public Element chequeTypeLookup => new Element(FindElement("cboChequeType", attributeType: Defs.boLocatorAutomationId));

        public Element daysToClearBox => new Element(FindElement("txtDaysToClear", attributeType: Defs.boLocatorAutomationId));

        public Element chequeNumberBox => new Element(FindElement("txtRefNo", attributeType: Defs.boLocatorAutomationId));

        public Element sortCodeBox => new Element(FindElement("txtSortCode", attributeType: Defs.boLocatorAutomationId));

        public Element accountNumberBox => new Element(FindElement("txtAccNo", attributeType: Defs.boLocatorAutomationId));

        #endregion

        #region Transfer Dates Section


        public Element applicationDateLookup => new Element(FindElement("dtApplicationDate", attributeType: Defs.boLocatorAutomationId));

        public Element remittanceDateLookup => new Element(FindElement("dtRemittanceDate", attributeType: Defs.boLocatorAutomationId));

        public Element firstTransactionDateLookup => new Element(FindElement("dtFirstTransactionDate", attributeType: Defs.boLocatorAutomationId));


        #endregion

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class ISATransferInP1Data : PageData
    {
        public string currentYearContribution { get; set; } = "1000";

        public string receivedMethod { get; set; } = "Cheque";

        public string chequeType { get; set; } = "Bank";

        public string chequeNumber { get; set; } = "1111";

        public string sortCode { get; set; } = "110001";

        public string accountNumber { get; set; } = "11111111";

    }
}
