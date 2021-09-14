using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP05 : WebBasePage
    {
        public EAP05()
        {
            pageLoadedElement = numberOfSignatoriesRbtn;
            correspondingDataClass = new EAP05Data().GetType();
            textName = "Signatory Information";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("ProductSelection", "productType", "Corporate"))));
        }


        #region Your Account Application
        

        public Element numberOfSignatoriesRbtn => new Element(new RadioButton()
                .AddRadioButtonElement("1", FindElement("NumberOfOtherApplicants", "_0"))
                .AddRadioButtonElement("2", FindElement("NumberOfOtherApplicants", "_1"))
                .AddRadioButtonElement("3", FindElement("NumberOfOtherApplicants", "_2"))
                .AddRadioButtonElement("4", FindElement("NumberOfOtherApplicants", "_3"))
            );


        #endregion


        #region Signatory 1


        #region Qualifying Questions

        public Element countryOfResidenceLookup => new Element(FindElement("cboCoR"));

        public Element currentAccountWithAnotherBankRbtn => new Element(new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radHoldsOtherAccount_btn", "_rbl_0"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radHoldsOtherAccount_btn", "_rbl_1"))
            );        

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

        public Element existingBankMemberRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radExistingCustomer_btn_rbl", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radExistingCustomer_btn_rbl", "_1")));

        // CONDITIONAL ELEMENT. REQUIRES 'existingBankMember' = 'Yes'
        public Element accountNumberBox => new Element(
            FindElement("AccountNumberTextBox"), new ConditionList()
            .Add(new Condition("EAP04", "existingBankMemberRbtn", "_rbl_0")));

        public Element permanentUKResidentRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radPermanentRightsToResideInUK_btn_rbl", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radPermanentRightsToResideInUK_btn_rbl", "_1")));

        public Element nationalInsuranceNumberBox => new Element(FindElement("NINumber"));

        #endregion


        #region Nationality/Tax
        public Element nationalityLookup => new Element(FindElement("ctl03_cboNationality", "!Lbl", "!Tax"));

        public Element dualNationalityRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HasSecondNationality_btn_rbl", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HasSecondNationality_btn_rbl", "_1")));

        // CONDITIONAL ELEMENT. REQUIRES 'dualNationalityRbtn' = 'Yes'
        public Element secondNationalityLookup => new Element(
            FindElement("cboSecondNationality"),
            new ConditionList()
                .Add(new Condition(className, "dualNationalityRbtn", "_rbl_0")));

        public Element taxResidencyLookup => new Element(FindElement("TaxResidency", "!Second", "!Nationality", tag: "select"));

        public Element dualResidencyRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HasSecondTaxResidency_btn", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HasSecondTaxResidency_btn", "_rbl_1")));

        // CONDITIONAL ELEMENT. REQUIRES 'dualResidencyRbtn' = 'Yes'
        public Element secondResidencyLookup => new Element(FindElement("redSecondTaxResidency"),
            new ConditionList()
                .Add(new Condition(className, "dualResidencyRbtn", "_rbl_0")));

        public Element taxpayerIdentificationNumber => new Element(FindElement("TaxpayerIdentificationNo"));
        #endregion


        #region Contact details


        public Element positionInBusinessLookup => new Element(FindElement("JobTitleTextBox", tag: "select"));
        public Element workPhoneNumberBox => new Element(FindElement("txtWorkTel"));
        public Element mobilePhoneNumberBox => new Element(FindElement("txtMobile"));
        public Element preferredPhoneContactMethod => new Element(FindElement("ddlPreferredContactMethod"));
        public Element emailAddressBox => new Element(FindElement("txtEmailAddress"));
        public Element confirmEmailAddressBox => new Element(FindElement("txtConfirmEmailAddress"));
        public Element preferredContactMethod => new Element(FindElement("ddlPreferredCorrespondenceMethod"));
        public Element wouldYouLikeToReceivePaperlessStatements => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("RequiresPaperlessStatements", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("RequiresPaperlessStatements", "_rbl_1")));

        #endregion


        #region Current residential address



        public Element postcodeBox => new Element(FindElement("SearchPostCode"));

        public Element houseNumberBox => new Element(FindElement("SearchAddressLine"));

        public Element findAddressBtn => new Element(FindElement("SearchButton")).SetIsButtonFlag(true);

        public WaitFor waitForAddressSearch => new WaitFor(findAddressBtn)
            .AddWaitElement(addressLbl.locator);

        public Element addressLbl => new Element(FindElement("GetFullAddress"))
            .SetCompletePageFlag(false);


        // CONDITIONAL SECTION. REQUIRES 'findAddressButton' TO BE CLICKED
        public Element selectAddress => new Element(FindElement("SelectAddressDropDown"),
            new ConditionList()
            .Add(new Condition(findAddressBtn.locator, Defs.elementDisplayed)));

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
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AllowedAnyMarketing", "_rbl_1")));

        public Section keepingInformedSection => new Section(new Element(new ConditionList()
            //.Add(new Condition("ProductSelection", "productType", "Child", Defs.conditionTypeNotEqual))
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


        #endregion

        public Element nextBtn => new Element(FindElement("_Next")).SetIsButtonFlag(true);
    }

    public class EAP05Data : PageData
    {
        public EAP05Data()
        {
            uniqueIdentifier = UniqueStringGenerator();
            emailAddress = uniqueIdentifier + "@automation.test";
            confirmEmailAddress = emailAddress;
        }

        private string uniqueIdentifier { get; set; } = null;
        
        #region Your Account Application


        public string numberOfSignatories { get; set; } = "1";


        #endregion


        #region Signatory 1


        #region Qualifying Questions


        public string countryOfResidence { get; set; } = "United Kingdom";


        public string currentAccountWithAnotherBank { get; set; } = Defs.radioButtonYes;


        #endregion


        #region Your name


        public string title { get; set; } = null;

        public string firstName { get; set; } = null;

        public string middleName { get; set; } = "TestMName";

        public string lastName { get; set; } = null;

        #endregion


        #region Your Personal information


        public string dateOfBirth { get; set; } = "09/12/1999";


        public string countryOfBirth { get; set; } = "United Kingdom";


        public string placeOfBirth { get; set; } = "London";


        public string gender { get; set; } = "Male";


        public string existingBankMember { get; set; } = Defs.radioButtonNo;


        public string permanentUKResident { get; set; } = Defs.radioButtonYes;


        public string nationalInsuranceNumber { get; set; } = "JW123456C";


        #endregion


        #region Nationality/Tax


        public string nationality { get; set; } = "British";


        public string dualNationality { get; set; } = Defs.radioButtonNo;


        public string taxResidency { get; set; } = "United Kingdom";


        public string dualResidency { get; set; } = Defs.radioButtonNo;


        public string taxpayerIdentificationNumber { get; set; } = "1859";


        #endregion


        #region Contact details
        public string positionInBusiness { get; set; } = "Director";
        public string workPhoneNumber { get; set; } = "01002003004";
        public string mobilePhoneNumber { get; set; } = "07740000000";
        public string preferredPhoneContactMethod { get; set; } = "Mobile";
        public string emailAddress { get; set; } = null;
        public string confirmEmailAddress { get; set; } = "nathan.welch@dpr.co.uk";
        public string preferredContactMethod { get; set; } = "Email";
        public string wouldYouLikeToReceivePaperlessStatements { get; set; } = Defs.radioButtonYes;
        #endregion


        #region Current residential address

        public string postcode { get; set; } = "CM16JN";

        public string houseNumber { get; set; } = "27";

        public string movedToCurrentAddress { get; set; } = "01/2000";


        #endregion


        #region Keeping you informed
        public string keepYouInformed { get; set; } = Defs.radioButtonYes;
        public string contactByPhone { get; set; } = Defs.radioButtonYes;
        public string contactByPost { get; set; } = Defs.radioButtonYes;
        public string contactByEmail { get; set; } = Defs.radioButtonYes;
        public string contactByText { get; set; } = Defs.radioButtonYes;
        #endregion


        #endregion

    }
}
