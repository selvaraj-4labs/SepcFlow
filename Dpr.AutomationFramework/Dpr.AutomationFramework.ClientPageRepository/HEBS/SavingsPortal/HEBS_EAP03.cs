using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP03 : EAP03
    { 
        public HEBS_EAP03()
        {
            pageLoadedElement = businessTypeLookup;
            correspondingDataClass = new HEBS_EAP03Data().GetType();
            textName = "Corporate Company Details Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("HEBS_EAP00", "productType", "Corporate"))));
        }
    }

    public class HEBS_EAP03Data : EAP03Data
    {
    }
}
