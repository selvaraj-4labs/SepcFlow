using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP05 : EAP05
    {
        public HEBS_EAP05()
        {
            pageLoadedElement = numberOfSignatoriesRbtn;
            correspondingDataClass = new HEBS_EAP05Data().GetType();
            textName = "Signatory Information";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("HEBS_EAP00", "productType", "Corporate"))));
        }
    }

    public class HEBS_EAP05Data : EAP05Data
    {
        public new string postcode { get; set; } = "CM16JN";
    }
}
