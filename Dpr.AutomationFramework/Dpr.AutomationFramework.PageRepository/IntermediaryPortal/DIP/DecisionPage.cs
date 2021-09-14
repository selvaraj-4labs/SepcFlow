using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class DecisionPage : WebBasePage
    {
        public DecisionPage()
        {
            pageLoadedElement = decisionLbl;
            correspondingDataClass = new DecisionData().GetType();
            textName = "Decision Result Page";
        }

        //Cannot currently access the Accept with affordability fail screen due to it not being set up
        //Product selection elements of the of the Accept screen have been left out for speed.


        #region Locators
        
        //"Decision" text - Label
        public Element decisionLbl => new Element(FindElement(
            new LocatorList()
            .Add(Defs.locatorId, "DecisionLblFor")))
            .SetCompletePageFlag(false);
        

        
        //Decision result text Label
        public Element decisionResult => new Element(FindElement(
            new LocatorList()
                .Add(Defs.locatorId, "MC_ucDecisionResult_ctl01_lblDecision")))
            .SetCompletePageFlag(false);

        public Element provideAdditionalInformation => new Element(FindElement("txtOtherInfo"), new ConditionList()
            .Add(new Condition(decisionResult, "This case has been referred based on the information you have provided.", Defs.conditionTypeEqual)));

        // Removed on 15/04/2020 - Not displaying on 'Accept' journey, perform further testing on 'Refer' journeys.
        //public Element alternativeProducts => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl02_ViewAlternativeProducts_btn", "_rbl_0"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl02_ViewAlternativeProducts_btn", "_rbl_1")));

        public Element nextBtn => new Element(FindElement("Next"), new ConditionList()
            .Add(new Condition(decisionResult, "The mortgage application has been accepted.",  Defs.conditionTypeEqual)))
            .SetIsButtonFlag(true);
      
        #endregion

    }

    public class DecisionData : PageData
    {
        public string provideAdditionalInformation { get; set; } = null;
        //public string alternativeProducts { get; set; } = Defs.radioButtonNo;
    }
}
