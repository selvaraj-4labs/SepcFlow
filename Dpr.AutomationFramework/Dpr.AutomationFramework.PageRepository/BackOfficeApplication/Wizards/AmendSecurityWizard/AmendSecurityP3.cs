using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendSecurityWizard
{
    public class AmendSecurityP3 : BOWizardBasePage
    {
        public AmendSecurityP3()
        {
            pageLoadedElement = next;
            correspondingDataClass = new AmendSecurityP2Data().GetType();
            textName = "Amend Security Page 2";
            windowTitle = "Amend Security";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("AmendSecurityP1", "selectTheRequiredAction", "Correct the Property Data"))));
        }

        #region 'Existing Security Details' Section
        public Element existingSecurityType => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uceSecurityType")));

        public Element existingSecuritySubType => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uceSecuritySubType")));

        public Element existingNoOfStoreysInBuilding => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteNoOfStories")));

        public Element existingStoreyOfFlat => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteStoryOfFlat")));

        public Element existingIsStandardConstruction => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "uoIsStandardConstruction"),
                "/RadioButton[@Name=\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "uoIsStandardConstruction"),
                "/RadioButton[@Name=\"No\"]")));

        public Element existingBuildYear => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteBuildYear")));

        public Element existingTenure => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uceTenure")));

        public Element existingUnexpiredTermOfLease => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteTermOfLease")));

        public Element existingEPCRating => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteTermOfLease")));

        #region 'Room Details' Subsection
        public Element existingNoOfBedrooms => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteBedrooms")));

        public Element existingNoOfBathrooms => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteBathrooms")));

        public Element existingNoofKitchens => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteKitchens")));

        public Element existingNoOfReceptions => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteReceptions")));

        public Element existingNoOfGarages => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteGarages")));
        #endregion
        #endregion

        #region 'Updated Security Details' Section
        public Element securityType => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uceSecurityTypeUpdated")));

        public Element securitySubType => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uceSecuritySubTypeUpdated")));

        public Element noOfStoreysInBuilding => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "neNoOfStoriesUpdated")));

        public Element storeyOfFlat => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "neStoryOfFlatUpdated")));

        public Element isStandardConstruction => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uoIsStandardConstructionUpdated"),
                "/RadioButton[@Name=\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "uoIsStandardConstructionUpdated"),
                "/RadioButton[@Name=\"No\"]")));

        public Element buildYear => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uteBuildYearUpdated")));

        public Element tenure => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uceTenureUpdated")));

        public Element unexpiredTermOfLease => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "neTermOfLeaseUpdated")));

        public Element epcRating => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uceEPCRatingUpdated")));

        #region 'Room Details' Subsection
        public Element noOfBedrooms => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "neBedRoomsUpdated")));

        public Element noOfBathrooms => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "neBathRoomsUpdated")));

        public Element noOfKitchens => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "neKitchensUpdated")));

        public Element noOfReceptions => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "neReceptionsUpdated")));

        public Element noOfGarages => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "neGaragesUpdated")));
        #endregion
        #endregion

        public Element next => new Element(FindElement(
            "pnlNextButton",
            attributeType: Defs.boLocatorAutomationId))
        .SetIsButtonFlag(true);
    }

    public class AmendSecurityP3Data : PageData
    {
        public string securityType { get; set; } = "House";
        //TODO: When this is fixed, give it a default data value.
        public string securitySubType { get; set; } = null;
        public string noOfStoreysInBuilding { get; set; } = null;
        public string isStandardConstruction { get; set; } = Defs.radioButtonYes;
        public string buildYear { get; set; } = "1981";
        public string tenure { get; set; } = "Freehold";
        public string unexpiredTermOfLease { get; set; } = null;
        public string epcRating { get; set; } = "A";
        public string noOfBedrooms { get; set; } = "6";
        public string noOfBathrooms { get; set; } = "2";
        public string noOfKitchens { get; set; } = "1";
        public string noOfReceptions { get; set; } = "2";
        public string noOfGarages { get; set; } = "1";

    }
}
