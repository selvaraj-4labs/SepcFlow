using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;


namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.SetNominatedBankAccountDetails
{
    public class SetNominatedBankAccountDetailsP1 : AppBasePage
    {
        public SetNominatedBankAccountDetailsP1()
        {
            pageLoadedElement = currentNominatedAccountBox;
            correspondingDataClass = new SetNominatedBankAccountDetailsP1Data().GetType();
            textName = "Set Nominated Bank Account Details Page 1";
        }
        public Element currentNominatedAccountBox => new Element(FindElement("txtNominatedAccountNom", Defs.boLocatorAutomationId));
        public Element selectedNominatedAccountLookup => new Element(FindElement("cbSelectedAccountNom", Defs.boLocatorAutomationId));
        public Element nominatedApplyToMaturityOptionChbox => new Element(FindElement("chkNomMat", Defs.boLocatorAutomationId));
        public Element nominatedApplyToMaturityOptionReferenceBox => new Element(FindElement("ultraTextEditor", Defs.boLocatorAutomationId));
        public Element nominatedApplyToMInterestOptionChbox => new Element(FindElement("chkNomInt", Defs.boLocatorAutomationId));
        public Element nominatedApplyToInterestOptionReferenceBox => new Element(FindElement("txtInterestOptionCustomerReference", Defs.boLocatorAutomationId));

        public Element currentLinkedAccountBox => new Element(FindElement("txtLinkedAccount", Defs.boLocatorAutomationId));
        public Element selectedLinkedAccountLookup => new Element(FindElement("cbSelectedAccountLinked", Defs.boLocatorAutomationId));
        public Element linkedApplyToMaturityOptionChbox => new Element(FindElement("chkLinkMat", Defs.boLocatorAutomationId));
        public Element linkedApplyToInterestOptionChbox => new Element(FindElement("chkIntLink", Defs.boLocatorAutomationId));
    }
    
    public class SetNominatedBankAccountDetailsP1Data : PageData
    {
        public string selectedNominatedAccount { get; set; } = "Test Account - 070116 - 02971797";
        public string nominatedApplyToMInterestOption { get; set; } = Defs.checkBoxSelected;
    }
}
