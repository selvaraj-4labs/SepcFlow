using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP07 : EAP07
    {
        public HEBS_EAP07()
        {
            pageLoadedElement = indiviualOrCompanyLookup;
            correspondingDataClass = new HEBS_EAP07Data().GetType();
            textName = "Shareholder 1 Details";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("HEBS_EAP06", "numberOfOtherApplicants", "1")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("HEBS_EAP06", "numberOfOtherApplicants", "2")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("HEBS_EAP06", "numberOfOtherApplicants", "3")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("HEBS_EAP06", "numberOfOtherApplicants", "4"))));
        }
    }

    public class HEBS_EAP07Data : EAP07Data
    {
    }
}
