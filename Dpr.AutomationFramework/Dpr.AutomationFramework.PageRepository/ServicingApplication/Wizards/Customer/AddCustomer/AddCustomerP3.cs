using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.AddCustomer
{
    public class AddCustomerP3 : AppBasePage
    {
        public AddCustomerP3()
        {
            pageLoadedElement = addAddressDetailBtn;
            correspondingDataClass = new AddCustomerP3Data().GetType();
            textName = "Add Customer Page 3";
        }
        // Page 3 and 4 are combined.

        public Element addAddressDetailBtn => new Element(FindElement("btnAddAddressDetails", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

        public Element existingAddressTable => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0"),
            "/DataItem[1]" +
            "/Edit[@Name=\"Address\"]"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element addressTableNextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AddCustomerP3Data : PageData
    {
    }
}
