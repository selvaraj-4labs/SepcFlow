using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP08 : WebBasePage
    {
        public EAP08()
        {
            pageLoadedElement = titleLookup;
            correspondingDataClass = new EAP08Data().GetType();
            textName = "Parent/Guardian page";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("ProductSelection", "productType", "Child"))
                    .Add(new Condition("EAP04", "dateOfBirth", "<16", Defs.conditionTypeCompareYearDifferenceDdMmYyyy)))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("ProductSelection", "productType", "ChildIsa"))
                    .Add(new Condition("EAP04", "dateOfBirth", "<16", Defs.conditionTypeCompareYearDifferenceDdMmYyyy))));
        }

        #region Locators


        public Element areYouTheParentLegalGuardian => new Element(FindElement("AreYouParentGuardian"));
        public Element countryOfResidence => new Element(FindElement("cboCoR"));

        #region Your name
        public Element titleLookup => new Element(FindElement("cboTitle"));
        public Element firstNameBox => new Element(FindElement("txtFirstName"));
        public Element middleNameBox => new Element(FindElement("txtMiddleName"));
        public Element lastNameBox => new Element(FindElement("txtSurname"));
        #endregion

        #region Your Personal information
        public Element dateOfBirthBox => new Element(FindElement("txtDateOfBirth"));
        public Element countryOfBirthLookup => new Element(FindElement("CountryOfBirth"));
        public Element genderRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("cboGender", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("cboGender", "_1")));
        public Element maritalStatusLookup => new Element(FindElement("cboMaritialStatus"));//,
                                                                                            //new ConditionList()                                                                                         //.Add(new Condition("ProductSelection", "productType", "Child", Defs.conditionTypeNotEqual)));

        public Element nationalInsuranceNumberBox => new Element(FindElement("NINumber"));//,
           // new ConditionList()
            //.Add(new Condition("ProductSelection", "productType", "Child", Defs.conditionTypeNotEqual)));


        public Element permanentUKResidentRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radPermanentRightsToResideInUK_btn_rbl", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radPermanentRightsToResideInUK_btn_rbl", "_1")));//,
                                                                                                                     //new ConditionList()
                                                                                                                     // .Add(new Condition("ProductSelection", "productType", "Child", Defs.conditionTypeNotEqual)));

        #endregion

        #region Nationality/Tax
        public Element nationalityLookup => new Element(FindElement("cboNationality", "!TaxIdentity"));

        public Element dualNationalityRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HasSecondNationality_btn_rbl", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HasSecondNationality_btn_rbl", "_1")));

        // CONDITIONAL ELEMENT. REQUIRES 'dualNationalityRbtn' = 'Yes'
        public Element secondNationalityLookup => new Element(
            FindElement("cboSecondNationality"), new ConditionList()
            .Add(new Condition("EAP04", "dualNationalityRbtn", "_rbl_0")));

        public Element taxResidencyLookup => new Element(FindElement("TaxResidency", "!Second"));

        public Element dualResidencyRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HasSecondTaxResidency_btn", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HasSecondTaxResidency_btn", "_rbl_1")));

        // CONDITIONAL ELEMENT. REQUIRES 'dualResidencyRbtn' = 'Yes'
        public Element secondResidencyLookup => new Element(
            FindElement("redSecondTaxResidency"), new ConditionList()
            .Add(new Condition("EAP04", "dualResidencyRbtn", "_rbl_0")));

        public Element taxpayerIdentificationNumber => new Element(FindElement("TaxpayerIdentificationNo"));

        #endregion

        #region Contact details

        //public Section contactDetailsSection => new Section(new Element(new ConditionList()
        //    .Add(new Condition("ProductSelection", "productType", "Child", Defs.conditionTypeNotEqual))));

        public Element homePhoneNumberBox => new Element(FindElement("txtHomeTel"));

        public Element workPhoneNumberBox => new Element(FindElement("txtWorkTel"));
        
        public Element mobilePhoneNumberBox => new Element(FindElement("txtMobile"));

        public Element preferredPhoneMethod => new Element(FindElement("PreferredContactMethod"));

        public Element preferredContactMethodLookup => new Element(FindElement("PreferredCorrespondenceMethod"));

        public Element emailAddressBox => new Element(FindElement("txtEmailAddress"));

        public Element confirmEmailAddressBox => new Element(FindElement("txtConfirmEmailAddress"));

        public Element wouldYouLikeToReceivePaperlessStatementsRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("RequiresPaperlessStatements", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("RequiresPaperlessStatements", "_rbl_1")));



        //public SectionEnd contactDetailsSectionEnd => new SectionEnd();
        #endregion

        #region Current residential address
        public Element residentialStatusLookup => new Element(FindElement("ResidentialStatus"));
        public Element postcodeBox => new Element(FindElement("SearchPostCode"));
        public Element houseNumberBox => new Element(FindElement("SearchAddressLine"));

        public Element findAddressButton => new Element(FindElement("SearchButton")).SetIsButtonFlag(true);

        public WaitFor waitForAddressLbl => new WaitFor(findAddressButton)
            .AddWaitElement(addressLbl.locator);

        public Element addressLbl => new Element(FindElement("GetFullAddress")).SetCompletePageFlag(false);


        // CONDITIONAL SECTION. REQUIRES 'findAddressButton' TO BE CLICKED
        public Element selectAddress => new Element(FindElement("SelectAddressDropDown"),
            new ConditionList()
            .Add(new Condition(findAddressButton.locator, Defs.elementDisplayed)));

        /* 
        INNER CONDITIONAL SECTION. REQUIRES 'selectAddress'= 'None of the Following'
        public Element flatBox => new Element(FindElement("FlatNumber"));
        public Element numberBox => new Element(FindElement("BuildingNumber"));
        public Element nameBox => new Element(FindElement("BuildingName"));
        public Element streetBox => new Element(FindElement("Street"));
        public Element districtBox => new Element(FindElement("District"));
        public Element townOrCityBox => new Element(FindElement("TownOrCity"));
        public Element countyBox => new Element(FindElement("County"));
        public Element postcodeBox_2 => new Element(FindElement("Postcode"));
            // EOC
        // EOC
        */
        public Element movedToCurrentAddressBox => new Element(FindElement("StartDateAtAddress"));

        #endregion

        #region Employment details
        //public Section employmentDetailsSection => new Section(new Element(new ConditionList()
        //   .Add(new Condition("ProductSelection", "productType", "Child", Defs.conditionTypeNotEqual))));

        public Element employmentStatusLookup => new Element(FindElement("IncomeSourceDropDownList"));

        /* CONDITIONAL ELEMENT. REQUIRES 'employmentStatus' =   'Employed - Full Time' OR 
                                                                'Employed - Part Time' OR 
                                                                'Self employed'.
        */
        public Element occupationBox => new Element(FindElement("JobTitleTextBox"),
            new ConditionList()
            .Add(new Condition(className, "employmentStatus", "Employed - Full Time")))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition(className, "employmentStatus", "Employed - Part Time")))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition(className, "employmentStatus", "Self employed")));

       // public SectionEnd employmentDetailsSectionEnd => new SectionEnd();
        #endregion

        #region Keeping you informed


        public Section keepingInformedSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "keepYouInformed", Defs.radioButtonYes))));

        public Element keepYouInformedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AllowedAnyMarketing", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AllowedAnyMarketing", "_rbl_1")));

        public Element contactByPhoneRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radAgreementToContactByPhone_btn", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radAgreementToContactByPhone_btn", "_rbl_1")));
        public Element contactByPostRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radAgreementToContact_btn", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radAgreementToContact_btn", "_rbl_1")));
        public Element contactByEmailRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radAgreementToContactByEmail_btn", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radAgreementToContactByEmail_btn", "_rbl_1")));

        public Element contactByTextRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AgreementToContactByText", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AgreementToContactByText", "_rbl_1")));


        public SectionEnd keepingInformedDetailsSectionEnd => new SectionEnd();
        #endregion

        public Element nextBtn => new Element(FindElement("_Next")).SetIsButtonFlag(true).SetIsPageContinueButtonFlag(true);

        #endregion


    }

    public class EAP08Data : PageData
    {
        public EAP08Data()
        {
            uniqueIdentifier = UniqueStringGenerator();
            emailAddress = UniqueStringGenerator() + "@automation.test";
            confirmEmailAddress = emailAddress;
            firstName = UniqueStringGenerator();
            lastName = UniqueStringGenerator();
        }

        private string uniqueIdentifier { get; set; } = null;
        public string firstName { get; set; } = null;
        public string lastName { get; set; } = null;


        public string areYouTheParentLegalGuardian { get; set; } = "Yes";
        public string countryOfResidence { get; set; } = "United Kingdom";

        #region Your name

        public string title { get; set; } = "Mr";

        public string middleName { get; set; } = "testMName";

        #endregion

        #region Your Personal information
        public string dateOfBirth { get; set; } = "01/01/1990";
        public string countryOfBirth { get; set; } = "United Kingdom";
        public string gender { get; set; } = Defs.radioButtonYes; // Male.
        public string maritalStatus { get; set; } = "Single";
        public string nationalInsuranceNumber { get; set; } = "AB123456D";
        public string permanentUKResident { get; set; } = Defs.radioButtonYes;
        #endregion

        #region Nationality/Tax
        public string nationality { get; set; } = "British";
        public string dualNationality { get; set; } = Defs.radioButtonNo;
        public string taxResidency { get; set; } = "United Kingdom";
        public string dualResidency { get; set; } = Defs.radioButtonNo;
        public string taxpayerIdentificationNumber { get; set; } = "1859";
        #endregion

        #region Contact details
        public string homePhoneNumber { get; set; } = null;
        public string workPhoneNumber { get; set; } = null;
        public string mobilePhoneNumber { get; set; } = "07740000000";
        public string preferredPhoneMethod{get; set;} = "Mobile";
        public string preferredContactMethod { get; set; } = "Email";
        public string emailAddress { get; set; } = "nathan.welch@dpr.co.uk";
        public string confirmEmailAddress { get; set; } = "nathan.welch@dpr.co.uk";
        public string wouldYouLikeToReceivePaperlessStatements { get; set; } = Defs.radioButtonYes;
        #endregion

        #region Current residential address
        public string residentialStatus { get; set; } = "Owner Without Mortgage";
        public string postcode { get; set; } = "CM1 6JN";
        public string houseNumber { get; set; } = "27";

        // 'findAddressButton' is clicked
        /* CONDITIONAL SECTION. REQUIRES 'findAddressButton' TO BE CLICKED
        public string selectAddress { get; set; } = 

        // CONDITIONAL SECTION. REQUIRES 'selectAddress'= 'None of the Following'
        public string flatBox { get; set; } =
        public string numberBox { get; set; } =
        public string nameBox { get; set; } =
        public string streetBox { get; set; } =
        public string districtBox { get; set; } =
        public string townOrCityBox { get; set; } =
        public string countyBox { get; set; } =
        public string postcodeBox_2 { get; set; } =
        */

        public string movedToCurrentAddress { get; set; } = "01/2013";
        #endregion

        #region Employment details
        public string employmentStatus { get; set; } = "Employed - Full Time";
        public string occupation { get; set; } = "Analyst";
        #endregion

        #region Keeping you informed
        public string keepYouInformed { get; set; } = Defs.radioButtonYes;
        public string contactByPhone { get; set; } = Defs.radioButtonYes;
        public string contactByPost { get; set; } = Defs.radioButtonYes;
        public string contactByEmail { get; set; } = Defs.radioButtonYes;
        public string contactByText { get; set; } = Defs.radioButtonYes;
        #endregion

    }
}
