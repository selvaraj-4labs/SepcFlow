using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AdHocDeposit
{
    public class AdHocDepositP2 : AppBasePage
    {
        public AdHocDepositP2()
        {
            pageLoadedElement = messagesBox;
            correspondingDataClass = new AdHocDepositP2Data().GetType();
            textName = "Ad-hoc Deposit Page 2";
        }
        public Element messagesBox => new Element(FindElement("txtMessages", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AdHocDepositP2Data : PageData
    {
    }
}
