using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class PropertyDetailsPage : WebBasePage
    {
        public PropertyDetailsPage()
        {
            pageLoadedElement = propertyInWhichJurisdiction;
            correspondingDataClass = new PropertyDetailsPageData().GetType();
            textName = "Property Details Page";
        }

        public Element applicantFoundProperty => new Element(
            new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("FoundProperty", "rbl_0"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("FoundProperty", "rbl_1")),
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase")));

        public Element currentAddressSameAsRemortgageProperty => new Element(
            new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("MortgagedPropertyAtCurrentAddress_btn_", "rbl_0"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("MortgagedPropertyAtCurrentAddress_btn_", "rbl_1")),
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        public Element propertyInWhichJurisdiction => new Element(FindElement("ctl01_Jurisdiction"));

        public Section propertyKnownSection => new Section(new Element(
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))));

        public Element applicantOneAddressSameAsRemoProperty => new Element(
            new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("PropertyAtCurrentAddress", "rbl_0"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("PropertyAtCurrentAddress", "rbl_1")),
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        #region 'Property Address Search' Section
        public Section propertyAddressSearch => new Section(
             new Element(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo))));

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
                .Add(new Condition(className, "selectAddress", null, Defs.conditionTypeNotEqual))
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo))
                .Add(new Condition(className, "selectAddress", null, Defs.conditionTypeNotEqual)))
            .SetValidationType(Defs.validationTypeNotRequired);

        public Element addressLbl => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "GetFullAddress")))
            .SetCompletePageFlag(false);

        public SectionEnd propertyAddressSearchEnd => new SectionEnd();
        #endregion

        #region 'Property Address Details' Section
        public Element manualAddressDiv => new Element(FindElement("AddressPickerDataEntryFieldPanel"))
            .SetCompletePageFlag(false);

        public Element flatBox => new Element(FindElement("FlatNumber"),
            new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);

        public Element numberBox => new Element(FindElement("BuildingNumber"),
            new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);

        public Element nameBox => new Element(FindElement("BuildingName"),
            new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);

        public Element streetBox => new Element(FindElement("Street"),
            new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);

        public Element districtBox => new Element(FindElement("District"),
            new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);

        public Element townOrCityBox => new Element(FindElement("TownOrCity"),
            new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);

        public Element countyBox => new Element(FindElement("County"),
            new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);

        public Element manualPostcodeBox => new Element(FindElement("Postcode"),
            new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(manualAddressDiv, Defs.elementDisplayed))
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "applicantOneAddressSameAsRemoProperty", Defs.radioButtonNo)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);
        #endregion

        #region Property section details

        public Element propertyType => new Element(FindElement("SecurityType"),
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        public Element propertyDescriptionLookup => new Element(FindElement("PropertyDescription"),
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        public Element originalPurchasePrice => new Element(FindElement("txtOriginalPurchasePrice"),
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        public Element originalPurchaseDate => new Element(FindElement("ctl00_ctl00_Date"),
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        public Element propertySubType => new Element(FindElement("ctl01_PropertyDescription"),
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Purpose Built Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Purpose Built Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Converted Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Converted Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Studio Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Studio Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Maisonette")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Maisonette")));

        public Element numOfStoreysInBuildingLookup => new Element(FindElement("NumberOfStoreys"),
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Purpose Built Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Purpose Built Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Converted Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Converted Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Studio Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Studio Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Maisonette")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Maisonette")));

        public Element floorFlatSituatedLookup => new Element(FindElement("StoreyOfFlat"),
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Purpose Built Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Purpose Built Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Converted Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Converted Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Studio Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Studio Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Maisonette")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Maisonette")));

        /*
         * Commented out: 11/06/2020    
        public Element buildingHaveLift => new Element(
            new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HaveLift", "rbl_0"))
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HaveLift", "rbl_1")),
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Purpose Built Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Purpose Built Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Converted Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Converted Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Studio Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Studio Flat")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "propertyType", "Maisonette")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "propertyType", "Maisonette")));
        */

        public Element isPropertyNewBuild => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsNewBuild", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsNewBuild", "rbl_1")),
            new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));


        public Element yearOfConstructionBox => new Element(FindElement("YearOfConstruction"),
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));
        /*
         * Commented out: 11/06/2020
        public Element convertedInLastTenYears => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HasPropertyBeenConverted_btn", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HasPropertyBeenConverted_btn", "_rbl_1")));

        public Element certificateTypeLookup => new Element(FindElement("CertificateType", "!Amal", "!Should"),
            new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
            .Add(new Condition(className, "isPropertyNewBuild", Defs.radioButtonYes)));

        public Element isPropertyOfStandardConstruction => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("BuildingOfStandardConstruction", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("BuildingOfStandardConstruction", "rbl_1")),
            new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        public Element wallConstructionTypeLookup => new Element(FindElement("ctl01_WallType"),
            new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        public Element roofConstructionTypeLookup => new Element(FindElement("ctl01_RoofType"),
            new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));
        */
        public Element numOfBedroomsBox => new Element(FindElement("Bedrooms"),
            new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        /*
         * Commented out: 11/06/2020
        public Element numOfKitchens => new Element(FindElement("Kitchens"),
            new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        public Element numOfReceptionRoomsBox => new Element(FindElement("Reception"),
           new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
           .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
           .AddNewConditionList(new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        public Element numOfBathroomsBox => new Element(FindElement("Bathrooms"),
           new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
           .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
           .AddNewConditionList(new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        public Element numOfGaragesBox => new Element(FindElement("Garages"),
           new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
           .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
           .AddNewConditionList(new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        public Element typeOfSaleLookup => new Element(FindElement("TypeOfSale", "!Field"),
           new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
           .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)));
        */

        public Element tenureLookup => new Element(FindElement("TenureType"),
           new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
           .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
           .AddNewConditionList(new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        /*
         * Commented out: 11/06/2020
        public Element yearsRemainingOnLease => new Element(FindElement("YearsRemainingOnLease"),
           new ConditionList()
               .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
               .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
               .Add(new Condition(className, "tenure", "Leasehold")))
           .AddNewConditionList(new ConditionList()
               .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
               .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
               .Add(new Condition(className, "tenure", "Commonhold")))
           .AddNewConditionList(new ConditionList()
               .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
               .Add(new Condition(className, "tenure", "Leasehold")))
           .AddNewConditionList(new ConditionList()
               .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
               .Add(new Condition(className, "tenure", "Commonhold")))
           .SetValidationType(Defs.validationTypeNumberOfYears);

        public Element groundRentPerAnnum => new Element(FindElement("ctl01_GroundRent"),
           new ConditionList()
               .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
               .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
               .Add(new Condition(className, "tenure", "Leasehold")))
           .AddNewConditionList(new ConditionList()
               .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
               .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
               .Add(new Condition(className, "tenure", "Commonhold")))
           .AddNewConditionList(new ConditionList()
               .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
               .Add(new Condition(className, "tenure", "Leasehold")))
           .AddNewConditionList(new ConditionList()
               .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
               .Add(new Condition(className, "tenure", "Commonhold")));

        public Element serviceChargePerAnnum => new Element(FindElement("ctl01_ServiceCharge"),
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "tenure", "Leasehold")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
                .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
                .Add(new Condition(className, "tenure", "Commonhold")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "tenure", "Leasehold")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
                .Add(new Condition(className, "tenure", "Commonhold")));
         */

        public Element EPCRating => new Element(FindElement("ddlEPCRating"),
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "BTL")));

        public Element typeOfTenancy => new Element(FindElement("ddlTypeOfTenancy"), 
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "BTL")));

        public Element rentalOccupancyType => new Element(FindElement("ddlRentalOccupancyType"),
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "loanPurpose", "BTL")));


        /*
         * Commented out: 11/06/2020
        public Element isPropertyconnectedOrAboveCommercial => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AboveCommercial", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AboveCommercial", "rbl_1")),
            new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        public Element ifYesProvideDetailsBox => new Element(FindElement("AboveCommercial", "Details"),
           new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
           .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
           .Add(new Condition(className, "isPropertyconnectedOrAboveCommercial", Defs.radioButtonYes)))
           .AddNewConditionList(new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
           .Add(new Condition(className, "isPropertyconnectedOrAboveCommercial", Defs.radioButtonYes)));

        public Element applicantPurchasePropertyFromLocalAuthority => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("PropertyPurchasedFromLocalAuthority_btn_", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("PropertyPurchasedFromLocalAuthority_btn_", "rbl_1")),
            new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        public Element dateApplicantPurchasePropertyFromLocalAuthority => new Element(FindElement("ctl01_DatePurchased"),
        new ConditionList()
            .Add(new Condition(className, "applicantPurchasePropertyFromLocalAuthority", Defs.radioButtonYes)));


        public Element anyOfPropertyUsedForBusinessPurpose => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("UsedForBusiness", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("UsedForBusiness", "rbl_1")),
            new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        public Element percentageUsedForBusinessBox => new Element(FindElement("BusinessUsePercentage", "Details"),
           new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
           .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
           .Add(new Condition(className, "anyOfPropertyUsedForBusinessPurpose", Defs.radioButtonYes)))
           .AddNewConditionList(new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
           .Add(new Condition(className, "anyOfPropertyUsedForBusinessPurpose", Defs.radioButtonYes)));

        public Element typeOfBusinessBox => new Element(FindElement("BusinessPurpose", "Details"),
           new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
           .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
           .Add(new Condition(className, "anyOfPropertyUsedForBusinessPurpose", Defs.radioButtonYes)))
           .AddNewConditionList(new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
           .Add(new Condition(className, "anyOfPropertyUsedForBusinessPurpose", Defs.radioButtonYes)));

        public Element propertyExSocialHousing => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("PreviouslyOwnedByLocalAuthority_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("PreviouslyOwnedByLocalAuthority_btn", "rbl_1")),
            new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));
        */

        //public Element localAuthorityPurchaseDateBox => new Element(FindElement("_DatePurchased", "!Ques"),
        //   new ConditionList()
        //   .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
        //   .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
        //   .Add(new Condition(className, "applicantPurchasePropertyFromLocalAuthoritLast5Years", Defs.radioButtonYes)))
        //   .AddNewConditionList(new ConditionList()
        //   .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
        //   .Add(new Condition(className, "applicantPurchasePropertyFromLocalAuthoritLast5Years", Defs.radioButtonYes)))
        //    .SetValidationType(Defs.validationTypeMmYyyy);

        //public Element propertyOwnedByLocalAuthority => new Element(new RadioButton()
        //   .AddRadioButtonElement(Defs.radioButtonYes, FindElement("PreviouslyOwnedByLocalAuthority_btn", "rbl_0"))
        //   .AddRadioButtonElement(Defs.radioButtonNo, FindElement("PreviouslyOwnedByLocalAuthority_btn", "rbl_1")),
        //   new ConditionList()
        //   .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
        //   .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)));

        /*
         * Commented out: 11/06/2020
        public Element purchasePartOfSocialHousingScheme => new Element(new RadioButton()
           .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsShelteredHousing", "rbl_0"))
           .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsShelteredHousing", "rbl_1")),
           new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));
        */

        //public Element socialHousingPurchaseDateBox => new Element(FindElement("DateofPurchase"),
        //   new ConditionList()
        //   .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
        //   .Add(new Condition(className, "purchasePartOfSocialHousingScheme", Defs.radioButtonYes)))
        //    .SetValidationType(Defs.validationTypeMmYyyy);

        //public Element isPropertyHmo => new Element(new RadioButton()
        //   .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsPropertyAHmo", "rbl_0"))
        //   .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsPropertyAHmo", "rbl_1")),
        //   new ConditionList()
        //   .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
        //   .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
        //   .AddNewConditionList(new ConditionList()
        //   .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        /*
         * Commented out: 11/06/2020
        public Element propertySubjectToAgriculturalRestrictions => new Element(new RadioButton()
           .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AgriculturalRestrictions", "rbl_0"))
           .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AgriculturalRestrictions", "rbl_1")),
           new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
           .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
           .AddNewConditionList(new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));


        public Element letUnderAssuredShortholdTenancy => new Element(new RadioButton()
           .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoQuestion", "rbl_0", "104"))
           .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoQuestion", "rbl_1", "104")),
           new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
           .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
           .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "BTL")))
           .AddNewConditionList(new ConditionList()
           .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
           .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "BTL")));


        public Element propertyExceedAcreage => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("PropertyIncludeMoreThanThreeAcresOfLand", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("PropertyIncludeMoreThanThreeAcresOfLand", "rbl_1")),
            new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));
        */

        //public Element numOfAcresBox => new Element(FindElement("txtFurtherDetails"),
        //   new ConditionList()
        //   .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
        //   .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
        //   .Add(new Condition(className, "propertyIncludeMoreThan6Acres", Defs.radioButtonYes)))
        //   .AddNewConditionList(new ConditionList()
        //   .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
        //   .Add(new Condition(className, "propertyIncludeMoreThan6Acres", Defs.radioButtonYes)));

        //public Element epcRatingLookup => new Element(FindElement("EPCRating")
        /*,
       new ConditionList()
       .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
       .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes))
       .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "BTL")))
       .AddNewConditionList(new ConditionList()
       .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage"))
       .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "BTL")));*/

        /*
         * Commented out: 11/06/2020
        public Element propertyAgeRestricted => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HasOccupantAgeRestrictions_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HasOccupantAgeRestrictions_btn", "rbl_1")),
            new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        public Element isPropertyListed => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ListedPropertyQuestion_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ListedPropertyQuestion_btn", "rbl_1")),
            new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        public Element anyElementOfFlyingFreehold => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsFlyFreehold_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsFlyFreehold_btn", "rbl_1")),
            new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));

        public Element isThereAnyFlatRoof => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoRoofFlat", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoRoofFlat", "_1")),
            new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Purchase"))
            .Add(new Condition(className, "applicantFoundProperty", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("LoanDetailsPage", "loanPurpose", "Remortgage")));
        */
        #endregion

        // Commented out: 11/06/2020
        // Commented in: 22/06/2020
        // Commented out: 23/06/2020
        //public Element areThereAnyIncentives => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IncentiveScheme_btn", "_rbl_0"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IncentiveScheme_btn", "_rbl_1")),
        //    new ConditionList()
        //    .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "Residential")));
        
        public SectionEnd propertyKnownSectionEnd => new SectionEnd();
        //Next
        public Element next => new Element(FindElement("Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class PropertyDetailsPageData : PageData
    {
        public string applicantFoundProperty { get; set; } = Defs.radioButtonNo;
        public string currentAddressSameAsRemortgageProperty { get; set; } = Defs.radioButtonNo;
        public string propertyInWhichJurisdiction { get; set; } = "England and Wales";
        public string applicantOneAddressSameAsRemoProperty { get; set; } = Defs.radioButtonNo;
        public string nameOrNumber { get; set; } = "4";
        public string postcode { get; set; } = "cm1 4uw";

        public string selectAddress { get; set; } = null;


        public string flat { get; set; } = "1";
        public string number { get; set; } = "2";
        public string name { get; set; } = "HouseName";
        public string street { get; set; } = "StreetName";
        public string district { get; set; } = "DistrictName";
        public string townOrCity { get; set; } = "TownName";
        public string county { get; set; } = "CountyName";
        public string manualPostcode { get; set; } = "PO5 CD3";

        public string propertyType { get; set; } = "House";
        public string propertyDescription { get; set; } = "Detached";
        public string originalPurchasePrice { get; set; } = "200000";
        public string originalPurchaseDate { get; set; } = "01/2010";
        public string propertySubType { get; set; } = "Purpose Built";
        public string numOfStoreysInBuilding { get; set; } = "1";
        public string floorFlatSituated { get; set; } = "1";
        public string buildingHaveLift { get; set; } = Defs.radioButtonYes;
        public string isPropertyNewBuild { get; set; } = Defs.radioButtonNo;
        public string yearOfConstruction { get; set; } = "2000";
        //public string convertedInLastTenYears { get; set; } = Defs.radioButtonYes;
        //public string certificateType { get; set; } = "NHBC";
        //public string isPropertyOfStandardConstruction { get; set; } = Defs.radioButtonYes;
        //public string wallConstructionType { get; set; } = "Brick";
        //public string roofConstructionType { get; set; } = "Slate";
        //public string numOfBedrooms { get; set; } = "1";
        //public string numOfKitchens { get; set; } = "1";
        //public string numOfReceptionRooms { get; set; } = "1";
        //public string numOfBathrooms { get; set; } = "1";
        //public string numOfGarages { get; set; } = "1";
        public string typeOfSale { get; set; } = "Private Sale";
        public string tenure { get; set; } = "Freehold";
        public string yearsRemainingOnLease { get; set; } = "500";
        public string groundRentPerAnnum { get; set; } = "1000";
        public string serviceChargePerAnnum { get; set; } = "100";
        public string EPCRating { get; set; } = "A";
        public string typeOfTenancy { get; set; } = "Standard AST";
        public string rentalOccupancyType { get; set; } = "Standard";
        //public string isPropertyconnectedOrAboveCommercial { get; set; } = Defs.radioButtonNo;
        public string ifYesProvideDetails { get; set; } = "Test Details";
        public string applicantPurchasePropertyFromLocalAuthority { get; set; } = Defs.radioButtonNo;
        public string dateApplicantPurchasePropertyFromLocalAuthority { get; set; } = "01/2010";
        //public string anyOfPropertyUsedForBusinessPurpose { get; set; } = Defs.radioButtonNo;
        public string percentageUsedForBusiness { get; set; } = "1";
        public string typeOfBusiness { get; set; } = "Test Business";
        //public string propertyExSocialHousing { get; set; } = Defs.radioButtonNo;
        //public string localAuthorityPurchaseDate { get; set; } = "01/2010";
        //public string propertyOwnedByLocalAuthority { get; set; } = Defs.radioButtonNo;
        //public string purchasePartOfSocialHousingScheme { get; set; } = Defs.radioButtonNo;
        //public string socialHousingPurchaseDate { get; set; } = "01/2010";
        //public string isPropertyHmo { get; set; } = Defs.radioButtonNo;
        //public string propertySubjectToAgriculturalRestrictions { get; set; } = Defs.radioButtonNo;
        //public string propertyExceedAcreage { get; set; } = Defs.radioButtonNo;
        //public string propertyAgeRestricted { get; set; } = Defs.radioButtonNo;
        //public string isPropertyListed { get; set; } = Defs.radioButtonNo;
        //public string anyElementOfFlyingFreehold { get; set; } = Defs.radioButtonNo;
        //public string isThereAnyFlatRoof { get; set; } = Defs.radioButtonNo;
        //public string areThereAnyIncentives { get; set; } = Defs.radioButtonNo;

        //public string letUnderAssuredShortholdTenancy { get; set; } = Defs.radioButtonNo;
        //public string numOfAcres { get; set; } = "7";

    }
}
