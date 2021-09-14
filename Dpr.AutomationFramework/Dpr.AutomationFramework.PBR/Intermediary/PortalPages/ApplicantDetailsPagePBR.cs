using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PBR.Intermediary.PortalPages
{
    class ApplicantDetailsPagePBR : WebBasePage
    {
        public ApplicantDetailsPagePBR()
        {
            pageLoadedElement = titleLookup;
            correspondingDataClass = new ApplicantDetailsData().GetType();
            javascriptPageNavigator = @"javascript:__doPostBack('ctl00$MC$Menu1','bApplicant1Details\\AddAmendApplicant')";
        }

        #region Applicants section locators
        //Number of applicants
        public Element numberOfApplicantsRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("1", FindElement("NumberOfApplicants", "_0"))
            .AddRadioButtonElement("2", FindElement("NumberOfApplicants", "_1")));

        #endregion

        #region Personal Detail section locators

        public Element titleLookup => new Element(FindElement("cboTitle"));

        public Element titleOtherBox => new Element(FindElement("OtherTitle", "!item"),
        new ConditionList()
            .Add(new Condition(className, "title", "Other")));

        public Element firstNameBox => new Element(FindElement("txtFirstName"));
        public Element middleNameBox => new Element(FindElement("txtMiddleName"));
        public Element surnameBox => new Element(FindElement("txtSurname"));
        public Element dateOfBirthBox => new Element(FindElement("DateOfBirth"))
            .SetValidationType(Defs.validationTypeDdMmYyyy);

        /**********************************PBR Field**********************************/

        public Element countryOfBirthBox => new Element(FindElement("CountryOfBirth", "!item"));

        /**********************************PBR Field End**********************************/

        public Element niNumberBox => new Element(FindElement("NIN"))
             .SetValidationType(Defs.validationTypeNiNumber);
        public Element estimatedRetirementAgeBox => new Element(FindElement("EstimatedRetirementAge"));
        //public Element genderLookup => new Element(FindElement("Gender"));
        public Element nationalityLookup => new Element(FindElement("Nationality"));

        
        /**********************************PBR Field**********************************/
        public Element residencyLookup => new Element(FindElement("Residency"));

        /**********************************PBR Field  End**********************************/

        public Element applicantHaveRightToResideInUkRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("PermanentRightsToResideInUK", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("PermanentRightsToResideInUK", "_1")));


        public Element fromBirthChbox => new Element(FindElement("FromBirth"));

        public Element lengthOfResidencyYearsBox => new Element(FindElement("YearsInUK"),
            new ConditionList()
            .Add(new Condition(className, "fromBirth", Defs.checkBoxNotSelected)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition(className, "fromBirth", null)));

        public Element lengthOfResidencyMonthsBox => new Element(FindElement("MonthsInUK"),
            new ConditionList()
            .Add(new Condition(className, "fromBirth", Defs.checkBoxNotSelected)))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition(className, "fromBirth", null)));

        public Element applicantDiplomaticImmunityRbtn => new Element(new RadioButton()
           .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radDiplomaticImmunity", "_0"))
           .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radDiplomaticImmunity", "_1")));

        public Element maritalStatusLookup => new Element(FindElement("MaritialStatus"));

        public Element existingRelationshipWithPBRRbtn => new Element(new RadioButton()
           .AddRadioButtonElement(Defs.radioButtonYes, FindElement("FactfindList", "rbl_0", "ctl63"))
           .AddRadioButtonElement(Defs.radioButtonNo, FindElement("FactfindList", "rbl_1", "ctl63"))
           .AddRadioButtonElement("Dont know", FindElement("FactfindList", "_2")));

        public Element existingAldermoreResidentialMemberRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ExistingCustomer", "_0", attributeType: Defs.locatorClass))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ExistingCustomer", "_1")));


        public Element homeTelephoneBox => new Element(FindElement("HomeTelephone"));

        public Element mobileTelephoneBox => new Element(FindElement("MobilePhone"));

        public Element attorneyActingRbtn => new Element(new RadioButton()
          .AddRadioButtonElement(Defs.radioButtonYes, FindElement("qffAnyPowerOfAttorneys", "_0"))
          .AddRadioButtonElement(Defs.radioButtonNo, FindElement("qffAnyPowerOfAttorneys", "_1")));


        #endregion

        #region Previous Names section locators
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


        public Element nextBtn => new Element(FindElement("Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);

    }


    public class ApplicantDetailsData : PageData
    {
        public string numberOfApplicants { get; set; } = "1";
        public string title { get; set; } = "Mr";
        public string titleOther { get; set; } = "Sir";
        public string firstName { get; set; } = "Test";
        public string middleName { get; set; } = "Test";
        public string surname { get; set; } = "Test##01";
        public string dateOfBirth { get; set; } = "01/01/1990";
        public string countryOfBirth { get; set; } = "United Kingdom";
        public string niNumber { get; set; } = "JE123456a";
        public string estimatedRetirementAge { get; set; } = "70";
        public string gender { get; set; } = "Male";
        public string nationality { get; set; } = "British"; 
        public string residency { get; set; } = "United Kingdom";
        public string applicantHaveRightToResideInUk { get; set; } = Defs.radioButtonYes;
        public string lengthOfResidencyYears { get; set; } = "6";
        public string lengthOfResidencyMonths { get; set; } = "20";
        public string fromBirth { get; set; } = Defs.checkBoxNotSelected;

        public string applicantDiplomaticImmunity { get; set; } = Defs.radioButtonNo;
        public string maritalStatus { get; set; } = "Single"; 

        public string existingRelationshipWithPBR { get; set; } = Defs.radioButtonNo;

        public string existingAldermoreResidentialMember { get; set; } = Defs.radioButtonNo;
        public string applicantKnownByAnotherNameInLast6Years { get; set; } = Defs.radioButtonNo;

        public string homeTelephone { get; set; } = "0207787675633";

        public string mobileTelephone { get; set; } = "07856734567"; 

        public string attorneyActing { get; set; } = Defs.radioButtonNo;


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
    }
}
    

