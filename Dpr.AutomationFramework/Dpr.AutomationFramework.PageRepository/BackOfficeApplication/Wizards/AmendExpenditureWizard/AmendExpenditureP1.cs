using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendExpenditureWizard
{
    public class AmendExpenditureP1 : BOWizardBasePage
    {
        public AmendExpenditureP1()
        {
            pageLoadedElement = next;
            correspondingDataClass = new AmendExpenditureP1Data().GetType();
            textName = "Amend Expenditure Page 1";
            windowTitle = "Amend Expenditure";
        }

        public Element editCurrentDependantBreakdown => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "AmendExpenditure_CaptureDetails"),
                "/ComboBox[@AutomationId=\"osEditDependant\"]/RadioButton[@Name=\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "AmendExpenditure_CaptureDetails"),
                "/ComboBox[@AutomationId=\"osEditDependant\"]/RadioButton[@Name=\"No\"]")));

        #region 'Dependants' Section
        public Section dependantsSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "editCurrentDependantBreakdown", Defs.radioButtonYes))));

        public Element numberOfAdultDependants => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uceNoOfAdultDependants")));
        public Element numberOfAChildDependants => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uceNoOfChildDependants")));

        public SectionEnd dependantsSectionEnd => new SectionEnd();
        #endregion

        #region 'Expenditure' Section
        public Element foodAndNonAlcoholicDrinks => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtFoodNonAlcoholicDrinksActual")));

        public Element alcoholicDrinkTabaccoAndNarcotics => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtAlcoholicDrinkTobaccoNarcoticsActual")));

        public Element clothingAndFootwear => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtClothingFootwearActual")));

        public Element housingFuelAndPower => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtHousingFuelPowerActual")));

        public Element householdGoodsAndServices => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtHouseholdGoodsServicesActual")));

        public Element transport => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtTransportActual")));

        public Element health => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtHealthActual")));

        public Element communication => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtCommunicationActual")));

        public Element recreationAndCulture => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtRecreationCultureActual")));

        public Element education => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtEducationActual")));

        public Element restaurantsAndHotels => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtRestaurantsHotelsActual")));

        public Element miscellaneousGoodsAndServices => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtMiscellaneousGoodsServicesActual")));

        public Element otherExpenditureItem => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtOtherExpenditureItemsActual")));

        public Element otherItemsRecorded => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtOtherItemsRecordedActual")));

        public Element committedSavings => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtCommittedSavings")));

        public Element monthlyFood => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtMonthlyFoodExpense")));

        public Element monthlyTravel => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtMonthlyTravelExpense")));

        public Element monthlyUtilityCosts => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtMonthlyUtilityBillsExpense")));

        public Element anyOtherExpenses => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtOtherExpense")));

        public Element houseCosts => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtHouseCosts")));

        public Element total => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtTotal")));
        #endregion

        public Element next => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AmendExpenditureP1Data : PageData
    {
        public string editCurrentDependantBreakdown { get; set; } = Defs.radioButtonYes;

        #region 'Dependants' Data Section
        public string numberOfAdultDependants { get; set; } = "1";
        public string numberOfAChildDependants { get; set; } = "1";
        #endregion

        #region 'Expenditure' Data Section
        public string foodAndNonAlcoholicDrinks { get; set; } = "1";
        public string alcoholicDrinkTabaccoAndNarcotics { get; set; } = "1";
        public string clothingAndFootwear { get; set; } = "1";
        public string housingFuelAndPower { get; set; } = "1";
        public string householdGoodsAndServices { get; set; } = "1";
        public string transport { get; set; } = "1";
        public string health { get; set; } = "1";
        public string communication { get; set; } = "1";
        public string recreationAndCulture { get; set; } = "1";
        public string education { get; set; } = "1";
        public string restaurantsAndHotels { get; set; } = "1";
        public string miscellaneousGoodsAndServices { get; set; } = "1";
        public string otherExpenditureItem { get; set; } = "1";
        public string otherItemsRecorded { get; set; } = "1";
        public string committedSavings { get; set; } = "1";
        public string monthlyFood { get; set; } = "1";
        public string monthlyTravel { get; set; } = "1";
        public string monthlyUtilityCosts { get; set; } = "1";
        public string anyOtherExpenses { get; set; } = "1";
        public string houseCosts { get; set; } = "1";
        #endregion
    }
}
