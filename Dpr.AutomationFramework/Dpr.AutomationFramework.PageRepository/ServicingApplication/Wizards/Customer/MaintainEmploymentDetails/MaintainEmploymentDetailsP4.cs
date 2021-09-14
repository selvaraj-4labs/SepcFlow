using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;


namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.MaintainEmploymentDetails
{
    public class MaintainEmploymentDetailsP4 : AppBasePage
    {
        public MaintainEmploymentDetailsP4()
        {
            pageLoadedElement = businessNameBox;
            correspondingDataClass = new MaintainEmploymentDetailsP4Data().GetType();
            textName = "Maintain Employment Details Page4 ";
        }
        public Element businessNameBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtBusinessName"),
            "/Edit[@AutomationId=\"txtBusinessName_EmbeddableTextBox\"]"));
        public Element natureOfBusinessBox => new Element(FindElement("txtNatureOfBusiness", attributeType: Defs.boLocatorAutomationId));
        public Element positionBox => new Element(FindElement("txtOccupation", attributeType: Defs.boLocatorAutomationId));
        public Element businessEstablishedBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtBusinessEstablished"),
            "/Edit"));
        public Element percentShareholdingBox => new Element(FindElement("txtPercentShareholding", attributeType: Defs.boLocatorAutomationId));
        public Element ownershipYearsBox => new Element(FindElement("txtOwnershipYears", attributeType: Defs.boLocatorAutomationId));
        public Element ownershipMonthsBox => new Element(FindElement("txtOwnershipMonths", attributeType: Defs.boLocatorAutomationId));
        public Element taxOfficeBox => new Element(FindElement("txtTaxOffice", attributeType: Defs.boLocatorAutomationId));
        public Element taxDistrictBox => new Element(FindElement("txtTaxDistrict", attributeType: Defs.boLocatorAutomationId));
        public Element taxRefBox => new Element(FindElement("txtTaxRef", attributeType: Defs.boLocatorAutomationId));
        public Element companyRefNumberBox => new Element(FindElement("txtCompanyRegNumber", attributeType: Defs.boLocatorAutomationId));
        public Element companyTypeBox => new Element(FindElement("txtCompanyType", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("Next", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);
    }

    public class MaintainEmploymentDetailsP4Data : PageData
    {
        public string businessName { get; set; } = "TestBusiness";
        public string natureOfBusiness { get; set; } = "Analysis";
        public string businessNameBox { get; set; } = null;
        public string natureOfBusinessBox { get; set; } = null;
        public string positionBox { get; set; } = null;
        public string businessEstablishedBox { get; set; } = null;
        public string percentShareholdingBox { get; set; } = null;
        public string ownershipYearsBox { get; set; } = null;
        public string ownershipMonthsBox { get; set; } = null;
        public string taxOfficeBox { get; set; } = null;
        public string taxDistrictBox { get; set; } = null;
        public string taxRefBox { get; set; } = null;
        public string companyRefNumberBox { get; set; } = null;
        public string companyTypeBox { get; set; } = null;
    }
}
