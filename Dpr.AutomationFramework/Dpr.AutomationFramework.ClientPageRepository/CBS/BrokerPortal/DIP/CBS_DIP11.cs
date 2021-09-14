﻿using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP11 : WebBasePage
    {
        public CBS_DIP11()
        {
            pageLoadedElement = applicantHaveMortgageOrSecuredLoansRbtn;
            correspondingDataClass = new CBS_DIP11Data().GetType();
            textName = "CBS Applicant 1 Credit Commitments Page";
        }

        #region 'Residential Mortgage' Section
        public Element existingResidentialMortgageRedeemedRbtn => new Element(
            new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("CommitmentsResidentialMortgagesRepeater1", "ApplicantPanel_ctl00_CurrentMortgageRedeemed_btn", "_rbl_0"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("CommitmentsResidentialMortgagesRepeater1", "ApplicantPanel_ctl00_CurrentMortgageRedeemed_btn", "_rbl_1")),
            new ConditionList()
                .Add(new Condition("CBS_DIP07", "residentialStatus", "Owner Unencumbered")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_DIP07", "residentialStatus", "Owner With Mortgage")));

        public Element estimatedValueOfCurrentResidentialPropertyBox => new Element(FindElement("ApplicantPanel_ctl00_CurrentMortgageValue", tag: "input"),
            new ConditionList()
                .Add(new Condition("CBS_DIP07", "residentialStatus", "Owner Unencumbered")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_DIP07", "residentialStatus", "Owner With Mortgage")));

        public Element reasonForNotRedeemingLookup => new Element(FindElement("CurrentMortgageRedeemedNote", tag: "select"),
            new ConditionList()
                .Add(new Condition("CBS_DIP07", "residentialStatus", "Owner With Mortgage")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(className, "existingResidentialMortgageRedeemed", Defs.radioButtonNo)));

        public Element monthlyResidentialMortgageRepaymentBox => new Element(FindElement("CurrentMortgagePayment", tag: "input"),
            new ConditionList()
            .Add(new Condition("CBS_DIP07", "residentialStatus", "Owner With Mortgage")));

        public Element residentialMortgageBalanceOutstandingBox => new Element(FindElement("CurrentMortgageBalance", tag: "input"),
            new ConditionList()
            .Add(new Condition("CBS_DIP07", "residentialStatus", "Owner With Mortgage")));

        public Element currentMortgageStartDate => new Element(FindElement("CurrentMortgageStartDate", tag: "input"),
            new ConditionList()
            .Add(new Condition("CBS_DIP07", "residentialStatus", "Owner With Mortgage")));
        #endregion

        #region 'Mortgage & Secured Loan History' Section 
        public Element applicantHaveMortgageOrSecuredLoansRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("SecondaryMortgage", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("SecondaryMortgage", "rbl_1")));

        public Section mortgageAndSecuredLoanSection => new Section(new Element(
            new ConditionList()
            .Add(new Condition(className, "applicantHaveMortgageOrSecuredLoans", Defs.radioButtonYes))));

        public Element outstandingBalance1Box => new Element(FindElement("CurrentOutstanding", "item0"));

        public Element monthlyPayment1Box => new Element(FindElement("CurrentRepayment", "item0"));

        public Element mortgageSecuredLoanEndDate1Box => new Element(FindElement("EndDate", "item0", "Secured", "!Unsecured"));

        public Element mortgageSecuredRepayOnCompletion1Chbox => new Element(FindElement("ToBeRepaid", "item0", "Secured", "!Unsecured"));

        public Element outstandingBalance2Box => new Element(FindElement("CurrentOutstanding", "item1"),
             new ConditionList()
             .Add(new Condition(className, "outstandingBalance2", null, Defs.conditionTypeNotEqual)),
            mortgageSecuredLoanAddMoreBtn);

        public Element monthlyPayment2Box => new Element(FindElement("CurrentRepayment", "item1"),
            new ConditionList()
             .Add(new Condition(className, "monthlyPayment2", null, Defs.conditionTypeNotEqual)),
            mortgageSecuredLoanAddMoreBtn);

        public Element mortgageSecuredLoanEndDate2Box => new Element(FindElement("EndDate", "item1", "Secured", "!Unsecured"),
            new ConditionList()
             .Add(new Condition(className, "mortgageSecuredLoanEndDate2", null, Defs.conditionTypeNotEqual)),
            mortgageSecuredLoanAddMoreBtn);

        public Element mortgageSecuredRepayOnCompletion2Chbox => new Element(FindElement("ToBeRepaid", "item1", "Secured", "!Unsecured"),
            new ConditionList()
             .Add(new Condition(className, "mortgageSecuredRepayOnCompletion2", null, Defs.conditionTypeNotEqual)),
            mortgageSecuredLoanAddMoreBtn);

        public Element outstandingBalance3Box => new Element(FindElement("CurrentOutstanding", "item2"),
             new ConditionList()
             .Add(new Condition(className, "outstandingBalance3", null, Defs.conditionTypeNotEqual)),
            mortgageSecuredLoanAddMoreBtn);

        public Element monthlyPayment3Box => new Element(FindElement("CurrentRepayment", "item2"),
            new ConditionList()
             .Add(new Condition(className, "monthlyPayment3", null, Defs.conditionTypeNotEqual)),
            mortgageSecuredLoanAddMoreBtn);

        public Element mortgageSecuredLoanEndDate3Box => new Element(FindElement("EndDate", "item2", "Secured", "!Unsecured"),
            new ConditionList()
             .Add(new Condition(className, "mortgageSecuredLoanEndDate3", null, Defs.conditionTypeNotEqual)),
            mortgageSecuredLoanAddMoreBtn);

        public Element mortgageSecuredRepayOnCompletion3Chbox => new Element(FindElement("ToBeRepaid", "item2", "Secured", "!Unsecured"),
            new ConditionList()
             .Add(new Condition(className, "mortgageSecuredRepayOnCompletion3", null, Defs.conditionTypeNotEqual)),
            mortgageSecuredLoanAddMoreBtn);

        public Element mortgageSecuredLoanAddMoreBtn => new Element(FindElement("btnAdd", "Secured", "!Unsecured"))
            .SetCompletePageFlag(false);

        public SectionEnd mortgageAndSecuredLoanSectionEnd => new SectionEnd();

        #endregion

        #region 'Store/Credit Cards' Section
        public Element applicantHaveCreditOrStoreCardsRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("Card", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("Card", "rbl_1")));

        public Section storeCreditSection => new Section(new Element(
            new ConditionList()
            .Add(new Condition(className, "applicantHaveCreditOrStoreCards", Defs.radioButtonYes))));

        public Element storeCreditCardBalance1Box => new Element(FindElement("Balance", "item0", "Card"));

        public Element cardProvider1Box => new Element(FindElement("Issuer", "Card", "item0"));

        public Element storeCreditCardEndDate1Box => new Element(FindElement("EndDate", "Card", "item0"));

        public Element storeCreditCardToBeRepaid1Chbox => new Element(FindElement("ToBeRepaid", "Card", "item0"));

        public Element storeCreditCardBalance2Box => new Element(FindElement("Balance", "item1", "Card"),
              new ConditionList()
             .Add(new Condition(className, "storeCreditCardBalance2", null, Defs.conditionTypeNotEqual)),
             storeCreditCardAddMoreBtn);

        public Element cardProvider2Box => new Element(FindElement("Issuer", "Card", "item1"),
             new ConditionList()
             .Add(new Condition(className, "cardProvider2", null, Defs.conditionTypeNotEqual)),
             storeCreditCardAddMoreBtn);

        public Element storeCreditCardEndDate2Box => new Element(FindElement("EndDate", "Card", "item1"),
             new ConditionList()
             .Add(new Condition(className, "storeCreditCardEndDate2", null, Defs.conditionTypeNotEqual)),
             storeCreditCardAddMoreBtn);

        public Element storeCreditCardToBeRepaid2Chbox => new Element(FindElement("ToBeRepaid", "Card", "item1"),
             new ConditionList()
             .Add(new Condition(className, "storeCreditCardToBeRepaid2", null, Defs.conditionTypeNotEqual)),
             storeCreditCardAddMoreBtn);

        public Element storeCreditCardBalance3Box => new Element(FindElement("Balance", "item2", "Card"),
                     new ConditionList()
             .Add(new Condition(className, "storeCreditCardBalance3", null, Defs.conditionTypeNotEqual)),
             storeCreditCardAddMoreBtn);

        public Element cardProvider3Box => new Element(FindElement("Issuer", "Card", "item2"),
             new ConditionList()
             .Add(new Condition(className, "cardProvider3", null, Defs.conditionTypeNotEqual)),
             storeCreditCardAddMoreBtn);

        public Element storeCreditCardEndDate3Box => new Element(FindElement("EndDate", "Card", "item2"),
             new ConditionList()
             .Add(new Condition(className, "storeCreditCardEndDate3", null, Defs.conditionTypeNotEqual)),
             storeCreditCardAddMoreBtn);

        public Element storeCreditCardToBeRepaid3Chbox => new Element(FindElement("ToBeRepaid", "Card", "item2"),
             new ConditionList()
             .Add(new Condition(className, "storeCreditCardToBeRepaid3", null, Defs.conditionTypeNotEqual)),
             storeCreditCardAddMoreBtn);

        public Element storeCreditCardAddMoreBtn => new Element(FindElement("Card", "btnAdd"))
            .SetCompletePageFlag(false);

        public SectionEnd storeCreditSectionEnd => new SectionEnd();
        #endregion

        #region 'Loans' Section
        public Element applicantHaveUnsecuredLoansOrHirePurchaseRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("Hire", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("Hire", "rbl_1")));

        public Section loanHirePurchaseSection => new Section(new Element(
            new ConditionList()
            .Add(new Condition(className, "applicantHaveUnsecuredLoansOrHirePurchase", Defs.radioButtonYes))));

        public Element loanHirePurchaseBalance1Box => new Element(FindElement("Balance", "Hire", "item0"));

        public Element loanHirePurchaseMonthlyPayment1Box => new Element(FindElement("Monthly", "Hire", "item0"));

        public Element loanHirePurchaseEndDate1Box => new Element(FindElement("EndDate", "Hire", "item0"));

        public Element loanHirePurchaseToBeRepaid1Chbox => new Element(FindElement("ToBeRepaid", "Hire", "item0"));

        public Element loanHirePurchaseBalance2Box => new Element(FindElement("Balance", "Hire", "item1"),
              new ConditionList()
             .Add(new Condition(className, "loanHirePurchaseBalance2", null, Defs.conditionTypeNotEqual)),
             loanHirePurchaseAddMoreBtn);

        public Element loanHirePurchaseMonthlyPayment2Box => new Element(FindElement("Monthly", "Hire", "item1"),
              new ConditionList()
             .Add(new Condition(className, "loanHirePurchaseMonthlyPayment2", null, Defs.conditionTypeNotEqual)),
             loanHirePurchaseAddMoreBtn);

        public Element loanHirePurchaseEndDate2Box => new Element(FindElement("EndDate", "Hire", "item1"),
              new ConditionList()
             .Add(new Condition(className, "loanHirePurchaseEndDate2", null, Defs.conditionTypeNotEqual)),
             loanHirePurchaseAddMoreBtn);

        public Element loanHirePurchaseToBeRepaid2Chbox => new Element(FindElement("ToBeRepaid", "Hire", "item1"),
              new ConditionList()
             .Add(new Condition(className, "loanHirePurchaseToBeRepaid2", null, Defs.conditionTypeNotEqual)),
             loanHirePurchaseAddMoreBtn);

        public Element loanHirePurchaseBalance3Box => new Element(FindElement("Balance", "Hire", "item2"),
              new ConditionList()
             .Add(new Condition(className, "loanHirePurchaseBalance3", null, Defs.conditionTypeNotEqual)),
             loanHirePurchaseAddMoreBtn);

        public Element loanHirePurchaseMonthlyPayment3Box => new Element(FindElement("Monthly", "Hire", "item2"),
              new ConditionList()
             .Add(new Condition(className, "loanHirePurchaseMonthlyPayment3", null, Defs.conditionTypeNotEqual)),
             loanHirePurchaseAddMoreBtn);

        public Element loanHirePurchaseEndDate3Box => new Element(FindElement("EndDate", "Hire", "item2"),
              new ConditionList()
             .Add(new Condition(className, "loanHirePurchaseEndDate3", null, Defs.conditionTypeNotEqual)),
             loanHirePurchaseAddMoreBtn);

        public Element loanHirePurchaseToBeRepaid3Chbox => new Element(FindElement("ToBeRepaid", "Hire", "item2"),
              new ConditionList()
             .Add(new Condition(className, "loanHirePurchaseToBeRepaid3", null, Defs.conditionTypeNotEqual)),
             loanHirePurchaseAddMoreBtn);


        public Element loanHirePurchaseAddMoreBtn => new Element(FindElement("Hire", "btnAdd"))
            .SetCompletePageFlag(false);

        public SectionEnd loanHirePurchaseSectionEnd => new SectionEnd();
        #endregion

        #region 'Mail Order Accounts' Section
        public Element applicantHaveMailOrderAccounts => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radMailOrderCommitments_btn", "rbl_0", tag:"input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radMailOrderCommitments_btn", "rbl_1", tag: "input")));

        public Section mailOrderSection => new Section(new Element(
            new ConditionList()
            .Add(new Condition(className, "applicantHavMailOrderAccounts", Defs.radioButtonYes))));

        #region Row 1
        public Element lender1 => new Element(FindElement("CommitmentsMailOrderRepeater1", "item0", "txtLender", tag:"input"));
        public Element outstandingBalanceMail1 => new Element(FindElement("CommitmentsMailOrderRepeater1", "item0", "txtBalance", tag:"input"));
        public Element repayOnCompletionMail1 => new Element(FindElement("CommitmentsMailOrderRepeater1", "item0", "chkToBeRepaid", tag:"input"));
        public Element sourceOfFunds1 => new Element(FindElement("CommitmentsMailOrderRepeater1", "item0", "ddlSourceOfFund", tag:"select"),
            new ConditionList()
                .Add(new Condition(className, "repayOnCompletion1", Defs.checkBoxSelected)));
        #endregion

        #region Row 2
        public Element lender2 => new Element(FindElement("CommitmentsMailOrderRepeater1", "item1", "txtLender", tag: "input"));
        public Element outstandingBalance2 => new Element(FindElement("CommitmentsMailOrderRepeater1", "item1", "txtBalance", tag: "input"));
        public Element repayOnCompletion2 => new Element(FindElement("CommitmentsMailOrderRepeater1", "item1", "chkToBeRepaid", tag: "input"));
        public Element sourceOfFunds2 => new Element(FindElement("CommitmentsMailOrderRepeater1", "item1", "ddlSourceOfFund", tag: "select"),
            new ConditionList()
                .Add(new Condition(className, "repayOnCompletion2", Defs.checkBoxSelected)));
        #endregion

        #region Row 3
        public Element lender3 => new Element(FindElement("CommitmentsMailOrderRepeater1", "item2", "txtLender", tag: "input"));
        public Element outstandingBalance3 => new Element(FindElement("CommitmentsMailOrderRepeater1", "item2", "txtBalance", tag: "input"));
        public Element repayOnCompletion3 => new Element(FindElement("CommitmentsMailOrderRepeater1", "item2", "chkToBeRepaid", tag: "input"));
        public Element sourceOfFunds3 => new Element(FindElement("CommitmentsMailOrderRepeater1", "item2", "ddlSourceOfFund", tag: "select"),
            new ConditionList()
                .Add(new Condition(className, "repayOnCompletion3", Defs.checkBoxSelected)));
        #endregion

        public SectionEnd mailOrderSectionEnd => new SectionEnd();
        #endregion

        #region 'Debt Management Plans' Section

        public Element applicantHaveDebtManagement => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radDebtManagementCommitments_btn", "rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radDebtManagementCommitments_btn", "rbl_1", tag: "input")));

        public Section debtManagementSection => new Section(new Element(
            new ConditionList()
            .Add(new Condition(className, "applicantHaveDebtManagement", Defs.radioButtonYes))));

        #region Row 1
        public Element provider1 => new Element(FindElement("CommitmentsDebtManagementRepeater1", "item0", "txtLender", tag: "input"));
        public Element outstandingBalanceDebt1 => new Element(FindElement("CommitmentsDebtManagementRepeater1", "item0", "txtCurrentBalance", tag: "input"));
        public Element monthlyPayment1 => new Element(FindElement("CommitmentsDebtManagementRepeater1", "item0", "txtStartDate", tag: "input"));
        public Element repayOnCompletionDebt1 => new Element(FindElement("CommitmentsDebtManagementRepeater1", "item0", "chkToBeRepaid", tag: "input"));
        #endregion

        #region Row 2
        public Element provider2 => new Element(FindElement("CommitmentsDebtManagementRepeater1", "item1", "txtLender", tag: "input"));
        public Element outstandingBalanceDebt2 => new Element(FindElement("CommitmentsDebtManagementRepeater1", "item1", "txtCurrentBalance", tag: "input"));
        public Element monthlyPayment2 => new Element(FindElement("CommitmentsDebtManagementRepeater1", "item1", "txtStartDate", tag: "input"));
        public Element repayOnCompletionDebt2 => new Element(FindElement("CommitmentsDebtManagementRepeater1", "item1", "chkToBeRepaid", tag: "input"));
        #endregion

        #region Row 3
        public Element provider3 => new Element(FindElement("CommitmentsDebtManagementRepeater1", "item2", "txtLender", tag: "input"));
        public Element outstandingBalanceDebt3 => new Element(FindElement("CommitmentsDebtManagementRepeater1", "item2", "txtCurrentBalance", tag: "input"));
        public Element monthlyPayment3 => new Element(FindElement("CommitmentsDebtManagementRepeater1", "item2", "txtStartDate", tag: "input"));
        public Element repayOnCompletionDebt3 => new Element(FindElement("CommitmentsDebtManagementRepeater1", "item2", "chkToBeRepaid", tag: "input"));
        #endregion

        public SectionEnd debtManagementSectionEnd => new SectionEnd();
        #endregion

        #region 'Other Commitments (non lifestyle)' Section
        public Element applicantHaveOtherCommitmentsRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("Other", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("Other", "rbl_1")));

        public Section otherCommitmentsSection => new Section(new Element(
            new ConditionList()
            .Add(new Condition(className, "applicantHaveOtherCommitments", Defs.radioButtonYes))));

        public Element commitmentType1Lookup => new Element(FindElement("CommitmentType", "item0"));

        public Element commitmentOther1Box => new Element(FindElement("txtOther", "item0"),
             new ConditionList()
             .Add(new Condition(className, "commitmentType1", "Other")));

        public Element otherMonthlyPayment1Box => new Element(FindElement("MonthlyPayment", "!Card", "item0", "!HirePurchase"));

        public Element commitmentType2Lookup => new Element(FindElement("CommitmentType", "item1"),
              new ConditionList()
             .Add(new Condition(className, "commitmentType2", null, Defs.conditionTypeNotEqual)),
             otherAddMoreBtn);

        public Element commitmentOther2Box => new Element(FindElement("txtOther", "item1"),
             new ConditionList()
             .Add(new Condition(className, "commitmentOther2", null, Defs.conditionTypeNotEqual))
             .Add(new Condition(className, "commitmentType2", "Other")),
             otherAddMoreBtn);

        public Element otherMonthlyPayment2Box => new Element(FindElement("MonthlyPayment", "!Card", "item1", "!HirePurchase"),
              new ConditionList()
             .Add(new Condition(className, "otherMonthlyPayment2", null, Defs.conditionTypeNotEqual)),
             otherAddMoreBtn);

        public Element commitmentType3Lookup => new Element(FindElement("CommitmentType", "item2"),
              new ConditionList()
             .Add(new Condition(className, "commitmentType3", null, Defs.conditionTypeNotEqual)),
             otherAddMoreBtn);

        public Element commitmentOther3Box => new Element(FindElement("txtOther", "item2"),
             new ConditionList()
             .Add(new Condition(className, "commitmentType3", null, Defs.conditionTypeNotEqual))
             .Add(new Condition(className, "commitmentType3", "Other")),
             otherAddMoreBtn);

        public Element otherMonthlyPayment3Box => new Element(FindElement("MonthlyPayment", "!Card", "item2", "!HirePurchase"),
              new ConditionList()
             .Add(new Condition(className, "otherMonthlyPayment3", null, Defs.conditionTypeNotEqual)),
             otherAddMoreBtn);

        public Element otherAddMoreBtn => new Element(FindElement("Other", "btnAdd"))
            .SetCompletePageFlag(false);

        public SectionEnd otherCommitmentsSectionEnd => new SectionEnd();
        #endregion

        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class CBS_DIP11Data : PageData
    {

        #region 'Residential Mortgage' Section
        //public string existingResidentialMortgageRedeemed { get; set; } = Defs.radioButtonYes;
        //public string estimatedValueOfCurrentResidentialProperty { get; set; } = "200000";
        //public string reasonForNotRedeeming{ get; set; } = null;
        public string monthlyResidentialMortgageRepayment { get; set; } = "10";
        public string residentialMortgageBalanceOutstanding { get; set; } = "10";
        public string currentMortgageStartDate { get; set; } = "01/2020";
        #endregion

        #region 'Mortgage & Secured Loan History' Section 
        public string applicantHaveMortgageOrSecuredLoans { get; set; } = Defs.radioButtonNo;
        public string outstandingBalance1 { get; set; } = "10";
        public string outstandingBalance2 { get; set; } = null;
        public string outstandingBalance3 { get; set; } = null;
        public string monthlyPayment1 { get; set; } = "1";
        public string monthlyPayment2 { get; set; } = null;
        public string monthlyPayment3 { get; set; } = null;
        public string mortgageSecuredLoanEndDate1 { get; set; } = "01/2020";
        public string mortgageSecuredLoanEndDate2 { get; set; } = null;
        public string mortgageSecuredLoanEndDate3 { get; set; } = null;
        public string mortgageSecuredRepayOnCompletion1 { get; set; } = Defs.checkBoxSelected;
        public string mortgageSecuredRepayOnCompletion2 { get; set; } = null;
        public string mortgageSecuredRepayOnCompletion3 { get; set; } = null;
        public string mortgageSecuredLoanAddMore { get; set; } = null;
        #endregion

        #region 'Store/Credit Cards' Section
        public string applicantHaveCreditOrStoreCards { get; set; } = Defs.radioButtonNo;
        public string storeCreditCardBalance1 { get; set; } = "10";
        public string storeCreditCardBalance2 { get; set; } = null;
        public string storeCreditCardBalance3 { get; set; } = null;
        public string cardProvider1 { get; set; } = "TestProvider";
        public string cardProvider2 { get; set; } = null;
        public string cardProvider3 { get; set; } = null;
        public string storeCreditCardEndDate1 { get; set; } = "01/2020";
        public string storeCreditCardEndDate2 { get; set; } = null;
        public string storeCreditCardEndDate3 { get; set; } = null;
        public string storeCreditCardToBeRepaid1 { get; set; } = Defs.checkBoxNotSelected;
        public string storeCreditCardToBeRepaid2 { get; set; } = null;
        public string storeCreditCardToBeRepaid3 { get; set; } = null;
        public string storeCreditCardAddMore { get; set; } = null;
        #endregion

        #region 'Loans' Section
        public string applicantHaveUnsecuredLoansOrHirePurchase { get; set; } = Defs.radioButtonNo;
        public string loanHirePurchaseBalance1 { get; set; } = "10";
        public string loanHirePurchaseBalance2 { get; set; } = null;
        public string loanHirePurchaseBalance3 { get; set; } = null;
        public string loanHirePurchaseMonthlyPayment1 { get; set; } = "1";
        public string loanHirePurchaseMonthlyPayment2 { get; set; } = null;
        public string loanHirePurchaseMonthlyPayment3 { get; set; } = null;
        public string loanHirePurchaseEndDate1 { get; set; } = "01/2020";
        public string loanHirePurchaseEndDate2 { get; set; } = null;
        public string loanHirePurchaseEndDate3 { get; set; } = null;
        public string loanHirePurchaseToBeRepaid1 { get; set; } = Defs.checkBoxSelected;
        public string loanHirePurchaseToBeRepaid2 { get; set; } = null;
        public string loanHirePurchaseToBeRepaid3 { get; set; } = null;
        public string loanHirePurchaseAddMore { get; set; } = null;
        #endregion

        #region 'Mail Order Acocunts' Section
        public string applicantHaveMailOrderAccounts { get; set; } = Defs.radioButtonNo;
        
        public string lender1 { get; set; } = "MailOrderLender1";
        public string outstandingBalanceMail1 { get; set; } = "10000";
        public string repayOnCompletionMail1 { get; set; } = Defs.checkBoxSelected;
        public string sourceOfFunds1 { get; set; } = "Savings";

        public string lender2 { get; set; } = "MailOrderLender2";
        public string outstandingBalanceMail2 { get; set; } = "20000";
        public string repayOnCompletionMail2 { get; set; } = Defs.checkBoxSelected;
        public string sourceOfFunds2 { get; set; } = "Savings";

        public string lender3 { get; set; } = "MailOrderLender3";
        public string outstandingBalanceMail3 { get; set; } = "30000";
        public string repayOnCompletionMail3 { get; set; } = Defs.checkBoxSelected;
        public string sourceOfFunds3 { get; set; } = "Savings";
        #endregion

        #region 'Debt Management Plans' Section
        public string applicantHaveDebtManagement { get; set; } = Defs.radioButtonNo;

        public string provider1 { get; set; } = "DebtOrderprovider1";
        public string outstandingBalanceDebt1 { get; set; } = "10000";
        public string repayOnCompletionDebt1 { get; set; } = Defs.checkBoxSelected;

        public string provider2 { get; set; } = "DebtOrderprovider2";
        public string outstandingBalanceDebt2 { get; set; } = "20000";
        public string repayOnCompletionDebt2 { get; set; } = Defs.checkBoxSelected;

        public string provider3 { get; set; } = "DebtOrderprovider3";
        public string outstandingBalanceDebt3 { get; set; } = "30000";
        public string repayOnCompletionDebt3 { get; set; } = Defs.checkBoxSelected;
        #endregion

        #region 'Other Commitments (non lifestyle) Section
        public string applicantHaveOtherCommitments { get; set; } = Defs.radioButtonNo;
        public string commitmentType1 { get; set; } = "Student Loans";
        public string commitmentType2 { get; set; } = null;
        public string commitmentType3 { get; set; } = null;
        public string commitmentOther1 { get; set; } = "test";
        public string commitmentOther2 { get; set; } = null;
        public string commitmentOther3 { get; set; } = null;
        public string otherMonthlyPayment1 { get; set; } = "1";
        public string otherMonthlyPayment2 { get; set; } = null;
        public string otherMonthlyPayment3 { get; set; } = null;
        #endregion
    }
}
