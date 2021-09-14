using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant1EmploymentSummaryPage : WebBasePage
    {

        public Applicant1EmploymentSummaryPage()
        {
            pageLoadedElement = applicantName;
            correspondingDataClass = new Applicant1EmploymentSummaryPageData().GetType();
            textName = "Applicant 1 Employment Summary";
        }

        #region Primary Employment Summary

        public Element applicantName => new Element(FindElement("lblPrimaryApplicantName"))
            .SetCompletePageFlag(false);

        public Element companyName => new Element(FindElement("lblPrimaryCompanyName"))
            .SetCompletePageFlag(false);

        public Element status => new Element(FindElement("lblEmploymentTypePrimary"))
            .SetCompletePageFlag(false);

        public Element ownershipType => new Element(FindElement("lblCompanyTypePrimary"))
            .SetCompletePageFlag(false);

        public Element edit => new Element(FindElement("btnEditPrimaryIncome"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element delete => new Element(FindElement("btnRemovePrimaryIncome"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element employmentStatus => new Element(FindElement("EmploymentType", "ctl10"))
            .SetCompletePageFlag(false);

        public Element moreThan25pcShareOwnerOrPartnerWithLessThanPartners => new Element(new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsShareholding", "rbl_0", "ctl10"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsShareholding", "rbl_1", "ctl10")))
            .SetCompletePageFlag(false);

        public Element cancel => new Element(FindElement("btnCancelAddPrimaryIncome"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element confirm => new Element(FindElement("btnCancelAddPrimaryIncome"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        #endregion

        #region Secondary Employment Summary

        public Element secondaryApplicantName => new Element(FindElement("lblSecondaryApplicantName"))
            .SetCompletePageFlag(false);

        public Element secondaryCompanyName => new Element(FindElement("lblSecondaryCompanyName"))
            .SetCompletePageFlag(false);

        public Element secondaryStatus => new Element(FindElement("lblCurrentSecondaryEmploymentType"))
            .SetCompletePageFlag(false);

        public Element secondaryOwnershipType => new Element(FindElement("lblCompanyTypeSecondary"))
            .SetCompletePageFlag(false);

        public Element secondaryEdit => new Element(FindElement("btnEditSecondaryIncome"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element secondaryDelete => new Element(FindElement("btnRemoveSecondaryIncome"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element doesTheApplicantHaveAnySecondaryEmployment => new Element(new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl04_FactfindList", "rbl_0"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl04_FactfindList", "rbl_1")))
            .SetCompletePageFlag(false);

        public Element secondaryEmploymentStatus => new Element(FindElement("EmploymentType", "ctl11"))
            .SetCompletePageFlag(false);

        public Element secondaryMoreThan25pcShareOwnerOrPartnerWithLessThanPartners => new Element(new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsShareholding", "rbl_0", "ctl11"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsShareholding", "rbl_1", "ctl11")))
            .SetCompletePageFlag(false);

        public Element secondaryConfirm => new Element(FindElement("btnAddSecondayIncome"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);


        #endregion

        //This section only appears when retirement age - current age < mortgage term OR RIO selected.
        #region Lending into Retirement Section

        public Element doYouHaveAnySourceOfIncomeIntoRetirement => new Element(new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl00_FactfindList", "rbl_0", "FutureIncomeDetails1", tag:"input"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl00_FactfindList", "rbl_1", "FutureIncomeDetails1", tag: "input")), 
            new ConditionList()
                .Add(new Condition("LoanDetailsPage", "termRequirements", "RIO")));


        public Section retirementIncomeYes => new Section(new Element(
            new ConditionList()
                .Add(new Condition(className, "doYouHaveAnySourceOfIncomeIntoRetirement", Defs.radioButtonYes))));

        public Element retirementSource1 => new Element(FindElement("FutureIncomeSource", "item0")/*, new ConditionList()
            .Add(new Condition(className, "applicationSubmittedViaMortgageClub", Defs.radioButtonYes))*/);

        public Element retirementSpousalBenefit1 => new Element(FindElement("SpousalBenefit", "item0"));

        public Element retirementAnnualAmount1 => new Element(FindElement("FutureIncomeAmount", "item0")/*, new ConditionList()
            .Add(new Condition(className, "applicationSubmittedViaMortgageClub", Defs.radioButtonYes))*/);

        public Element retirementSource2 => new Element(FindElement("FutureIncomeSource", "item1"), null, retirementAdd.locator);

        public Element retirementAnnualAmount2 => new Element(FindElement("FutureIncomeAmount", "item1"), null, retirementAdd.locator);

        public Element retirementSpousalBenefit2 => new Element(FindElement("SpousalBenefit", "item1"));

        public Element retirementSource3 => new Element(FindElement("FutureIncomeSource", "item2"), null, retirementAdd.locator);

        public Element retirementAnnualAmount3 => new Element(FindElement("FutureIncomeAmount", "item2"), null, retirementAdd.locator);

        public Element retirementSpousalBenefit3 => new Element(FindElement("SpousalBenefit", "item2"));

        public Element retirementAdd => new Element(FindElement("_MortgageClub"), new ConditionList()
            .Add(new Condition(className, "applicationSubmittedViaMortgageClub", Defs.radioButtonYes)))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);


        public SectionEnd retirementIncomeYesEnd => new SectionEnd();
        #endregion  

        #region Other Income

        public Element doesTheApplicantHaveAnySourcesOfOtherIncome => new Element(new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl00_FactfindList", "rbl_0", "!FutureIncomeDetails1"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl00_FactfindList", "rbl_1", "!FutureIncomeDetails1")))
            .SetCompletePageFlag(false);

        public Section otherIncomeYes => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "doesTheApplicantHaveAnySourcesOfOtherIncome", Defs.radioButtonYes))));

        public Element otherSource1 => new Element(FindElement("item0_OtherIncomeYear1Source"))
            .SetCompletePageFlag(false);

        public Element otherAnnualAmount1 => new Element(FindElement("item0_OtherIncomeYear1Amount"))
            .SetCompletePageFlag(false);

        public Element otherSpousalBenefit1 => new Element(FindElement("item0_SpousalBenefitYear1"))
            .SetCompletePageFlag(false);

        public Element otherSource2 => new Element(FindElement("item1_OtherIncomeYear1Source"), null, otherAdd.locator)
            .SetCompletePageFlag(false);

        public Element otherAnnualAmount2 => new Element(FindElement("item1_OtherIncomeYear1Amount"), null, otherAdd.locator)
            .SetCompletePageFlag(false);

        public Element otherSpousalBenefit2 => new Element(FindElement("item1_SpousalBenefitYear1"), null, otherAdd.locator)
            .SetCompletePageFlag(false);

        public Element otherSource3 => new Element(FindElement("item2_OtherIncomeYear1Source"), null, otherAdd.locator)
            .SetCompletePageFlag(false);

        public Element otherAnnualAmount3 => new Element(FindElement("item2_OtherIncomeYear1Amount"), null, otherAdd.locator)
            .SetCompletePageFlag(false);

        public Element otherSpousalBenefit3 => new Element(FindElement("item2_SpousalBenefitYear1"), null, otherAdd.locator)
            .SetCompletePageFlag(false);


        public Element otherAdd => new Element(FindElement("rptOtherIncomeRepeater", "btnAdd"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(false);

        public SectionEnd otherIncomeYesEnd => new SectionEnd();


        #endregion

        #region Basic Rate Tax Payer

        public Element areYouABasicRateTaxPayer => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsBasicRateTaxPayer","rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsBasicRateTaxPayer", "rbl_1")), new ConditionList()
            .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "BTL")));


        #endregion

        #region Income Changes

        public Element awareOfChangesToIncomeAndExpenditure => new Element(new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl25_FactfindList", "rbl_0"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl25_FactfindList", "rbl_1")))
            .SetCompletePageFlag(false);

        public Element pleaseProvideDetails => new Element( FindElement("txtFurtherDetails"))
            .SetCompletePageFlag(false);

        #endregion

        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);

    }


    public class Applicant1EmploymentSummaryPageData : PageData
    {
        #region Lending into Retirement
        //Values changed to null until fully implemented
        public string doYouHaveAnySourceOfIncomeIntoRetirement { set; get; } = null;//Defs.radioButtonYes;

        public string retirementSource1 { set; get; } = "Private Occupational Pension";//"Private Occupational Pension";

        public string retirementAnnualAmount1 { set; get; } = "90000";//"90000";
        public string retirementSpousalBenefit1 { set; get; } = "100";


        public string retirementSource2 { set; get; } = null;

        public string retirementAnnualAmount2 { set; get; } = null;
        public string retirementSpousalBenefit2 { set; get; } = null;


        public string retirementSource3 { set; get; } = null;

        public string retirementAnnualAmount3 { set; get; } = null;
        public string retirementSpousalBenefit3 { set; get; } = null;

        #endregion

        #region Other Income

        public string doesTheApplicantHaveAnySourcesOfOtherIncome { set; get; } = null;

        public string otherSource1 { set; get; } = "Private Occupational Pension";

        public string otherAnnualAmount1 { set; get; } = "90000";

        public string otherSpousalBenefit1 { set; get; } = "100";

        public string otherSource2 { set; get; } = null;

        public string otherAnnualAmount2 { set; get; } = null;

        public string otherSpousalBenefit2 { set; get; } = null;

        public string otherSource3 { set; get; } = null;

        public string otherAnnualAmount3 { set; get; } = null;

        public string otherSpousalBenefit3 { set; get; } = null;




        #endregion

        public string areYouABasicRateTaxPayer { get; set; } = Defs.radioButtonYes;
    }
}
