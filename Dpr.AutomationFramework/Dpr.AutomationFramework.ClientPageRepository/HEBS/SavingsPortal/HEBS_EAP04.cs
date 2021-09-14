using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP04 : WebBasePage
    {
        public HEBS_EAP04()
        {
            pageLoadedElement = titleLookup;
            correspondingDataClass = new HEBS_EAP04Data().GetType();
            textName = "About You";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("HEBS_EAP00", "productType", "Child")))
                 .AddNewConditionList(new ConditionList()
                    .Add(new Condition("HEBS_EAP00", "productType", "ISA")))
                 .AddNewConditionList(new ConditionList()
                    .Add(new Condition("HEBS_EAP00", "productType", "ChildISA")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("HEBS_EAP00", "productType", "Retail"))));
        }
        // Required a rewrite due to the conditions.

        #region Your Account Application
        public Element singleJointAccountRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Single", FindElement("NumberOfApplicants", "_0"))
            .AddRadioButtonElement("Joint", FindElement("NumberOfApplicants", "_1")),
            new ConditionList()
            .Add(new Condition("HEBS_EAP00", "productType", "ISA", Defs.conditionTypeNotEqual))
            .Add(new Condition("HEBS_EAP00", "productType", "Child", Defs.conditionTypeNotEqual))
            .Add(new Condition("HEBS_EAP00", "productType", "ChildIsa", Defs.conditionTypeNotEqual)));
        #endregion

        #region Qualifying Questions
        public Element countryOfResidenceLookup => new Element(FindElement("cboCoR"));
        public Element currentAccountWithAnotherBankRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radHoldsOtherAccount_btn", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radHoldsOtherAccount_btn", "_rbl_1")));
        #endregion

        #region Your name
        public Element titleLookup => new Element(FindElement("cboTitle"));
        public Element firstNameBox => new Element(FindElement("txtFirstName"));
        public Element middleNameBox => new Element(FindElement("txtMiddleName"));
        public Element lastNameBox => new Element(FindElement("txtSurname"));
        #endregion

        #region Your Personal information
        public Element dateOfBirthBox => new Element(FindElement("txtDateOfBirth"));
        public Element countryOfBirthLookup => new Element(FindElement("CountryOfBirth"));
        public Element placeOfBirthBox => new Element(FindElement("txtBirthPlace"));
        public Element gender => new Element(FindElement("cboGender"));
        public Element maritalStatusLookup => new Element(FindElement("cboMaritialStatus"));
        public Element nationalInsuranceNumberBox => new Element(FindElement("NINumber"),
            new ConditionList()
                .Add(new Condition(className, "dateOfBirth", ">=16", Defs.conditionTypeCompareYearDifferenceDdMmYyyy)));

        public Element existingBankMemberRbtn => new Element(new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radExistingCustomer_btn_rbl", "_0"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radExistingCustomer_btn_rbl", "_1")),
            new ConditionList()
                .Add(new Condition(className, "dateOfBirth", ">=16", Defs.conditionTypeCompareYearDifferenceDdMmYyyy)));


        // CONDITIONAL ELEMENT. REQUIRES 'existingBankMember' = 'Yes'
        public Element accountNumberBox => new Element(FindElement("AccountNumberTextBox"),
            new ConditionList()
                .Add(new Condition("HEBS_EAP04", "existingBankMemberRbtn", Defs.radioButtonYes))
                .Add(new Condition("HEBS_EAP00", "productType", "Child", Defs.conditionTypeNotEqual))
                .Add(new Condition("HEBS_EAP04", "dateOfBirth", ">=16", Defs.conditionTypeCompareYearDifferenceDdMmYyyy)));

        public Element permanentUKResidentRbtn => new Element(new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radPermanentRightsToResideInUK_btn_rbl", "_0"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radPermanentRightsToResideInUK_btn_rbl", "_1")),
            new ConditionList()
                .Add(new Condition(className, "dateOfBirth", ">=16", Defs.conditionTypeCompareYearDifferenceDdMmYyyy)));

        public Element currentlyUkResident => new Element(new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsUkResident", "rbl_0"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsUkResident", "rbl_1")),
            new ConditionList()
                .Add(new Condition(className, "dateOfBirth", ">=16", Defs.conditionTypeCompareYearDifferenceDdMmYyyy)));
        #endregion

        #region Nationality/Tax
        public Element nationalityLookup => new Element(FindElement("ctl03_cboNationality", "!Lbl", "!Tax", tag: "select"));

        public Element dualNationalityRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HasSecondNationality_btn_rbl", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HasSecondNationality_btn_rbl", "_1")));

        // CONDITIONAL ELEMENT. REQUIRES 'dualNationalityRbtn' = 'Yes'
        public Element secondNationalityLookup => new Element(
            FindElement("cboSecondNationality"),
            new ConditionList()
                .Add(new Condition(className, "dualNationalityRbtn", "_rbl_0")));

        public Element taxResidencyLookup => new Element(FindElement("TaxResidency", "!Second", "!Nationality", tag: "select"));

        public Element taxpayerIdentificationNumber => new Element(FindElement("TaxpayerIdentificationNo"));

        #endregion

        #region Contact details
        public Section contactDetailsSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "dateOfBirth", ">=16", Defs.conditionTypeCompareYearDifferenceDdMmYyyy))));

        public Element homePhoneNumberBox => new Element(FindElement("txtHomeTel"));
        public Element workPhoneNumberBox => new Element(FindElement("txtWorkTel"));
        public Element mobilePhoneNumberBox => new Element(FindElement("txtMobile"));
        public Element preferredPhoneMethod => new Element(FindElement("PreferredContactMethod"));
        public Element preferredContactMethodLookup => new Element(FindElement("PreferredCorrespondenceMethod"));
        public Element emailAddressBox => new Element(FindElement("txtEmailAddress"));
        public Element confirmEmailAddressBox => new Element(FindElement("txtConfirmEmailAddress"));
        public Element wouldYouLikeToReceivePaperlessStatementsRbtn => new Element(
            new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("RequiresPaperlessStatements", "_rbl_0"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("RequiresPaperlessStatements", "_rbl_1")));

        public SectionEnd contactDetailsSectionEnd => new SectionEnd();
        #endregion

        #region Current residential address
        public Element residentialStatusLookup => new Element(FindElement("ResidentialStatus"));
        public Element postcodeBox => new Element(FindElement("SearchPostCode"));
        public Element houseNumberBox => new Element(FindElement("SearchAddressLine"));
        public Element findAddress => new Element(FindElement("SearchButton")).SetIsButtonFlag(true);
        public WaitFor waitForAddressLbl => new WaitFor(findAddress)
            .AddWaitElement(addressLbl.locator);
        public Element addressLbl => new Element(FindElement("GetFullAddress")).SetCompletePageFlag(false);
        public Element selectAddress => new Element(FindElement("SelectAddressDropDown"),
            new ConditionList()
                .Add(new Condition(findAddress.locator, Defs.elementDisplayed)));
        // CONDITIONAL SECTION. REQUIRES 'findAddressButton' TO BE CLICKED
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

        #region Keeping you informed

        public Element keepYouInformedRbtn => new Element(new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AllowedAnyMarketing", "_rbl_0"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AllowedAnyMarketing", "_rbl_1")),
            new ConditionList()
                .Add(new Condition(className, "dateOfBirth", ">=18", Defs.conditionTypeCompareYearDifferenceDdMmYyyy)));

        public Section keepingInformedSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "dateOfBirth", ">=18", Defs.conditionTypeCompareYearDifferenceDdMmYyyy))
            .Add(new Condition(className, "keepYouInformed", Defs.radioButtonYes))));

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

        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class HEBS_EAP04Data : PageData
    {
        public HEBS_EAP04Data()
        {
            uniqueIdentifier = UniqueStringGenerator();
            emailAddress = UniqueStringGenerator() + "@automation.test";
            confirmEmailAddress = emailAddress;
        }

        private string uniqueIdentifier { get; set; } = null;
        public string firstName { get; set; } = null;
        public string lastName { get; set; } = null;

        #region Your Account Application
        public string singleJointAccount { get; set; } = "Single";
        #endregion

        #region Qualifying Questions
        public string countryOfResidence { get; set; } = "United Kingdom";
        public string currentAccountWithAnotherBank { get; set; } = Defs.radioButtonYes;
        #endregion

        #region Your name
        public string title { get; set; } = null;
        public string middleName { get; set; } = "TestMName";
        #endregion

        #region Your Personal information
        public string dateOfBirth { get; set; } = "09/12/1999";
        public string countryOfBirth { get; set; } = "United Kingdom";
        public string placeOfBirth { get; set; } = "London";
        public string gender { get; set; } = "Male";
        public string maritalStatus { get; set; } = "Single";
        public string nationalInsuranceNumber { get; set; } = "AB123456D";
        public string existingBankMember { get; set; } = Defs.radioButtonNo;
        public string permanentUKResident { get; set; } = Defs.radioButtonYes;
        public string currentlyUkResident { get; set; } = Defs.radioButtonYes;
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
        public string preferredPhoneMethod { get; set; } = "Mobile";
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

        #region Keeping you informed
        public string keepYouInformed { get; set; } = Defs.radioButtonYes;
        public string contactByPhone { get; set; } = Defs.radioButtonYes;
        public string contactByPost { get; set; } = Defs.radioButtonYes;
        public string contactByEmail { get; set; } = Defs.radioButtonYes;
        public string contactByText { get; set; } = Defs.radioButtonYes;
        #endregion
    }
}
