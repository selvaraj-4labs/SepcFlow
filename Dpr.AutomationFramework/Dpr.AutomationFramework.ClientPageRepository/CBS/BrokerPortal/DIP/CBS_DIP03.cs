using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP03 : WebBasePage
    {
        public CBS_DIP03()
        {
            pageLoadedElement = typeOfSale;
            correspondingDataClass = new CBS_DIP03Data().GetType();
            textName = "CBS Submission Route Details Page";
        }

        #region Locators
        public Element typeOfSale => new Element(new RadioButton()
            .AddRadioButtonElement("Advised", FindElement("LevelOfAdvice", "rbl_0", tag: "input"))
            .AddRadioButtonElement("Execution Only", FindElement("LevelOfAdvice", "rbl_1", tag: "input")));

        public Element applicationSubmittedViaMortgageClub => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsMortgageClubApplication", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsMortgageClubApplication", "rbl_1")));

        public Element mortgageClub => new Element(FindElement("_MortgageClub", tag: "select"),
            new ConditionList()
                .Add(new Condition(className, "applicationSubmittedViaMortgageClub", Defs.radioButtonYes)));
        #endregion

        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class CBS_DIP03Data : PageData
    {
        public string typeOfSale { get; set; } = "Advised";
        public string applicationSubmittedViaMortgageClub { get; set; } = Defs.radioButtonNo;
        public string mortgageClub { get; set; } = "Cambridge Select Legal & General Mortgage Club";
    }
}
