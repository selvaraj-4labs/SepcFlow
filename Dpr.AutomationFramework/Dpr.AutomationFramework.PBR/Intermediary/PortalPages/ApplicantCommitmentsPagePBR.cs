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
    class ApplicantCommitmentsPagePBR : WebBasePage
    {

        public ApplicantCommitmentsPagePBR()
        {
            pageLoadedElement = applicantHaveMortgageOrSecuredLoansRbtn;
            correspondingDataClass = new ApplicantCommitmentsData().GetType();
            //javascriptPageNavigator = @"javascript:__doPostBack('ctl00$MC$Menu1','bApplicant1Details\\ApplicantCommitments')";
            //displayedAfterNextPageBackBtn = false;
        }

        #region Residential Mortgages section locators


        public Element existingResidentialMortgageRedeemedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("CurrentMortgageRedeemed", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("CurrentMortgageRedeemed", "rbl_1")),
            new ConditionList()
            .Add(new Condition("ApplicantAddressPage", "residentialStatus", "Owner With Mortgage")));
        public Element estimatedValueOfCurrentResidentialPropertyBox => new Element(FindElement("CurrentMortgageValue"),
            new ConditionList()
            .Add(new Condition("ApplicantAddressPage", "residentialStatus", "Owner Without Mortgage")))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("ApplicantAddressPage", "residentialStatus", "Owner With Mortgage")));


        public Element reasonForNotRedeemingLookup => new Element(FindElement("CurrentMortgageRedeemedNote"),
            new ConditionList()
            .Add(new Condition("ApplicantAddressPage", "residentialStatus", "Owner With Mortgage"))
            .Add(new Condition(className, "existingResidentialMortgageRedeemed", Defs.radioButtonNo)));

        public Element monthlyResidentialMortgageRepaymentBox => new Element(FindElement("CurrentMortgagePayment"),
            new ConditionList()
            .Add(new Condition("ApplicantAddressPage", "residentialStatus", "Owner With Mortgage")));

        public Element residentialMortgageBalanceOutstandingBox => new Element(FindElement("CurrentMortgageBalance"),
            new ConditionList()
            .Add(new Condition("ApplicantAddressPage", "residentialStatus", "Owner With Mortgage")));

        public Element remainingTermOfMortgageYearsBox => new Element(FindElement("CurrentMortgageRemainingYears"),
            new ConditionList()
            .Add(new Condition("ApplicantAddressPage", "residentialStatus", "Owner With Mortgage")));

        public Element remainingTermOfMortgageMonthsBox => new Element(FindElement("CurrentMortgageRemainingMonth"),
            new ConditionList()
            .Add(new Condition("ApplicantAddressPage", "residentialStatus", "Owner With Mortgage")));

        #endregion

        #region Mortgage/Rent section locators

        public Element monthlyRentalPaymentBox => new Element(FindElement("TenancyPayment"),
            new ConditionList()
            .Add(new Condition("ApplicantAddressPage", "residentialStatus", "Renting - Private Landlord")))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("ApplicantAddressPage", "residentialStatus", "Renting - Local Authority or Social Landlord")))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition("ApplicantAddressPage", "residentialStatus", "Renting - Letting Agent")));

        #endregion

        #region Mortgage & Secured Loan History section locators
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

        #region Overdraft section locators

        public Element applicantHaveOverdraftRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("OverDrafts", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("OverDrafts", "rbl_1")));

        public Section overdraftSection => new Section(new Element(
            new ConditionList()
            .Add(new Condition(className, "applicantHaveOverdraft", Defs.radioButtonYes))));

        public Element bank1Box => new Element(FindElement("Bank", "item0"));

        public Element overdraftBalance1Box => new Element(FindElement("Balance", "Over", "item0"));

        public Element overdraftToBeRepaid1Chbox => new Element(FindElement("ToBeRepaid", "Over", "item0"));

        public Element bank2Box => new Element(FindElement("Bank", "item1"),
             new ConditionList()
             .Add(new Condition(className, "bank2", null, Defs.conditionTypeNotEqual)),
            overdraftAddMoreBtn);

        public Element overdraftBalance2Box => new Element(FindElement("Balance", "Over", "item1"),
             new ConditionList()
             .Add(new Condition(className, "overdraftBalance2", null, Defs.conditionTypeNotEqual)),
             overdraftAddMoreBtn);

        public Element overdraftToBeRepaid2Chbox => new Element(FindElement("ToBeRepaid", "Over", "item1"),
             new ConditionList()
             .Add(new Condition(className, "overdraftToBeRepaid2", null, Defs.conditionTypeNotEqual)),
             overdraftAddMoreBtn);

        public Element bank3Box => new Element(FindElement("Bank", "item2"),
             new ConditionList()
             .Add(new Condition(className, "bank3", null, Defs.conditionTypeNotEqual)),
             overdraftAddMoreBtn);

        public Element overdraftBalance3Box => new Element(FindElement("Balance", "Over", "item2"),
             new ConditionList()
             .Add(new Condition(className, "overdraftBalance3", null, Defs.conditionTypeNotEqual)),
             overdraftAddMoreBtn);

        public Element overdraftToBeRepaid3Chbox => new Element(FindElement("ToBeRepaid", "Over", "item2"),
             new ConditionList()
             .Add(new Condition(className, "overdraftToBeRepaid3", null, Defs.conditionTypeNotEqual)),
             overdraftAddMoreBtn);

        public Element overdraftAddMoreBtn => new Element(FindElement("Over", "btnAdd"))
            .SetCompletePageFlag(false);

        public SectionEnd overdraftSectionEnd => new SectionEnd();

        #endregion

        #region Store/Credit Cards section locators
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

        #region Loan And Hire Purchase section locators

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

        #region Other Commitments (Non Lifestyle) section locators

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

        #region BTL Mortgages

        public Element applicanthaveBtlMortgageInOwnNameRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("BTL", "!Non", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("BTL", "!Non", "rbl_1")));

        public Element totalOutstandingMortgageBalancesBox => new Element(FindElement("Money"),
             new ConditionList()
             .Add(new Condition(className, "applicanthaveBtlMortgageInOwnName", Defs.radioButtonYes)));


        #endregion


        public Element nextBtn => new Element(FindElement("Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);



    }
    public class ApplicantCommitmentsData : PageData
    {
        public string existingResidentialMortgageRedeemed { get; set; } = Defs.radioButtonYes;

        public string estimatedValueOfCurrentResidentialProperty { get; set; } = "100000";
      
        public string reasonForNotRedeeming { get; set; } = "New mortgage to purchase Buy to Let";
        public string monthlyResidentialMortgageRepayment { get; set; } = "10";
        public string residentialMortgageBalanceOutstanding { get; set; } = "10";
        public string remainingTermOfMortgageYears { get; set; } = "1";
        public string remainingTermOfMortgageMonths { get; set; } = "1";

        public string monthlyRentalPayment { get; set; } = "10";

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


        public string applicantHaveOverdraft { get; set; } = Defs.radioButtonNo;
        public string bank1 { get; set; } = "TestBank";
        public string bank2 { get; set; } = null;
        public string bank3 { get; set; } = null;
        public string overdraftBalance1 { get; set; } = "10";
        public string overdraftBalance2 { get; set; } = null;
        public string overdraftBalance3 { get; set; } = null;
        public string overdraftToBeRepaid1 { get; set; } = Defs.checkBoxSelected;
        public string overdraftToBeRepaid2 { get; set; } = null;
        public string overdraftToBeRepaid3 { get; set; } = null;
        public string overdraftAddMore { get; set; } = null;


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


        public string applicanthaveBtlMortgageInOwnName { get; set; } = Defs.radioButtonNo;
        public string totalOutstandingMortgageBalances { get; set; } = "10";
    }


}

