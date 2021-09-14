using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP02 : EAP02
    {
        public HEBS_EAP02()
        {
            pageLoadedElement = acceptISADeclarationChbox;
            correspondingDataClass = new HEBS_EAP02Data().GetType();
            textName = "ISA Declaration Page";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("HEBS_EAP00", "productType", "ISA")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("HEBS_EAP00", "productType", "ChildISA"))));
        }
    }

    public class HEBS_EAP02Data : EAP02Data
    {
    }
}
