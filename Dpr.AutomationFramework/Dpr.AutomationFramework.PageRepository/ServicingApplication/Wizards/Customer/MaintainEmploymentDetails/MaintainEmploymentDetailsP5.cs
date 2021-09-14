using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.MaintainEmploymentDetails
{
    public class MaintainEmploymentDetailsP5 : AppBasePage
    {
        public MaintainEmploymentDetailsP5()
        {
            pageLoadedElement = houseFlatNumberBox;
            correspondingDataClass = new MaintainEmploymentDetailsP5Data().GetType();
            textName = "Maintain Employment Details Page 5";
        }
        public Element houseFlatNumberBox => new Element(FindElement("teAddressLine", attributeType: Defs.boLocatorAutomationId));
        public Element postcodeBox => new Element(FindElement("tePostCodeSrch", attributeType: Defs.boLocatorAutomationId));
        public Element addressSearchBtn => new Element(FindElement("btnAddressSearch", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
        public Element nextBtn => new Element(FindElement("Next", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);
    }

    public class MaintainEmploymentDetailsP5Data : PageData
    {
        public string houseFlatNumber { get; set; } = "11";
        public string postcode { get; set; } = "SW8 3QJ";
    }
}
