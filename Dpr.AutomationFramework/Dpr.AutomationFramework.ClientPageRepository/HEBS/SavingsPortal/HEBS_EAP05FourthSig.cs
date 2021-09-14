using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP05FourthSig : EAP05FourthSig
    {
        public HEBS_EAP05FourthSig()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new EAP05FourthSigData().GetType();
            textName = "Signatory Information 4th Signatory";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("HEBS_EAP05", "numberOfSignatories", "4"))));
        }
    }

    public class HEBS_EAP05FourthSigData : EAP05FourthSigData
    {
    }
}
