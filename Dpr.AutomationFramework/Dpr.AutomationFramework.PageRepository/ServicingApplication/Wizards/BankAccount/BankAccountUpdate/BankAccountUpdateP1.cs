using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountUpdate
{
    public class BankAccountUpdateP1 : AppBasePage
    {
        public BankAccountUpdateP1()
        {
            pageLoadedElement = accountNameBox;
            correspondingDataClass = new BankAccountUpdateP1Data().GetType();
            textName = "Bank Account Update Page 1";
        }

        public Element accountNameBox => new Element(FindElement("txtAccountName", attributeType: Defs.boLocatorAutomationId));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

    }

    public class BankAccountUpdateP1Data : PageData
    {
        public string accountName { get; set; } = "TestAccountUpdate";
    }
}
