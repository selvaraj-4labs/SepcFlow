using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP09_Employed : WebBasePage
    {
        public CBS_DIP09_Employed()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new CBS_DIP09_EmployedData().GetType();
            textName = "CBS Applicant 1 Primary Employment Page - Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP08", "employmentStatus", "Employed"))));
        }

        #region 'Employment Details' Section
        public Element fullTime => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("EmplymentStatus_0", tag: "input"))
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
        public Element zeroHoursContract => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsZeroHoursContract_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsZeroHoursContract_btn_rbl_1", tag: "input")));
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
        public Element calculateIncome => new Element(FindElement("ctl00_EmployedIncomeDetailsCalculateIncomeButton")).SetIsButtonFlag(true);
        #endregion

        #region 'Deductions' Subsection

        public Element applicantSalaryDeductions => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AnySalarySacrifices_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AnySalarySacrifices_1")));

        #region 'Deduction Details' Subsection

        public Section applicantSalaryDeductionSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "applicantSalaryDeductions", Defs.radioButtonYes))));

        #region Deduction Details Repeater Section

        #region Deduction Detail Row 1
        public Element deductionDetailSource_1 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item0", "cboSource", tag: "select"));
        public Element deductionDetailMonthlyAmount_1 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item0", "txtAmount", tag: "input"));
        #endregion

        #region Deduction Detail Row 2
        public Element deductionDetailSource_2 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item1", "cboSource", tag: "select"),
            new ConditionList()
                .Add(new Condition(className, "deductionDetailSource_2", null, Defs.conditionTypeNotEqual)),
            addMore);
        public Element deductionDetailMonthlyAmount_2 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item1", "txtAmount", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "deductionDetailMonthlyAmount_2", null, Defs.conditionTypeNotEqual)),
            addMore);
        #endregion

        #region Deduction Detail Row 3
        public Element deductionDetailSource_3 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item2", "cboSource", tag: "select"),
            new ConditionList()
                .Add(new Condition(className, "deductionDetailSource_3", null, Defs.conditionTypeNotEqual)),
            addMore);
        public Element deductionDetailMonthlyAmount_3 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item2", "txtAmount", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "deductionDetailMonthlyAmount_3", null, Defs.conditionTypeNotEqual)),
            addMore);
        #endregion

        public Element addMore => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "btnAdd"))
            .SetCompletePageFlag(false);
        #endregion

        public SectionEnd applicantSalaryDeductionSectionEnd => new SectionEnd();

        #endregion


        #endregion

        #endregion

        #region 'Current annual income & allowances' Section
        public Section zeroHourContractSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "zeroHoursContract", Defs.radioButtonYes))));

        public Element averageIncomeOverThreeMonths => new Element(FindElement("AverageIncome3MonthsAmount"));
        public Element averageIncomeOverSixMonths => new Element(FindElement("AverageIncome6MonthsAmount"));
        public Element averageIncomeOverTwelveMonths => new Element(FindElement("AverageIncome12MonthsAmount"));

        public SectionEnd zeroHourContractSectionEnd => new SectionEnd();
        #endregion

        public Element next => new Element(FindElement("Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class CBS_DIP09_EmployedData : PageData
    {
        #region 'Employment Details' Data Section
        public string fullTime { get; set; } = Defs.radioButtonYes;
        public string companyName { get; set; } = "TestCompany";
        public string employedSinceFrom { get; set; } = "01/2010";
        public string employedSinceTo { get; set; } = null;
        public string permanentEmployment { get; set; } = Defs.radioButtonYes;
        public string withinProbationaryPeriod { get; set; } = Defs.radioButtonNo;
        public string occupation { get; set; } = "TestOccupation";

        public string zeroHoursContract { get; set; } = Defs.radioButtonNo;
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

        #region 'Current annual income & allowances' Data Section
        public string averageIncomeOverThreeMonths { get; set; } = "10000";
        public string averageIncomeOverSixMonths { get; set; } = "20000";
        public string averageIncomeOverTwelveMonths { get; set; } = "40000";
        #endregion

    }
}
