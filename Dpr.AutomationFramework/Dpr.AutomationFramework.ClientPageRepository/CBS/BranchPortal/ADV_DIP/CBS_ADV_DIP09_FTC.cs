using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP09_FTC : CBS_DIP09_FTC
    {
        public CBS_ADV_DIP09_FTC()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new CBS_ADV_DIP09_FTCData().GetType();
            textName = "CBS Advised Applicant 1 Primary Employment Page - Fixed Term Contract";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_ADV_DIP08", "employmentStatus", "Fixed Term Contract"))));
        }
        #region 'Employment Details' Section
        public new Element fullTime => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("EmplymentStatus_1", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("EmplymentStatus_2", tag: "input")));

        public new Element hasContractBeenRenewed => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HasContractRenewed_1", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HasContractRenewed_2", tag: "input")));

        public new Element willContractBeenRenewed => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("WillCurrctContractRenewed_1", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("WillCurrctContractRenewed_2", tag: "input")));
        #endregion
    }

    public class CBS_ADV_DIP09_FTCData : CBS_DIP09_FTCData
    {
    }
}
