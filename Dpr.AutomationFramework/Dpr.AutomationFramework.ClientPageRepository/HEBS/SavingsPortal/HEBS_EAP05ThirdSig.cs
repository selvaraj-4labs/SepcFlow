using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP05ThirdSig : EAP05ThirdSig
    {
        public HEBS_EAP05ThirdSig()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new HEBS_EAP05ThirdSigData().GetType();
            textName = "Signatory Information 3rd Signatory";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("HEBS_EAP05", "numberOfSignatories", "3")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("HEBS_EAP05", "numberOfSignatories", "4"))));
        }
    }

    public class HEBS_EAP05ThirdSigData : EAP05ThirdSigData
    {
    }
}
