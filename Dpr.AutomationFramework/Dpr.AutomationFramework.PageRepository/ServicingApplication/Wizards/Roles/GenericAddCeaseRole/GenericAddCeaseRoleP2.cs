using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Roles.GenericAddCeaseRole
{
    public class GenericAddCeaseRoleP2 : AppBasePage
    {
        public GenericAddCeaseRoleP2()
        {
            pageLoadedElement = companyLookup;
            correspondingDataClass = new GenericAddCeaseRoleP2Data().GetType();
            textName = "Generic Add Cease Role Page 2";
        }
        #region 'Customer Details' Section
        public Element nameBox => new Element(FindElement("txtName", Defs.boLocatorAutomationId));
        #endregion

        #region 'Account Role' Section
        public Element primaryAccountHolderChbox => new Element(FindElement("ckIsPrimaryAccountHolder", Defs.boLocatorAutomationId));
        public Element accountSignatoryChbox => new Element(FindElement("ckIsAccountSignatory", Defs.boLocatorAutomationId));
        #endregion

        #region 'Add Business Role' Section
        public Element companyLookup => new Element(FindElement("cboCompany", Defs.boLocatorAutomationId));
        public Element roleLookup => new Element(FindElement("cboRole", Defs.boLocatorAutomationId));
        public Element principalContactChbox => new Element(FindElement("chkPrimary", Defs.boLocatorAutomationId));
        public Element shareholdingBox => new Element(FindElement("txtShareholdingPC", Defs.boLocatorAutomationId));
        public Element companySignatoryChbox => new Element(FindElement("chkSignature", Defs.boLocatorAutomationId));
        public Element addBtn => new Element(FindElement("btnAdd", Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
        #endregion

        #region 'Business Roles' Section
        public Element firstRowCeaseChbox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ultraGrid")
            .Add(Defs.boLocatorName, "List`1 row 1")
            .Add(Defs.boLocatorName, "Cease")
            ));
        #endregion

        public Element remarksBox => new Element(FindElement("txtRemarks", Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class GenericAddCeaseRoleP2Data : PageData
    {

    }
}
