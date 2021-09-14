﻿using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP09_2ndEmployed_3 : CBS_DIP09_2ndEmployed
    {
        public CBS_DIP09_2ndEmployed_3()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new CBS_DIP09_2ndEmployed_3Data().GetType();
            textName = "CBS Applicant 3 Secondary Employment Page - Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "3"))
                    .Add(new Condition("CBS_DIP08_3", "secondaryEmploymentStatus", "Employed")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "4"))
                    .Add(new Condition("CBS_DIP08_3", "secondaryEmploymentStatus", "Employed"))));
        }
    }

    public class CBS_DIP09_2ndEmployed_3Data : CBS_DIP09_2ndEmployedData
    {
    }
}

