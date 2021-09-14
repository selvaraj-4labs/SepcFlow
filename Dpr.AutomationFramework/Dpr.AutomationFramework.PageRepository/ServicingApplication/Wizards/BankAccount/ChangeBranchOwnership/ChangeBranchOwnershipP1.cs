using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.ChangeBranchOwnership
{
    public class ChangeBranchOwnershipP1 : AppBasePage
    {
        public ChangeBranchOwnershipP1()
        {
            pageLoadedElement = accountNumberBox;
            correspondingDataClass = new ChangeBranchOwnershipP1Data().GetType();
            textName = "Change Branch Ownership Page 1";
        }
        public Element accountNumberBox => new Element(FindElement("txtAccountNumber", attributeType: Defs.boLocatorAutomationId));
        public Element branchBox => new Element(FindElement("txtBranchCode", attributeType: Defs.boLocatorAutomationId));
        public Element ibanBox => new Element(FindElement("txtIBAN", attributeType: Defs.boLocatorAutomationId));
        public Element bicBox => new Element(FindElement("txtBIC", attributeType: Defs.boLocatorAutomationId));
        public Element portalUserCompanyBox => new Element(FindElement("gbCurrentBranch", attributeType: Defs.boLocatorAutomationId));
        public Element branchCodeLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboBranchCode"),
            "/Edit"));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }
    public class ChangeBranchOwnershipP1Data : PageData
    {
        public string accountNumber { get; set; } = null;
        public string branch { get; set; } = null;
        public string iban { get; set; } = null;
        public string bic { get; set; } = null;
        public string portalUserCompany { get; set; } = null;
        public string branchCode { get; set; } = "Branch:PBR(101)";
    }
}
