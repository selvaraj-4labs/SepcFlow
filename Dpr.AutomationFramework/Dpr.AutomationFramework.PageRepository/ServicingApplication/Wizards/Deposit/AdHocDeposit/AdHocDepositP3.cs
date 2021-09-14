using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AdHocDeposit
{
    public class AdHocDepositP3 : AppBasePage
    {
        public AdHocDepositP3()
        {
            pageLoadedElement = paymentAmountBox;
            correspondingDataClass = new AdHocDepositP3Data().GetType();
            textName = "Ad-hoc Deposit Page 3";
        }
        public Element paymentAmountBox => new Element(FindElement("txtAmount", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);
        public Element currencyBox => new Element(FindElement("txtCurrency", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);

        public Element selectPaymentMethodRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("DebitCredit Card", FindElement("rbDebitCreditCard", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Card Reader", FindElement("rbCardReader", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Other", FindElement("rbOther", attributeType: Defs.boLocatorAutomationId)));



        #region 'Debit/Credit Card' Section
        public Section debitCardSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "selectPaymentMethod", "DebitCredit Card"))));
        public SectionEnd debitCardSectionEnd => new SectionEnd();
        #endregion

        #region 'Card Reader' Section
        public Section cardReaderDetailsSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "selectPaymentMethod", "Card Reader"))));

        public Element transactionReferenceBox => new Element(FindElement("txtTransactionReference", attributeType: Defs.boLocatorAutomationId));
        public Element cardReaderInvoiceToBePaidChbox => new Element(FindElement("chkInvoiceToBePaid", attributeType: Defs.boLocatorAutomationId));
        public Element cardReaderBackdateThisPaymentChbox => new Element(FindElement("chkBackdate", attributeType: Defs.boLocatorAutomationId));
        public Element applicableDateLookup => new Element(FindElement("dtApplicableDate", attributeType: Defs.boLocatorAutomationId));

        public SectionEnd cardReaderDetailsSectionEnd => new SectionEnd();
        #endregion

        #region 'Other' Section
        public Section otherSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "selectPaymentMethod", "Other"))));

        public Element otherLookup => new Element(FindElement("cbOtherOptions", attributeType: Defs.boLocatorAutomationId),
            new ConditionList()
                .Add(new Condition(className, "selectPaymentMethod", "Other")));
       
        #region 'otherLookup' == 'Cheque' Section
        public Section otherLookupChequeSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "other", "Cheque"))));

        public Element chequeTypeLookup => new Element(FindElement("selectChequeType", attributeType: Defs.boLocatorAutomationId));
        public Element daysToClearBox => new Element(FindElement("txtDaysToClear", attributeType: Defs.boLocatorAutomationId));
        public Element chequeNoBox => new Element(FindElement("txtChequeNo", attributeType: Defs.boLocatorAutomationId));
        public Element referenceNoBox => new Element(FindElement("txtReferenceNo", attributeType: Defs.boLocatorAutomationId));
        public Element sortCodeBox => new Element(FindElement("txtSortCode", attributeType: Defs.boLocatorAutomationId));
        public Element accountNumberBox => new Element(FindElement("txtAccountNumber", attributeType: Defs.boLocatorAutomationId));
        public Element otherInvoiceToBePaidChbox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "chkInvoiceToBePaid"),
            "/CheckBox[@Name=\"Invoice to be Paid\"]"));
        public Element otherBackdateThisPaymentChbox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "chkBackdate"),
            "/CheckBox[@Name=\"Backdate this payment\"]"));
        public SectionEnd otherLookupChequeSectionEnd => new SectionEnd();
        #endregion

        public SectionEnd otherSectionEnd => new SectionEnd();
        #endregion

        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AdHocDepositP3Data : PageData
    {
        public string selectPaymentMethod { get; set; } = "Card Reader";
        public string transactionReference { get; set; } = "1";
        public string invoiceToBePaid { get; set; } = null;
        public string backdateThisPayment { get; set; } = null;
        public string applicableDate { get; set; } = null;

        public string other { get; set; } = null;
        public string chequeType { get; set; } = "Personal";
        public string chequeNo { get; set; } = "1";

        public string remarks { get; set; } = "TestRemarks";
    }
}
