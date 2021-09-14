using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP04 : CBS_DIP04
    {
        public CBS_ADV_DIP04()
        {
            pageLoadedElement = loanPurpose;
            correspondingDataClass = new CBS_ADV_DIP04Data().GetType();
            textName = "CBS Advised Loan Details Page";
        }

        #region 'Loan details' Section
        public new Element loanPurpose => new Element(new RadioButton()
            .AddRadioButtonElement("Purchase", FindElement("LoanPurpose_0", tag: "input"))
            .AddRadioButtonElement("Remortgage", FindElement("LoanPurpose_1", tag: "input")));

        public new Element firstTimeBuyers => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("FirstTimeBuyer_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("FirstTimeBuyer_btn_rbl_1", tag: "input")),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "Residential"))
                .Add(new Condition(className, "loanPurpose", "Purchase")));

        public new Element firstTimeLandlord => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("FirstTimeLandlord_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("FirstTimeLandlord_btn_rbl_1", tag: "input")),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "BTL"))
                .Add(new Condition(className, "loanPurpose", "Purchase")));

        public new Element rightToBuy => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("RightToBuy_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("RightToBuy_btn_rbl_1", tag: "input")),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "Residential"))
                .Add(new Condition(className, "loanPurpose", "Purchase")));
        public new Element sharedOwnership => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("SharedOwnership_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("SharedOwnership_btn_rbl_1", tag: "input")),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "Residential"))
                .Add(new Condition(className, "rightToBuy", Defs.radioButtonNo)));

        public new Element sharedEquity => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("SharedEquity_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("SharedEquity_btn_rbl_1", tag: "input")),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "Residential"))
                .Add(new Condition(className, "loanPurpose", "Purchase"))
                .Add(new Condition(className, "rightToBuy", Defs.radioButtonNo))
                .Add(new Condition(className, "sharedOwnership", Defs.radioButtonNo)));

        public new Element familyAssistance => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("FamilyAssistOpt_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("FamilyAssistOpt_btn_rbl_1", tag: "input")),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "Residential"))
                .Add(new Condition(className, "rightToBuy", Defs.radioButtonNo))
                .Add(new Condition(className, "sharedOwnership", Defs.radioButtonNo))
                .Add(new Condition(className, "sharedEquity", Defs.radioButtonNo)));

        //#region 'Family Assistance' = 'Yes' Section
        //public new Section familyAssistanceAffirmativeSection => new Section(new Element(new ConditionList()
        //    .Add(new Condition(className, "familyAssistance", Defs.radioButtonYes))));
        //public new Element securedDepositAmount => new Element(FindElement("txtTotalAdditionalSecurityValue", tag: "input"));
        //public new Element numberOfAccounts => new Element(FindElement("txtNumberOfAdditionalSecurities", tag: "input"));
        //public new SectionEnd familyAssistanceAffirmativeSectionEnd => new SectionEnd();
        //#endregion

        public new Element letToBuy => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsLetToBuy_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsLetToBuy_btn_rbl_1")),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP02", "loanType", "BTL"))
            .Add(new Condition(className, "loanPurpose", "Remortgage")));

        public new Element estimatedValue => new Element(FindElement("ctl04_OpenMarketValue", tag: "input"));
        public new Element loanAmount => new Element(FindElement("LoanAmount", tag: "input"));
        public new Element termRequirements => new Element(FindElement("ddlTermRequirements", tag: "select"),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "Residential")));

        public new Element repaymentType => new Element(FindElement("RepaymentType", tag: "select"));
        public new Element estimatedMonthlyRentalIncome => new Element(FindElement("BtlAnticipatedRent", tag: "input"),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "BTL")));
        public new Element expat => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ExPat", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ExPat", "rbl_0")),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "BTL")));
        #endregion

        #region 'Occupancy Details' Section
        public new Element applicantsMainResidence => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radApplicantLive_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radApplicantLive_btn_rbl_1")),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "Residential")));

        public new Element youOrSomeoneRelatedLivingInProperty => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radFamilyLive", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radFamilyLive", "rbl_1")),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "BTL")));
        #endregion

        #region Loan Amount Breakdown section locators

        //Use of Funds - row 1
        public new Element loanAllocation_1 => new Element(FindElement("MainCnt_ucLoanDetails_ctl04_ctl185_rptCapitalRaisingPurpose_item0_LoanPurpose", "!-button", "!ListLookup", "!ReqVal"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage")));

        //Use of Funds - row 2
        public new Element loanAllocation_2 => new Element(FindElement("MainCnt_ucLoanDetails_ctl04_ctl185_rptCapitalRaisingPurpose_item1_LoanPurpose", "!-button", "!ListLookup", "!ReqVal"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage"))
            .Add(new Condition(className, "loanAllocation_2", null, Defs.conditionTypeNotEqual)),
            loanAllocationAdd);

        //Use of Funds - row 3
        public new Element loanAllocation_3 => new Element(FindElement("MainCnt_ucLoanDetails_ctl04_ctl185_rptCapitalRaisingPurpose_item02_LoanPurpose", "!-button", "!ListLookup", "!ReqVal"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage"))
            .Add(new Condition(className, "loanAllocation_3", null, Defs.conditionTypeNotEqual)),
            loanAllocationAdd);
        #endregion
    }

    public class CBS_ADV_DIP04Data : CBS_DIP04Data
    {
        public new string numberOfAccounts { get; set; } = "2";
    }
}
