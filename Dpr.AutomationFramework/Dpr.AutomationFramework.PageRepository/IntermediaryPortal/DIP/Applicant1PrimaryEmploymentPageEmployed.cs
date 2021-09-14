using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant1PrimaryEmploymentPageEmployed : WebBasePage
    {
        public Applicant1PrimaryEmploymentPageEmployed()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new Applicant1PrimaryEmploymentPageEmployedData().GetType();
            textName = "Applicant 1 Primary Employment Page - Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("Applicant1EmploymentInitialisationPage", "employmentStatus", "Employed"))));
        }

        #region 'Employment Details' Section
        public Element fullTime => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("EmplymentStatus_0", tag:"input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("EmplymentStatus_1", tag: "input")));
        public Element companyName => new Element(FindElement("CompanyName", tag: "input"));
        public Element employedSinceFrom => new Element(FindElement("EmployedSinceFrom", tag: "input"));
        public Element employedSinceTo => new Element(FindElement("EmployedSinceTo", tag: "input"));
        public Element permanentEmployment => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsEmploymentPermenant_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsEmploymentPermenant_1", tag: "input")));
        public Element withinProbationaryPeriod => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsOnProbation_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsOnProbation_1", tag: "input")));
        public Element occupation => new Element(FindElement("Occupation"));
        #endregion

        #region 'Primary Income' Section

        #region 'Current Annual Income & Allowances' Subsection
        public Element basicIncome => new Element(FindElement("BasicIncomeYear1Amount", tag: "input"));
        public Element carAllowance => new Element(FindElement("CarAllowanceYear1Amount", tag: "input"));
        public Element otherAllowance => new Element(FindElement("OtherAllowanceYear1Amount", tag: "input"));
        public Element bonus => new Element(FindElement("BonusYear1Amount", tag: "input"));
        public Element commission => new Element(FindElement("CommissionPerAnnumYear1Amount", tag: "input"));
        public Element overtime => new Element(FindElement("OvertimeYear1Amount", tag: "input"));
        #endregion

        #region 'Income Total' Subsection
        public Element calculateIncome => new Element(FindElement("ctl00_Button1")).SetIsButtonFlag(true);
        #endregion

        #region 'Deductions' Subsection

        //public Element applicantSalaryDeductions => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AnySalarySacrifices_0"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AnySalarySacrifices_1")));

        //#region 'Deduction Details' Subsection

        //public Section applicantSalaryDeductionSection => new Section(new Element(new ConditionList()
        //    .Add(new Condition(className, "applicantSalaryDeductions", Defs.radioButtonYes))));

        //#region Deduction Details Repeater Section

        //#region Deduction Detail Row 1
        //// No condition required as it is covered by the 'applicantSalaryDeductionSection' condition.
        //public Element deductionDetailSource_1 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item0", "cboSource"));
        //public Element deductionDetailMonthlyAmount_1 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item0", "txtAmount"));
        //#endregion

        //#region Deduction Detail Row 2
        //public Element deductionDetailSource_2 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item1", "cboSource"),
        //    new ConditionList()
        //        .Add(new Condition(className, "deductionDetailSource_2", null, Defs.conditionTypeNotEqual)),
        //    addMore);
        //public Element deductionDetailMonthlyAmount_2 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item1", "txtAmount"),
        //    new ConditionList()
        //        .Add(new Condition(className, "deductionDetailMonthlyAmount_2", null, Defs.conditionTypeNotEqual)),
        //    addMore);
        //#endregion

        //#region Deduction Detail Row 3
        //public Element deductionDetailSource_3 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item2", "cboSource"),
        //    new ConditionList()
        //        .Add(new Condition(className, "deductionDetailSource_3", null, Defs.conditionTypeNotEqual)),
        //    addMore);
        //public Element deductionDetailMonthlyAmount_3 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item2", "txtAmount"),
        //    new ConditionList()
        //        .Add(new Condition(className, "deductionDetailMonthlyAmount_3", null, Defs.conditionTypeNotEqual)),
        //    addMore);
        //#endregion

        //#region Deduction Detail Row 4
        //public Element deductionDetailSource_4 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item3", "cboSource"),
        //    new ConditionList()
        //        .Add(new Condition(className, "deductionDetailSource_4", null, Defs.conditionTypeNotEqual)),
        //    addMore);
        //public Element deductionDetailMonthlyAmount_4 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item3", "txtAmount"),
        //    new ConditionList()
        //        .Add(new Condition(className, "deductionDetailMonthlyAmount_4", null, Defs.conditionTypeNotEqual)),
        //    addMore);
        //#endregion

        //#region Deduction Detail Row 5
        //public Element deductionDetailSource_5 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item4", "cboSource"),
        //    new ConditionList()
        //        .Add(new Condition(className, "deductionDetailSource_5", null, Defs.conditionTypeNotEqual)),
        //    addMore);
        //public Element deductionDetailMonthlyAmount_5 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item4", "txtAmount"),
        //    new ConditionList()
        //        .Add(new Condition(className, "deductionDetailMonthlyAmount_5", null, Defs.conditionTypeNotEqual)),
        //    addMore);
        //#endregion

        //#region Deduction Detail Row 6
        //public Element deductionDetailSource_6 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item5", "cboSource"),
        //    new ConditionList()
        //        .Add(new Condition(className, "deductionDetailSource_6", null, Defs.conditionTypeNotEqual)),
        //    addMore);
        //public Element deductionDetailMonthlyAmount_6 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item5", "txtAmount"),
        //    new ConditionList()
        //        .Add(new Condition(className, "deductionDetailMonthlyAmount_6", null, Defs.conditionTypeNotEqual)),
        //    addMore);
        //#endregion

        //#region Deduction Detail Row 7
        //public Element deductionDetailSource_7 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item6", "cboSource"),
        //    new ConditionList()
        //        .Add(new Condition(className, "deductionDetailSource_7", null, Defs.conditionTypeNotEqual)),
        //    addMore);
        //public Element deductionDetailMonthlyAmount_7 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item6", "txtAmount"),
        //    new ConditionList()
        //        .Add(new Condition(className, "deductionDetailMonthlyAmount_7", null, Defs.conditionTypeNotEqual)),
        //    addMore);
        //#endregion

        //#region Deduction Detail Row 8
        //public Element deductionDetailSource_8 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item7", "cboSource"),
        //    new ConditionList()
        //        .Add(new Condition(className, "deductionDetailSource_8", null, Defs.conditionTypeNotEqual)),
        //    addMore);
        //public Element deductionDetailMonthlyAmount_8 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item7", "txtAmount"),
        //    new ConditionList()
        //        .Add(new Condition(className, "deductionDetailMonthlyAmount_8", null, Defs.conditionTypeNotEqual)),
        //    addMore);
        //#endregion

        //public Element addMore => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "btnAdd"))
        //    .SetCompletePageFlag(false);
        //#endregion

        //public SectionEnd applicantSalaryDeductionSectionEnd => new SectionEnd();

        //#endregion

        #endregion

        #region 'Previous Employment' Subsection
        public Element previousEmployment => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("EmployedForLessThan12Months_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("EmployedForLessThan12Months_1")));

        public Section previousEmploymentDetailsSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "previousEmployment", Defs.radioButtonYes))));

        public Element previousEmploymentStatus => new Element(FindElement("PreviousIncomeEmploymentType"));
        public Element previousEmployedSinceFrom => new Element(FindElement("PreviousIncomeEmployedSinceFrom"));
        public Element previousEmployedSinceTo => new Element(FindElement("PreviousIncomeEmployedSinceTo"));
        public SectionEnd previousEmploymentDetailsSectionEnd => new SectionEnd();
        #endregion

        #endregion

        public Element next => new Element(FindElement("ctl04_Next")).SetIsButtonFlag(true);
    }

    public class Applicant1PrimaryEmploymentPageEmployedData : PageData
    {
        #region 'Employment Details' Data Section
        public string fullTime { get; set; } = Defs.radioButtonYes;
        public string companyName { get; set; } = "TestCompany";
        public string employedSinceFrom { get; set; } = "01/2010";
        public string employedSinceTo { get; set; } = null;
        public string permanentEmployment { get; set; } = Defs.radioButtonYes;
        public string withinProbationaryPeriod { get; set; } = Defs.radioButtonNo;
        public string occupation { get; set; } = "TestOccupation";
        #endregion

        #region 'Primary Income' Data Section

        #region 'Current Annual Income & Allowances' Subsection
        public string basicIncome { get; set; } = "65000";
        public string carAllowance { get; set; } = "5000";
        public string otherAllowance { get; set; } = "5000";
        public string bonus { get; set; } = "5000";
        public string commission { get; set; } = "5000";
        public string overtime { get; set; } = "5000";
        #endregion

        #region 'Deductions' Subsection

        public string applicantSalaryDeductions { get; set; } = Defs.radioButtonNo;

        #region 'Deduction Details' Subsection

        #region Deduction Details Repeater Section

        public string deductionDetailSource_1 { get; set; } = "Student Loan";
        public string deductionDetailMonthlyAmount_1 { get; set; } = "1000";

        public string deductionDetailSource_2 { get; set; } = null;
        public string deductionDetailMonthlyAmount_2 { get; set; } = null;

        public string deductionDetailSource_3 { get; set; } = null;
        public string deductionDetailMonthlyAmount_3 { get; set; } = null;

        public string deductionDetailSource_4 { get; set; } = null;
        public string deductionDetailMonthlyAmount_4 { get; set; } = null;

        public string deductionDetailSource_5 { get; set; } = null;
        public string deductionDetailMonthlyAmount_5 { get; set; } = null;

        public string deductionDetailSource_6 { get; set; } = null;
        public string deductionDetailMonthlyAmount_6 { get; set; } = null;

        public string deductionDetailSource_7 { get; set; } = null;
        public string deductionDetailMonthlyAmount_7 { get; set; } = null;

        public string deductionDetailSource_8 { get; set; } = null;
        public string deductionDetailMonthlyAmount_8 { get; set; } = null;

        #endregion

        #endregion

        #endregion

        #region 'Previous Employment' Data Subsection
        public string previousEmployment { get; set; } = Defs.radioButtonNo;
        public string previousEmploymentStatus { get; set; } = null;
        public string previousEmployedSinceFrom { get; set; } = null;
        public string previousEmployedSinceTo { get; set; } = null;
        #endregion

        #endregion
    }
}
