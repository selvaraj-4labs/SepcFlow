using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP05SecondSig : EAP05SecondSig
    {
        public HEBS_EAP05SecondSig()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new HEBS_EAP05SecondSigData().GetType();
            textName = "Signatory Information 2nd Signatory";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("HEBS_EAP05", "numberOfSignatories", "2")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("HEBS_EAP05", "numberOfSignatories", "3")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("HEBS_EAP05", "numberOfSignatories", "4"))));
        }
    }

    public class HEBS_EAP05SecondSigData : EAP05SecondSigData
    {
    }
}
