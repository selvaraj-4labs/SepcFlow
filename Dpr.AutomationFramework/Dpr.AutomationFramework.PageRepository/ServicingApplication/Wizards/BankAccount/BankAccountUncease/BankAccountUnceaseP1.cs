using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountUncease
{
    public class BankAccountUnceaseP1 : AppBasePage
    {
        public BankAccountUnceaseP1()
        {
            pageLoadedElement = unceaseChbox;
            correspondingDataClass = new BankAccountUnceaseP1Data().GetType();
            textName = "Bank Account Uncease Page 1";
        }

        public Element sortCodeBox => new Element(FindElement("txtSortCode", attributeType: Defs.boLocatorAutomationId));
        public Element accountNumberBox => new Element(FindElement("txtAccountNumber", attributeType: Defs.boLocatorAutomationId));
        public Element accountIbanBox => new Element(FindElement("txtAccountIban", attributeType: Defs.boLocatorAutomationId));
        public Element accountNameBox => new Element(FindElement("txtAccountName", attributeType: Defs.boLocatorAutomationId));
        public Element rollNumberBox => new Element(FindElement("txtRollNumber", attributeType: Defs.boLocatorAutomationId));
        public Element unceaseChbox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cbUncease")));

        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class BankAccountUnceaseP1Data : PageData
    {
        public string sortCode { get; set; } = null;
        public string accountNumber { get; set; } = null;
        public string accountIban { get; set; } = null;
        public string accountName { get; set; } = null;
        public string rollNumber { get; set; } = null;
        public string uncease { get; set; } = Defs.checkBoxSelected;
        public string remarks { get; set; } = "TestRemarks";
    }
}