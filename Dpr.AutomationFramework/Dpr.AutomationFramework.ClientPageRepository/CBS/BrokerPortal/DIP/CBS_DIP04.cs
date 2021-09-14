using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP04 : LoanDetailsPage
    {
        public CBS_DIP04()
        {
            pageLoadedElement = loanPurpose;
            correspondingDataClass = new CBS_DIP04Data().GetType();
            textName = "CBS Loan Details Page";
        }
        public new Element loanPurpose => new Element(new RadioButton()
            .AddRadioButtonElement("Purchase", FindElement("LoanPurpose_0", tag: "input"))
            .AddRadioButtonElement("Remortgage", FindElement("LoanPurpose_1", tag: "input")));

        public new Element firstTimeBuyers => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("FirstTimeBuyer_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("FirstTimeBuyer_btn_rbl_1", tag: "input")),
            new ConditionList()
                .Add(new Condition("CBS_DIP02", "loanType", "Residential"))
                .Add(new Condition(className, "loanPurpose", "Purchase")));

        public new Element firstTimeLandlord => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("FirstTimeLandlord_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("FirstTimeLandlord_btn_rbl_1", tag: "input")),
            new ConditionList()
                .Add(new Condition("CBS_DIP02", "loanType", "BTL"))
                .Add(new Condition(className, "loanPurpose", "Purchase")));

        public new Element rightToBuy => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("RightToBuy_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("RightToBuy_btn_rbl_1", tag: "input")),
            new ConditionList()
                .Add(new Condition("CBS_DIP02", "loanType", "Residential"))
                .Add(new Condition(className, "loanPurpose", "Purchase")));

        #region 'Right To Buy' = 'Yes' Section
        public Section rightToBuyAffirmativeSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "rightToBuy", Defs.radioButtonYes))));

        public Element discountedPurchasePrice => new Element(FindElement("ctl04_PurchasePrice", tag: "input"));

        public SectionEnd rightToBuyAffirmativeSectionEnd => new SectionEnd();
        #endregion

        public new Element sharedOwnership => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("SharedOwnership_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("SharedOwnership_btn_rbl_1", tag: "input")),
            new ConditionList()
                .Add(new Condition("CBS_DIP02", "loanType", "Residential"))
                .Add(new Condition(className, "rightToBuy", Defs.radioButtonNo)));


        #region 'Shared Ownership' = 'Yes' Section
        public Section sharedOwnershipAffirmativeSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "sharedOwnership", Defs.radioButtonYes))));

        public Element housingAssociation => new Element(FindElement("OwHousingAss", tag: "select"));

        #region 'Shared Ownership' = 'Yes' - 'Loan Purpose' = 'Purchase' Section
        public Section sharedOwnershipPurchaseSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Purchase"))));
        public Element percentageBeingPurchased => new Element(FindElement("ctl04_OwAdditionalPercentage", tag: "input"));
        public SectionEnd shareOwnershipPurchaseSectionEnd => new SectionEnd();
        #endregion

        #region 'Shared Ownership' = 'Yes' - 'Loan Purpose' = 'Remortgage' Section
        public Section sharedOwnershipRemortgageSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage"))));

        public Element shareCurrentlyOwned => new Element(FindElement("OwCurrentPercentage"));
        public Element purchasingAdditionalShare => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("OwWantAdditionalPercentage_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("OwWantAdditionalPercentage_btn_rbl_1", tag: "input")));

        public Section purchasingAdditionalShareAffirmativeSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage"))));

        public Element additionalPercentageBeingPurchased => new Element(FindElement("OwAdditionalPercentage", tag: "input"));

        public SectionEnd purchasingAdditionalShareAffirmativeSectionEnd => new SectionEnd();

        public SectionEnd sharedOwnershipRemortgageSectionEnd => new SectionEnd();
        #endregion

        public Element rentalServiceCharges => new Element(FindElement("OwNewCharges", tag: "input"));

        public SectionEnd sharedOwnershipAffirmativeSectionEnd => new SectionEnd();
        #endregion

        public new Element sharedEquity => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("SharedEquity_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("SharedEquity_btn_rbl_1", tag: "input")),
            new ConditionList()
                .Add(new Condition("CBS_DIP02", "loanType", "Residential"))
                .Add(new Condition(className, "loanPurpose", "Purchase"))
                .Add(new Condition(className, "rightToBuy", Defs.radioButtonNo))
                .Add(new Condition(className, "sharedOwnership", Defs.radioButtonNo)));

        #region 'Shared Equity' = 'Yes' Section
        public Section sharedEquityAffirmativeSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "sharedEquity", Defs.radioButtonYes))));
        public Element equitySchemeProvider => new Element(FindElement("EqSchemeProvider", tag: "select"));
        public Element equityPercentage => new Element(FindElement("EqPercentage", tag: "input"));
        public SectionEnd sharedEquityAffirmativeSectionEnd => new SectionEnd();
        #endregion

        public new Element familyAssistance => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("FamilyAssistOpt_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("FamilyAssistOpt_btn_rbl_1", tag: "input")),
            new ConditionList()
                .Add(new Condition("CBS_DIP02", "loanType", "Residential"))
                .Add(new Condition(className, "rightToBuy", Defs.radioButtonNo))
                .Add(new Condition(className, "sharedOwnership", Defs.radioButtonNo))
                .Add(new Condition(className, "sharedEquity", Defs.radioButtonNo)));

        #region 'Family Assistance' = 'Yes' Section
        public Section familyAssistanceAffirmativeSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "familyAssistance", Defs.radioButtonYes))));
        public Element securedDepositAmount => new Element(FindElement("txtTotalSecurityDepositAmount", tag: "input"));
        public Element numberOfAccounts => new Element(FindElement("txtNumberOfAccounts", tag: "input"));
        public SectionEnd familyAssistanceAffirmativeSectionEnd => new SectionEnd();
        #endregion

        public new Element letToBuy => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsLetToBuy_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsLetToBuy_btn_rbl_1")),
            new ConditionList()
            .Add(new Condition("CBS_DIP02", "applicantType", "Individual"))
            .Add(new Condition("CBS_DIP02", "loanType", "BTL"))
            .Add(new Condition(className, "loanPurpose", "Remortgage")));

        public new Element estimatedValue => new Element(FindElement("ctl04_OpenMarketValue", tag: "input"));
        public new Element loanAmount => new Element(FindElement("LoanAmount", tag: "input"));
        public new Element termRequirements => new Element(FindElement("ddlTermRequirements", tag: "select"),
            new ConditionList()
                .Add(new Condition("CBS_DIP02", "loanType", "Residential")));

        public new Element repaymentType => new Element(FindElement("RepaymentType", tag: "select"));
        public new Element estimatedMonthlyRentalIncome => new Element(FindElement("BtlAnticipatedRent", tag: "input"),
            new ConditionList()
                .Add(new Condition("CBS_DIP02", "loanType", "BTL")));
        public new Element expat => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ExPat", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ExPat", "rbl_0")),
            new ConditionList()
                .Add(new Condition("CBS_DIP02", "applicantType", "Individual"))
                .Add(new Condition("CBS_DIP02", "loanType", "BTL")));

        public new Section termLengthSection => new Section(new Element(
            new ConditionList()
                .Add(new Condition(className, "termRequirements", "Standard")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(className, "termRequirements", "Both"))));

        public new Element termYears => new Element(FindElement("TermYears"));
        public new Element termMonths => new Element(FindElement("TermMonths"));

        public new SectionEnd termLengthSectionEnd => new SectionEnd();

        public Element interestOnlyAmount => new Element(FindElement("InterestOnlyAmt", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "repaymentType", "Part and Part")));

        #region 'Repayment Strategy Summary' Section
        public new Section repaymentStrategySummarySection => new Section(new Element(new ConditionList()
                /*.Add(new Condition(className, "loanPurpose", "Purchase"))*/
                .Add(new Condition(className, "repaymentType", "Interest Only")))
            .AddNewConditionList(new ConditionList()
                /*Add(new Condition(className, "loanPurpose", "Purchase"))*/
                .Add(new Condition(className, "repaymentType", "Part and Part"))));

        #region Repayment Strategy Summary Row 1
        public new Element repaymentStrategy_1 => new Element(FindElement("item0", "ddlRepaymentVehicle", tag: "select"));
        public Element repaymentPlanCost_1 => new Element(FindElement("item0", "PlanCost", "!Dummy", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "repaymentStrategy_1", "Sale of Security Property", Defs.conditionTypeNotEqual)));
        public Element repaymentPlanFrequency_1 => new Element(FindElement("item0", "PlanFrequency", "!Dummy", tag: "select"),
            new ConditionList()
                .Add(new Condition(className, "repaymentStrategy_1", "Sale of Security Property", Defs.conditionTypeNotEqual)));
        public Element projectedValue_1 => new Element(FindElement("item0", "ProjectedValue", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "repaymentStrategy_1", "Sale of Security Property", Defs.conditionTypeNotEqual)));
        #endregion

        #region Repayment Strategy Summary Row 2
        public Element repaymentStrategy_2 => new Element(FindElement("item1", "ddlRepaymentVehicle", tag: "select"),
            new ConditionList()
                .Add(new Condition(className, "repaymentStrategy_2", null, Defs.conditionTypeNotEqual)),
                repaymentStrategySummaryAddMore);
        public Element repaymentPlanCost_2 => new Element(FindElement("item1", "PlanCost", "!Dummy", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "repaymentStrategy_2", "Sale of Security Property", Defs.conditionTypeNotEqual))
                .Add(new Condition(className, "repaymentStrategy_2", null, Defs.conditionTypeNotEqual)),
                repaymentStrategySummaryAddMore);
        public Element repaymentPlanFrequency_2 => new Element(FindElement("item1", "PlanFrequency", "!Dummy", tag: "select"),
            new ConditionList()
                .Add(new Condition(className, "repaymentStrategy_2", "Sale of Security Property", Defs.conditionTypeNotEqual))
                .Add(new Condition(className, "repaymentStrategy_2", null, Defs.conditionTypeNotEqual)),
                repaymentStrategySummaryAddMore);
        public Element projectedValue_2 => new Element(FindElement("item1", "ProjectedValue", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "repaymentStrategy_2", "Sale of Security Property", Defs.conditionTypeNotEqual))
                .Add(new Condition(className, "repaymentStrategy_2", null, Defs.conditionTypeNotEqual)),
                repaymentStrategySummaryAddMore);
        #endregion

        #region Repayment Strategy Summary Row 3
        public Element repaymentStrategy_3 => new Element(FindElement("item2", "ddlRepaymentVehicle", tag: "select"),
            new ConditionList()
                .Add(new Condition(className, "repaymentStrategy_3", null, Defs.conditionTypeNotEqual)),
                repaymentStrategySummaryAddMore);
        public Element repaymentPlanCost_3 => new Element(FindElement("item2", "PlanCost", "!Dummy", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "repaymentStrategy_3", "Sale of Security Property", Defs.conditionTypeNotEqual))
                .Add(new Condition(className, "repaymentStrategy_3", null, Defs.conditionTypeNotEqual)),
                repaymentStrategySummaryAddMore);
        public Element repaymentPlanFrequency_3 => new Element(FindElement("item2", "PlanFrequency", "!Dummy", tag: "select"),
            new ConditionList()
                .Add(new Condition(className, "repaymentStrategy_3", "Sale of Security Property", Defs.conditionTypeNotEqual))
                .Add(new Condition(className, "repaymentStrategy_3", null, Defs.conditionTypeNotEqual)),
                repaymentStrategySummaryAddMore);
        public Element projectedValue_3 => new Element(FindElement("item2", "ProjectedValue", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "repaymentStrategy_3", "Sale of Security Property", Defs.conditionTypeNotEqual))
                .Add(new Condition(className, "repaymentStrategy_3", null, Defs.conditionTypeNotEqual)),
                repaymentStrategySummaryAddMore);
        #endregion

        public Element repaymentStrategySummaryAddMore => new Element(FindElement("rptRepaymentVehicles", "btnAdd"))
            .SetCompletePageFlag(false);

        public new SectionEnd repaymentStrategySummarySectionEnd => new SectionEnd();
        #endregion

        #region Loan Amount Breakdown section locators

        #region Use of Funds - row 1
        public new Element loanAllocation_1 => new Element(FindElement("MC_ucLoanDetails_ctl04_ctl185_rptCapitalRaisingPurpose_item0_LoanPurpose", "!-button", "!ListLookup", "!ReqVal"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage")));

        public new Element loanAllocationAmountBox_1 => new Element(FindElement("CapitalRaisingPurpose", "_Amount", "item0"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage")))
            .SetValidationType(Defs.validationTypeLoanBreakdown);
        #endregion

        #region Use of Funds - row 2
        public new Element loanAllocation_2 => new Element(FindElement("MC_ucLoanDetails_ctl04_ctl185_rptCapitalRaisingPurpose_item1_LoanPurpose", "!-button", "!ListLookup", "!ReqVal"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage"))
            .Add(new Condition(className, "loanAllocation_2", null, Defs.conditionTypeNotEqual)),
            loanAllocationAdd);

        public new Element loanAllocationAmountBox_2 => new Element(FindElement("CapitalRaisingPurpose", "_Amount", "item1"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage"))
            .Add(new Condition(className, "loanAllocation_2", null, Defs.conditionTypeNotEqual)),
            loanAllocationAdd)
            .SetValidationType(Defs.validationTypeCalculativeRepeater);
        #endregion

        #region Use of Funds - row 3
        public new Element loanAllocation_3 => new Element(FindElement("MC_ucLoanDetails_ctl04_ctl185_rptCapitalRaisingPurpose_item02_LoanPurpose", "!-button", "!ListLookup", "!ReqVal"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage"))
            .Add(new Condition(className, "loanAllocation_3", null, Defs.conditionTypeNotEqual)),
            loanAllocationAdd);

        public new Element loanAllocationAmountBox_3 => new Element(FindElement("CapitalRaisingPurpose", "_Amount", "item2"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage"))
            .Add(new Condition(className, "loanAllocation_3", null, Defs.conditionTypeNotEqual)),
            loanAllocationAdd)
            .SetValidationType(Defs.validationTypeCalculativeRepeater);
        #endregion

        public new Element loanAllocationAdd => new Element(FindElement("CapitalRaisingPurpose", "btnAdd"))
            .SetCompletePageFlag(false);
        #endregion

        public new Element applicantsMainResidence => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radApplicantLive_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radApplicantLive_btn_rbl_1")),
            new ConditionList()
                .Add(new Condition("CBS_DIP02", "loanType", "Residential")));

        public new Element youOrSomeoneRelatedLivingInProperty => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radFamilyLive", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radFamilyLive", "rbl_1")),
            new ConditionList()
                .Add(new Condition("CBS_DIP02", "loanType", "BTL")));
    }

    public class CBS_DIP04Data : LoanDetailsPageData
    {
        public string discountedPurchasePrice { get; set; } = null;

        public new string estimatedValue { get; set; } = "200000";

        #region 'Shared Ownership' = 'Yes' Data Data Section
        public string housingAssociation { get; set; } = null;

        #region 'Shared Ownership' = 'Yes' - 'Loan Purpose' = 'Purchase' Data Section
        public string percentageBeingPurchased { get; set; } = null;
        #endregion

        #region 'Shared Ownership' = 'Yes' - 'Loan Purpose' = 'Remortgage' Data Section
        public string purchasingAdditionalShare { get; set; } = null;
        public string shareCurrentlyOwned { get; set; } = null;
        public string additionalPercentageBeingPurchased { get; set; } = null;

        #endregion

        public string rentalServiceCharges { get; set; } = null;
        #endregion

        public new string familyAssistance { get; set; } = Defs.radioButtonNo;

        #region 'Family Assistance' = 'Yes' Data Section
        public string securedDepositAmount { get; set; } = null;
        public string numberOfAccounts { get; set; } = null;
        #endregion

        #region 'Shared Equity' = 'Yes' Data Section
        public string equitySchemeProvider { get; set; } = null;
        public string equityPercentage { get; set; } = null;
        #endregion

        public string interestOnlyAmount { get; set; } = null;

        #region 'Repayment Strategy Sumamry' Data Section

        #region Repayment Strategy Summary Row 1
        public new string repaymentStrategy_1 { get; set; } = "Sale of Security Property";
        public string repaymentPlanCost_1 { get; set; } = null;
        public string repaymentPlanFrequency_1 { get; set; } = null;
        public string projectedValue_1 { get; set; } = null;
        #endregion

        #region Repayment Strategy Summary Row 2
        public string repaymentStrategy_2 { get; set; } = null;
        public string repaymentPlanCost_2 { get; set; } = null;
        public string repaymentPlanFrequency_2 { get; set; } = null;
        public string projectedValue_2 { get; set; } = null;
        #endregion

        #region Repayment Strategy Summary Row 3
        public string repaymentStrategy_3 { get; set; } = null;
        public string repaymentPlanCost_3 { get; set; } = null;
        public string repaymentPlanFrequency_3 { get; set; } = null;
        public string projectedValue_3 { get; set; } = null;
        #endregion

        #endregion
    }
}
