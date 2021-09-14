using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendExpenditureWizard
{
    public class AmendExpenditureP2 :BOWizardBasePage
    {
        public AmendExpenditureP2()
        {
            pageLoadedElement = next;
            correspondingDataClass = new AmendExpenditureP2Data().GetType();
            textName = "Amend Expenditure Page 2";
            windowTitle = "Amend Expenditure";
        }

        public Element foodAndNonAlcoholicDrinksVerified => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtFoodNonAlcoholicDrinksVerified")));

        public Element alcoholicDrinkTobaccoAndNarcotics => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtAlcoholicDrinkTobaccoNarcoticsVerified")));

        public Element clothingAndFootwear => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtClothingFootwearVerified")));

        public Element housingFuelAndPower => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtHousingFuelPowerVerified")));

        public Element householdGoodsAndServices => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtHouseholdGoodsServicesVerified")));

        public Element health => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtHealthVerified")));

        public Element transport => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtTransportVerified")));

        public Element communication => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtCommunicationVerified")));

        public Element recreationAndCulture => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtRecreationCultureVerified")));

        public Element education => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtEducationVerified")));

        public Element resturantsAndHotels => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtRestaurantsHotelsVerified")));

        public Element miscellaneousGoodsAndServices => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtMiscellaneousGoodsServicesVerified")));

        public Element otherExpenditureItem => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtOtherExpenditureItemsVerified")));

        public Element otherItemsRecorded => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtOtherItemsRecordedVerified")));

        public Element next => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AmendExpenditureP2Data : PageData
    {
        public string foodAndNonAlcoholicDrinksVerified { get; set; } = "1";
        public string alcoholicDrinkTobaccoAndNarcotics { get; set; } = "1";
        public string clothingAndFootwear { get; set; } = "1";
        public string housingFuelAndPower { get; set; } = "1";
        public string householdGoodsAndServices { get; set; } = "1";
        public string health { get; set; } = "1";
        public string transport { get; set; } = "1";
        public string communication { get; set; } = "1";
        public string recreationAndCulture { get; set; } = "1";
        public string education { get; set; } = "1";
        public string resturantsAndHotels { get; set; } = "1";
        public string miscellaneousGoodsAndServices { get; set; } = "1";
        public string otherExpenditureItem { get; set; } = "1";
        public string otherItemsRecorded { get; set; } = "1";
    }
}
