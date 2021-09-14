using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PBR.Intermediary.PortalPages
{
    class ApplicantAddressPagePBR : WebBasePage
    {
        public ApplicantAddressPagePBR()
        {
            pageLoadedElement = fromBox;
            correspondingDataClass = new ApplicantAddressData().GetType();
            //javascriptPageNavigator = @"javascript: __doPostBack('ctl00$MC$Menu1', 'bApplicant1Details\\ApplicantAddressDetails')";
            //specialPageValidationRequired = true;
            //displayedAfterNextPageBackBtn = false;
        }

        #region Current Address Search section locators


        public Element ukAddressEverHadRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HaveYouEverHadUKAddress", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HaveYouEverHadUKAddress", "_1")));
            //.SetValidationType(Defs.validationTypeNotRequired);

        public Element ukAddressRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("item0", "IsUKAddress", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("item0", "IsUKAddress", "rbl_1")))
            .SetValidationType(Defs.validationTypeNotRequired);

        public Element nameOrNumberBox => new Element(FindElement("item0", "SearchAddressLine"),
            new ConditionList()
            .Add(new Condition(className, "nameOrNumber", null, Defs.conditionTypeNotEqual)))
            .SetValidationType(Defs.validationTypeNotRequired);

        public Element postcodeBox => new Element(FindElement("item0", "SearchPostCode"))
            .SetValidationType(Defs.validationTypeNotRequired);

        public Element findAddressBtn => new Element(FindElement("item0", "SearchButton")).SetIsButtonFlag(true)
            .SetValidationType(Defs.validationTypeNotRequired);

        public WaitFor waitForSelectAddressOrAddressLbl => new WaitFor(findAddressBtn)
             .AddWaitElement(addressLbl.locator)
             .AddWaitElement(selectAddressLookup.locator);


        public Element selectAddressLookup => new Element(FindElement("item0", "SelectAddressDropDown"),
            new ConditionList()
            .Add(new Condition(className, "selectAddress", null, Defs.conditionTypeNotEqual)));


        public Element addressLbl => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "item0")
            .Add(Defs.locatorId, "GetFullAddress")))
            .SetCompletePageFlag(false);



        public Element fromBox => new Element(FindElement("item0", "StartDateAtAddress"))
            .SetValidationType(Defs.validationTypeMmYyyy)
            .SetValidationCompletePageResetRequired(true);

        public Element residentialStatusLookup => new Element(FindElement("item0", "ResidentialStatus"))
            .SetValidationCompletePageResetRequired(true);




        public Element toBox => new Element(FindElement("item0", "EndDateAtAddress"))
            .SetCompletePageFlag(false);

        public Element manualAddressEntrySection => new Element(FindElement("item0", "AddressPickerDataEntryPanel2"))
            .SetCompletePageFlag(false);

        public Element flatBox => new Element(FindElement("item0", "FlatNumber"),
            new ConditionList()
            .Add(new Condition(manualAddressEntrySection.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);

        public Element numberBox => new Element(FindElement("item0", "BuildingNumber"),
            new ConditionList()
            .Add(new Condition(manualAddressEntrySection.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);


        public Element nameBox => new Element(FindElement("item0", "BuildingName"),
            new ConditionList()
            .Add(new Condition(manualAddressEntrySection.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);


        public Element streetBox => new Element(FindElement("item0", "Street"),
            new ConditionList()
            .Add(new Condition(manualAddressEntrySection.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);


        public Element districtBox => new Element(FindElement("item0", "District"),
            new ConditionList()
            .Add(new Condition(manualAddressEntrySection.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);


        public Element townOrCityBox => new Element(FindElement("item0", "TownOrCity"),
            new ConditionList()
            .Add(new Condition(manualAddressEntrySection.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);


        public Element countyBox => new Element(FindElement("item0", "County"),
            new ConditionList()
            .Add(new Condition(manualAddressEntrySection.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);


        public Element manualPostcodeBox => new Element(FindElement("item0", "Postcode"),
            new ConditionList()
            .Add(new Condition(manualAddressEntrySection.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);


        #endregion

        #region Previous Address 1 Search section locators


        public Element previousAddressSection1 => new Element(FindElement("item1", "pnlAddressPickerFieldSet"))
            .SetCompletePageFlag(false);


        public Element previousUkAddressRbtn1 => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("item1_", "IsUKAddress", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("item1_", "IsUKAddress", "rbl_1")),
            new ConditionList()
            .Add(new Condition(previousAddressSection1, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeNotRequired);

        public Element previousNameOrNumberBox1 => new Element(FindElement("item1_", "SearchAddressLine"),
            new ConditionList()
            .Add(new Condition(className, "from", "<=3", Defs.conditionTypeCompareYearDifferenceMmYyyy))
            .Add(new Condition(className, "previousNameOrNumber1", null, Defs.conditionTypeNotEqual)))
            .SetValidationType(Defs.validationTypeNotRequired);


        public Element previousPostcodeBox1 => new Element(FindElement("item1_", "SearchPostCode"),
            new ConditionList()
            .Add(new Condition(className, "from", "<=3", Defs.conditionTypeCompareYearDifferenceMmYyyy)))
            .SetValidationType(Defs.validationTypeNotRequired);

        public Element previousFindAddressBtn1 => new Element(FindElement("item1_", "SearchButton"),
            new ConditionList()
            .Add(new Condition(className, "from", "<=3", Defs.conditionTypeCompareYearDifferenceMmYyyy)))
            .SetIsButtonFlag(true);


        public WaitFor previousWaitForSelectAddressOrAddressLbl1 => new WaitFor(previousFindAddressBtn1)
             .AddWaitElement(previousAddressLbl1.locator)
             .AddWaitElement(previousSelectAddressLookup1.locator);

        public Element previousAddressLbl1 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "item1")
            .Add(Defs.locatorText, "GetFullAddress")))
            .SetCompletePageFlag(false);


        public Element previousSelectAddressLookup1 => new Element(FindElement("item1_", "SelectAddressDropDown"),
            new ConditionList()
            .Add(new Condition(previousAddressSection1, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeNotRequired);


        public Element previousResidentialStatusLookup1 => new Element(FindElement("item1_", "ResidentialStatus"),
            new ConditionList()
            .Add(new Condition(className, "from", "<=3", Defs.conditionTypeCompareYearDifferenceMmYyyy)))
            .SetValidationType(Defs.validationTypeNotRequired);

        public Element previousFromBox1 => new Element(FindElement("item1_", "StartDateAtAddress"),
            new ConditionList()
            .Add(new Condition(className, "from", "<=3", Defs.conditionTypeCompareYearDifferenceMmYyyy)))
            .SetValidationType(Defs.validationTypeNotRequired);

        public Element previousToBox1 => new Element(FindElement("item1_", "EndDateAtAddress")).SetCompletePageFlag(false);

        public Element previousManualAddressEntrySection1 => new Element(FindElement("item1_", "AddressPickerDataEntryPanel2"))
            .SetCompletePageFlag(false);

        public Element previousFlatBox1 => new Element(FindElement("item1_", "FlatNumber"),
            new ConditionList()
            .Add(new Condition(previousManualAddressEntrySection1.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeNotRequired)
            .SetValidationCompletePageResetRequired(true);

        public Element previousNumberBox1 => new Element(FindElement("item1_", "BuildingNumber"),
            new ConditionList()
            .Add(new Condition(className, "from", "<=3", Defs.conditionTypeCompareYearDifferenceMmYyyy))
            .Add(new Condition(previousManualAddressEntrySection1.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeNotRequired)
            .SetValidationCompletePageResetRequired(true);

        public Element previousNameBox1 => new Element(FindElement("item1_", "BuildingName"),
            new ConditionList()
            .Add(new Condition(className, "from", "<=3", Defs.conditionTypeCompareYearDifferenceMmYyyy))
            .Add(new Condition(previousManualAddressEntrySection1.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeNotRequired)
            .SetValidationCompletePageResetRequired(true);

        public Element previousStreetBox1 => new Element(FindElement("item1_", "Street"),
            new ConditionList()
            .Add(new Condition(className, "from", "<=3", Defs.conditionTypeCompareYearDifferenceMmYyyy))
            .Add(new Condition(previousManualAddressEntrySection1.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeNotRequired)
            .SetValidationCompletePageResetRequired(true);

        public Element previousDistrictBox1 => new Element(FindElement("item1_", "District"),
            new ConditionList()
            .Add(new Condition(className, "from", "<=3", Defs.conditionTypeCompareYearDifferenceMmYyyy))
            .Add(new Condition(previousManualAddressEntrySection1.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeNotRequired)
            .SetValidationCompletePageResetRequired(true);

        public Element previousTownOrCityBox1 => new Element(FindElement("item1_", "TownOrCity"),
            new ConditionList()
            .Add(new Condition(className, "from", "<=3", Defs.conditionTypeCompareYearDifferenceMmYyyy))
            .Add(new Condition(previousManualAddressEntrySection1.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeNotRequired)
            .SetValidationCompletePageResetRequired(true);

        public Element previousCountyBox1 => new Element(FindElement("item1_", "County"),
            new ConditionList()
            .Add(new Condition(className, "from", "<=3", Defs.conditionTypeCompareYearDifferenceMmYyyy))
            .Add(new Condition(previousManualAddressEntrySection1.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeNotRequired)
            .SetValidationCompletePageResetRequired(true);

        public Element previousManualPostcodeBox1 => new Element(FindElement("item1_", "Postcode"),
            new ConditionList()
            .Add(new Condition(className, "from", "<=3", Defs.conditionTypeCompareYearDifferenceMmYyyy))
            .Add(new Condition(previousManualAddressEntrySection1.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeNotRequired)
            .SetValidationCompletePageResetRequired(true);
        #endregion

        //Next
        public Element nextBtn => new Element(FindElement("Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);


    }

    public class ApplicantAddressData : PageData
    {

        public string ukAddressEverHad { get; set; } = Defs.radioButtonYes;
        public string ukAddress { get; set; } = Defs.radioButtonYes; 
        public string nameOrNumber { get; set; } = "4";
        public string postcode { get; set; } = "cm1 4uw";
        public string selectAddress { get; set; } = null;
        public string residentialStatus { get; set; } = "Owner With Mortgage";
        public string from { get; set; } = "01/2010";

        public string flat { get; set; } = "1";
        public string number { get; set; } = "2";
        public string name { get; set; } = "House Name";
        public string street { get; set; } = "Street Name";
        public string district { get; set; } = "District Name";
        public string townOrCity { get; set; } = "Town Name";
        public string county { get; set; } = "County Name";
        public string manualPostcode { get; set; } = "Postcode Name";

        public string previousUkAddress1 { get; set; } = Defs.radioButtonYes;
        public string previousNameOrNumber1 { get; set; } = "37";
        public string previousPostcode1 { get; set; } = "cm5 0bj";
        public string previousSelectAddress1 { get; set; } = null;
        public string previousResidentialStatus1 { get; set; } = "Owner Without Mortgage";
        public string previousFrom1 { get; set; } = "01/2010";

        public string previousFlat1 { get; set; } = "3";
        public string previousNumber1 { get; set; } = "4";
        public string previousName1 { get; set; } = "Prev House Name";
        public string previousStreet1 { get; set; } = "Prev Street Name";
        public string previousDistrict1 { get; set; } = "Prev District Name";
        public string previousTownOrCity1 { get; set; } = "Prev Town Name";
        public string previousCounty1 { get; set; } = "Prev County Name";
        public string previousManualPostcode1 { get; set; } = "Prev Postcode";
    }
}

