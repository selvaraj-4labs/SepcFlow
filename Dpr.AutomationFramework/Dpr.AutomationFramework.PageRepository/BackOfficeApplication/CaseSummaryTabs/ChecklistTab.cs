using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.CaseSummaryTabs
{
    public class ChecklistTab : AppBasePage
    {
        public ChecklistTab()
        {
            pageLoadedElement = checkListTable;
            correspondingDataClass = new CaseSummaryTabData().GetType();
            textName = "Checklist Tab";
        }

        public Element checkListTable => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ultraGridChecklist")))
            .SetCompletePageFlag(false);

        // Below may be descoped
        // Commented Out: 21/07/2020
        //#region First Row

        //public Element partyTableBox_1 => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "ultraGridChecklist"),
        //    "/Custom[@Name=\"ArrayList row 1\"]/DataItem[@Name=\"Party\"]"));

        //public Element typeTableBox_1 => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "ultraGridChecklist"),
        //    "/Custom[@Name=\"ArrayList row 1\"]/DataItem[@Name=\"Type\"]"));

        //public Element itemDetailBox_1 => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "ultraGridChecklist"),
        //    "/Custom[@Name=\"ArrayList row 1\"]/DataItem[@Name=\"Item Detail\"]"));

        //public Element applicantBox_1 => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "ultraGridChecklist"),
        //    "/Custom[@Name=\"ArrayList row 1\"]/DataItem[@Name=\"Applicant\"]"));

        //public Element receivedSatisfiedBox_1 => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "ultraGridChecklist"),
        //    "/Custom[@Name=\"ArrayList row 1\"]/DataItem[@Name=\"Received/Satisfied\"]"));

        //public Element expiresBox_1 => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "ultraGridChecklist"),
        //    "/Custom[@Name=\"ArrayList row 1\"]/DataItem[@Name=\"Expires\"]"));

        //public Element statusBox_1 => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "ultraGridChecklist"),
        //    "/Custom[@Name=\"ArrayList row 1\"]/DataItem[@Name=\"Status\"]"));

        //public Element isPresubmissionBox_1 => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "ultraGridChecklist"),
        //    "/Custom[@Name=\"ArrayList row 1\"]/DataItem[@Name=\"Is PreSubmission\"]"));

        //public Element presubmissionStatusBox_1 => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "ultraGridChecklist"),
        //    "/Custom[@Name=\"ArrayList row 1\"]/DataItem[@Name=\"PreSubmission Status\"]"));

        //public Element lastUpdatedByBox_1 => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "ultraGridChecklist"),
        //    "/Custom[@Name=\"ArrayList row 1\"]/DataItem[@Name=\"Last Updated By\"]"));

        //public Element createBox_1 => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "ultraGridChecklist"),
        //    "/Custom[@Name=\"ArrayList row 1\"]/DataItem[@Name=\"Created\"]"));

        //public Element lastUpdatedBox_1 => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "ultraGridChecklist"),
        //    "/Custom[@Name=\"ArrayList row 1\"]/DataItem[@Name=\"Last Updated\"]"));

        //#endregion

        #region Checklist Table Locators
        #region Row 1
        public Element party_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0")
            .Add(Defs.boLocatorName, "BackOffice")
            .Add(Defs.boLocatorName, "Party")));

        public Element type_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0")
            .Add(Defs.boLocatorName, "BackOffice")
            .Add(Defs.boLocatorName, "Type")));

        public Element itemDetail_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0")
            .Add(Defs.boLocatorName, "BackOffice")
            .Add(Defs.boLocatorName, "Item Detail")));

        public Element applicant_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0")
            .Add(Defs.boLocatorName, "BackOffice")
            .Add(Defs.boLocatorName, "Applicant")));

        public Element receivedSatisfied_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0")
            .Add(Defs.boLocatorName, "BackOffice")
            .Add(Defs.boLocatorName, "Received/Satisfied")));

        public Element expires_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0")
            .Add(Defs.boLocatorName, "BackOffice")
            .Add(Defs.boLocatorName, "Expires")));

        public Element status_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0")
            .Add(Defs.boLocatorName, "BackOffice")
            .Add(Defs.boLocatorName, "Status")));

        public Element isPreSubmission_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0")
            .Add(Defs.boLocatorName, "BackOffice")
            .Add(Defs.boLocatorName, "Is PreSubmission")));

        public Element preSubmissionStatus_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0")
            .Add(Defs.boLocatorName, "BackOffice")
            .Add(Defs.boLocatorName, "PreSubmission Status")));

        public Element lastUpdatedBy_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0")
            .Add(Defs.boLocatorName, "BackOffice")
            .Add(Defs.boLocatorName, "Last Updated By")));

        public Element created_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0")
            .Add(Defs.boLocatorName, "BackOffice")
            .Add(Defs.boLocatorName, "Created")));

        public Element lastUpdated_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0")
            .Add(Defs.boLocatorName, "BackOffice")
            .Add(Defs.boLocatorName, "Last Updated")));
        #endregion
        #endregion

    }

    public class ChecklistTabData : PageData
    {
    }
}
