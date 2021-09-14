
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class CompanyDetailsPage : WebBasePage
    {

        public CompanyDetailsPage()
        {
            pageLoadedElement = limitedCompanyName;
            correspondingDataClass = new CompanyDetailsPageData().GetType();
            textName = "Company Details Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("ApplicantLoanTypePage", "applicantType", "Limited Company"))));
        }

        #region Limited Company Details

        public Element limitedCompanyName => new Element(FindElement("txtRegisteredCompanyName", tag: "input"));


        public Element registeredNumber => new Element(FindElement("txtRegisteredCompanyNumber", tag: "input"));

        public Element primarySicCode => new Element(FindElement("txtSicCode", tag: "select"));


        public Element dateOfRegistration => new Element(FindElement("DateOfRegistration"));

        public Element tradingSince => new Element(FindElement("txtTradingSince", tag: "input"));

        #endregion

        #region Company Registered Office Address Search

        public Element ukAddress => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsUKAddress", "rbl_0", "!CorrespondenceAddress"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsUKAddress", "rbl_1", "!CorrespondenceAddress")))
            .SetValidationType(Defs.validationTypeNotRequired);

        public Element nameOrNumber => new Element(FindElement("SearchAddressLine", "!CorrespondenceAddress"),
            new ConditionList()
            .Add(new Condition(className, "nameOrNumber", null, Defs.conditionTypeNotEqual)))
            .SetValidationType(Defs.validationTypeNotRequired);

        public Element postcode => new Element(FindElement("SearchPostCode", "!CorrespondenceAddress"))
            .SetValidationType(Defs.validationTypeNotRequired);

        public Element findAddress => new Element(FindElement("AddressDetailsFields1_SearchButton", "!CorrespondenceAddress")).SetIsButtonFlag(true)
            .SetValidationType(Defs.validationTypeNotRequired);

        public WaitFor waitForSelectAddressOrAddressLbl => new WaitFor(findAddress)
             .AddWaitElement(addressLbl.locator)
             .AddWaitElement(selectAddress.locator);


        public Element selectAddress => new Element(FindElement("SelectAddressDropDown", "!CorrespondenceAddress"),
            new ConditionList()
            .Add(new Condition(className, "selectAddress", null, Defs.conditionTypeNotEqual)));


        public Element addressLbl => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "AddressDetailsFields1_GetFullAddress")
            .Add(Defs.locatorId, "!CorrespondenceAddress")))
            .SetCompletePageFlag(false);




        public Element manualAddressEntrySection => new Element(FindElement("item0", "AddressPickerDataEntryPanel2", "!CorrespondenceAddress"))
            .SetCompletePageFlag(false);

        public Element flat => new Element(FindElement("AddressDetailsFields4_FlatNumber", "!CorrespondenceAddress"),
            new ConditionList()
            .Add(new Condition(manualAddressEntrySection.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);

        public Element number => new Element(FindElement("AddressDetailsFields4_BuildingNumber", "!CorrespondenceAddress"),
            new ConditionList()
            .Add(new Condition(manualAddressEntrySection.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);


        public Element name => new Element(FindElement("AddressDetailsFields4_BuildingName", "!CorrespondenceAddress"),
            new ConditionList()
            .Add(new Condition(manualAddressEntrySection.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);


        public Element street => new Element(FindElement("AddressDetailsFields4_Street", "!CorrespondenceAddress"),
            new ConditionList()
            .Add(new Condition(manualAddressEntrySection.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);


        public Element district => new Element(FindElement("AddressDetailsFields4_District", "!CorrespondenceAddress"),
            new ConditionList()
            .Add(new Condition(manualAddressEntrySection.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);


        public Element townOrCity => new Element(FindElement("AddressDetailsFields4_TownOrCity", "!CorrespondenceAddress"),
            new ConditionList()
            .Add(new Condition(manualAddressEntrySection.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);


        public Element county => new Element(FindElement("AddressDetailsFields4_County", "!CorrespondenceAddress"),
            new ConditionList()
            .Add(new Condition(manualAddressEntrySection.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);


        public Element manualPostcode => new Element(FindElement("AddressDetailsFields4_Postcode", "!CorrespondenceAddress"),
            new ConditionList()
            .Add(new Condition(manualAddressEntrySection.locator, Defs.elementDisplayed)))
            .SetValidationType(Defs.validationTypeAddress)
            .SetValidationCompletePageResetRequired(true);


        public Element copyToCorrespondence => new Element(FindElement("btnCopyAddress", "!CorrespondenceAddress"))
            .SetIsButtonFlag(true);

        #endregion

        //Correspondence address left out for now due to time pressures. to be added later.
        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);

    }


    public class CompanyDetailsPageData : PageData
    {
        public string limitedCompanyName { set; get; } = "TestCompany";

        public string registeredNumber { set; get; } = "123456";

        public string primarySicCode { set; get; } = "68310 - Real estate agencies";

        public string dateOfRegistration { set; get; } = "01/1990";

        public string tradingSince { set; get; } = "01/1990";

        public string ukAddress { set; get; } = Defs.radioButtonYes;

        public string nameOrNumber { set; get; } = "25";

        public string postcode { set; get; } = "CM1 6JN";

        public string selectAddress { set; get; } = null;

        public string flat { set; get; } = null;


        public string number { set; get; } = null;



        public string name { set; get; } = null;



        public string street { set; get; } = null;



        public string district { set; get; } = null;



        public string townOrCity { set; get; } = null;


        public string county { set; get; } = null;


        public string manualPostcode { set; get; } = null;
    }
}
