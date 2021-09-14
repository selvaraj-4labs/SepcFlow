using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.MaintainEmploymentDetails
{
    public class MaintainEmploymentDetailsP6 : AppBasePage
    {
        public MaintainEmploymentDetailsP6()
        {
            pageLoadedElement = contactNameBox;
            correspondingDataClass = new MaintainEmploymentDetailsP6Data().GetType();
            textName = "Maintain Employment Details Page 6";
        }
        public Element contactNameBox => new Element(FindElement("txtContactName", attributeType: Defs.boLocatorAutomationId));
        public Element contactTelBox => new Element(FindElement("txtContactTel", attributeType: Defs.boLocatorAutomationId));
        public Element contactFaxBox => new Element(FindElement("txtContactFax", attributeType: Defs.boLocatorAutomationId));
        public Element contactemailBox => new Element(FindElement("txtContactEmail", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("Next", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);
    }

    public class MaintainEmploymentDetailsP6Data : PageData
    {
        public string contactName { get; set; } = "TestEmployer";
        public string contactTel { get; set; } = null;
        public string contactFax { get; set; } = null;
        public string contactEmail { get; set; } = null;

    }
}
