using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.MaintainEmploymentDetails
{
    public class MaintainEmploymentDetailsP1 : AppBasePage
    {
        public MaintainEmploymentDetailsP1()
        {
            pageLoadedElement = employmentDetails;
            correspondingDataClass = new MaintainEmploymentDetailsP1Data().GetType();
            textName = "Maintain Employment Details Page 1";
        }
        public Element employmentDetails => new Element(new ButtonGroup()
            .AddButtonElement("Verify", FindElement("btnVerify", attributeType: Defs.boLocatorAutomationId))
            .AddButtonElement("Update", FindElement("btnUpdate", attributeType: Defs.boLocatorAutomationId)));
    }
    

    public class MaintainEmploymentDetailsP1Data : PageData
    {
        public string employmentDetails { get; set; } = "Update";
    }
}
