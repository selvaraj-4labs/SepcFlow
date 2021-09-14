using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline
{
    public class EAP02Ebanking : EAP02
    {
        public EAP02Ebanking()
        {
            pageLoadedElement = acceptISADeclarationChbox;
            correspondingDataClass = new EAP02EbankingData().GetType();
            textName = "ISA Declaration Page EBanking";
            pageCondition = new PageCondition(new Element(new ConditionList()
                        .Add(new Condition("AP01", "productType", "ISA")))
                .AddNewConditionList(new ConditionList()
                        .Add(new Condition("AP01", "productType", "ChildIsa"))));
        }
    }
    public class EAP02EbankingData : EAP02Data
    {
    }
}
