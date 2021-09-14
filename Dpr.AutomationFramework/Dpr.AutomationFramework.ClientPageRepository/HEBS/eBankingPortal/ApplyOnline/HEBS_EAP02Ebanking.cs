using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.ApplyOnline
{
    public class HEBS_EAP02Ebanking : EAP02Ebanking
    {
        public HEBS_EAP02Ebanking()
        {
            pageLoadedElement = acceptISADeclarationChbox;
            correspondingDataClass = new HEBS_EAP02EbankingData().GetType();
            textName = "ISA Declaration Page EBanking";
            pageCondition = new PageCondition(new Element(new ConditionList()
                        .Add(new Condition("HEBS_AP01", "productType", "ISA")))
                .AddNewConditionList(new ConditionList()
                        .Add(new Condition("HEBS_AP01", "productType", "ChildIsa"))));
        }
    }

    public class HEBS_EAP02EbankingData : EAP02EbankingData
    {
    }
}
