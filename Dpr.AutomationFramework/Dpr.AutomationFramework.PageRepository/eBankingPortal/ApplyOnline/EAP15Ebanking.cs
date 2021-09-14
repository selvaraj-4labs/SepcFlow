using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline
{
    public class EAP15Ebanking : EAP15
    {
        public EAP15Ebanking()
        {
            pageLoadedElement = fscsChbox;
            correspondingDataClass = new EAP15EbankingData().GetType();
            textName = "Summary Ebanking";
        }

        public new Element yourAgreement => new Element(FindElement("YourAgreement1_ctl00_chkAcceptDeclaration"),
            new ConditionList()
                .Add(new Condition("AP01", "productType", "retail")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("AP01", "productType", "child")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("AP01", "productType", "isa")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("AP01", "productType", "childisa")));
    }

    public class EAP15EbankingData : EAP15Data
    {
    }
}
