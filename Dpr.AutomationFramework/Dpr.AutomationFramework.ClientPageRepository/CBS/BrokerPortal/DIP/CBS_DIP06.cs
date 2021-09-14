using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;


namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP06 : WebBasePage
    {
        public CBS_DIP06()
        {
            pageLoadedElement = title;
            correspondingDataClass = new CBS_DIP06Data().GetType();
            textName = "CBS Applicant 1 Details Page";
        }

        public Element numberOfApplicants => new Element(new RadioButton()
            .AddRadioButtonElement("1", FindElement("NumberOfApplicants", "_0", tag: "input"))
            .AddRadioButtonElement("2", FindElement("NumberOfApplicants", "_1", tag: "input"))
            .AddRadioButtonElement("3", FindElement("NumberOfApplicants", "_2", tag: "input"))
            .AddRadioButtonElement("4", FindElement("NumberOfApplicants", "_3", tag: "input")));

        #region 'Personal Details' Section
        public Element title => new Element(FindElement("cboTitle", tag: "select"));
        public Element firstName => new Element(FindElement("txtFirstName", tag: "input"));
        public Element middleName => new Element(FindElement("txtMiddleName", tag: "input"));
        public Element surname => new Element(FindElement("txtSurname", tag: "input"));
        public Element gender => new Element(FindElement("cboGender", tag: "select"),
            new ConditionList()
                .Add(new Condition("CBS_DIP04", "termRequirements", "RIO")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_DIP04", "termRequirements", "Both")));
        public Element dateOfBirth => new Element(FindElement("txtDateOfBirth", tag: "input"));
        public Element estimatedRetirementAge => new Element(FindElement("txtEstimatedRetirementAge", tag: "input"));
        public Element nationality => new Element(FindElement("cboNationality", tag: "select"));
        public Element diplomaticImmunity => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radDiplomaticImmunity_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radDiplomaticImmunity_btn_rbl_1", tag: "input")));
        //public Element rightToResideInUK => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radPermanentRightsToResideInUK_btn_rbl_0", tag: "input"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radPermanentRightsToResideInUK_btn_rbl_1", tag: "input")));
        public Element lengthOfResidencyYears => new Element(FindElement("txtYearsInUK", tag: "input"));
        public Element lengthOfResidencyMonths => new Element(FindElement("txtMonthsInUK", tag: "input"));
        public Element fromBirth => new Element(FindElement("chkFromBirth", tag: "input"));
        public Element existingCustomer => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radExistingCustomer_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radExistingCustomer_btn_rbl_1", tag: "input")));
        public Element maritalStatus => new Element(FindElement("cboMaritialStatus", tag: "select"));
        #endregion

        #region 'UK Address' Section
        public Element emailAddress => new Element(FindElement("txtEmailAddress", tag: "input"));
        public Element confirmEmailAddress => new Element(FindElement("txtConfirmEmailAddress", tag: "input"));
        #endregion

        #region 'Previous Names' Section 
        public Element previousName => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AnyPreviousName_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AnyPreviousName_btn_rbl_1")));
        //Has the applicant ever been known by another name in the last 6 years?
        public Element applicantKnownByAnotherNameInLast6YearsRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AnyPreviousName_btn", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AnyPreviousName_btn", "_1")));

        //Previous Names - row 1

        public Element previousNameTitleLookup_1 => new Element(FindElement("Title", "item0", "!Other"),
            new ConditionList()
            .Add(new Condition(className, "applicantKnownByAnotherNameInLast6Years", Defs.radioButtonYes)));

        public Element previousNameTitleOtherBox_1 => new Element(FindElement("Title", "item0", "Other"),
            new ConditionList()
            .Add(new Condition(className, "applicantKnownByAnotherNameInLast6Years", Defs.radioButtonYes))
            .Add(new Condition(className, "previousNameTitle_1", "Other")));

        public Element previousNameFirstNameBox_1 => new Element(FindElement("FirstName", "item0"),
            new ConditionList()
            .Add(new Condition(className, "applicantKnownByAnotherNameInLast6Years", Defs.radioButtonYes)));

        public Element previousNameMiddleNameBox_1 => new Element(FindElement("MiddleName", "item0"),
            new ConditionList()
            .Add(new Condition(className, "applicantKnownByAnotherNameInLast6Years", Defs.radioButtonYes)));

        public Element previousNameSurnameBox_1 => new Element(FindElement("Surname", "item0"),
            new ConditionList()
            .Add(new Condition(className, "applicantKnownByAnotherNameInLast6Years", Defs.radioButtonYes)));


        //Previous Names - row 2
        public Element previousNameTitleLookup_2 => new Element(FindElement("Title", "item1", "!Other"),
            new ConditionList()
            .Add(new Condition(className, "applicantKnownByAnotherNameInLast6Years", Defs.radioButtonYes))
            .Add(new Condition(className, "previousNameTitle_2", null, Defs.conditionTypeNotEqual)),
            addMoreBtn);
        public Element previousNameTitleOtherBox_2 => new Element(FindElement("Title", "item1", "Other"),
            new ConditionList()
            .Add(new Condition(className, "applicantKnownByAnotherNameInLast6Years", Defs.radioButtonYes))
            .Add(new Condition(className, "previousNameTitle_2", "Other")));

        public Element previousNameFirstNameBox_2 => new Element(FindElement("FirstName", "item1"),
            new ConditionList()
            .Add(new Condition(className, "applicantKnownByAnotherNameInLast6Years", Defs.radioButtonYes))
            .Add(new Condition(className, "previousNameTitle_2", null, Defs.conditionTypeNotEqual)),
            addMoreBtn);

        public Element previousNameMiddleNameBox_2 => new Element(FindElement("MiddleName", "item1"),
            new ConditionList()
            .Add(new Condition(className, "applicantKnownByAnotherNameInLast6Years", Defs.radioButtonYes))
            .Add(new Condition(className, "previousNameTitle_2", null, Defs.conditionTypeNotEqual)),
            addMoreBtn);

        public Element previousNameSurnameBox_2 => new Element(FindElement("Surname", "item1"),
            new ConditionList()
            .Add(new Condition(className, "applicantKnownByAnotherNameInLast6Years", Defs.radioButtonYes))
            .Add(new Condition(className, "previousNameTitle_2", null, Defs.conditionTypeNotEqual)),
            addMoreBtn);
        //Previous Names - row 3
        public Element previousNameTitleLookup_3 => new Element(FindElement("Title", "item2", "!Other"),
            new ConditionList()
            .Add(new Condition(className, "previousNameTitle_3", null, Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "applicantKnownByAnotherNameInLast6Years", Defs.radioButtonYes)),
            addMoreBtn);

        public Element previousNameTitleOtherBox_3 => new Element(FindElement("Title", "item2", "Other"),
            new ConditionList()
            .Add(new Condition(className, "applicantKnownByAnotherNameInLast6Years", Defs.radioButtonYes))
            .Add(new Condition(className, "previousNameTitle_3", "Other")));


        public Element previousNameFirstNameBox_3 => new Element(FindElement("FirstName", "item2"),
            new ConditionList()
            .Add(new Condition(className, "applicantKnownByAnotherNameInLast6Years", Defs.radioButtonYes))
            .Add(new Condition(className, "previousNameTitle_3", null, Defs.conditionTypeNotEqual)),
            addMoreBtn);

        public Element previousNameMiddleNameBox_3 => new Element(FindElement("MiddleName", "item2"),
            new ConditionList()
            .Add(new Condition(className, "applicantKnownByAnotherNameInLast6Years", Defs.radioButtonYes))
            .Add(new Condition(className, "previousNameTitle_3", null, Defs.conditionTypeNotEqual)),
            addMoreBtn);

        public Element previousNameSurnameBox_3 => new Element(FindElement("Surname", "item2"),
            new ConditionList()
            .Add(new Condition(className, "applicantKnownByAnotherNameInLast6Years", Defs.radioButtonYes))
            .Add(new Condition(className, "previousNameTitle_3", null, Defs.conditionTypeNotEqual)),
            addMoreBtn);
        public Element addMoreBtn => new Element(FindElement("PreviousNameRepeater", "btnAdd"))
            .SetCompletePageFlag(false);
        #endregion

        #region 'Company Association' Section
        public Section companyAssociationSection => new Section(new Element(new ConditionList()
            .Add(new Condition("CBS_DIP02", "applicantType", "Limited Company"))));
        public Element company_1 => new Element(FindElement("CompanyAssociationRepeater", "item0", "CboCompany", tag: "select"));
        public Element roleWithinCompany_1 => new Element(FindElement("CompanyAssociationRepeater", "item0", "CboRolewithinBusiness", tag: "select"));
        public Element percentageShareholding_1 => new Element(FindElement("CompanyAssociationRepeater", "item0", "txtShareholding", tag: "input"));
        public SectionEnd companyAssociationSectionEnd => new SectionEnd();
        #endregion

        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class CBS_DIP06Data : PageData
    {
        public string numberOfApplicants { get; set; } = "1";
        public string title { get; set; } = "Mr";
        public string firstName { get; set; } = "Otto";
        public string middleName { get; set; } = "May";
        public string surname { get; set; } = "Shun##01";
        public string gender { get; set; } = "Male";
        public string dateOfBirth { get; set; } = "09/12/1997";
        public string estimatedRetirementAge { get; set; } = "75";
        public string nationality { get; set; } = "British";
        public string diplomaticImmunity { get; set; } = Defs.radioButtonNo;
        //public string rightToResideInUK { get; set; } = Defs.radioButtonYes;
        public string lengthOfResidencyYears { get; set; } = string.Empty;
        public string lengthOfResidencyMonths { get; set; } = string.Empty;
        public string fromBirth { get; set; } = Defs.checkBoxSelected;
        public string existingCustomer { get; set; } = Defs.radioButtonNo;
        public string maritalStatus { get; set; } = "Single";
        public string emailAddress { get; set; } = "test@test.com";
        public string confirmEmailAddress { get; set; } = "test@test.com";
        public string previousName { get; set; } = Defs.radioButtonNo;

        #region 'Previous Names' Data section 
        public string previousNameTitle_1 { get; set; } = "Mr";
        public string previousNameTitleOther_1 { get; set; } = "Master";
        public string previousNameFirstName_1 { get; set; } = "Previous1";
        public string previousNameMiddleName_1 { get; set; } = "Name1";
        public string previousNameSurname_1 { get; set; } = "Test##01";

        public string previousNameTitle_2 { get; set; } = null;
        public string previousNameTitleOther_2 { get; set; } = null;
        public string previousNameFirstName_2 { get; set; } = null;
        public string previousNameMiddleName_2 { get; set; } = null;
        public string previousNameSurname_2 { get; set; } = null;

        public string previousNameTitle_3 { get; set; } = null;
        public string previousNameTitleOther_3 { get; set; } = null;
        public string previousNameFirstName_3 { get; set; } = null;
        public string previousNameMiddleName_3 { get; set; } = null;
        public string previousNameSurname_3 { get; set; } = null;
        #endregion

        #region 'Company Association' Data Section
        public string company_1 { get; set; } = null;
        public string roleWithinCompany_1 { get; set; } = "Director";
        public string percentageShareholding_1 { get; set; } = "25";
        #endregion
    }
}
