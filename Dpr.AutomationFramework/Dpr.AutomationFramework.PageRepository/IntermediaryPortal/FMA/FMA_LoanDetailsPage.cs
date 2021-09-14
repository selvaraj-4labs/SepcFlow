using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_LoanDetailsPage : WebBasePage
    {
        public FMA_LoanDetailsPage()
        {
            pageLoadedElement = loanPurpose;
            correspondingDataClass = new FMA_LoanDetailsPageData().GetType();
            textName = "FMA Loan Details Page";
        }
        public Element loanPurpose => new Element(new RadioButton()
            .AddRadioButtonElement("Purchase", FindElement("LoanPurpose_0"))
            .AddRadioButtonElement("Remortgage", FindElement("LoanPurpose_1")));

        //public Element loanType=> new Element(FindElement("LoanType-button"));

        public Element sharedOwnership => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("SharedOwnership_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("SharedOwnership_btn_rbl_1")), new ConditionList()
            .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "Residential")));
        public Element familyAssistance => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AdditionalSecuritiesToCaptureExists_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AdditionalSecuritiesToCaptureExists_btn_rbl_1")), new ConditionList()
            .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "Residential")));

        public Section purchaseRbtnSection => new Section(new Element(
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Purchase"))));

        public Element firstTimeBuyers => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("FirstTimeBuyer_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("FirstTimeBuyer_btn_rbl_1")), new ConditionList()
            .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "Residential"))
            .Add(new Condition(className, "loanPurpose", "Purchase")));

        public Element firstTimeLandlord => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("FirstTimeLandlord_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("FirstTimeLandlord_btn_rbl_1")), new ConditionList()
            .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "BTL"))
            .Add(new Condition(className, "loanPurpose", "Purchase")));
        public Element letToBuy => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("FirstTimeLandlord_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("FirstTimeLandlord_btn_rbl_1")), new ConditionList()
            .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "BTL"))
            .Add(new Condition(className, "loanPurpose", "Remortgage")));

        public Element rightToBuy => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("RightToBuy_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("RightToBuy_btn_rbl_1")), new ConditionList()
            .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "Residential")));
        public Element sharedEquity => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("SharedEquity_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("SharedEquity_btn_rbl_1")), new ConditionList()
            .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "Residential")));

        public SectionEnd purchaseRbtnSectionEnd => new SectionEnd();

        public Element estimatedValue => new Element(FindElement("OpenMarketValue"));
        public Element loanAmount => new Element(FindElement("LoanAmount"));
        public Element termRequirements => new Element(FindElement("ddlTermRequirements"), new ConditionList()
            //.Add(new Condition("ApplicantAndLoanTypePage", "applicantType", "Individual"))  //Wireframes state should be only for Individual/Resi but actually currently displayed for corp.
            .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "Residential")));
        public Element termYears => new Element(FindElement("TermYears"));
        public Element termMonths => new Element(FindElement("TermMonths"));
        public Element repaymentType => new Element(FindElement("RepaymentType"));
        public Element estimatedMonthlyRentalIncome => new Element(FindElement("BtlAnticipatedRent", tag: "input"), new ConditionList()
            .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "BTL")));
        public Element expat => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ExPat", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ExPat", "rbl_0")), new ConditionList()
            .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "BTL")));



        #region Source Of Deposit section locators

        public Section sourceOfDepositSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Purchase"))));

        //Source of deposit - row 1
        public Element sourceOfDeposit_1 => new Element(FindElement("_SourceOfDeposit", "item0"));

        public Element sourceOfDepositAmountBox_1 => new Element(FindElement("SourceOfDeposit", "_Amount", "item0"))
            .SetValidationType(Defs.validationTypeSourceOfDeposit);

        //Source of deposit - row 2
        public Element sourceOfDeposit_2 => new Element(FindElement("_SourceOfDeposit", "item1"),
            new ConditionList()
            .Add(new Condition(className, "sourceOfDeposit_2", null, Defs.conditionTypeNotEqual)),
            sourceOfDepositAddMoreBtn);

        public Element sourceOfDepositAmountBox_2 => new Element(FindElement("SourceOfDeposit", "_Amount", "item1"),
            new ConditionList()
            .Add(new Condition(className, "sourceOfDeposit_2", null, Defs.conditionTypeNotEqual)),
            sourceOfDepositAddMoreBtn)
            .SetValidationType(Defs.validationTypeCalculativeRepeater);

        //Source of deposit - row 3
        public Element sourceOfDeposit_3 => new Element(FindElement("_SourceOfDeposit", "item2"),
            new ConditionList()
            .Add(new Condition(className, "sourceOfDeposit_3", null, Defs.conditionTypeNotEqual)),
            sourceOfDepositAddMoreBtn);

        public Element sourceOfDepositAmountBox_3 => new Element(FindElement("SourceOfDeposit", "_Amount", "item2"),
            new ConditionList()
            .Add(new Condition(className, "sourceOfDeposit_3", null, Defs.conditionTypeNotEqual)),
            sourceOfDepositAddMoreBtn)
            .SetValidationType(Defs.validationTypeCalculativeRepeater);

        public SectionEnd sourceOfDepositSectionEnd => new SectionEnd();

        public Element sourceOfDepositAddMoreBtn => new Element(FindElement("SourceOfDeposit", "btnAdd"))
            .SetCompletePageFlag(false);
        #endregion

        #region Loan Amount Breakdown section locators

        //Use of Funds - row 1
        public Element loanAllocation_1 => new Element(FindElement("_LoanPurpose", "item0"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage")));

        public Element loanAllocationAmountBox_1 => new Element(FindElement("CapitalRaisingPurpose", "_Amount", "item0"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage")))
            .SetValidationType(Defs.validationTypeLoanBreakdown);

        //Use of Funds - row 2
        public Element loanAllocation_2 => new Element(FindElement("_LoanPurpose", "item1"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage"))
            .Add(new Condition(className, "loanAllocation_2", null, Defs.conditionTypeNotEqual)),
            loanAllocationAdd);

        public Element loanAllocationAmountBox_2 => new Element(FindElement("CapitalRaisingPurpose", "_Amount", "item1"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage"))
            .Add(new Condition(className, "loanAllocation_2", null, Defs.conditionTypeNotEqual)),
            loanAllocationAdd)
                        .SetValidationType(Defs.validationTypeCalculativeRepeater);

        //Use of Funds - row 3
        public Element loanAllocation_3 => new Element(FindElement("_LoanPurpose", "item2"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage"))
            .Add(new Condition(className, "loanAllocation_3", null, Defs.conditionTypeNotEqual)),
            loanAllocationAdd);

        public Element loanAllocationAmountBox_3 => new Element(FindElement("CapitalRaisingPurpose", "_Amount", "item2"),
            new ConditionList()
            .Add(new Condition(className, "loanPurpose", "Remortgage"))
            .Add(new Condition(className, "loanAllocation_3", null, Defs.conditionTypeNotEqual)),
            loanAllocationAdd)
                        .SetValidationType(Defs.validationTypeCalculativeRepeater);

        public Element loanAllocationAdd => new Element(FindElement("CapitalRaisingPurpose", "btnAdd"))
            .SetCompletePageFlag(false);
        #endregion

        public Element applicantsMainResidence => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radApplicantLive_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radApplicantLive_btn_rbl_1")), new ConditionList()
            .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "Residential")));

        public Element youOrSomeoneRelatedLivingInProperty => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radFamilyLive", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radFamilyLive", "rbl_1")), new ConditionList()
            .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "BTL")));

        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }
    public class FMA_LoanDetailsPageData : PageData
    {
        public string expat { get; set; } = Defs.radioButtonNo;
        public string youOrSomeoneRelatedLivingInProperty { get; set; } = Defs.radioButtonNo;
        public string estimatedMonthlyRentalIncome { get; set; } = "2000";
        public string loanPurpose { get; set; } = "Purchase";
        public string firstTimeBuyers { get; set; } = Defs.radioButtonNo;
        public string firstTimeLandlord { get; set; } = Defs.radioButtonNo;
        public string rightToBuy { get; set; } = Defs.radioButtonNo;
        public string sharedOwnership { get; set; } = Defs.radioButtonNo;
        public string sharedEquity { get; set; } = Defs.radioButtonNo;
        public string familyAssistance { get; set; } = Defs.radioButtonNo;
        public string estimatedValue { get; set; } = "200000";
        public string loanAmount { get; set; } = "100000";
        public string termRequirements { get; set; } = "Standard";
        public string termYears { get; set; } = "20";
        public string termMonths { get; set; } = "0";
        public string repaymentType { get; set; } = "Capital Repayment";
        public string sourceOfDeposit_1 { get; set; } = "Savings";
        public string sourceOfDepositAmount_1 { get; set; } = "100000";
        public string sourceOfDeposit_2 { get; set; } = null;
        public string sourceOfDepositAmount_2 { get; set; } = null;
        public string sourceOfDeposit_3 { get; set; } = null;
        public string sourceOfDepositAmount_3 { get; set; } = null;
        public string loanAllocation_1 { get; set; } = "Light Refurbishment";
        public string loanAllocationAmount_1 { get; set; } = "100000";
        public string loanAllocation_2 { get; set; } = null;
        public string loanAllocationAmount_2 { get; set; } = null;
        public string loanAllocation_3 { get; set; } = null;
        public string loanAllocationAmount_3 { get; set; } = null;
        public string applicantsMainResidence { get; set; } = Defs.radioButtonYes;
    }
}
