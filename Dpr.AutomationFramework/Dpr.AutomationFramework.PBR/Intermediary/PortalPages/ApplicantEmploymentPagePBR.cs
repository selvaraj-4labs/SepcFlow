using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PBR.Intermediary.PortalPages
{
    class ApplicantEmploymentPagePBR : WebBasePage
    {
        public ApplicantEmploymentPagePBR()
        {
            pageLoadedElement = employmentStatusLookup;
            //javascriptPageNavigator = @"javascript:__doPostBack('ctl00$MC$Menu1', 'bApplicant1Details\\ApplicantEmploymentSimple')";
            correspondingDataClass = new ApplicantEmploymentDataPBR().GetType();
            //displayedAfterNextPageBackBtn = false;
        }


        #region Employment Status section locators
        //Employment status
        public Element employmentStatusLookup => new Element(FindElement("EmploymentType", "ctl01"));



        public Element ownership25pcRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsShareholding", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsShareholding", "rbl_1")),
            new ConditionList()
            .Add(new Condition(className, "employmentStatus", "Employed")));

        public Element deductionFromSalaryRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AnySalarySacrifices", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AnySalarySacrifices", "_1")));

        public Element employmentLessThan12MonthsRbtn => new Element(new RadioButton()
           .AddRadioButtonElement(Defs.radioButtonYes, FindElement("EmployedForLessThan12Months", "_0"))
           .AddRadioButtonElement(Defs.radioButtonNo, FindElement("EmployedForLessThan12Months", "_1")));



        //public Element incomeDerivedThroughProfitFromLandPropertyRbtn => new Element(new RadioButton()
        //   .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IncomeFromLandAndProperty", "Primary", "rbl_0"))
        //   .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IncomeFromLandAndPropertyPrimary", "Primary", "rbl_1")),
        //   new ConditionList()
        //   .Add(new Condition(className, "employmentStatus", "Self Employed - Sole Trader")))
        //   .AddNewConditionList(new ConditionList()
        //   .Add(new Condition(className, "employmentStatus", "Self Employed - Partnership")))
        //   .AddNewConditionList(new ConditionList()
        //   .Add(new Condition(className, "employmentStatus", "Employed"))
        //   .Add(new Condition(className, "ownership25pc", Defs.radioButtonYes)));

        #endregion

        //#region Employment Details section locator

        //public Section incomeEmployedSection => new Section(new Element(
        //    new ConditionList()
        //    .Add(new Condition(className, "employmentStatus", "Employed"))
        //    .Add(new Condition(className, "ownership25pc", Defs.radioButtonNo))));

        //public Element employedFullTimeRbtn => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("EmploymentType", "Primary", "_1", "!Self"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("EmploymentType", "Primary", "_2", "!Self")),
        //    new ConditionList()
        //    .Add(new Condition(className, "employmentStatus", "Employed"))
        //    .Add(new Condition(className, "ownership25pc", Defs.radioButtonNo)));

        //public Element employedOccupationBox => new Element(FindElement("Primary", "EmployedJobTitle"));

        //public Element employedBusinessSectorLookup => new Element(FindElement("Primary", "BusinessSector", "!Self"));

        //public Element employedStartDateBox => new Element(FindElement("Primary", "EmployedStartDate", "!Self"))
        //    .SetValidationType(Defs.validationTypeMmYyyy);


        //public Element toBox => new Element(FindElement("txtEmployedEndDate", "primary", "!Self"))
        //    .SetCompletePageFlag(false);

        //public Element stillWithinProbationaryPeriodRbtn => new Element(
        //    new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("Primary", "WithinProbationaryPeriod", "rbl_0"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("Primary", "WithinProbationaryPeriod", "rbl_1")));

        //public Element employedEndDateOfProbationaryPeriodBox => new Element(FindElement("Primary", "ProbationEndDate"),
        //    new ConditionList()
        //    .Add(new Condition(className, "stillWithinProbationaryPeriod", Defs.radioButtonYes)));

        //public Element grossAnnualSalaryBox => new Element(FindElement("Primary", "BasicSalary", "!Assessable"));

        //public Element assessableGrossAnnualSalaryBox => new Element(FindElement("Primary", "Assessable", "BasicSalary"))
        //    .SetCompletePageFlag(false);

        //public Element overtimeInLastYearBox => new Element(FindElement("Primary", "Overtime", "!Assessable"));

        //public Element assessableOvertimeInLastYearBox => new Element(FindElement("Primary", "Overtime", "Assessable"))
        //    .SetCompletePageFlag(false);

        //public Element commissionBox => new Element(FindElement("Primary", "Dividend", "!Assessable"));

        //public Element assessableCommissionBox => new Element(FindElement("Primary", "Dividend", "Assessable"))
        //    .SetCompletePageFlag(false);

        //public Element bonusBox => new Element(FindElement("Primary", "Bonus", "!Assessable"));

        //public Element assessableBonusBox => new Element(FindElement("Primary", "Bonus", "!Assessable"))
        //    .SetCompletePageFlag(false);

        //public Element allowanceBox => new Element(FindElement("Primary", "Allowance", "!Assessable"));

        //public Element assessableAllowanceBox => new Element(FindElement("Primary", "Allowance", "Assessable"))
        //    .SetCompletePageFlag(false);

        //public Element londonWeightingBox => new Element(FindElement("Primary", "LondonWeighting", "!Assessable"));


        //public Element assessableLondonWeightingBox => new Element(FindElement("Primary", "LondonWeighting", "Assessable"))
        //    .SetCompletePageFlag(false);

        //public Element calculateBtn => new Element(FindElement(new LocatorList()
        //    .Add(Defs.locatorName, "Primary")
        //    .Add(Defs.locatorName, "Simple")
        //    .Add(Defs.locatorValue, "Calculate")))
        //    .SetIsButtonFlag(true);

        //public SectionEnd incomeEmployedSectionEnd => new SectionEnd();

        //#endregion

        //#region Self-Employed Details section locators


        //public Section incomeSelfEmployedSection => new Section(new Element(
        //    new ConditionList()
        //    .Add(new Condition(className, "employmentStatus", "Self Employed - Sole Trader")))
        //    .AddNewConditionList(new ConditionList()
        //    .Add(new Condition(className, "employmentStatus", "Self Employed - Partnership")))
        //    .AddNewConditionList(new ConditionList()
        //    .Add(new Condition(className, "employmentStatus", "Employed"))
        //    .Add(new Condition(className, "ownership25pc", Defs.radioButtonYes))));


        //public Element selfEmployedFullTimeRbtn => new Element(new RadioButton()
        //           .AddRadioButtonElement(Defs.radioButtonYes, FindElement("SelfEmployedEmploymentType", "Primary", "_1"))
        //           .AddRadioButtonElement(Defs.radioButtonNo, FindElement("SelfEmployedEmploymentType", "Primary", "_2")));

        //public Element selfEmployedOccupationBox => new Element(FindElement("Primary", "SelfEmployedOccupation"));

        //public Element selfEmployedBusinessSectorLookup => new Element(FindElement("Primary", "Self", "BusinessSector"));

        //public Element selfEmployedStartDateBox => new Element(FindElement("Primary", "Self", "StartDate"))
        //    .SetValidationType(Defs.validationTypeMmYyyy);

        //public Element percentageOwnershipBox => new Element(FindElement("Primary", "Self", "PercentageShares"));

        //public Element earnedIncomeY1Box => new Element(FindElement("Primary", "Year1Profit"));

        //public Element earnedIncomeY2Box => new Element(FindElement("Primary", "Year2Profit"));

        //public Element earnedIncomeY3Box => new Element(FindElement("Primary", "Year3Profit"));

        //public Element year1EndingBox => new Element(FindElement("Primary", "YearEnding1"))
        //    .SetValidationType(Defs.validationTypeMmYyyy);

        //public Element year2EndingBox => new Element(FindElement("Primary", "YearEnding2"))
        //    .SetValidationType(Defs.validationTypeMmYyyy);

        //public Element year3EndingBox => new Element(FindElement("Primary", "YearEnding3"))
        //    .SetValidationType(Defs.validationTypeMmYyyy);


        //public SectionEnd incomeSelfEmployedSectionEnd => new SectionEnd();

        //#endregion

        #region Secondary Income section locators - General

        //public Element anyOtherEmployedSelfEmployedIncomeRbtn => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AnySecondaryIncome", "rbl_0"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AnySecondaryIncome", "rbl_1")),
        //    new ConditionList()
        //    .Add(new Condition(className, "employmentStatus", "Retired", Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "employmentStatus", "Not working", Defs.conditionTypeNotEqual)));


        public Element anyOtherEmployedSelfEmployedIncomeRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl04", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl04", "rbl_1")),
            new ConditionList()
            .Add(new Condition(className, "employmentStatus", "Retired", Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "employmentStatus", "Not working", Defs.conditionTypeNotEqual)));

        //public Element secondaryEmploymentStatusLookup => new Element(FindElement("EmploymentType","ctl02"),
        //    new ConditionList()
        //    .Add(new Condition(className, "anyOtherEmployedSelfEmployedIncome", Defs.radioButtonYes))
        //    .Add(new Condition(className, "employmentStatus", "Retired", Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "employmentStatus", "Not working", Defs.conditionTypeNotEqual)));

        //public Element secondaryOwnership25pcRbtn => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("Shareholding", "rbl_0", "Secondary"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("Shareholding", "rbl_1", "Secondary")),
        //    new ConditionList()
        //    .Add(new Condition(className, "employmentStatus", "Retired", Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "employmentStatus", "Not working", Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "secondaryEmploymentStatus", "Employed"))
        //    .Add(new Condition(className, "anyOtherEmployedSelfEmployedIncome", Defs.radioButtonYes)));


        //public Element secondaryIncomeDerivedThroughProfitFromLandPropertyRbtn => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("LandAndProperty", "rbl_0", "Secondary"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("LandAndProperty", "rbl_1", "Secondary")),
        //    new ConditionList()
        //    .Add(new Condition(className, "anyOtherEmployedSelfEmployedIncome", Defs.radioButtonYes))
        //    .Add(new Condition(className, "secondaryEmploymentStatus", "Self Employed - Sole Trader")))
        //    .AddNewConditionList(new ConditionList()
        //    .Add(new Condition(className, "anyOtherEmployedSelfEmployedIncome", Defs.radioButtonYes))
        //    .Add(new Condition(className, "secondaryEmploymentStatus", "Self Employed - Partnership")))
        //    .AddNewConditionList(new ConditionList()
        //    .Add(new Condition(className, "anyOtherEmployedSelfEmployedIncome", Defs.radioButtonYes))
        //    .Add(new Condition(className, "secondaryEmploymentStatus", "Employed"))
        //    .Add(new Condition(className, "secondaryOwnership25pc", Defs.radioButtonYes)));

        #endregion

        //#region Secondary Income section locators - Employed

        //public Section secondaryIncomeEmployedSection => new Section(new Element(
        //    new ConditionList()
        //    .Add(new Condition(className, "employmentStatus", "Retired", Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "employmentStatus", "Not working", Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "secondaryEmploymentStatus", "Employed"))
        //    .Add(new Condition(className, "secondaryOwnership25pc", Defs.radioButtonNo))
        //    .Add(new Condition(className, "anyOtherEmployedSelfEmployedIncome", Defs.radioButtonYes))));

        //public Element secondaryEmployedFullTimeRbtn => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("EmployedEmploymentType", "Secondary", "_1", "!Self"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("EmployedEmploymentType", "Secondary", "_2", "!Self")));

        //public Element secondaryEmployedOccupationBox => new Element(FindElement("Secondary", "EmployedJobTitle"));

        //public Element secondaryEmployedBusinessSectorLookup => new Element(FindElement("Secondary", "BusinessSector", "!Self"));

        //public Element secondaryEmployedStartDateBox => new Element(FindElement("Secondary", "StartDate", "!Self"))
        //    .SetValidationType(Defs.validationTypeMmYyyy);

        //public Element secondaryEmployedToBox => new Element(FindElement("Secondary", "EmployedEndDate", "!Self"))
        //    .SetCompletePageFlag(false);

        //public Element secondaryEmployedStillWithinProbationaryPeriodRbtn => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("WithinProbationaryPeriod", "Secondary", "rbl_0", "!Self"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("WithinProbationaryPeriod", "Secondary", "rbl_1", "!Self")));

        //public Element secondaryEmployedEndDateOfProbationaryPeriodBox => new Element(FindElement("Secondary", "ProbationEndDate"),
        //    new ConditionList()
        //    .Add(new Condition(className, "secondaryEmployedStillWithinProbationaryPeriod", Defs.radioButtonYes)));

        //public Element secondaryGrossAnnualSalaryBox => new Element(FindElement("Secondary", "BasicSalary", "!Assessable"));

        //public Element secondaryAssessableGrossAnnualSalaryBox => new Element(FindElement("Secondary", "Assessable", "BasicSalary"))
        //    .SetCompletePageFlag(false);

        //public Element secondaryOvertimeInLastYearBox => new Element(FindElement("Secondary", "Overtime", "!Assessable"));

        //public Element secondaryAssessableOvertimeInLastYearBox => new Element(FindElement("Secondary", "Overtime", "Assessable"))
        //    .SetCompletePageFlag(false);

        //public Element secondaryCommissionBox => new Element(FindElement("Secondary", "Dividend", "!Assessable"));

        //public Element secondaryAssessableCommissionBox => new Element(FindElement("Secondary", "Dividend", "Assessable"))
        //    .SetCompletePageFlag(false);

        //public Element secondaryBonusBox => new Element(FindElement("Secondary", "Bonus", "!Assessable"));

        //public Element secondaryAsessableBonusBox => new Element(FindElement("Secondary", "Bonus", "Assessable"))
        //    .SetCompletePageFlag(false);

        //public Element secondaryAllowanceBox => new Element(FindElement("Secondary", "Allowance", "!Assessable"));

        //public Element secondaryAssessableAllowanceBox => new Element(FindElement("Secondary", "Allowance", "Assessable"))
        //    .SetCompletePageFlag(false);

        //public Element secondaryLondonWeightingBox => new Element(FindElement("Secondary", "LondonWeighting", "!Assessable"));

        //public Element secondaryAssessableLondonWeightingBox => new Element(FindElement("Secondary", "LondonWeighting", "Assessable"))
        //    .SetCompletePageFlag(false);

        //public Element secondaryCalculateBtn => new Element(FindElement(new LocatorList()
        //    .Add(Defs.locatorName, "Secondary")
        //    .Add(Defs.locatorName, "Simple")
        //    .Add(Defs.locatorValue, "Calculate")))
        //    .SetIsButtonFlag(true);


        //public SectionEnd secondaryIncomeEmployedSectionEnd => new SectionEnd();

        //#endregion

        //#region Secondary Income section locators - Self Employed
        //public Section secondarySelfEmployedSection => new Section(new Element(
        //    new ConditionList()
        //    .Add(new Condition(className, "employmentStatus", "Retired", Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "employmentStatus", "Not working", Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "anyOtherEmployedSelfEmployedIncome", Defs.radioButtonYes))
        //    .Add(new Condition(className, "secondaryEmploymentStatus", "Self Employed - Sole Trader")))
        //    .AddNewConditionList(new ConditionList()
        //    .Add(new Condition(className, "employmentStatus", "Retired", Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "employmentStatus", "Not working", Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "anyOtherEmployedSelfEmployedIncome", Defs.radioButtonYes))
        //    .Add(new Condition(className, "secondaryEmploymentStatus", "Self Employed - Partnership")))
        //    .AddNewConditionList(new ConditionList()
        //    .Add(new Condition(className, "employmentStatus", "Retired", Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "employmentStatus", "Not working", Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "anyOtherEmployedSelfEmployedIncome", Defs.radioButtonYes))
        //    .Add(new Condition(className, "secondaryEmploymentStatus", "Employed"))
        //    .Add(new Condition(className, "secondaryOwnership25pc", Defs.radioButtonYes))));


        //public Element secondarySelfEmployedFullTimeRbtn => new Element(new RadioButton()
        //           .AddRadioButtonElement(Defs.radioButtonYes, FindElement("SelfEmployedEmploymentType", "Secondary", "_1"))
        //           .AddRadioButtonElement(Defs.radioButtonNo, FindElement("SelfEmployedEmploymentType", "Secondary", "_2")));

        //public Element secondarySelfEmployedOccupationBox => new Element(FindElement("Secondary", "SelfEmployedOccupation"));

        //public Element secondarySelfEmployedBusinessSectorLookup => new Element(FindElement("Secondary", "Self", "BusinessSector"));

        //public Element secondarySelfEmployedStartDateBox => new Element(FindElement("Secondary", "Self", "StartDate"));

        //public Element secondaryPercentageOwnershipBox => new Element(FindElement("Secondary", "Self", "PercentageShares"));

        //public Element secondaryEarnedIncomeY1Box => new Element(FindElement("Secondary", "Year1Profit"));

        //public Element secondaryEarnedIncomeY2Box => new Element(FindElement("Secondary", "Year2Profit"));

        //public Element secondaryEarnedIncomeY3Box => new Element(FindElement("Secondary", "Year3Profit"));

        //public Element secondaryYear1EndingBox => new Element(FindElement("Secondary", "YearEnding1"))
        //    .SetValidationType(Defs.validationTypeMmYyyy);

        //public Element secondaryYear2EndingBox => new Element(FindElement("Secondary", "YearEnding2"))
        //    .SetValidationType(Defs.validationTypeMmYyyy);

        //public Element secondaryYear3EndingBox => new Element(FindElement("Secondary", "YearEnding3"))
        //    .SetValidationType(Defs.validationTypeMmYyyy);

        //public SectionEnd secondarySelfEmployedSectionEnd => new SectionEnd();
        //#endregion

        //#region Other Sources Of Income? section locators

        //public Element otherSourcesOfIncomeRbtn => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AnyOtherIncome", "rbl_0"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AnyOtherIncome", "rbl_1")));

        //public Section otherIncomeSection => new Section(new Element(
        //    new ConditionList()
        //    .Add(new Condition(className, "otherSourcesOfIncome", Defs.radioButtonYes))));



        //public Element source1Lookup => new Element(FindElement("Source", "item0", "OtherIncome", "!txt"));


        //public Element source2Lookup => new Element(FindElement("Source", "item1", "OtherIncome", "!txt"),
        //    new ConditionList()
        //    .Add(new Condition(className, "source2", null, Defs.conditionTypeNotEqual)),
        //    otherIncomeAddBtn);

        //public Element source3Lookup => new Element(FindElement("Source", "item2", "OtherIncome", "!txt"),
        //    new ConditionList()
        //    .Add(new Condition(className, "source3", null, Defs.conditionTypeNotEqual)),
        //    otherIncomeAddBtn);

        //public Element other1Box => new Element(FindElement("Source", "item0", "Description"),
        //    new ConditionList()
        //    .Add(new Condition(className, "source1", "Other")));

        //public Element other2Box => new Element(FindElement("Source", "item1", "Description"),
        //    new ConditionList()
        //    .Add(new Condition(className, "source2", null, Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "source2", "Other")),
        //    otherIncomeAddBtn);

        //public Element other3Box => new Element(FindElement("Source", "item2", "Description"),
        //    new ConditionList()
        //    .Add(new Condition(className, "source3", null, Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "source3", "Other")),
        //    otherIncomeAddBtn);

        //public Element otherGrossAnnualIncome1Box => new Element(FindElement("item0", "AnnualIncome"));

        //public Element otherGrossAnnualIncome2Box => new Element(FindElement("item1", "AnnualIncome"),
        //     new ConditionList()
        //     .Add(new Condition(className, "source2", null, Defs.conditionTypeNotEqual)),
        //     otherIncomeAddBtn);

        //public Element otherGrossAnnualIncome3Box => new Element(FindElement("item2", "AnnualIncome"),
        //     new ConditionList()
        //     .Add(new Condition(className, "source3", null, Defs.conditionTypeNotEqual)),
        //     otherIncomeAddBtn);


        //public Element otherIncomeAddBtn => new Element(FindElement("OtherIncome", "btnAdd"))
        //    .SetCompletePageFlag(false);

        //public SectionEnd otherIncomeSectionEnd => new SectionEnd();
        //#endregion

        //#region Basic Rate Tax Payer section locators

        //public Element applicantBasicRateTaxPayerRbtn => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("Question", "rbl_0", "26"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("Question", "rbl_1", "26")));

        //#endregion



        #region Other Sources OF Income section locators
        public Element otherSourcesOfIncome1Rbtn => new Element(new RadioButton()
           .AddRadioButtonElement(Defs.radioButtonYes, FindElement("MC_IncomeLandingPage1_pnlApplicantPanel_ctl00_ctl00_FactfindList_ctl00_ctl00_rbl_1"))
           .AddRadioButtonElement(Defs.radioButtonNo, FindElement("MC_IncomeLandingPage1_pnlApplicantPanel_ctl00_ctl00_FactfindList_ctl00_ctl00_rbl_1")));

        #endregion



        #region Income Changes section locators

        public Element awareOfChangesToIncomeOrExpenditureRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoQuestion", "rbl_0", "ctl03"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoQuestion", "rbl_1", "ctl03")));

        public Element pleaseProvideDetailsBox => new Element(FindElement("FurtherDetails"),
                   new ConditionList()
                   .Add(new Condition(className, "awareOfChangesToIncomeOrExpenditure", Defs.radioButtonYes)));

        #endregion

        public Element nextBtn => new Element(FindElement("Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);


    }
    public class ApplicantEmploymentDataPBR : PageData
    {
        public string employmentStatus { set; get; } = "Employed";
        public string ownership25pc { set; get; } = Defs.radioButtonNo;
        public string deductionFromSalary { set; get; } = Defs.radioButtonNo;
        public string employmentLessThan12Months { set; get; } = Defs.radioButtonNo;
        public string incomeDerivedThroughProfitFromLandProperty { set; get; } = Defs.radioButtonNo;

        public string employedFullTime { set; get; } = Defs.radioButtonYes;
        public string employedOccupation { set; get; } = "Test";
        public string employedBusinessSector { set; get; } = "Government";
        public string employedStartDate { set; get; } = "01/2010";
        public string to { set; get; } = null;
        public string stillWithinProbationaryPeriod { set; get; } = Defs.radioButtonNo;
        public string employedEndDateOfProbationaryPeriod { set; get; } = null;
        public string grossAnnualSalary { set; get; } = "200000";
        public string assessableGrossAnnualSalary { set; get; } = null;
        public string overtimeInLastYear { set; get; } = null;
        public string assessableOvertimeInLastYear { set; get; } = null;
        public string commission { set; get; } = null;
        public string assessableCommission { set; get; } = null;
        public string bonus { set; get; } = null;
        public string assessableBonus { set; get; } = null;
        public string allowance { set; get; } = null;
        public string assessableAllowance { set; get; } = null;
        public string londonWeighting { set; get; } = null;
        public string assessableLondonWeighting { set; get; } = null;
        public string calculate { set; get; } = null;

        public string selfEmployedFullTime { set; get; } = Defs.radioButtonYes;
        public string selfEmployedOccupation { set; get; } = "Secondary Test";
        public string selfEmployedBusinessSector { set; get; } = "Government";
        public string selfEmployedStartDate { set; get; } = "01/2010";
        public string percentageOwnership { set; get; } = "25";
        public string earnedIncomeY1 { set; get; } = "200000";
        public string earnedIncomeY2 { set; get; } = "200000";
        public string earnedIncomeY3 { set; get; } = "200000";
        public string year1Ending { set; get; } = "04/2019";
        public string year2Ending { set; get; } = "04/2018";
        public string year3Ending { set; get; } = "04/2017";

        public string anyOtherEmployedSelfEmployedIncome { set; get; } = Defs.radioButtonNo;
        public string secondaryEmploymentStatus { set; get; } = "Employed";
        public string secondaryOwnership25pc { set; get; } = Defs.radioButtonNo;
        public string secondaryIncomeDerivedThroughProfitFromLandProperty { set; get; } = Defs.radioButtonNo;

        public string secondaryEmployedFullTime { set; get; } = Defs.radioButtonYes;
        public string secondaryEmployedOccupation { set; get; } = "Secondary Test";
        public string secondaryEmployedBusinessSector { set; get; } = "Government";
        public string secondaryEmployedStartDate { set; get; } = "01/2010";
        public string secondaryEmployedTo { set; get; } = null;
        public string secondaryEmployedStillWithinProbationaryPeriod { set; get; } = Defs.radioButtonNo;
        public string secondaryEmployedEndDateOfProbationaryPeriod { set; get; } = "01/2010";
        public string secondaryGrossAnnualSalary { set; get; } = "200000";
        public string secondaryGrossAnualSalaryAssessable { set; get; } = null;
        public string secondaryOvertimeInLastYear { set; get; } = null;
        public string secondaryOvertimeInLastYearAssessable { set; get; } = null;
        public string secondaryCommission { set; get; } = null;
        public string secondaryCommissionAssessable { set; get; } = null;
        public string secondaryBonus { set; get; } = null;
        public string secondaryBonusAssessable { set; get; } = null;
        public string secondaryAllowance { set; get; } = null;
        public string secondaryAllowanceAssessable { set; get; } = null;
        public string secondaryLondonWeighting { set; get; } = null;
        public string secondaryLondonWeightingAssessable { set; get; } = null;


        public string secondarySelfEmployedFullTime { set; get; } = Defs.radioButtonYes;
        public string secondarySelfEmployedOccupation { set; get; } = "Secondary Test";
        public string secondarySelfEmployedBusinessSector { set; get; } = "Government";
        public string secondarySelfEmployedStartDate { set; get; } = "01/2010";
        public string secondaryPercentageOwnership { set; get; } = "25";
        public string secondaryEarnedIncomeY1 { set; get; } = "200000";
        public string secondaryEarnedIncomeY2 { set; get; } = "200000";
        public string secondaryEarnedIncomeY3 { set; get; } = "200000";
        public string secondaryYear1Ending { set; get; } = "01/2019";
        public string secondaryYear2Ending { set; get; } = "01/2018";
        public string secondaryYear3Ending { set; get; } = "01/2017";

        public string otherSourcesOfIncome1 { set; get; } = Defs.radioButtonNo;
        public string source1 { set; get; } = "Pension";
        public string other1 { set; get; } = "Text";

        public string otherGrossAnnualIncome1 { set; get; } = "200000";
        public string source2 { set; get; } = null;
        public string other2 { set; get; } = null;
        public string otherGrossAnnualIncome2 { set; get; } = null;
        public string source3 { set; get; } = null;
        public string other3 { set; get; } = null;
        public string otherGrossAnnualIncome3 { set; get; } = null;

        public string applicantBasicRateTaxPayer { set; get; } = Defs.radioButtonYes;
        public string awareOfChangesToIncomeOrExpenditure { set; get; } = Defs.radioButtonNo;
        public string pleaseProvideDetails { set; get; } = "Test";
    }
}
