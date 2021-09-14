using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP10 : Applicant1EmploymentSummaryPage
    {
        public CBS_DIP10()
        {
            pageLoadedElement = applicantName;
            correspondingDataClass = new CBS_DIP10Data().GetType();
            textName = "CBS Applicant 1 Employment Summary";
        }

        public new Element areYouABasicRateTaxPayer => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsBasicRateTaxPayer", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsBasicRateTaxPayer", "rbl_1")), 
            new ConditionList()
                .Add(new Condition("CBS_DIP02", "loanType", "BTL")));


        #region Lending into Retirement Section

        public new Element doYouHaveAnySourceOfIncomeIntoRetirement => new Element(new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("FutureIncomeDetails1_ctl00_pnlApplicantPanel_ctl00_ctl00_FactfindList_ctl00_ctl00_rbl_0", tag: "input"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("FutureIncomeDetails1_ctl00_pnlApplicantPanel_ctl00_ctl00_FactfindList_ctl00_ctl00_rbl_1", tag: "input")),
            new ConditionList()
                .Add(new Condition("CBS_DIP04", "termRequirements", "RIO")));


        public new Section retirementIncomeYes => new Section(new Element(
            new ConditionList()
                .Add(new Condition(className, "doYouHaveAnySourceOfIncomeIntoRetirement", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_DIP04", "termRequirements", "RIO"))));

        public new Element retirementSource1 => new Element(FindElement("FutureIncomeSource", "item0")/*, new ConditionList()
            .Add(new Condition(className, "applicationSubmittedViaMortgageClub", Defs.radioButtonYes))*/);

        public new Element retirementSpousalBenefit1 => new Element(FindElement("FutureIncomeDetails1", "SpousalBenefit", "item0"));

        public new Element retirementAnnualAmount1 => new Element(FindElement("FutureIncomeAmount", "item0")/*, new ConditionList()
            .Add(new Condition(className, "applicationSubmittedViaMortgageClub", Defs.radioButtonYes))*/);

        public new Element retirementSource2 => new Element(FindElement("FutureIncomeSource", "item1"), null, retirementAdd.locator);

        public new Element retirementAnnualAmount2 => new Element(FindElement("FutureIncomeAmount", "item1"), null, retirementAdd.locator);

        public new Element retirementSpousalBenefit2 => new Element(FindElement("FutureIncomeDetails1", "SpousalBenefit", "item1"));

        public new Element retirementSource3 => new Element(FindElement("FutureIncomeSource", "item2"), null, retirementAdd.locator);

        public new Element retirementAnnualAmount3 => new Element(FindElement("FutureIncomeAmount", "item2"), null, retirementAdd.locator);

        public new Element retirementSpousalBenefit3 => new Element(FindElement("FutureIncomeDetails1", "SpousalBenefit", "item2"));

        public new Element retirementAdd => new Element(FindElement("_MortgageClub"), new ConditionList()
            .Add(new Condition(className, "applicationSubmittedViaMortgageClub", Defs.radioButtonYes)))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public new SectionEnd retirementIncomeYesEnd => new SectionEnd();
        #endregion  

        #region 'Other Sources of Income' Section
        public Element otherSourcesOfIncome => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl00_ctl00_FactfindList_ctl00_ctl00_rbl_0", "!FutureIncomeDetails1_ctl00", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl00_ctl00_FactfindList_ctl00_ctl00_rbl_1", "!FutureIncomeDetails1_ctl00", tag: "input")));

        public Section hasOtherIncomeSection => new Section(new Element(new ConditionList()
                .Add(new Condition(className, "otherSourcesOfIncome", Defs.radioButtonYes))));

        #region Other Income Row 1
        public Element source_1 => new Element(FindElement("item0", "OtherIncomeYear1Source", tag: "select"));
        public Element annualAmount_1 => new Element(FindElement("item0", "OtherIncomeYear1Amount", tag: "input"));
        public Element spousalBenefit_1 => new Element(FindElement("item0", "SpousalBenefitYear1", tag: "input"));
        #endregion

        #region Repayment Strategy Summary Row 2
        public Element source_2 => new Element(FindElement("item1", "OtherIncomeYear1Source", tag: "select"),
            new ConditionList()
                .Add(new Condition(className, "source_2", null, Defs.conditionTypeNotEqual)),
                otherIncomeAddMore);
        public Element annualAmount_2 => new Element(FindElement("item1", "OtherIncomeYear1Amount", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "source_2", null, Defs.conditionTypeNotEqual)),
                otherIncomeAddMore);
        public Element spousalBenefit_2 => new Element(FindElement("item1", "SpousalBenefitYear1", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "source_2", null, Defs.conditionTypeNotEqual)),
                otherIncomeAddMore);
        #endregion

        #region Repayment Strategy Summary Row 3 
        public Element source_3 => new Element(FindElement("item2", "OtherIncomeYear1Source", tag: "select"),
            new ConditionList()
                .Add(new Condition(className, "repaymentStrategy_3", null, Defs.conditionTypeNotEqual)),
                otherIncomeAddMore);
        public Element annualAmount_3 => new Element(FindElement("item2", "OtherIncomeYear1Amount", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "source_3", null, Defs.conditionTypeNotEqual)),
                otherIncomeAddMore);
        public Element spousalBenefit_3 => new Element(FindElement("item2", "SpousalBenefitYear1", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "source_3", null, Defs.conditionTypeNotEqual)),
                otherIncomeAddMore);
        #endregion

        public Element otherIncomeAddMore => new Element(FindElement("rptOtherIncomeRepeater", "btnAdd"))
            .SetCompletePageFlag(false);

        public SectionEnd hasOtherIncomeSectionEnd => new SectionEnd();
        #endregion
    }

    public class CBS_DIP10Data : Applicant1EmploymentSummaryPageData
    {
        public new string areYouABasicRateTaxPayer { get; set; } = Defs.radioButtonYes;

        #region Lending into Retirement
        //Values changed to null until fully implemented
        public new string doYouHaveAnySourceOfIncomeIntoRetirement { set; get; } = null;//Defs.radioButtonYes;

        public new string retirementSource1 { set; get; } = "Private Occupational Pension";//"Private Occupational Pension";

        public new string retirementAnnualAmount1 { set; get; } = "90000";//"90000";
        public new string retirementSpousalBenefit1 { set; get; } = "100";

        public new string retirementSource2 { set; get; } = null;

        public new string retirementAnnualAmount2 { set; get; } = null;
        public new string retirementSpousalBenefit2 { set; get; } = null;

        public new string retirementSource3 { set; get; } = null;

        public new string retirementAnnualAmount3 { set; get; } = null;
        public new string retirementSpousalBenefit3 { set; get; } = null;

        #endregion

        #region 'Other Income' Data Section
        public string otherSourcesOfIncome { get; set; } = Defs.radioButtonNo;
        #region Other Income Row 1
        public string source_1 { get; set; } = "Other";
        public string annualAmount_1 { get; set; } = "30000";
        public string spousalBenefit_1 { get; set; } = "50";
        #endregion

        #region Other Income Row 2
        public string source_2 { get; set; } = null;
        public string annualAmount_2 { get; set; } = null;
        public string spousalBenefit_2 { get; set; } = null;
        #endregion

        #region Other Income Row 3
        public string source_3 { get; set; } = null;
        public string annualAmount_3 { get; set; } = null;
        public string spousalBenefit_3 { get; set; } = null;
        #endregion

        #endregion
    }
}
