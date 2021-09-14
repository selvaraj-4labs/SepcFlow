using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{ 
    public class EAP25 : WebBasePage
    {
        public EAP25()
        {
            pageLoadedElement = makePaymentBtn;
            correspondingDataClass = new EAP25Data().GetType();
            textName = "Debit Card Payment";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("EAP19", "depositType", "Debit Card"))));
        }
        #region Locators
        public Element makePaymentBtn => new Element(FindElement("MakePaymentButton")).SetIsButtonFlag(true);
        #endregion  
    }

    public class EAP25Data : PageData
    {
    }
}
