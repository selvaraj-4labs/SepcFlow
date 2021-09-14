using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP06 : EAP06
    {
        public HEBS_EAP06()
        {
            pageLoadedElement = signatoryShareholding_1Rbtn;
            correspondingDataClass = new EAP06Data().GetType();
            textName = "Signatory Shareholders";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("HEBS_EAP00", "productType", "Corporate"))
                    .Add(new Condition("HEBS_EAP03", "businessType", "Limited Company"))));
        }
    }

    public class HEBS_EAP06Data : EAP06Data
    {
    }
}
