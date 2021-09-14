using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_Applicant1PrimaryEmploymentPageSelfEmployed : WebBasePage
    {
        public FMA_Applicant1PrimaryEmploymentPageSelfEmployed()
        {
            pageLoadedElement = employmentStatus;
            correspondingDataClass = new FMA_Applicant1PrimaryEmploymentPageSelfEmployedData().GetType();
            textName = "FMA Applicant 1 Primary Employment Details Page Self Employed";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("DIP_ApplicationSummaryPage", "_app1EmploymentType", "Self Employed"))));
        }
        public Element employmentStatus => new Element(FindElement("ctl00_EmploymentType-button"));
        public Element occupation => new Element(FindElement("ctl00_Occupation"));

        public Element ownershipType => new Element(FindElement("ctl00_CompanyType-button"));
        public Element nameOfBusiness => new Element(FindElement("ctl00_CompanyName"));

        public Element nameOrNumber => new Element(FindElement("ctl01_pnlApplicantPanel_ctl00_ctl20_AddressDetailsFields1_SearchAddressLine"));
        public Element postcode => new Element(FindElement("ctl01_pnlApplicantPanel_ctl00_ctl20_AddressDetailsFields1_SearchPostCode"));
        public Element findAddress => new Element(FindElement("ctl01_pnlApplicantPanel_ctl00_ctl20_AddressDetailsFields1_SearchButton"))
            .SetIsButtonFlag(true);
        //public Element selectAddress => new Element(FindElement("ctl20_AddressDetailsFields1_SelectAddressDropDown"));
        public Element addressLbl => new Element(FindElement(new LocatorList()
            //.Add(Defs.locatorId, "item0")
            .Add(Defs.locatorId, "ctl01_pnlApplicantPanel_ctl00_ctl20_AddressDetailsFields1_GetFullAddress")))
            .SetCompletePageFlag(false);
        //public WaitFor waitForAddressLbl => new WaitFor(findAddress)
        //    /*.AddWaitElement(selectAddress.locator)*/
        //    .AddWaitElement(addressLbl.locator);

        #region Select Address = 'None of the Following' Section
        //public Section noneOfTheFollowingAddressSection => new Section(new Element(new ConditionList()
        //    .Add(new Condition(className, "selectAddress", "None of the Following"))));
        //public Element number => new Element(FindElement("AddressDetailsFields2_BuildingNumber"));
        //public Element flat => new Element(FindElement("AddressDetailsFields2_FlatNumber"));
        //public Element name => new Element(FindElement("AddressDetailsFields2_BuildingName"));
        //public Element street => new Element(FindElement("AddressDetailsFields2_Street"));
        //public Element district => new Element(FindElement("AddressDetailsFields2_District"));
        //public Element townOrCity => new Element(FindElement("AddressDetailsFields2_TownOrCity"));
        //public Element county => new Element(FindElement("AddressDetailsFields2_County"));
        //public Element country => new Element(FindElement("AddressDetailsFields2_cboCountry"));
        #endregion

        public Element accountantUsedToPrepareAccounts => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl00_HasAccountantActingFor_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl00_HasAccountantActingFor_1")));

        #region 'Accountants used to prepare accounts' = 'Yes'
        public Section accountantPrepareAccountsSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "accountantUsedToPrepareAccounts", Defs.radioButtonYes))));

        public Element accountantCompany => new Element(FindElement("ctl00_AccountantCompany"));
        public Element accountantContactName => new Element(FindElement("ctl00_AccountantName"));
        public Element accountantQualification => new Element(FindElement("ctl00_AccountantQualification"));
        public Element accountantActingForYears => new Element(FindElement("ctl00_ActingForYears"));
        public Element accountantActingForMonths => new Element(FindElement("ctl00_ActingForMonths"));
        public Element accountantNameOrNumber => new Element(FindElement("ctl02_ApplicantPanel_ctl00_ctl20_AddressDetailsFields1_SearchAddressLine"));
        public Element accountantPostcode => new Element(FindElement("ctl02_ApplicantPanel_ctl00_ctl20_AddressDetailsFields1_SearchPostCode"));
        public Element accountantFindAddress => new Element(FindElement("ctl02_ApplicantPanel_ctl00_ctl20_AddressDetailsFields1_SearchButton"))
            .SetIsButtonFlag(true);
        //public Element selectAddress => new Element(FindElement("ctl20_AddressDetailsFields1_SelectAddressDropDown"));
        public Element accountantAddressLbl => new Element(FindElement(new LocatorList()
            //.Add(Defs.locatorId, "item0")
            .Add(Defs.locatorId, "ctl02_ApplicantPanel_ctl00_ctl20_AddressDetailsFields1_GetFullAddress")))
            .SetCompletePageFlag(false);
        //public WaitFor waitForAccountantAddressLbl => new WaitFor(findAddress)
        //    /*.AddWaitElement(selectAddress.locator)*/
        //    .AddWaitElement(accountantAddressLbl.locator);

        public SectionEnd accountantPrepareAccountsSectionEnd => new SectionEnd();
        #endregion

        public Element next => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class FMA_Applicant1PrimaryEmploymentPageSelfEmployedData : PageData
    {
        public string nameOfBusiness { get; set; } = "TestBusinessName";
        public string nameOrNumber { get; set; } = "27";
        public string postcode { get; set; } = "CM1 6JN";
        public string accountantUsedToPrepareAccounts { get; set; } = Defs.radioButtonNo;

        #region 'Accountants used to prepare accounts' = 'Yes'
        public string accountantCompany { get; set; } = "TestAccountCompany";
        public string accountantContactName { get; set; } = "TestAccountName";
        public string accountantQualification { get; set; } = "ACCA";
        public string accountantActingForYears { get; set; } = "8";
        public string accountantActingForMonths { get; set; } = "0";
        public string accountantNameOrNumber { get; set; } = "4";
        public string accountantPostcode { get; set; } = "CM1 4UW";
        #endregion
    }
}
