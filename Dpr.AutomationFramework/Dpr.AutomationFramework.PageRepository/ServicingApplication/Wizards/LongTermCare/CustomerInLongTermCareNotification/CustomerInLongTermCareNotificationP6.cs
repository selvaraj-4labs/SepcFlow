using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.CustomerInLongTermCareNotification
{
    public class CustomerInLongTermCareNotificationP6 : AppBasePage
    {
        public CustomerInLongTermCareNotificationP6()
        {
            pageLoadedElement = careHomeSelectBtn;
            correspondingDataClass = new CustomerInLongTermCareNotificationP6Data().GetType();
            textName = "Customer In Long Term Care Notification Page 2";
        }

        public Element careHomeSelectBtn => new Element(FindElement(new LocatorList()
            //.Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0")
            .Add(Defs.boLocatorName, "Select"), tag: "CheckBox"))
            .SetIsButtonFlag(true);

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId))
            .SetIsButtonFlag(true);
    }
    public class CustomerInLongTermCareNotificationP6Data : PageData
    { 
    }
}
