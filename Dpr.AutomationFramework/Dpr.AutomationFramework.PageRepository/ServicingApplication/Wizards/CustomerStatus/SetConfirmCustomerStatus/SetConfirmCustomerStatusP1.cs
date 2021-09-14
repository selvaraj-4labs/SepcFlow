using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerStatus.SetConfirmCustomerStatus
{
    public class SetConfirmCustomerStatusP1 : AppBasePage
    {
        public SetConfirmCustomerStatusP1()
        {
            pageLoadedElement = statusReasonLookup;
            correspondingDataClass = new SetConfirmCustomerStatusP1Data().GetType();
            textName = "Set / Confirm Customer Status Page 1";
        }

        public Element statusReasonLookup => new Element(FindElement("cboOnHoldTypes", attributeType: Defs.boLocatorAutomationId));
        public Element subStatusLookup => new Element(FindElement("cboSubStatus", attributeType: Defs.boLocatorAutomationId));
        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId ));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class SetConfirmCustomerStatusP1Data : PageData
    {
        public string statusReason { get; set; } = "Risk Profile";
        public string subStatus { get; set; } = "Low";
        public string remarks { get; set; } = "TestRemarks";
    }
}
