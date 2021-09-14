using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_DirectDebitDetailsPage : WebBasePage
    {
        public FMA_DirectDebitDetailsPage()
        {
            pageLoadedElement = directDebitDeclaration;
            correspondingDataClass = new FMA_DirectDebitDetailsPageData().GetType();
            textName = "FMA Direct Debit Details Page";
        }
        public Element directDebitDeclaration => new Element(FindElement("chkAcceptDeclaration"));
        
        public Element applicant1AssociatedWithBankAccount => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "MC_ucBankDetailsSelectiveApplicantAllocation_ctl03_ctl00"),
            "[1]/div/span/input"));

        public Element sortCode => new Element(FindElement("txtSortCode"));
        public Element accountNumber => new Element(FindElement("txtAccountNo"));
        public Element findBank => new Element(FindElement("ctl03_btnValidate")).SetIsButtonFlag(true);

        // Add WaitFor here.
        public WaitFor waitForAddressDetails => new WaitFor(findBank)
            .AddWaitElement(bankName.locator)
            .AddWaitElement(address.locator)
            .AddWaitElement(accountHolderName.locator)
            .AddWaitElement(perferredPaymentDay.locator);

        public Element bankName => new Element(FindElement("lblBankName"));
        public Element address => new Element(FindElement("txtBankAddress"));
        public Element accountHolderName => new Element(FindElement("txtAccountHolder"));
        public Element perferredPaymentDay => new Element(FindElement("ddlPaymentDates"));
        
        public Element next => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);

    }

    public class FMA_DirectDebitDetailsPageData : PageData
    {
        public string directDebitDeclaration { get; set; } = Defs.checkBoxSelected;
        public string applicant1AssociatedWithBankAccount { get; set; } = Defs.checkBoxSelected;
        public string applicantAssociatedWithBankAccount { get; set; } = Defs.checkBoxSelected;
        public string sortCode { get; set; } = "999999";
        public string accountNumber { get; set; } = "99999999";

        // Bank Name has no data as it is not an interactable element.
        public string address { get; set; } = null;
        public string accountHolderName { get; set; } = "TestAccountHolderName";
        public string perferredPaymentDay { get; set; } = "1";

    }
}
