using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP12 : EAP12
    {
        public HEBS_EAP12()
        {
            pageLoadedElement = enterPasswordBox;
            correspondingDataClass = new EAP12Data().GetType();
            textName = "Registration";
            pageCondition = new PageCondition(new Element(new ConditionList()
            .Add(new Condition("HEBS_EAP12", "dedupe", "false"))
            .Add(new Condition("HEBS_EAP04", "dateOfBirth", ">=16", Defs.conditionTypeCompareYearDifferenceDdMmYyyy))));
        }
    }

    public class HEBS_EAP12Data : EAP12Data
    {
    }
}
