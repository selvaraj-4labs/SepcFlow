using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PBR.Intermediary.PortalPages
{
    class LoanDetailsPagePBR : WebBasePage
    {

        public LoanDetailsPagePBR()
        {
            pageLoadedElement = typeOfLoanLookup;

            correspondingDataClass = new LoanDetailsData().GetType();
            //javascriptPageNavigator = @"javascript:__doPostBack('ctl00$MC$Menu1','bLoanDetails')";
        }

        #region Loan Details section locators
        public Element loanPurposeRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Purchase", FindElement("LoanPurpose", "_0"))
            .AddRadioButtonElement("Remortgage", FindElement("LoanPurpose", "_1")));
        public Element typeOfLoanLookup => new Element(FindElement("LoanType"))
            .SetCompletePageFlag(false);

        public Element isSelfBuildRbtn => new Element(
          new RadioButton()
          .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsSelfBuild", "rbl_0"))
          .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsSelfBuild", "rbl_1")),
          new ConditionList()
          .Add(new Condition(className, "loanPurpose", "Purchase"))
          .Add(new Condition("ApplicantLoanTypePagePBR", "loanType", "Residential")));

        public Element isApplicantFTBRbtn => new Element(
            new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("FirstTimeBuyer", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("FirstTimeBuyer", "rbl_1")),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Purchase"))
            .Add(new Condition("ApplicantLoanTypePagePBR", "loanType", "Residential")));

        public Element isRTBRbtn => new Element(
          new RadioButton()
          .AddRadioButtonElement(Defs.radioButtonYes, FindElement("RightToBuy", "rbl_0"))
          .AddRadioButtonElement(Defs.radioButtonNo, FindElement("RightToBuy", "rbl_1")),
          new ConditionList()
          .Add(new Condition(className, "loanPurpose", "Purchase"))
          .Add(new Condition("ApplicantLoanTypePagePBR", "loanType", "Residential")));

        //public Element isApplicantFirstTimeLandlordRbtn => new Element(
        //    new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("FirstTimeLandlord", "rbl_0"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("FirstTimeLandlord", "rbl_1")),
        //    new ConditionList()
        //    .Add(new Condition(className, "loanPurpose", "Purchase"))
        //    .Add(new Condition("ApplicantLoanTypePagePBR", "loanType", "BTL")));

        public Element purchasePriceBox => new Element(FindElement("_PurchasePrice"));

        public Element loanAmountBox => new Element(FindElement("_LoanAmount"));

        public Element ltvBox => new Element(FindElement("LTV"))
            .SetCompletePageFlag(false);

        //public Element anticipatedMonthlyRentalIncomeBox => new Element(FindElement("BtlAnticipatedRent"),
        //    new ConditionList()
        //    .Add(new Condition("ApplicantLoanTypePagePBR", "loanType", "BTL")));

        public Element termRequirements => new Element(FindElement("_ddlTermRequirements"));

        public Element termBox => new Element(FindElement("TermYears"))
            .SetValidationType(Defs.validationTypeNumberOfYears);

        

        public Element termMonthsBox => new Element(FindElement("TermMonths"))
        .SetValidationType(Defs.validationTypeNumberOfMonths);

        public Element repaymentTypeLookup => new Element(FindElement("RepaymentType"));

        

        //public Element propertyLocationLookup => new Element(FindElement("PropertyLocation"));

        public Element interestOnlyAmountBox => new Element(FindElement("InterestOnlyAmt"),
            new ConditionList()
            .Add(new Condition(className, "repaymentType", "Part and Part")))
            .SetValidationType(Defs.validationTypeInterestOnlyAmount);


        #endregion

        #region Loan/Occupancy Details section locators

        //public Element applicantsMainResidenceRbtn => new Element(
        //    new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radApplicantLive", "rbl_0"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radApplicantLive", "rbl_1")),
        //    new ConditionList()
        //    .Add(new Condition("ApplicantLoanTypePage", "loanType", "Residential")));

        //public Element anyOfPropertyLetOrSubLetRbtn => new Element(
        //    new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radIntendToLet", "rbl_0"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radIntendToLet", "rbl_1")),
        //    new ConditionList()
        //    .Add(new Condition("ApplicantLoanTypePage", "loanType", "Residential")));

        //public Element applicantOrCloseRelativeOccupyPropertyRbtn => new Element(
        //    new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radFamilyLive", "rbl_0"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radFamilyLive", "rbl_1")),
        //    new ConditionList()
        //    .Add(new Condition("ApplicantLoanTypePage", "loanType", "BTL")));


        #endregion

        #region Source Of Deposit section locators

        public Section sourceOfDepositSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Purchase"))));

        //Source of deposit - row 1
        public Element sourceOfDepositLookup_1 => new Element(FindElement("_SourceOfDeposit", "item0"));

        public Element sourceOfDepositAmountBox_1 => new Element(FindElement("SourceOfDeposit", "_Amount", "item0"))
            .SetValidationType(Defs.validationTypeSourceOfDeposit);

        ////Source of deposit - row 2
        //public Element sourceOfDepositLookup_2 => new Element(FindElement("_SourceOfDeposit", "item1"),
        //    new ConditionList()
        //    .Add(new Condition(className, "sourceOfDeposit_2", null, Defs.conditionTypeNotEqual)),
        //    sourceOfDepositAddMoreBtn);

        //public Element sourceOfDepositAmountBox_2 => new Element(FindElement("SourceOfDeposit", "_Amount", "item1"),
        //    new ConditionList()
        //    .Add(new Condition(className, "sourceOfDeposit_2", null, Defs.conditionTypeNotEqual)),
        //    sourceOfDepositAddMoreBtn)
        //    .SetValidationType(Defs.validationTypeCalculativeRepeater);

        ////Source of deposit - row 3
        //public Element sourceOfDepositLookup_3 => new Element(FindElement("_SourceOfDeposit", "item2"),
        //    new ConditionList()
        //    .Add(new Condition(className, "sourceOfDeposit_3", null, Defs.conditionTypeNotEqual)),
        //    sourceOfDepositAddMoreBtn);

        //public Element sourceOfDepositAmountBox_3 => new Element(FindElement("SourceOfDeposit", "_Amount", "item2"),
        //    new ConditionList()
        //    .Add(new Condition(className, "sourceOfDeposit_3", null, Defs.conditionTypeNotEqual)),
        //    sourceOfDepositAddMoreBtn)
        //    .SetValidationType(Defs.validationTypeCalculativeRepeater);

        //public SectionEnd sourceOfDepositSectionEnd => new SectionEnd();

        //public Element sourceOfDepositAddMoreBtn => new Element(FindElement("SourceOfDeposit", "btnAdd"))
        //    .SetCompletePageFlag(false);
        #endregion

        #region Use of Funds section locators

        //Use of Funds - row 1
        public Element purposeOfBorrowingLookup_1 => new Element(FindElement("_LoanPurpose", "item0"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage")));

        public Element purposeOfBorrowingAmountBox_1 => new Element(FindElement("CapitalRaisingPurpose", "_Amount", "item0"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage")))
            .SetValidationType(Defs.validationTypeLoanBreakdown);

        //Use of Funds - row 2
        public Element purposeOfBorrowingLookup_2 => new Element(FindElement("_LoanPurpose", "item1"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage"))
            .Add(new Condition(className, "purposeOfBorrowing_2", null, Defs.conditionTypeNotEqual)),
            useOfFundsAddMoreBtn);

        public Element purposeOfBorrowingAmountBox_2 => new Element(FindElement("CapitalRaisingPurpose", "_Amount", "item1"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage"))
            .Add(new Condition(className, "purposeOfBorrowing_2", null, Defs.conditionTypeNotEqual)),
            useOfFundsAddMoreBtn)
                        .SetValidationType(Defs.validationTypeCalculativeRepeater);

        //Use of Funds - row 3
        public Element purposeOfBorrowingLookup_3 => new Element(FindElement("_LoanPurpose", "item2"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage"))
            .Add(new Condition(className, "purposeOfBorrowing_3", null, Defs.conditionTypeNotEqual)),
            useOfFundsAddMoreBtn);

        public Element purposeOfBorrowingAmountBox_3 => new Element(FindElement("CapitalRaisingPurpose", "_Amount", "item2"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage"))
            .Add(new Condition(className, "purposeOfBorrowing_3", null, Defs.conditionTypeNotEqual)),
            useOfFundsAddMoreBtn)
                        .SetValidationType(Defs.validationTypeCalculativeRepeater);

        public Element useOfFundsAddMoreBtn => new Element(FindElement("CapitalRaisingPurpose", "btnAdd"))
            .SetCompletePageFlag(false);
        #endregion

        #region Repayment Strategy Details

        //Repayment strategy - row 1
        public Element repaymentStrategyLookup_1 => new Element(FindElement("ddlRepaymentVehicle", "item0", "!Plan"),
            new ConditionList()
            .Add(new Condition(className, "repaymentType", "Interest Only")))
            .AddNewConditionList(
            new ConditionList()
            .Add(new Condition(className, "repaymentType", "Part and Part")));

        public Element repaymentPlanCostBox_1 => new Element(FindElement("PlanCost", "item0"),
            new ConditionList()
            .Add(new Condition(className, "repaymentType", "Interest Only"))
            .Add(new Condition(className, "repaymentStrategy_1", "Inheritance")))
            .AddNewConditionList(
            new ConditionList()
            .Add(new Condition(className, "repaymentType", "Part and Part"))
            .Add(new Condition(className, "repaymentStrategy_1", "Inheritance")));

        public Element paymentPlanFrequencyLookup_1 => new Element(FindElement("PlanFrequency", "item0", "!Dummy"),
            new ConditionList()
            .Add(new Condition(className, "repaymentType", "Interest Only")))
            .AddNewConditionList(
            new ConditionList()
            .Add(new Condition(className, "repaymentType", "Part and Part")));

        public Element projectedRepaymentAmountBox_1 => new Element(FindElement("ProjectedValue", "item0"),
            new ConditionList()
            .Add(new Condition(className, "repaymentType", "Interest Only")))
            .AddNewConditionList(
            new ConditionList()
            .Add(new Condition(className, "repaymentType", "Part and Part")))
            .SetValidationType(Defs.validationTypeRepaymentStrategy);


        //Repayment strategy - row 2
        public Element repaymentStrategyLookup_2 => new Element(FindElement("ddlRepaymentVehicle", "item1"),
            new ConditionList()
            .Add(new Condition(className, "repaymentStrategy_2", null, Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "repaymentType", "Interest Only")),
            addRepaymentStrategyBtn)
            .AddNewConditionList(
            new ConditionList()
            .Add(new Condition(className, "repaymentStrategy_2", null, Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "repaymentType", "Part and Part")));

        public Element repaymentPlanCostBox_2 => new Element(FindElement("PlanCost", "item1"),
            new ConditionList()
            .Add(new Condition(className, "repaymentStrategy_2", null, Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "repaymentType", "Interest Only"))
            .Add(new Condition(className, "repaymentStrategy_2", "Inheritance")),
            addRepaymentStrategyBtn)
            .AddNewConditionList(
            new ConditionList()
            .Add(new Condition(className, "repaymentStrategy_2", null, Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "repaymentType", "Part and Part"))
            .Add(new Condition(className, "repaymentStrategy_2", "Inheritance")));

        public Element paymentPlanFrequencyLookup_2 => new Element(FindElement("PlanFrequency", "item1", "!Dummy"),
            new ConditionList()
            .Add(new Condition(className, "repaymentStrategy_2", null, Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "repaymentType", "Interest Only")),
            addRepaymentStrategyBtn)
            .AddNewConditionList(
            new ConditionList()
            .Add(new Condition(className, "repaymentStrategy_2", null, Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "repaymentType", "Part and Part")));

        public Element projectedRepaymentAmountBox_2 => new Element(FindElement("ProjectedValue", "item1"),
            new ConditionList()
            .Add(new Condition(className, "repaymentStrategy_2", null, Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "repaymentType", "Interest Only")),
            addRepaymentStrategyBtn)
            .AddNewConditionList(
            new ConditionList()
            .Add(new Condition(className, "repaymentStrategy_2", null, Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "repaymentType", "Part and Part")))
                        .SetValidationType(Defs.validationTypeCalculativeRepeater);

        //Repayment strategy - row 3
        public Element repaymentStrategyLookup_3 => new Element(FindElement("ddlRepaymentVehicle", "item2"),
            new ConditionList()
            .Add(new Condition(className, "repaymentStrategy_3", null, Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "repaymentType", "Interest Only")),
            addRepaymentStrategyBtn)
            .AddNewConditionList(
            new ConditionList()
            .Add(new Condition(className, "repaymentStrategy_3", null, Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "repaymentType", "Part and Part")));

        public Element repaymentPlanCostBox_3 => new Element(FindElement("PlanCost", "item2"),
            new ConditionList()
            .Add(new Condition(className, "repaymentStrategy_3", null, Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "repaymentType", "Interest Only"))
            .Add(new Condition(className, "repaymentStrategy_3", "Inheritance")),
            addRepaymentStrategyBtn)
            .AddNewConditionList(
            new ConditionList()
            .Add(new Condition(className, "repaymentStrategy_3", null, Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "repaymentType", "Part and Part"))
            .Add(new Condition(className, "repaymentStrategy_3", "Inheritance")));

        public Element paymentPlanFrequencyLookup_3 => new Element(FindElement("PlanFrequency", "item2", "!Dummy"),
            new ConditionList()
            .Add(new Condition(className, "repaymentStrategy_3", null, Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "repaymentType", "Interest Only")),
            addRepaymentStrategyBtn)
            .AddNewConditionList(
            new ConditionList()
            .Add(new Condition(className, "repaymentStrategy_3", null, Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "repaymentType", "Part and Part")));

        public Element projectedRepaymentAmountBox_3 => new Element(FindElement("ProjectedValue", "item2"),
            new ConditionList()
            .Add(new Condition(className, "repaymentStrategy_3", null, Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "repaymentType", "Interest Only")),
            addRepaymentStrategyBtn)
            .AddNewConditionList(
            new ConditionList()
            .Add(new Condition(className, "repaymentStrategy_3", null, Defs.conditionTypeNotEqual))
            .Add(new Condition(className, "repaymentType", "Part and Part")))
                        .SetValidationType(Defs.validationTypeCalculativeRepeater);

        public Element addRepaymentStrategyBtn => new Element(FindElement("RepaymentVehicles", "btnAdd"))
            .SetCompletePageFlag(false);

        #endregion

        #region Consumer Buy To Let

        public Element isCbtlRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ConsumerBuyToLet", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ConsumerBuyToLet", "rbl_1")),
            new ConditionList()
            .Add(new Condition("ApplicantLoanTypePagePBR", "loanType", "BTL"))
            .Add(new Condition(className, "loanPurpose", "Remortgage")));

        public Element confirmFcaHoldRelevantPermissionsRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ConsumerBuyToLet", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ConsumerBuyToLet", "rbl_1")),
            new ConditionList()
            .Add(new Condition("ApplicantLoanTypePagePBR", "loanType", "BTL"))
            .Add(new Condition(className, "loanPurpose", "Remortgage"))
            .Add(new Condition(className, "isCbtl", Defs.radioButtonYes)));
        #endregion

        #region Intermediary Fees section locators

        public Element chargingIntermediaryFeesRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HasIntermediaryFees", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HasIntermediaryFees", "rbl_1")));


        //Intermediary fees - Row 1
        public Element intFeeDescriptionLookup_1 => new Element(FindElement("FeeDescription", "item0", "cbo"),
            new ConditionList()
            .Add(new Condition(className, "chargingIntermediaryFees", Defs.radioButtonYes)));

        public Element intFeeAmountBox_1 => new Element(FindElement("FeeAmount", "item0"),
            new ConditionList()
            .Add(new Condition(className, "chargingIntermediaryFees", Defs.radioButtonYes)));

        public Element intFeeWhenPayableLookup_1 => new Element(FindElement("FeeWhenPayable", "item0"),
            new ConditionList()
            .Add(new Condition(className, "chargingIntermediaryFees", Defs.radioButtonYes)));

        public Element intFeeRefundAmountBox_1 => new Element(FindElement("FeeRefundableAmount", "item0"),
            new ConditionList()
            .Add(new Condition(className, "chargingIntermediaryFees", Defs.radioButtonYes)));

        ////Intermediary fees - Row 2
        //public Element intFeeDescriptionLookup_2 => new Element(FindElement("FeeDescription", "item1", "cbo"),
        //    new ConditionList()
        //    .Add(new Condition(className, "intFeeDescription_2", null, Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "chargingIntermediaryFees", Defs.radioButtonYes)),
        //    intermediaryFeesAddMoreBtn);

        //public Element intFeeAmountBox_2 => new Element(FindElement("FeeAmount", "item1"),
        //    new ConditionList()
        //    .Add(new Condition(className, "intFeeDescription_2", null, Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "chargingIntermediaryFees", Defs.radioButtonYes)),
        //    intermediaryFeesAddMoreBtn);

        //public Element intFeeWhenPayableLookup_2 => new Element(FindElement("FeeWhenPayable", "item1"),
        //    new ConditionList()
        //    .Add(new Condition(className, "intFeeDescription_2", null, Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "chargingIntermediaryFees", Defs.radioButtonYes)),
        //    intermediaryFeesAddMoreBtn);

        //public Element intFeeRefundAmountBox_2 => new Element(FindElement("FeeRefundableAmount", "item1"),
        //    new ConditionList()
        //    .Add(new Condition(className, "intFeeDescription_2", null, Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "chargingIntermediaryFees", Defs.radioButtonYes)),
        //    intermediaryFeesAddMoreBtn);



        ////Intermediary fees - Row 3
        //public Element intFeeDescriptionLookup_3 => new Element(FindElement("FeeDescription", "item2", "cbo"),
        //     new ConditionList()
        //    .Add(new Condition(className, "intFeeDescription_3", null, Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "chargingIntermediaryFees", Defs.radioButtonYes)),
        //    intermediaryFeesAddMoreBtn);

        //public Element intFeeAmountBox_3 => new Element(FindElement("FeeAmount", "item2"),
        //    new ConditionList()
        //    .Add(new Condition(className, "intFeeDescription_3", null, Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "chargingIntermediaryFees", Defs.radioButtonYes)),
        //    intermediaryFeesAddMoreBtn);

        //public Element intFeeWhenPayableLookup_3 => new Element(FindElement("FeeWhenPayable", "item2"),
        //    new ConditionList()
        //    .Add(new Condition(className, "intFeeDescription_3", null, Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "chargingIntermediaryFees", Defs.radioButtonYes)),
        //    intermediaryFeesAddMoreBtn);

        //public Element intFeeRefundAmountBox_3 => new Element(FindElement("FeeRefundableAmount", "item2"),
        //    new ConditionList()
        //    .Add(new Condition(className, "intFeeDescription_3", null, Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "chargingIntermediaryFees", Defs.radioButtonYes)),
        //    intermediaryFeesAddMoreBtn);

        //public Element intermediaryFeesAddMoreBtn => new Element(FindElement("IntermediaryFees", "btnAdd"))
        //    .SetCompletePageFlag(false);

        #endregion

        public Element willAllLivingInThePropertyRbtn => new Element(new RadioButton()
        .AddRadioButtonElement(Defs.radioButtonYes, FindElement("qffWillAllLivingInTheProperty", "rbl_0"))
        .AddRadioButtonElement(Defs.radioButtonNo, FindElement("qffWillAllLivingInTheProperty", "rbl_1")));

        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);

    }

    public class LoanDetailsData : PageData
    {
        public string loanPurpose { get; set; } = "purchase"; 
        public string isSelfBuild { get; set; } = Defs.radioButtonNo;
        public string isApplicantFTB { get; set; } = Defs.radioButtonNo;
        public string isRTB { get; set; } = Defs.radioButtonNo;

        //public string isApplicantFirstTimeLandlord { get; set; } = Defs.radioButtonNo;
        public string purchasePrice { get; set; } = "200000";
        public string loanAmount { get; set; } = "100000";
        //public string anticipatedMonthlyRentalIncome { get; set; } = "5000";

        public string termRequirements { get; set; } = "Standard";
        
        public string term { get; set; } = "20";
        public string termMonths { get; set; } = "2";
        public string repaymentType { get; set; } = "Capital Repayment";
        //public string propertyLocation { get; set; } = "England and Wales";

        public string repaymentStrategy_1 { get; set; } = "Inheritance";
        public string repaymentPlanCost_1 { get; set; } = "500";
        public string paymentPlanFrequency_1 { get; set; } = "Monthly";
        public string projectedRepaymentAmount_1 { get; set; } = "100000";

        public string repaymentStrategy_2 { get; set; } = null;
        public string repaymentPlanCost_2 { get; set; } = null;
        public string paymentPlanFrequency_2 { get; set; } = null;
        public string projectedRepaymentAmount_2 { get; set; } = null;

        public string repaymentStrategy_3 { get; set; } = null;
        public string repaymentPlanCost_3 { get; set; } = null;
        public string paymentPlanFrequency_3 { get; set; } = null;
        public string projectedRepaymentAmount_3 { get; set; } = null;

        public string interestOnlyAmount { get; set; } = "5000";
        public string applicantsMainResidence { get; set; } = Defs.radioButtonYes;
        public string anyOfPropertyLetOrSubLet { get; set; } = Defs.radioButtonNo;
        public string applicantOrCloseRelativeOccupyProperty { get; set; } = Defs.radioButtonNo;

        public string sourceOfDeposit_1 { get; set; } = "Savings";
        public string sourceOfDepositAmount_1 { get; set; } = "100000";
        public string sourceOfDeposit_2 { get; set; } = null;
        public string sourceOfDepositAmount_2 { get; set; } = null;
        public string sourceOfDeposit_3 { get; set; } = null;
        public string sourceOfDepositAmount_3 { get; set; } = null;

        public string purposeOfBorrowing_1 { get; set; } = "Home Improvements";
        public string purposeOfBorrowingAmount_1 { get; set; } = "100000";
        public string purposeOfBorrowing_2 { get; set; } = null;
        public string purposeOfBorrowingAmount_2 { get; set; } = null;
        public string purposeOfBorrowing_3 { get; set; } = null;
        public string purposeOfBorrowingAmount_3 { get; set; } = null;

        public string isCbtl { get; set; } = Defs.radioButtonNo;
        public string confirmFcaHoldRelevantPermissionsRbtn { get; set; } = Defs.radioButtonYes;

        public string chargingIntermediaryFees { get; set; } = Defs.radioButtonNo;
        public string intFeeDescription_1 { get; set; } = "Intermediary Advice Fee";
        public string intFeeAmount_1 { get; set; } = "50";
        public string intFeeWhenPayable_1 { get; set; } = "On Offer";
        public string intFeeRefundAmount_1 { get; set; } = "25";

        public string intFeeDescription_2 { get; set; } = null;
        public string intFeeAmount_2 { get; set; } = null;
        public string intFeeWhenPayable_2 { get; set; } = null;
        public string intFeeRefundAmount_2 { get; set; } = null;

        public string intFeeDescription_3 { get; set; } = null;
        public string intFeeAmount_3 { get; set; } = null;
        public string intFeeWhenPayable_3 { get; set; } = null;
        public string intFeeRefundAmount_3 { get; set; } = null;

        public string willAllLivingInTheProperty { get; set; } = Defs.radioButtonYes;
    }
}


