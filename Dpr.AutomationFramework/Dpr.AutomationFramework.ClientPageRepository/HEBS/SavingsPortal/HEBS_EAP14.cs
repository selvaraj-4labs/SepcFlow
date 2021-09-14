using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP14 : EAP14
    {
        public HEBS_EAP14()
        {
            pageLoadedElement = pleaseWaitText;
            correspondingDataClass = new EAP14Data().GetType();
            textName = "Decision Loading Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("HEBS_EAP00", "productType", "Child", Defs.conditionTypeNotEqual))
                .Add(new Condition("HEBS_EAP00", "productType", "ChildISA", Defs.conditionTypeNotEqual))));
        }
    }

    public class HEBS_EAP14Data : EAP14Data
    {
    }
}
