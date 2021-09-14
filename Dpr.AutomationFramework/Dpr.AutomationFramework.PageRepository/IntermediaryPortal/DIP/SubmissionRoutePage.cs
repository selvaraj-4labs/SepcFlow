using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class SubmissionRoutePage : WebBasePage
    {

        public SubmissionRoutePage()
        {
            pageLoadedElement = typeOfSale;
            correspondingDataClass = new SubmissionRoutePageData().GetType();
            textName = "Submission Route Details Page";
        }

        #region Locators
        public Element typeOfSale => new Element(new RadioButton()
            .AddRadioButtonElement("Advised", FindElement("LevelOfAdvice", "rbl_0", tag: "input"))
            .AddRadioButtonElement("Execution Only", FindElement("LevelOfAdvice", "rbl_1", tag: "input")));

        public Element adviceRejected => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoIsAdviceRejected", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoIsAdviceRejected", "rbl_1")),
            new ConditionList()
                .Add(new Condition(className, "typeOfSale", "Advised")));

        public Element applicationSubmittedViaMortgageClub => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsMortgageClubApplication", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsMortgageClubApplication", "rbl_1")));


        public Element mortgageClub => new Element(FindElement("_MortgageClub"), 
            new ConditionList()
                .Add(new Condition(className, "applicationSubmittedViaMortgageClub", Defs.radioButtonYes)));

        #endregion
        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }


    public class SubmissionRoutePageData : PageData
    {
        public string typeOfSale { get; set; } = "Advised";
        public string adviceRejected { get; set; } = Defs.radioButtonNo;
        public string applicationSubmittedViaMortgageClub { get; set; } = Defs.radioButtonNo;
        public string mortgageClub { get; set; } = "M-Club Seven Limited";  //No MCS show currently for holmes introducer
    }
}
