using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_Applicant1PrimaryEmploymentPageFixedTermContract : WebBasePage
    {
        public FMA_Applicant1PrimaryEmploymentPageFixedTermContract()
        {
            pageLoadedElement = employmentStatus;
            correspondingDataClass = new FMA_Applicant1PrimaryEmploymentPageFixedTermContractData().GetType();
            textName = "FMA Applicant 1 Primary Employment Details Page Self Employed";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("DIP_ApplicationSummaryPage", "_app1EmploymentType", "Fixed Term Contract"))));
        }

        public Element employmentStatus => new Element(FindElement("ctl00_EmploymentType-button"));
        public Element occupation => new Element(FindElement("ctl00_Occupation"));
        public Element jobTitle => new Element(FindElement("ctl00_Position"));
        public Element companyName => new Element(FindElement("ctl00_CompanyName"));
        public Element employedByFamilyMember => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl00_ctl00_rdoQuestion_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl00_ctl00_rdoQuestion_btn_rbl_1")));
        public Element isTheAddressAUKAddress => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl00_ctl22_radIsUKAddress_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl00_ctl22_radIsUKAddress_btn_rbl_1")));

        #region 'Is the address a UK address?' = 'Yes'
        public Section addressIsUkAddressSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "isTheAddressAUKAddress", Defs.radioButtonYes))));

        public Element nameOrNumber => new Element(FindElement("ctl22_AddressDetailsFields1_SearchAddressLine"));
        public Element postcode => new Element(FindElement("ctl22_AddressDetailsFields1_SearchPostCode"));
        public Element findAddress => new Element(FindElement("ctl22_AddressDetailsFields1_SearchButton")).SetIsButtonFlag(true);
        //public Element selectAddress => new Element(FindElement("ctl20_AddressDetailsFields1_SelectAddressDropDown"));
        public Element addressLbl => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "item0")
            .Add(Defs.locatorId, "GetFullAddress")))
            .SetCompletePageFlag(false);
        //public WaitFor waitForAddressLbl => new WaitFor(findAddress)
        //    /*.AddWaitElement(selectAddress.locator)*/
        //    .AddWaitElement(addressLbl.locator);

        public SectionEnd addressIsUkAddressSectionEnd => new SectionEnd();
        #endregion

        #region 'Is the address a UK address?' = 'No' 
        public Section addressIsNotUkAddressSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "isTheAddressAUKAddress", Defs.radioButtonNo))));

        public Element number => new Element(FindElement("AddressDetailsFields2_BuildingNumber"));
        public Element flat => new Element(FindElement("AddressDetailsFields2_FlatNumber"));
        public Element name => new Element(FindElement("AddressDetailsFields2_BuildingName"));
        public Element street => new Element(FindElement("AddressDetailsFields2_Street"));
        public Element district => new Element(FindElement("AddressDetailsFields2_District"));
        public Element townOrCity => new Element(FindElement("AddressDetailsFields2_TownOrCity"));
        public Element county => new Element(FindElement("AddressDetailsFields2_County"));
        public Element country => new Element(FindElement("AddressDetailsFields2_cboCountry"));

        public SectionEnd addressIsNotUkAddressSectionEnd => new SectionEnd();
        #endregion

        public Element next => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class FMA_Applicant1PrimaryEmploymentPageFixedTermContractData : PageData
    {
        public string jobTitle { get; set; } = "TestJobTitle";
        public string companyName { get; set; } = "TestCompanyName";
        public string employedByFamilyMember { get; set; } = Defs.radioButtonNo;
        public string isTheAddressAUKAddress { get; set; } = Defs.radioButtonYes;

        #region 'Is the address a UK address?' = 'Yes'
        public string nameOrNumber { get; set; } = "27";
        public string postcode { get; set; } = "CM1 6JN";

        #endregion

        #region 'Is the address a UK address?' = 'No'
        public string number { get; set; } = null;
        public string flat { get; set; } = null;
        public string name { get; set; } = null;
        public string street { get; set; } = null;
        public string district { get; set; } = null;
        public string townOrCity { get; set; } = null;
        public string county { get; set; } = null;
        public string country { get; set; } = null;
        #endregion
    }
}
