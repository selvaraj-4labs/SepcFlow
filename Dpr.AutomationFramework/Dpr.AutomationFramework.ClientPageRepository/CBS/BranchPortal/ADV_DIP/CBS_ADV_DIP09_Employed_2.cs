using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP09_Employed_2 : CBS_DIP09_Employed_2
    {
        public CBS_ADV_DIP09_Employed_2()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new CBS_ADV_DIP09_Employed_2Data().GetType();
            textName = "CBS Advised Applicant 2 Primary Employment Page - Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_ADV_DIP06", "numberOfApplicants", "2"))
                    .Add(new Condition("CBS_ADV_DIP08_2", "employmentStatus", "Employed")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_ADV_DIP06", "numberOfApplicants", "3"))
                    .Add(new Condition("CBS_ADV_DIP08_2", "employmentStatus", "Employed")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_ADV_DIP06", "numberOfApplicants", "4"))
                    .Add(new Condition("CBS_ADV_DIP08_2", "employmentStatus", "Employed"))));
        }
        #region 'Employment Details' Section
        public new Element fullTime => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("EmplymentStatus_1", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("EmplymentStatus_2", tag: "input")));

        public new Element permanentEmployment => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsEmploymentPermenant_1", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsEmploymentPermenant_2", tag: "input")));

        public new Element withinProbationaryPeriod => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsOnProbation_1", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsOnProbation_2", tag: "input")));
        #endregion
    }

    public class CBS_ADV_DIP09_Employed_2Data : CBS_DIP09_Employed_2Data
    {
    }
}
