using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountNew
{
    public class BankAccountNewP1 : AppBasePage 
    {
        public BankAccountNewP1()
        {
            pageLoadedElement = accountNameBox;
            correspondingDataClass = new BankAccountNewP1Data().GetType();
            textName = "Bank Account New Page 1";
        }

        #region 'Validate And Find Bank Account Details' Section

        public Element accountNameBox => new Element(FindElement("txtAccountName", attributeType: Defs.boLocatorAutomationId));

        public Element sortCodeBox => new Element(FindElement("txtSortCode", attributeType: Defs.boLocatorAutomationId));

        public Element accountNumberBox => new Element(FindElement("txtAccountNo", attributeType: Defs.boLocatorAutomationId));

        public Element validationBtn => new Element(FindElement("btnValidate", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true)
            /*.SetCompletePageFlag(false)*/;

        #endregion

        #region 'Bank Account Detail' Section

        public Element bankNameBox => new Element(FindElement("txtBank", attributeType: Defs.boLocatorAutomationId));

        public Element branchNameBox => new Element(FindElement("txtBranch", attributeType: Defs.boLocatorAutomationId));

        public Element branchAddressBox => new Element(FindElement("txtAddress", attributeType: Defs.boLocatorAutomationId));
        #endregion


    }

    public class BankAccountNewP1Data : PageData
    {
        public string accountName { get; set; } = "TestAccountNew";

        public string sortCode { get; set; } = "089999";

        public string accountNumber { get; set; } = "02971797";

        public string bankName { get; set; } = "TestBank";

        public string branchName { get; set; } = "TestBranch";

        public string brandAddress { get; set; } = "6th Floor, Commodity Quay, St Katharine Docks, London, E1W 1AZ";
    }

}
