using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.ManagePayees
{
    public class ManagePayeesP1 : AppBasePage
    {
        public ManagePayeesP1()
        {
            pageLoadedElement = payeeReferenceBox;
            correspondingDataClass = new ManagePayeesP1Data().GetType();
            textName = "Manage Payees Page 1";
        }
        public Element payeeReferenceBox => new Element(FindElement("txtPayeeReference", Defs.boLocatorAutomationId));
        public Element sortCodeBox => new Element(FindElement("txtSortCode", Defs.boLocatorAutomationId));
        public Element accountNumberBox => new Element(FindElement("txtAccountNumber", Defs.boLocatorAutomationId));
        public Element accountIbanBox => new Element(FindElement("txtAccountIban", Defs.boLocatorAutomationId));
        public Element accountNameBox => new Element(FindElement("txtAccountName", Defs.boLocatorAutomationId));

        public Element newPayeeReferenceBox => new Element(FindElement("txtPayeeReference", Defs.boLocatorAutomationId));
        public Element newAccountNameBox => new Element(FindElement("txtNewAccountName", Defs.boLocatorAutomationId));
        public Element newSortCodeBox => new Element(FindElement("txtNewSortCode", Defs.boLocatorAutomationId));
        public Element newAccountNumberBox => new Element(FindElement("txtNewAccountNo", Defs.boLocatorAutomationId));
        public Element validateBtn => new Element(FindElement("btnValidate", Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
        public Element newAccountIbanBox => new Element(FindElement("txtNewAccountIban", Defs.boLocatorAutomationId));
        public Element validateIbanBtn => new Element(FindElement("btnValidateIban", Defs.boLocatorAutomationId)).SetIsButtonFlag(true).SetCompletePageFlag(false);
        public Element swiftBicLookup => new Element(FindElement("cboBicLookUp", Defs.boLocatorAutomationId));
        public Element overrideSwiftBicLookup => new Element(FindElement("txtOverrideBic", Defs.boLocatorAutomationId));
        public Element forceAcceptBankAccountChbox => new Element(FindElement("chkForceAcceptBankAccount", Defs.boLocatorAutomationId));
        public Element addBtn => new Element(FindElement("btnAdd", Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
        public Element sharePayeeChbox => new Element(FindElement("chkSharePayee", Defs.boLocatorAutomationId));
        public Element behalfOfCompanyLookup => new Element(FindElement("cboOnBehalfOfCompany", Defs.boLocatorAutomationId));


    }

    public class ManagePayeesP1Data : PageData
    {
        public string newPayeeReference { get; set; } = "11";
        public string newAccountName { get; set; } = "TestAccount";
        public string newSortCode { get; set; } = "110001";
        public string newAccountNumber { get; set; } = "11111111";
        public string behalfOfCompany { get; set; } = "None";

    }
}
