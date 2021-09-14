using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_PropertyDetailsPage : WebBasePage
    {
        public FMA_PropertyDetailsPage()
        {
            pageLoadedElement = propertyInWhichJurisdiction;
            correspondingDataClass = new FMA_PropertyDetailsPageData().GetType();
            textName = "FMA Property Details Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("DIP_ApplicationSummaryPage", "_loanPurpose", "Remortgage"))
                .Add(new Condition("FMA_ProductValidityPage", "amendPropertyDetails", Defs.radioButtonYes)))
                .AddNewConditionList(new ConditionList()
                .Add(new Condition("DIP_ApplicationSummaryPage", "_loanPurpose", "Purchase"))));
        }

        public Element propertyInWhichJurisdiction => new Element(FindElement("ctl01_Jurisdiction"));

        #region 'Property Address Search' Section

        public Element nameOrNumberBox => new Element(FindElement("SearchAddressLine"))
            .SetValidationType(Defs.validationTypeNotRequired);


        public Element postcodeBox => new Element(FindElement("SearchPostCode"))
            .SetValidationType(Defs.validationTypeNotRequired);


        public Element findAddress => new Element(FindElement("SearchButton"))
            .SetIsButtonFlag(true);

        public WaitFor waitForAddressLblOrSelectAddressLookup => new WaitFor(findAddress)
            .AddWaitElement(selectAddressLookup.locator)
            .AddWaitElement(addressLbl.locator);

        public Element selectAddressLookup => new Element(FindElement("SelectAddressDropDown"),
            new ConditionList()
                .Add(new Condition(className, "selectAddress", null, Defs.conditionTypeNotEqual)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(className, "selectAddress", null, Defs.conditionTypeNotEqual)))
            .SetValidationType(Defs.validationTypeNotRequired);

        public Element addressLbl => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "GetFullAddress")))
            .SetCompletePageFlag(false);
        #endregion

        #region 'Property' Section
        public Element propertyType => new Element(FindElement("ctl01_SecurityType"));
        public Element propertySubType => new Element(FindElement("ctl01_PropertyDescription"));
        public Element isPropertyNewBuild => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsNewBuild", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsNewBuild", "rbl_1")));
        public Element yearsOfConstruction => new Element(FindElement("ctl01_YearOfConstruction"));
        /*
        Commented out: 10/06/2020
        public Element convertedInLast10Years => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl01_HasPropertyBeenConverted_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl01_HasPropertyBeenConverted_btn", "rbl_1")));
        
        public Element standardConstruction => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("BuildingOfStandardConstruction_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("BuildingOfStandardConstruction_btn", "rbl_1")));
        
        public Element wallConstructionType => new Element(FindElement("WallType"));
        public Element roofConstructionType => new Element(FindElement("RoofType"));
        */
        public Element numberOfBedrooms => new Element(FindElement("NoOfBedrooms"));
        /*
        public Element numberOfKitchens => new Element(FindElement("NoOfKitchens"));
        public Element numberOfReceptionRooms => new Element(FindElement("NoOfReceptionRooms"));
        public Element numberOfBathrooms => new Element(FindElement("NoOfBathrooms"));
        public Element numberOfGarages => new Element(FindElement("NoOfGarages"));
        */
        public Element typeOfSale => new Element(FindElement("TypeOfSale"));
        public Element tenure => new Element(FindElement("TenureType"));

        /*
        public Element connectedToOrAboveCommercialProperty => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("SituatedAboveCommercialProperty_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("SituatedAboveCommercialProperty_btn", "rbl_1")));
        public Element propertyUsedForCommercialPurposes => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("UsedForBusinessPurposes_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("UsedForBusinessPurposes_btn", "rbl_1")));
        public Element propertyExSocialHousing => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("PreviouslyOwnedByLocalAuthority_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("PreviouslyOwnedByLocalAuthority_btn", "rbl_1")));
        public Element propertySubjectToAgricultralRestrictions => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HasAgriculturalRestrictions_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HasAgriculturalRestrictions_btn", "rbl_1")));
        public Element propertyExceedTheMaximumAcreageGuidelines => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("DoesThePropertyIncludeMoreThanThreeAcresOfLand_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("DoesThePropertyIncludeMoreThanThreeAcresOfLand_btn", "rbl_1")));
        public Element propertAgeRestricted => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HasOccupantAgeRestrictions_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HasOccupantAgeRestrictions_btn", "rbl_1")));
        public Element listedProperty => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ListedPropertyQuestion_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ListedPropertyQuestion_btn", "rbl_1")));
        public Element anyElementOfFlyingFreehold => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsFlyFreehold_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsFlyFreehold_btn", "rbl_1")));
        public Element anyFlatRoof => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoRoofFlat", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoRoofFlat", "_1")));
        */
        #endregion

        #region 'Incentives' Section
        public Element areThereAnyIncentives => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IncentiveScheme_btn", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IncentiveScheme_btn", "_rbl_1"))/*,
            new ConditionList()
            .Add(new Condition("DIP_ApplicationSummaryPage", "_loanType", "Residential"))*/);

        public Section areThereAnyIncentivesSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "areThereAnyIncentives", Defs.radioButtonNo))));

        // Incentives - Row 1
        public Element typeOfIncentive_1 => new Element(FindElement("item0", "IncentiveTypeDropDownList"));
        public Element incentiveValue_1 => new Element(FindElement("item0", "Value"));

        // Incentives - Row 2
        public Element typeOfIncentive_2 => new Element(FindElement("item1", "IncentiveTypeDropDownList"),
            new ConditionList()
            .Add(new Condition(className, "incentives_2", null, Defs.conditionTypeNotEqual)),
            incentivesAdd);
        public Element incentiveValue_2 => new Element(FindElement("item1", "Value"),     
            new ConditionList()
            .Add(new Condition(className, "incentives_2", null, Defs.conditionTypeNotEqual)),
            incentivesAdd);

        // Incentives - Row 3
        public Element typeOfIncentive_3 => new Element(FindElement("item2", "IncentiveTypeDropDownList"),
            new ConditionList()
            .Add(new Condition(className, "incentives_3", null, Defs.conditionTypeNotEqual)),
            incentivesAdd);
        public Element incentiveValue_3 => new Element(FindElement("item2", "Value"),
            new ConditionList()
            .Add(new Condition(className, "incentives_3", null, Defs.conditionTypeNotEqual)),
            incentivesAdd);

        // Incentives - Row 4
        public Element typeOfIncentive_4 => new Element(FindElement("item3", "IncentiveTypeDropDownList"),
            new ConditionList()
            .Add(new Condition(className, "incentives_4", null, Defs.conditionTypeNotEqual)),
            incentivesAdd);
        public Element incentiveValue_4 => new Element(FindElement("item3", "Value"),
            new ConditionList()
            .Add(new Condition(className, "incentives_4", null, Defs.conditionTypeNotEqual)),
            incentivesAdd);

        public Element incentivesAdd => new Element(FindElement("rptDiscountRelation", "ctl01_btnAdd")).SetCompletePageFlag(false);
        
        public SectionEnd areThereAnyIncentivesSectionEnd => new SectionEnd();
        #endregion

        #region Tenancy Section

        public Section tenancySection => new Section(new Element(new ConditionList()
            .Add(new Condition("DIP_ApplicationSummaryPage", "_loanType", "BTL"))));

        public Element typeOfTenancy => new Element(FindElement("ddlTypeOfTenancy"));
        public Element rentalOccupancyType => new Element(FindElement("ddlRentalOccupancyType"));
        public Element totalNumberOfHouseholds => new Element(FindElement("txtNumberofHouseholds"),
            new ConditionList()
            .Add(new Condition(className, "rentalOccupancyType", "!null")));

        public SectionEnd tenancySectionEnd => new SectionEnd();
        #endregion

        public Element next => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class FMA_PropertyDetailsPageData : PageData
    {
        public string propertyInWhichJurisdiction { get; set; } = "England and Wales";

        #region 'Property Address Search' Section
        public string nameOrNumber { get; set; } = "4";
        public string postcode { get; set; } = "cm1 4uw";
        public string selectAddress { get; set; } = null;
        #endregion

        #region 'Property' Section
        public string propertyType { get; set; } = "House";
        public string propertySubType { get; set; } = "Detached";
        public string isPropertyNewBuild { get; set; } = Defs.radioButtonNo;
        public string yearsOfConstruction { get; set; } = "1980";
        public string convertedInLast10Years { get; set; } = Defs.radioButtonNo;
        public string standardConstruction { get; set; } = Defs.radioButtonYes;
        public string wallConstructionType { get; set; } = "Brick";
        public string roofConstructionType { get; set; } = "Tile";
        public string numberOfBedrooms { get; set; } = "4";
        public string numberOfKitchens { get; set; } = "1";
        public string numberOfReceptionRooms { get; set; } = "1";
        public string numberOfBathrooms { get; set; } = "1";
        public string numberOfGarages { get; set; } = "1";
        public string typeOfSale { get; set; } = "Private Sale";
        public string tenure { get; set; } = "Freehold";
        public string connectedToOrAboveCommercialProperty { get; set; } = Defs.radioButtonNo;
        public string propertyUsedForCommercialPurposes { get; set; } = Defs.radioButtonNo;
        public string propertyExSocialHousing { get; set; } = Defs.radioButtonNo;
        public string propertySubjectToAgricultralRestrictions { get; set; } = Defs.radioButtonNo;
        public string propertyExceedTheMaximumAcreageGuidelines { get; set; } = Defs.radioButtonNo;
        public string propertAgeRestricted { get; set; } = Defs.radioButtonNo;
        public string listedProperty { get; set; } = Defs.radioButtonNo;
        public string anyElementOfFlyingFreehold { get; set; } = Defs.radioButtonNo;
        public string anyFlatRoof { get; set; } = Defs.radioButtonNo;
        #endregion

        #region 'Incentives' Section
        public string areThereAnyIncentives { get; set; } = Defs.radioButtonNo;
        
        public string typeOfIncentive_1 { get; set; } = null;
        public string incentiveValue_1 { get; set; } = null;

        public string incentives_2 { get; set; } = null;
        public string typeOfIncentive_2 { get; set; } = null;
        public string incentiveValue_2 { get; set; } = null;

        public string incentives_3 { get; set; } = null;
        public string typeOfIncentive_3 { get; set; } = null;
        public string incentiveValue_3 { get; set; } = null;

        public string incentives_4 { get; set; } = null;
        public string typeOfIncentive_4 { get; set; } = null;
        public string incentiveValue_4 { get; set; } = null;
        #endregion

        #region Tenancy Section
        public string typeOfTenancy { get; set; } = "Standard AST";
        public string rentalOccupancyType { get; set; } = "Standard";
        public string totalNumberOfHouseholds { get; set; } = "2";
        #endregion
    }
}
