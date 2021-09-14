using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerStatus.CancelCustomerStatus
{
    public class CancelCustomerStatusP1 : AppBasePage
    {
        public CancelCustomerStatusP1()
        {
            pageLoadedElement = finishBtn;
            correspondingDataClass = new CancelCustomerStatusP1Data().GetType();
            textName = "Cancel Customer Status Page 1";
        }

        public Element finishBtn => new Element(FindElement("pnlNextButton", Defs.boLocatorAutomationId)).SetCompletePageFlag(true);
    }

    public class CancelCustomerStatusP1Data : PageData
    {

    }
}
