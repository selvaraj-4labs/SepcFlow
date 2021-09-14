using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendSecurityWizard
{
    public class AmendSecurityP2 : BOWizardBasePage
    {
        public AmendSecurityP2()
        {
            pageLoadedElement = next;
            correspondingDataClass = new AmendSecurityP2Data().GetType();
            textName = "Amend Security Page 2";
            windowTitle = "Amend Security";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("AmendSecurityP1", "selectTheRequiredAction", "Correct Address"))));
        }

        #region 'Existing Security Address' Section
        public Element existingFlat => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteFlat")));

        public Element existingHouseName => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteHouseName")));

        public Element existingHouseNumber => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteHouseNumber")));

        public Element existingStreet => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteStreet")));

        public Element existingDistrict => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteDistrict")));

        public Element existingCounty => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteCounty")));

        public Element existingPostcode => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "utePostCode")));

        public Element existingCountry => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uceCountry")));
        #endregion

        #region 'Search by Flat/Postcode' Section
        public Element houseFlatNumber => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteFlatSearch")));

        public Element postCode => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "utePostCoseSearch")));

        public Element search => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "btnSearch"))).SetIsButtonFlag(true);
        #endregion

        #region 'Search Address' Popout Window
        public Element okay => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "btnOK"))).SetIsButtonFlag(true);
        #endregion

        #region 'Updated Security Address' Section
        public Element flat => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteFlatUpdated_EmbeddableTextBox")));

        public Element houseName => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteHouseNameUpdated")));

        public Element houseNumber => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteHouseNumberUpdated")));

        public Element street => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteStreetUpdated")));

        public Element district => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteDistrictUpdated")));

        public Element townOrCity => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteTownUpdated")));

        public Element county => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteCountyUpdated")));

        public Element updatedPostcode => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "utePostCodeUpdated")));

        public Element country => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uceCountryUpdated")));
        #endregion

        public Element next => new Element(FindElement(
            "pnlNextButton",
            attributeType: Defs.boLocatorAutomationId))
        .SetIsButtonFlag(true);
    }

    public class AmendSecurityP2Data : PageData
    {
        public string houseFlatNumber { get; set; } = "27";
        public string postCode { get; set; } = "CM16JN";
        public string flat { get; set; } = null;
        public string houseName { get; set; } = null;
        public string houseNumber { get; set; } = null;
        public string street { get; set; } = null;
        public string district { get; set; } = null;
        public string townOrCity { get; set; } = null;
        public string county { get; set; } = null;
        public string updatedPostcode { get; set; } = null;
        public string country { get; set; } = null;
    }
}
