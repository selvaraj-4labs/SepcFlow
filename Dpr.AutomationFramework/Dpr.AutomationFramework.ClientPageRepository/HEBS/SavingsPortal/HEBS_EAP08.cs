using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP08 : EAP08
    {
        public HEBS_EAP08()
        {
            pageLoadedElement = titleLookup;
            correspondingDataClass = new HEBS_EAP08Data().GetType();
            textName = "Parent/Guardian page";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("HEBS_EAP00", "productType", "Child"))
                    .Add(new Condition("HEBS_EAP04", "dateOfBirth", "<16", Defs.conditionTypeCompareYearDifferenceDdMmYyyy)))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("HEBS_EAP00", "productType", "ChildISA"))
                    .Add(new Condition("HEBS_EAP04", "dateOfBirth", "<16", Defs.conditionTypeCompareYearDifferenceDdMmYyyy))));
        }
    }

    public class HEBS_EAP08Data : EAP08Data
    {
    }
}
