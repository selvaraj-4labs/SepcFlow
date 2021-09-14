using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Roles.GenericAddCeaseRole
{
    public class GenericAddCeaseRoleP1 : AppBasePage
    {
        public GenericAddCeaseRoleP1()
        {
            pageLoadedElement = individualCustomerChbox;
            correspondingDataClass = new GenericAddCeaseRoleP1Data().GetType();
            textName = "Generic Add Cease Role Page 1";
        }

        // Second row of a generic corp case is the individual customer.
        // Not a checkbox, but need to click.
        public Element individualCustomerChbox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ultraGrid")
            .Add(Defs.boLocatorName, "CustomerViewBinder[] row 2")));

        public Element nextBtn => new Element(FindElement("Next", Defs.boLocatorName)).SetIsButtonFlag(true);
    }
    
    public class GenericAddCeaseRoleP1Data : PageData
    {
        public string individualCustomer { get; set; } = Defs.checkBoxSelected;
    }
}
