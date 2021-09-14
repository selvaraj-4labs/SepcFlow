using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Complaints.CancelCustomerComplaint
{
    public class CancelCustomerComplaintP1 : AppBasePage
    {
        public CancelCustomerComplaintP1()
        {
            pageLoadedElement = remarksBox;
            correspondingDataClass = new CancelCustomerComplaintP1Data().GetType();
            textName = "Cancel Customer Complaint Page 1";
        }

        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CancelCustomerComplaintP1Data : PageData
    {
        public string remarks { get; set; } = "TestRemarks";
    }

}
