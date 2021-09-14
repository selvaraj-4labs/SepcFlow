using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant1PrimaryEmploymentPageFixedTermContract : WebBasePage
    {
        public Applicant1PrimaryEmploymentPageFixedTermContract()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new Applicant1PrimaryEmploymentPageFixedTermContractData().GetType();
            textName = "Applicant 1 Primary Employment Page - Fixed Term Contract";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("Applicant1EmploymentInitialisationPage", "employmentStatus", "Fixed Term Contract"))));
        }

        public Element fullTime => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("EmplymentStatus_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("EmplymentStatus_1", tag: "input")));
        public Element companyName => new Element(FindElement("CompanyName", tag: "input"));
        public Element employedSinceFrom => new Element(FindElement("EmployedSinceFrom", tag: "input"));
        public Element employedSinceTo => new Element(FindElement("EmployedSinceTo", tag: "input"));
        public Element hasContractBeenRenewed => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HasContractRenewed_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HasContractRenewed_1", tag: "input")));
        public Element willContractBeenRenewed => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("WillCurrctContractRenewed_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("WillCurrctContractRenewed_1", tag: "input")));
        public Element occupation => new Element(FindElement("Occupation", tag: "input"));
        public Element basicIncome => new Element(FindElement("BasicIncomeYear1Amount", tag: "input"));
        public Element carAllowance => new Element(FindElement("CarAllowanceYear1Amount", tag: "input"));
        public Element otherAllowance => new Element(FindElement("OtherAllowanceYear1Amount", tag: "input"));
        public Element bonus => new Element(FindElement("BonusYear1Amount", tag: "input"));
        public Element commission => new Element(FindElement("CommissionPerAnnumYear1Amount", tag: "input"));
        public Element overtime => new Element(FindElement("OvertimeYear1Amount", tag: "input"));
        public Element calculateIncome => new Element(FindElement("ctl00_Button1")).SetIsButtonFlag(true);

        #region 'Deductions' Subsection

        public Element applicantSalaryDeductions => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AnySalarySacrifices_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AnySalarySacrifices_1")));

        #region 'Deduction Details' Subsection

        public Section applicantSalaryDeductionSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "applicantSalaryDeductions", Defs.radioButtonYes))));

        #region Deduction Details Repeater Section

        #region Deduction Detail Row 1
        // No condition required as it is covered by the 'applicantSalaryDeductionSection' condition.
        public Element deductionDetailSource_1 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item0", "cboSource"));
        public Element deductionDetailMonthlyAmount_1 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item0", "txtAmount"));
        #endregion

        #region Deduction Detail Row 2
        public Element deductionDetailSource_2 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item1", "cboSource"),
            new ConditionList()
                .Add(new Condition(className, "deductionDetailSource_2", null, Defs.conditionTypeNotEqual)),
            addMore);
        public Element deductionDetailMonthlyAmount_2 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item1", "txtAmount"),
            new ConditionList()
                .Add(new Condition(className, "deductionDetailMonthlyAmount_2", null, Defs.conditionTypeNotEqual)),
            addMore);
        #endregion

        #region Deduction Detail Row 3
        public Element deductionDetailSource_3 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item2", "cboSource"),
            new ConditionList()
                .Add(new Condition(className, "deductionDetailSource_3", null, Defs.conditionTypeNotEqual)),
            addMore);
        public Element deductionDetailMonthlyAmount_3 => new Element(FindElement("FMAIncomeSalarySacrificeRepeater", "item2", "txtAmount"),
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

        public Element previousEmployment => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("EmployedForLessThan12Months_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("EmployedForLessThan12Months_1")));

        public Section previousEmploymentDetailsSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "previousEmployment", Defs.radioButtonYes))));

        public Element previousEmploymentStatus => new Element(FindElement("PreviousIncomeEmploymentType"));
        public Element previousEmployedSinceFrom => new Element(FindElement("PreviousIncomeEmployedSinceFrom"));
        public Element previousEmployedSinceTo => new Element(FindElement("PreviousIncomeEmployedSinceTo"));
        public SectionEnd previousEmploymentDetailsSectionEnd => new SectionEnd();

        public Element next => new Element(FindElement("ctl04_Next")).SetIsButtonFlag(true);
    }

    public class Applicant1PrimaryEmploymentPageFixedTermContractData : PageData 
    {
        #region 'Employment Details' Data Section
        public string fullTime { get; set; } = Defs.radioButtonYes;
        public string companyName { get; set; } = "TestCompany";
        public string employedSinceFrom { get; set; } = "01/2010";
        public string employedSinceTo{ get; set; } = "01/2019";
        public string hasContractBeenRenewed { get; set; } = Defs.radioButtonYes;
        public string willContractBeenRenewed { get; set; } = Defs.radioButtonYes;
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

        #region 'Deduction Details' Subsection

        public string applicantSalaryDeductions { get; set; } = Defs.radioButtonNo;

        #region Deduction Details Repeater Section
        public string deductionDetailSource_1 { get; set; } = "Student Loan";
        public string deductionDetailMonthlyAmount_1 { get; set; } = "1000";

        public string deductionDetailSource_2 { get; set; } = null;
        public string deductionDetailMonthlyAmount_2 { get; set; } = null;

        public string deductionDetailSource_3 { get; set; } = null;
        public string deductionDetailMonthlyAmount_3 { get; set; } = null;
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
