using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP19Card : WebBasePage
    {
        public EAP19Card()
        {
            pageLoadedElement = pledgeAmountBox;
            correspondingDataClass = new EAP19CardData().GetType();
            textName = "Payment Options";
        }
        public Element pledgeAmountBox => new Element(FindElement("initialDepositAmount"));
        public Element sourceOfFundsLookup => new Element(FindElement("sourceOfFundsControl"));
        public Element debitCardDepositBox => new Element(FindElement("txtDebitCardInitialAmount"));
        public Element cardPaymentSubmitBtn => new Element(FindElement("ucPrePayment_btnDebitCard")).SetIsButtonFlag(true);
        public Element bankTransferSubmitBtn => null;
    }

    public class EAP19CardData : PageData
    {
        public string pledgeAmount { get; set; } = "11000";
        public string sourceOfFunds { get; set; } = "Salary";
        public string debitCardDeposit { get; set; } = "11000";
    }
}
