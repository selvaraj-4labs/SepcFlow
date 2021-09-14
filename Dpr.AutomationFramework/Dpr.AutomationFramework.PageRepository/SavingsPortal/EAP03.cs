using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP03 : WebBasePage
    {
        public EAP03()
        {
            pageLoadedElement = businessTypeLookup;
            correspondingDataClass = new EAP03Data().GetType();
            textName = "Corporate Company Details Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
            .Add(new Condition("ProductSelection", "productType", "Corporate"))
            ));
        }

        public Element businessTypeLookup => new Element(FindElement("ddlBusinessType"));

        // TODO: Insert a wait for the 'Validate Company' button

        #region Business Type = "Limited Company"

        public Section LimitedCompanyAdditionalInputSection =>
            new Section(new Element(new ConditionList()
                    .Add(new Condition(className, "businessType", "Limited Company", Defs.conditionTypeEqual)
                )));


        public Element registrationNumberBox => new Element(FindElement("txtRegisteredCompanyNumber"));

        // Actually a button but conditions need to be applied  to it .: set to Rbtn.
        //public Element validateCompanyRBtn => 
        //    new Element(new RadioButton()
        //        .AddRadioButtonElement(Defs.radioButtonYes, FindElement("btnValidateCompany"))
        //    );

        public Element validateCompanyBtn => new Element(FindElement("btnValidateCompany"))
            .SetIsButtonFlag(true);


        public WaitFor waitForSearchToFinish => new WaitFor(validateCompanyBtn)
            .AddWaitElement(fullBusinessNameBox.locator);

        public SectionEnd LimitedCompanyAdditionalInputSectionEnd => new SectionEnd();

        #endregion


        public Element fullBusinessNameBox => new Element(FindElement("txtRegisteredCompanyName"));


        public Element builldingNumberNameBox => new Element(FindElement("ctl00_SearchAddressLine"));


        public Element postcodeBox => new Element(FindElement("ctl00_SearchPostCode"));


        public Element findAddressBtn => new Element(FindElement("ctl00_SearchButton")).SetIsButtonFlag(true);

        public WaitFor waitForAddressLbl => new WaitFor(findAddressBtn)
            .AddWaitElement(addressLbl.locator);

        public Element addressLbl => new Element(FindElement("GetFullAddress")).SetCompletePageFlag(false);

        public Element sameAsTradingAddressChbox => new Element(FindElement("CopyAddressInput"));


        public Section officeDiffersFromTradingAddressSection => new Section(new Element(new ConditionList()
                .Add(new Condition(className, "sameAsTradingAddress", Defs.checkBoxNotSelected, Defs.conditionTypeEqual))));


        public Element roBuildingNumberBox => new Element(FindElement("ctl02_SearchAddressLine"));


        public Element roPostcodeBox => new Element(FindElement("ctl02_SearchPostCode"));


        public Element roFindAddressBtn => new Element(FindElement("ctl02_SearchButton")).SetIsButtonFlag(true);


        public SectionEnd officeDiffersFromTradingAddressSectionEnd => new SectionEnd();


        public Element businessPhoneNumberBox => new Element(FindElement("txtWorkTel"));


        public Element businessEmailAddressBox => new Element(FindElement("txtEmailAddress"));


        public Element confirmBusinessEmailAddressBox => new Element(FindElement("txtConfirmEmailAddress"));


        public Element whenBusinessEstablishedBox => new Element(FindElement("TradingSinceDateInput"));


        public Element natureOfBusinessBox => new Element(FindElement("NatureOfTradeInput"));


        public Element numberOfEmployeesBox => new Element(FindElement("NumberOfEmployeesInput"));


        public Element turnoverBox => new Element(FindElement("txtTurnOver"));


        public Element nextBtn => new Element(FindElement("Next"))
            .SetIsButtonFlag(true);


    }

    public class EAP03Data : PageData
    {
        public string uniqueIdentifier { get; set; }

        public string fullBusinessName { get; set; }

        public EAP03Data()
        {
            uniqueIdentifier = UniqueStringGenerator();
            fullBusinessName = "TestCompany-" + uniqueIdentifier;
        }

        public string businessType { get; set; } = "Limited Company";


        public string registrationNumber { get; set; } = "03178610";


        public string builldingNumberName { get; set; } = "4";


        public string postcode { get; set; } = "cm1 4uw";


        public string sameAsTradingAddress { get; set; } = Defs.checkBoxSelected;


        public string businessPhoneNumber { get; set; } = "01002003004";


        public string businessEmailAddress { get; set; } = "nathan.welch@dpr.co.uk";


        public string confirmBusinessEmailAddress { get; set; } = "nathan.welch@dpr.co.uk";


        public string whenBusinessEstablished { get; set; } = "01/2010";


        public string natureOfBusiness { get; set; } = "Testing";


        public string numberOfEmployees { get; set; } = "7";


        public string turnover { get; set; } = "1000000";


    }
}
