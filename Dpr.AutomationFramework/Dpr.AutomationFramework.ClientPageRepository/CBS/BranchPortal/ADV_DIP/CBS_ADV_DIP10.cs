using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP10 : CBS_DIP10
    {
        public CBS_ADV_DIP10()
        {
            pageLoadedElement = applicantName;
            correspondingDataClass = new CBS_ADV_DIP10Data().GetType();
            textName = "CBS Advised Applicant 1 Employment Summary";
        }

        public new Element areYouABasicRateTaxPayer => new Element(new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsBasicRateTaxPayer", "rbl_0"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsBasicRateTaxPayer", "rbl_1")),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP02", "loanType", "BTL")));

        #region Lending into Retirement Section

        public new Element doYouHaveAnySourceOfIncomeIntoRetirement => new Element(new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("FutureIncomeDetails1_ctl00_pnlApplicantPanel_ctl00_ctl00_FactfindList_ctl00_ctl00_rbl_0", tag: "input"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("FutureIncomeDetails1_ctl00_pnlApplicantPanel_ctl00_ctl00_FactfindList_ctl00_ctl00_rbl_1", tag: "input")),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "termRequirements", "RIO")));


        public new Section retirementIncomeYes => new Section(new Element(
            new ConditionList()
                .Add(new Condition(className, "doYouHaveAnySourceOfIncomeIntoRetirement", Defs.radioButtonYes)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "termRequirements", "RIO"))));

        public new Element retirementSource1 => new Element(FindElement("FutureIncomeSource", "item0")/*, new ConditionList()
            .Add(new Condition(className, "applicationSubmittedViaMortgageClub", Defs.radioButtonYes))*/);

        public new Element retirementSpousalBenefit1 => new Element(FindElement("SpousalBenefit", "item0"));

        public new Element retirementAnnualAmount1 => new Element(FindElement("FutureIncomeAmount", "item0")/*, new ConditionList()
            .Add(new Condition(className, "applicationSubmittedViaMortgageClub", Defs.radioButtonYes))*/);

        public new Element retirementSource2 => new Element(FindElement("FutureIncomeSource", "item1"), null, retirementAdd.locator);

        public new Element retirementAnnualAmount2 => new Element(FindElement("FutureIncomeAmount", "item1"), null, retirementAdd.locator);

        public new Element retirementSpousalBenefit2 => new Element(FindElement("SpousalBenefit", "item1"));

        public new Element retirementSource3 => new Element(FindElement("FutureIncomeSource", "item2"), null, retirementAdd.locator);

        public new Element retirementAnnualAmount3 => new Element(FindElement("FutureIncomeAmount", "item2"), null, retirementAdd.locator);

        public new Element retirementSpousalBenefit3 => new Element(FindElement("SpousalBenefit", "item2"));

        public new Element retirementAdd => new Element(FindElement("_MortgageClub"), new ConditionList()
            .Add(new Condition(className, "applicationSubmittedViaMortgageClub", Defs.radioButtonYes)))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public new SectionEnd retirementIncomeYesEnd => new SectionEnd();
        #endregion  


    }

    public class CBS_ADV_DIP10Data : CBS_DIP10Data
    {
        #region Lending into Retirement
        //Values changed to null until fully implemented
        public new string doYouHaveAnySourceOfIncomeIntoRetirement { set; get; } = null;//Defs.radioButtonYes;

        public new string retirementSource1 { set; get; } = "Private Occupational Pension";//"Private Occupational Pension";

        public new string retirementAnnualAmount1 { set; get; } = "90000";//"90000";
        public new string retirementSpousalBenefit1 { set; get; } = "100";

        public new string retirementSource2 { set; get; } = null;

        public new string retirementAnnualAmount2 { set; get; } = null;
        public new string retirementSpousalBenefit2 { set; get; } = null;

        public new string retirementSource3 { set; get; } = null;

        public new string retirementAnnualAmount3 { set; get; } = null;
        public new string retirementSpousalBenefit3 { set; get; } = null;

        #endregion
    }
}
