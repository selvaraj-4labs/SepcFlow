using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Roles.AddCeaseRole
{
    public class AddCeaseRoleP2 : AppBasePage
    {
        public AddCeaseRoleP2()
        {
            pageLoadedElement = nameBox;
            correspondingDataClass = new AddNewNoteP2Data().GetType();
            textName = "Add Cease Role Page 1";
        }

        public Element nameBox => new Element(FindElement("txtName", Defs.boLocatorAutomationId));
        public Element primaryAccountHolderChbox => new Element(FindElement("ckIsPrimaryAccountHolder", Defs.boLocatorAutomationId));
        public Element accountSignatoryChbox => new Element(FindElement("ckIsAccountSignatory", Defs.boLocatorAutomationId));
        public Element companyLookup => new Element(FindElement("cboCompany", Defs.boLocatorAutomationId));
        public Element roleLookup => new Element(FindElement("cboRole", Defs.boLocatorAutomationId));
        public Element principalContactChbox => new Element(FindElement("chkPrimary", Defs.boLocatorAutomationId));
        public Element shareholdingBox => new Element(FindElement("txtShareholdingPC", Defs.boLocatorAutomationId));
        public Element companySignatoryChbox => new Element(FindElement("chkSignature", Defs.boLocatorAutomationId));
        public Element addBtn => new Element(FindElement("btnAdd", Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
        public Element remarksBox => new Element(FindElement("txtRemarks", Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AddNewNoteP2Data : PageData
    {
        public string role { get; set; } = "Nominee Director";
        public string principalContact { get; set; } = Defs.checkBoxSelected;
        public string companySignatory { get; set; } = Defs.checkBoxSelected;
        public string remarks { get; set; } = "TestRemarks";
    }
}
