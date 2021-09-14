using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountCease
{
    public class BankAccountCeaseP1 : AppBasePage
    {
        public BankAccountCeaseP1()
        {
            pageLoadedElement = customerCeaseChbox;
            correspondingDataClass = new BankAccountCeaseP1Data().GetType();
            textName = "Bank Account Cease Page 1";
        }

        #region Ceased By Customer Section
        public Element customerCeaseChbox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cbCeaseByCustomer")));
        public Element customerCeaseDateLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtCeaseDateByCustomer"),
            "/Edit"))
            .SetCompletePageFlag(false);
        public Element customerReasonBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtCeasedReasonByCustomer"),
            "/Edit"));

        #endregion

        #region Ceased By Bank Section

        public Element bankCeaseChbox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cbCeaseByBank")));

        public Element bankCeaseDateLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "gbByBank")
            .Add(Defs.boLocatorAutomationId, "txtCeasedReason")));

        public Element bankReasonBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtCeasedReason"),
            "/Edit"));

        #endregion

        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class BankAccountCeaseP1Data : PageData
    {
        public string customerCease { get; set; } = Defs.checkBoxSelected;
        public string customerCeaseDate { get; set; } = null;
        public string customerReason { get; set; } = "Customer Reason";

        public string bankCease { get; set; } = Defs.checkBoxNotSelected;
        public string bankCeaseDate { get; set; } = null;
        public string bankReason { get; set; } = null;

        public string remarks { get; set; } = "Test Remarks";
    }
}
