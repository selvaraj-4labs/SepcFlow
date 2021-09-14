using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Complaints.LogComplaint
{
    public class LogComplaintP1 : AppBasePage
    {
        public LogComplaintP1()
        {
            pageLoadedElement = complaintCategoryLookup;
            correspondingDataClass = new LogComplaintP1Data().GetType();
            textName = "Log Complaint Page 1";
        }

        public Element dateReceived => new Element(FindElement("dtReceived", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);
        public Element complaintCategoryLookup => new Element(FindElement("cboCategory", attributeType: Defs.boLocatorAutomationId));
        public Element complaintSubCategoryLookup => new Element(FindElement("cboSubcategory", attributeType: Defs.boLocatorAutomationId));
        public Element complaintAreaLookup => new Element(FindElement("cboArea", attributeType: Defs.boLocatorAutomationId));
        public Element partyInvolvedLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboParty"),
            "/Edit"));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class LogComplaintP1Data : PageData
    {
        public string complaintCategory { get; set; } = "Other";
        public string complaintSubCategory { get; set; } = "Other";
        public string complaintArea { get; set; } = "Other";
        public string partyInvolved { get; set; } = "Other Internal Department";
    }
}
