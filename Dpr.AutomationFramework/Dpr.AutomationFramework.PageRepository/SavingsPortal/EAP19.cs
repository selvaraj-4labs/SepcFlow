using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP19 : WebBasePage
    {
        public EAP19()
        {
            pageLoadedElement = pledgeAmountBox;
            correspondingDataClass = new EAP19Data().GetType();
            textName = "Payment Options";
        }

        #region Locators
        public Element pledgeAmountBox => new Element(FindElement("initialDepositAmount"));
        public Element sourceOfFundsLookup => new Element(FindElement("sourceOfFundsControl"));
        public Element debitCardDepositBox => new Element(FindElement("txtDebitCardInitialAmount"), new ConditionList()
            .Add(new Condition(className, "depositType", "Debit Card")));

        //public Element cardPaymentSubmitBtn => new Element(FindElement("btnDebitCard"));

        //public Element bankTransferSubmitBtn => new Element(FindElement("btnBankTransfer"));

        //public Element chequeSubmitBtn => new Element(FindElement("btnCheque"));

        //public ButtonGroup depositType => new ButtonGroup()
        //    .AddButtonElement("Debit Card", cardPaymentSubmitBtn.locator)
        //    .AddButtonElement("Bank Transfer", bankTransferSubmitBtn.locator)
        //    .AddButtonElement("Cheque", chequeSubmitBtn.locator);

        public Element depositType => new Element(new ButtonGroup()
            .AddButtonElement("Debit Card", FindElement("btnDebitCard"))
            .AddButtonElement("Bank Transfer", FindElement("btnBankTransfer"))
            .AddButtonElement("Cheque", FindElement("btnCheque")));

        #endregion
    }

    public class EAP19Data : PageData
    {

        public string pledgeAmount { get; set; } = "11000";

        public string sourceOfFunds { get; set; } = "Salary";

        public string debitCardDeposit { get; set; } = "11000";

        public string depositType { get; set; } = "Debit Card";

    }
}
