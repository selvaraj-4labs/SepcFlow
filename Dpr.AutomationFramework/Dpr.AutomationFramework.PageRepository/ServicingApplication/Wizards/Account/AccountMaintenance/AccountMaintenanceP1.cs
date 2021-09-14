using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountMaintenance
{
    public class AccountMaintenanceP1 : AppBasePage
    {
        public AccountMaintenanceP1()
        {
            pageLoadedElement = workflowNameLookup;
            correspondingDataClass = new AccountMaintenanceP1Data().GetType();
            textName = "Account Maintenance Page 1";
        }
        public Element workflowNameLookup => new Element(FindElement("cboScheduledWorkflowName", attributeType: Defs.boLocatorAutomationId));
        public Element workflowDateBox => new Element(FindElement("dtScheduledWorkflowDate", attributeType: Defs.boLocatorAutomationId));

        public Element confirmBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId));
    }

    public class AccountMaintenanceP1Data : PageData
    {
        public string workflowName { get; set; } = "Create Segment Rate Tiers";
    }
}
