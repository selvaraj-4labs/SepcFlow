using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP14 : CBS_DIP14
    {
        public CBS_ADV_DIP14()
        {
            pageLoadedElement = propertyInWhichJurisdiction;
            correspondingDataClass = new CBS_ADV_DIP14Data().GetType();
            textName = "CBS Advised Property Details Page";
        }
        public new Element applicantFoundProperty => new Element(
            new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("FoundProperty", "rbl_0"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("FoundProperty", "rbl_1")),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase")));

        public new Element currentAddressSameAsRemortgageProperty => new Element(
            new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("MortgagedPropertyAtCurrentAddress_btn_", "rbl_0"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("MortgagedPropertyAtCurrentAddress_btn_", "rbl_1")),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element propertyInWhichJurisdiction => new Element(FindElement("ctl01_Jurisdiction"));

        public new Section propertyKnownSection => new Section(new Element(
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))));

        public new Element applicantOneAddressSameAsRemoProperty => new Element(
            new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("PropertyAtCurrentAddress", "rbl_0"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("PropertyAtCurrentAddress", "rbl_1")),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        #region 'Property Address Search' Section
        public new Section propertyAddressSearch => new Section(
             new Element(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo))));

        public new Element selectAddressLookup => new Element(FindElement("SelectAddressDropDown"),
            new ConditionList()
                .Add(new Condition(className, "selectAddress", null, Defs.conditionTypeNotEqual))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo))
                .Add(new Condition(className, "selectAddress", null, Defs.conditionTypeNotEqual)))
            .SetValidationType(Defs.validationTypeNotRequired);
        #endregion

        #region 'Property Address Details' Section
        public new Element manualAddressDiv => new Element(FindElement("AddressPickerDataEntryFieldPanel"))
            .SetCompletePageFlag(false);

        public new Element flatBox => new Element(FindElement("FlatNumber"),
            new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);

        public new Element numberBox => new Element(FindElement("BuildingNumber"),
            new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);

        public new Element nameBox => new Element(FindElement("BuildingName"),
            new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);

        public new Element streetBox => new Element(FindElement("Street"),
            new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);

        public new Element districtBox => new Element(FindElement("District"),
            new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);

        public new Element townOrCityBox => new Element(FindElement("TownOrCity"),
            new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);

        public new Element countyBox => new Element(FindElement("County"),
            new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);

        public new Element manualPostcodeBox => new Element(FindElement("Postcode"),
            new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);
        #endregion

        #region Property section details
        public new Element propertyType => new Element(FindElement("SecurityType"),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element propertyDescriptionLookup => new Element(FindElement("PropertyDescription"),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element originalPurchasePrice => new Element(FindElement("txtOriginalPurchasePrice"),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element originalPurchaseDate => new Element(FindElement("ctl00_ctl00_Date"),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element propertySubType => new Element(FindElement("ctl01_PropertyDescription"),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Purpose Built Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Purpose Built Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Converted Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Converted Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Studio Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Studio Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Maisonette")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Maisonette")));

        public new Element numOfStoreysInBuildingLookup => new Element(FindElement("NumberOfStoreys"),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Purpose Built Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Purpose Built Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Converted Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Converted Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Studio Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Studio Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Maisonette")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Maisonette")));

        public new Element floorFlatSituatedLookup => new Element(FindElement("StoreyOfFlat"),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Purpose Built Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Purpose Built Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Converted Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Converted Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Studio Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Studio Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Maisonette")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Maisonette")));

        public new Element isPropertyNewBuild => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsNewBuild", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsNewBuild", "rbl_1")),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element yearOfConstructionBox => new Element(FindElement("YearOfConstruction"),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element certificateTypeLookup => new Element(FindElement("CertificateType", "!Amal", "!Should"),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
            .Add(new Condition(className, "isPropertyNewBuild", Defs.radioButtonYes)));

        public new Element isPropertyOfStandardConstruction => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("BuildingOfStandardConstruction", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("BuildingOfStandardConstruction", "rbl_1")),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element wallConstructionTypeLookup => new Element(FindElement("ctl01_WallType"),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element roofConstructionTypeLookup => new Element(FindElement("ctl01_RoofType"),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element numOfBedroomsBox => new Element(FindElement("Bedrooms"),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element numOfKitchens => new Element(FindElement("Kitchens"),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element numOfReceptionRoomsBox => new Element(FindElement("Reception"),
           new ConditionList()
           .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
           .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
           .AddNewConditionList(new ConditionList()
           .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element numOfBathroomsBox => new Element(FindElement("Bathrooms"),
           new ConditionList()
           .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
           .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
           .AddNewConditionList(new ConditionList()
           .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element numOfGaragesBox => new Element(FindElement("Garages"),
           new ConditionList()
           .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
           .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
           .AddNewConditionList(new ConditionList()
           .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element tenureLookup => new Element(FindElement("TenureType"),
           new ConditionList()
           .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
           .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
           .AddNewConditionList(new ConditionList()
           .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element isPropertyconnectedOrAboveCommercial => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("SituatedAboveCommercialProperty_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("SituatedAboveCommercialProperty_btn", "rbl_1")),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element anyOfPropertyUsedForBusinessPurpose => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("UsedForBusiness", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("UsedForBusiness", "rbl_1")),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element didApplicantPurchaseFromLocalAuthority => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("PropertyPurchasedFromLocalAuthority_btn_", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("PropertyPurchasedFromLocalAuthority_btn_", "rbl_1")),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element purchasePartOfSocialHousingScheme => new Element(new RadioButton()
           .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsShelteredHousing", "rbl_0"))
           .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsShelteredHousing", "rbl_1")),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element propertyExSocialHousing => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("PreviouslyOwnedByLocalAuthority_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("PreviouslyOwnedByLocalAuthority_btn", "rbl_1")),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element propertySubjectToAgriculturalRestrictions => new Element(new RadioButton()
           .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AgriculturalRestrictions", "rbl_0"))
           .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AgriculturalRestrictions", "rbl_1")),
           new ConditionList()
           .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
           .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
           .AddNewConditionList(new ConditionList()
           .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element propertyExceedAcreage => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("PropertyIncludeMoreThanThreeAcresOfLand", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("PropertyIncludeMoreThanThreeAcresOfLand", "rbl_1")),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element propertyAgeRestricted => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HasOccupantAgeRestrictions_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HasOccupantAgeRestrictions_btn", "rbl_1")),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element isPropertyListed => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ListedPropertyQuestion_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ListedPropertyQuestion_btn", "rbl_1")),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element anyElementOfFlyingFreehold => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsFlyFreehold_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsFlyFreehold_btn", "rbl_1")),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element isThereAnyFlatRoof => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoRoofFlat", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoRoofFlat", "_1")),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Remortgage")));

        public new Element areThereAnyIncentives => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IncentiveScheme_btn", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IncentiveScheme_btn", "_rbl_1")),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "Residential"))
                .Add(new Condition("CBS_ADV_DIP04", "loanPurpose", "Purchase")));

        public new Element EPCRating => new Element(FindElement("ddlEPCRating"),
             new ConditionList()
                 .Add(new Condition("CBS_ADV_DIP02", "loanType", "BTL")));

        public new Element typeOfTenancy => new Element(FindElement("ddlTypeOfTenancy"),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "BTL")));

        public new Element rentalOccupancyType => new Element(FindElement("ddlRentalOccupancyType"),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "BTL")));

        public new Element totalNumberOfHouseholds => new Element(FindElement("txtNumberofHouseholds", tag: "input"),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "BTL"))
                .Add(new Condition(className, "rentalOccupancyType", "Standard")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "BTL"))
                .Add(new Condition(className, "rentalOccupancyType", "House of Multiple Occupation (HMO)")));

        public new Element totalRentalOccupants => new Element(FindElement("txtTotalRentalOccupants", tag: "input"),
            /*new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "BTL"))
                .Add(new Condition(className, "rentalOccupancyType", "Standard")))
            .AddNewConditionList(*/
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "BTL"))
                .Add(new Condition(className, "rentalOccupancyType", "Multi Unit")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "BTL"))
                .Add(new Condition(className, "rentalOccupancyType", "House of Multiple Occupation (HMO)")));

        public new Element totalUnitRentalOccupants => new Element(FindElement("txtTotalUnitNumber", tag: "input"),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "BTL"))
                .Add(new Condition(className, "rentalOccupancyType", "Multi Unit")));
        #endregion
    }

    public class CBS_ADV_DIP14Data : CBS_DIP14Data 
    {
    }
}
