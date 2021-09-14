using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.MaintainEmploymentDetails
{
    // IDENTICAL PAGE TO 'MaintainEmploymentDetailsP1'
    public class MaintainEmploymentDetailsP8 : AppBasePage
    {
        public MaintainEmploymentDetailsP8()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new MaintainEmploymentDetailsP8Data().GetType();
            textName = "Maintain Employment Details Page 8";  
        }
        public Element nextBtn => new Element(FindElement("Next", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);
    }

   public class MaintainEmploymentDetailsP8Data : PageData
    {
    }
}
