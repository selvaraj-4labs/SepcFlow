using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP11 : CBS_DIP11
    {
        public CBS_ADV_DIP11()
        {
            pageLoadedElement = existingResidentialMortgageRedeemedRbtn;
            correspondingDataClass = new CBS_ADV_DIP11Data().GetType();
            textName = "CBS Advised Applicant 1 Credit Commitments Page";
        }
        
        #region 'Residential Mortgage' Section
        public new Element existingResidentialMortgageRedeemedRbtn => new Element(
            new RadioButton()
                .AddRadioButtonElement(Defs.radioButtonYes, FindElement("CommitmentsResidentialMortgagesRepeater1", "ApplicantPanel_ctl00_CurrentMortgageRedeemed_btn", "_rbl_0"))
                .AddRadioButtonElement(Defs.radioButtonNo, FindElement("CommitmentsResidentialMortgagesRepeater1", "ApplicantPanel_ctl00_CurrentMortgageRedeemed_btn", "_rbl_1")),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP07", "residentialStatus", "Owner Unencumbered")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP07", "residentialStatus", "Owner With Mortgage")));

        public new Element estimatedValueOfCurrentResidentialPropertyBox => new Element(FindElement("ApplicantPanel_ctl00_CurrentMortgageValue", tag: "input"),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP07", "residentialStatus", "Owner Unencumbered")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP07", "residentialStatus", "Owner With Mortgage")));

        public new Element reasonForNotRedeemingLookup => new Element(FindElement("CurrentMortgageRedeemedNote", tag: "select"),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP07", "residentialStatus", "Owner With Mortgage")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(className, "existingResidentialMortgageRedeemed", Defs.radioButtonNo)));

        public new Element monthlyResidentialMortgageRepaymentBox => new Element(FindElement("CurrentMortgagePayment", tag: "input"),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP07", "residentialStatus", "Owner With Mortgage")));

        public new Element residentialMortgageBalanceOutstandingBox => new Element(FindElement("CurrentMortgageBalance", tag: "input"),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP07", "residentialStatus", "Owner With Mortgage")));

        public new Element currentMortgageStartDate => new Element(FindElement("CurrentMortgageStartDate", tag: "input"),
            new ConditionList()
            .Add(new Condition("CBS_ADV_DIP07", "residentialStatus", "Owner With Mortgage")));
        #endregion
    }

    public class CBS_ADV_DIP11Data : CBS_DIP11Data
    {
        #region 'Residential Mortgage' Data Section
        public string existingResidentialMortgageRedeemed { get; set; } = Defs.radioButtonYes;
        public string estimatedValueOfCurrentResidentialProperty { get; set; } = "250000";
        #endregion
    }
}
