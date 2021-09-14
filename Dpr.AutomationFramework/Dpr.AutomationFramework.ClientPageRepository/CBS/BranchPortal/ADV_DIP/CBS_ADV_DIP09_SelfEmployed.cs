﻿using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP09_SelfEmployed : CBS_DIP09_SelfEmployed
    {
        public CBS_ADV_DIP09_SelfEmployed()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new CBS_ADV_DIP09_SelfEmployedData().GetType();
            textName = "CBS Advised Applicant 1 Primary Employment Page - Self Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_ADV_DIP08", "employmentStatus", "Self Employed"))));
        }
        #region 'Self-employed Details' Section
        public new Element fullTime => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("EmplymentStatus_1", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("EmplymentStatus_2", tag: "input")));
        #endregion
    }

    public class CBS_ADV_DIP09_SelfEmployedData : CBS_DIP09_SelfEmployedData
    {
    }
}
