using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Fees.AddNewFee
{
    public class AddNewFeeP3 : AppBasePage
    {
        public AddNewFeeP3()
        {
            pageLoadedElement = paymentMethodRbtn;
            correspondingDataClass = new AddNewFeeP3Data().GetType();
            textName = "Add New Fee Page 3";
        }

        public Element paymentAmountBox => new Element(FindElement("txtAmount", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);
        public Element currencyBox => new Element(FindElement("txtCurrency", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);

        public Element paymentMethodRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Debit/Credit Card", FindElement("rbDebitCreditCard", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Card Reader", FindElement("rbCardReader", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Other", FindElement("rbOther", attributeType: Defs.boLocatorAutomationId)));

        public Element otherLookup => new Element(FindElement("cbOtherOptions", attributeType: Defs.boLocatorAutomationId),
            new ConditionList()
            .Add(new Condition(className, "paymentMethod", "Other")));

        public Section cardReaderDetailsSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "paymentMethod", "Card Reader"))));

        public Element transactionReferenceBox => new Element(FindElement("txtTransactionReference", attributeType: Defs.boLocatorAutomationId));
        public Element invoiceToBePaidChbox => new Element(FindElement("chkInvoiceToBePaid", attributeType: Defs.boLocatorAutomationId));
        public Element backdateThisPaymentChbox => new Element(FindElement("chkBackdate", attributeType: Defs.boLocatorAutomationId));
        public Element applicableDateLookup => new Element(FindElement("dtApplicableDate", attributeType: Defs.boLocatorAutomationId));
        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));

        public SectionEnd cardReaderDetailsSectionEnd => new SectionEnd();

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AddNewFeeP3Data : PageData
    {
        public string paymentMethod { get; set; } = "Card Reader";
        public string transactionReference { get; set; } = "1";
        public string other { get; set; } = null;
        public string invoiceToBePaid { get; set; } = null;
        public string backdateThisPayment { get; set; } = null;
        public string applicableDate { get; set; } = null;
        public string remarks { get; set; } = null;
    }
}