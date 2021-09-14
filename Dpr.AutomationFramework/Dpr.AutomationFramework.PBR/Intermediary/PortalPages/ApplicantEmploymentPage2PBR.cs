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
    class ApplicantEmploymentPage2PBR : WebBasePage
    {

        public ApplicantEmploymentPage2PBR()
        {
            pageLoadedElement = employmentStatusLookup;
            correspondingDataClass = new ApplicantEmploymentData2PBR().GetType();

        }

        #region Employment Status section locators
       //Employment status
        public Element employmentStatusLookup => new Element(FindElement("EmploymentType", "ctl01"));

        #endregion

        #region Employment Details section locator

        public Section incomeEmployedSection => new Section(new Element(
            new ConditionList()
            .Add(new Condition(className, "employmentStatus", "Employed"))));
            //.Add(new Condition(className, "ownership25pc", Defs.radioButtonNo))));

        public Element employedFullTimeRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("EmplymentStatus", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("EmplymentStatus", "_1")),
            new ConditionList()
            .Add(new Condition(className, "employmentStatus", "Employed")));
            //.Add(new Condition(className, "ownership25pc", Defs.radioButtonNo)));

        public Element employedOccupationBox => new Element(FindElement("ctl01", "Occupation"));

        public Element employedBusinessSectorLookup => new Element(FindElement("ctl01", "CompanyName"));

        public Element employedStartDateBox => new Element(FindElement("EmployedSinceFrom", "ctl01"))
            .SetValidationType(Defs.validationTypeMmYyyy);


        public Element toBox => new Element(FindElement("EmployedSinceTo", "ctl01"))
            .SetCompletePageFlag(false);

        public Element employmentPermanentRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsEmploymentPermenant", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsEmploymentPermenant", "_1")),
            new ConditionList()
            .Add(new Condition(className, "employmentStatus", "Employed")));
            //.Add(new Condition(className, "ownership25pc", Defs.radioButtonNo)));

        public Element stillWithinProbationaryPeriodRbtn => new Element(
            new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsOnProbation", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsOnProbation", "_1")));

        public Element employedEndDateOfProbationaryPeriodBox => new Element(FindElement("Primary", "ProbationEndDate"),
            new ConditionList()
            .Add(new Condition(className, "stillWithinProbationaryPeriod", Defs.radioButtonYes)));

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

        public SectionEnd incomeEmployedSectionEnd => new SectionEnd();

        #endregion

        #region Primary Income details specific to the PBR ( fault on PBR)

        public Element basicIncomeAmountBox => new Element(FindElement("BasicIncomeYear1Amount", "ctl01"));
        public Element basicIncomeFrequencyLookup => new Element(FindElement("BasicIncomeYear1Frequency", "ctl01"));
        public Element basicIncomeCurrencyLookup => new Element(FindElement("BasicIncomeYear1Currency", "ctl01"));
        public Element carAllowanceAmountBox => new Element(FindElement("CarAllowanceYear1Amount", "ctl01"));
        public Element carAllowanceFrequencyLookup => new Element(FindElement("CarAllowanceYear1Frequency", "ctl01"));
        public Element carAllowanceCurrencyLookup => new Element(FindElement("CarAllowanceYear1Currency", "ctl01"));
        public Element otherAllowanceAmountBox => new Element(FindElement("OtherAllowanceYear1Amount", "ctl01"));
        public Element otherAllowanceFrequencyLookup => new Element(FindElement("OtherAllowanceYear1Frequency", "ctl01"));
        public Element otherAllowanceCurrencyLookup => new Element(FindElement("OtherAllowanceYear1Currency", "ctl01"));


        public Element year1CashPaidAmountBox => new Element(FindElement("AnualIncomeAllowanceYear1CashPaidAmount", "ctl01"));
        public Element year1CashPaidFrequencyLookup => new Element(FindElement("AnualIncomeAllowanceYear1CashPaidFrequency", "ctl01"));
        public Element Year1CashPaidCurrencyLookup => new Element(FindElement("AnualIncomeAllowanceYear1CashPaidCurrency", "ctl01"));


        public Element year1DeferredCashAmountBox => new Element(FindElement("AnualIncomeAllowanceYear1DeferredCashAmount", "ctl01"));
        public Element year1DeferredCashFrequencyLookup => new Element(FindElement("AnualIncomeAllowanceYear1DeferredCashFrequency", "ctl01"));
        public Element Year1DeferredCashCurrencyLookup => new Element(FindElement("AnualIncomeAllowanceYear1DeferredCashCurrency", "ctl01"));

        public Element year1DeferredStockAmountBox => new Element(FindElement("AnualIncomeAllowanceYear1DeferredStockAmount", "ctl01"));
        public Element year1DeferredStockFrequencyLookup => new Element(FindElement("AnualIncomeAllowanceYear1DeferredStockFrequency", "ctl01"));
        public Element Year1DeferredStockCurrencyLookup => new Element(FindElement("AnualIncomeAllowanceYear1DeferredStockCurrency", "ctl01"));


        public Element year2CashPaidAmountBox => new Element(FindElement("AnualIncomeAllowanceYear2CashPaidAmount", "ctl01"));
        public Element year2CashPaidFrequencyLookup => new Element(FindElement("AnualIncomeAllowanceYear2CashPaidFrequency", "ctl01"));
        public Element Year2CashPaidCurrencyLookup => new Element(FindElement("AnualIncomeAllowanceYear2CashPaidCurrency", "ctl01"));


        public Element year2DeferredCashAmountBox => new Element(FindElement("AnualIncomeAllowanceYear2DeferredCashAmount", "ctl01"));
        public Element year2DeferredCashFrequencyLookup => new Element(FindElement("AnualIncomeAllowanceYear2DeferredCashFrequency", "ctl01"));
        public Element Year2DeferredCashCurrencyLookup => new Element(FindElement("AnualIncomeAllowanceYear2DeferredCashCurrency", "ctl01"));

        public Element year2DeferredStockAmountBox => new Element(FindElement("AnualIncomeAllowanceYear2DeferredStockAmount", "ctl01"));
        public Element year2DeferredStockFrequencyLookup => new Element(FindElement("AnualIncomeAllowanceYear2DeferredStockFrequency", "ctl01"));
        public Element Year2DeferredStockCurrencyLookup => new Element(FindElement("AnualIncomeAllowanceYear2DeferredStockCurrency", "ctl01"));



        public Element year3CashPaidAmountBox => new Element(FindElement("AnualIncomeAllowanceYear3CashPaidAmount", "ctl01"));
        public Element year3CashPaidFrequencyLookup => new Element(FindElement("AnualIncomeAllowanceYear3CashPaidFrequency", "ctl01"));
        public Element Year3CashPaidCurrencyLookup => new Element(FindElement("AnualIncomeAllowanceYear3CashPaidCurrency", "ctl01"));


        public Element year3DeferredCashAmountBox => new Element(FindElement("AnualIncomeAllowanceYear3DeferredCashAmount", "ctl01"));
        public Element year3DeferredCashFrequencyLookup => new Element(FindElement("AnualIncomeAllowanceYear3DeferredCashFrequency", "ctl01"));
        public Element Year3DeferredCashCurrencyLookup => new Element(FindElement("AnualIncomeAllowanceYear3DeferredCashCurrency", "ctl01"));

        public Element year3DeferredStockAmountBox => new Element(FindElement("AnualIncomeAllowanceYear3DeferredStockAmount", "ctl01"));
        public Element year3DeferredStockFrequencyLookup => new Element(FindElement("AnualIncomeAllowanceYear3DeferredStockFrequency", "ctl01"));
        public Element Year3DeferredStockCurrencyLookup => new Element(FindElement("AnualIncomeAllowanceYear3DeferredStockCurrency", "ctl01"));


        public Element otherIncomeAmountBox => new Element(FindElement("OtherIncomeYear1Amount", "ctl01"));
        public Element otherIncomeFrequencyLookup => new Element(FindElement("OtherIncomeYear1Frequency", "ctl01"));
        public Element otherIncomeCurrencyLookup => new Element(FindElement("OtherIncomeYear1Currency", "ctl01"));






        #endregion


        public Element nextBtn => new Element(FindElement("Next"))
           .SetIsButtonFlag(true)
           .SetIsPageContinueButtonFlag(true);

        public Element next2Btn => new Element(FindElement("Next"))
        .SetIsButtonFlag(true)
        .SetIsPageContinueButtonFlag(true);



    }



    public class ApplicantEmploymentData2PBR : PageData
    {
    public string employmentStatus { set; get; } = "Employed";
    public string employedFullTime { set; get; } = Defs.radioButtonYes;
    public string employedOccupation { set; get; } = "Test";
    public string employedBusinessSector { set; get; } = "Government";
    public string employedStartDate { set; get; } = "01/2010";
    public string to { set; get; } = null; 
    public string employmentPermanent { set; get; } = Defs.radioButtonYes;
    public string stillWithinProbationaryPeriod { set; get; } = Defs.radioButtonNo;
    public string employedEndDateOfProbationaryPeriod { set; get; } = null;


        public string basicIncomeAmount { set; get; } = "3000";
        public string basicIncomeFrequency { set; get; } = "Weekly";
        public string basicIncomeCurrency { set; get; } = "Pounds Sterling";

        public string carAllowanceAmount { set; get; } = "30";
        public string carAllowanceFrequency { set; get; } = "Weekly";
        public string carAllowanceCurrency { set; get; } = "Pounds Sterling";

        public string otherAllowanceAmount { set; get; } = "30";
        public string otherAllowanceFrequency { set; get; } = "Weekly";
        public string otherAllowanceCurrency { set; get; } = "Pounds Sterling";


        public string year1CashPaidAmount { set; get; } = "30";
        public string year1CashPaidFrequency { set; get; } = "Weekly";
        public string Year1CashPaidCurrency { set; get; } = "Pounds Sterling";

        public string year1DeferredCashAmount { set; get; } = "30";
        public string year1DeferredCashFrequency { set; get; } = "Weekly";
        public string Year1DeferredCashCurrency { set; get; } = "Pounds Sterling";

        public string year1DeferredStockAmount { set; get; } = "30";
        public string year1DeferredStockFrequency { set; get; } = "Weekly";
        public string Year1DeferredStockCurrency { set; get; } = "Pounds Sterling";



        public string year2CashPaidAmount { set; get; } = "30";
        public string year2CashPaidFrequency { set; get; } = "Weekly";
        public string Year2CashPaidCurrency { set; get; } = "Pounds Sterling";

        public string year2DeferredCashAmount { set; get; } = "30";
        public string year2DeferredCashFrequency { set; get; } = "Weekly";
        public string Year2DeferredCashCurrency { set; get; } = "Pounds Sterling";

        public string year2DeferredStockAmount { set; get; } = "30";
        public string year2DeferredStockFrequency { set; get; } = "Weekly";
        public string Year2DeferredStockCurrency { set; get; } = "Pounds Sterling";

        public string year3CashPaidAmount { set; get; } = "30";
        public string year3CashPaidFrequency { set; get; } = "Weekly";
        public string Year3CashPaidCurrency { set; get; } = "Pounds Sterling";

        public string year3DeferredCashAmount { set; get; } = "30";
        public string year3DeferredCashFrequency { set; get; } = "Weekly";
        public string Year3DeferredCashCurrency { set; get; } = "Pounds Sterling";

        public string year3DeferredStockAmount { set; get; } = "30";
        public string year3DeferredStockFrequency { set; get; } = "Weekly";
        public string Year3DeferredStockCurrency { set; get; } = "Pounds Sterling";


        public string otherIncomeAmount { set; get; } = "3000";
        public string otherIncomeFrequency { set; get; } = "Weekly";
        public string otherIncomeCurrency { set; get; } = "Pounds Sterling";


    }
}
