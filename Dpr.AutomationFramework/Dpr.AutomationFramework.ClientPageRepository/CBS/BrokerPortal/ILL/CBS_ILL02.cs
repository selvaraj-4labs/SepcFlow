using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.ILL
{
    public class CBS_ILL02 : WebBasePage
    {
        public CBS_ILL02()
        {
            pageLoadedElement = typeOfSale;
            correspondingDataClass = new CBS_ILL01Data().GetType();
            textName = "CBS Submission Details";
        }
        #region 'Submission Route Details' Section
        public Element typeOfSale => new Element(new RadioButton()
            .AddRadioButtonElement("Advised", FindElement("LevelOfAdvice", "rbl_0"))
            .AddRadioButtonElement("Execution Only", FindElement("LevelOfAdvice", "rbl_1")));

        public Element applicationSubmittedViaMortgageClub => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsMortgageClubApplication", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsMortgageClubApplication", "rbl_1")));

        public Element mortgageClub => new Element(FindElement("_MortgageClub"),new ConditionList()
            .Add(new Condition(className, "applicationSubmittedViaMortgageClub", Defs.radioButtonYes)));
        #endregion

        public Element next => new Element(FindElement("Next")).SetIsButtonFlag(true);
    }

    public class CBS_ILL02Data : PageData
    {
        public string typeOfSale { get; set; } = "Advised";
        public string applicationSubmittedViaMortgageClub { get; set; } = Defs.radioButtonNo;
        public string mortgageClub { get; set; } = "Cambridge Select Legal & General Mortgage Club";
    }
}
