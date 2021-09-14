using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Fees.AddNewFee
{
    public class AddNewFeeP1 : AppBasePage
    {
        public AddNewFeeP1()
        {
            pageLoadedElement = type;
            correspondingDataClass = new AddNewFeeP1Data().GetType();
            textName = "Add New Fee Page 1";
        }
        public Element type => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=ceType")));
        //, tag: "ComboBox"
        //, "/Edit" "/Edit"

        public Element description => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtDescription"), "/Edit"))
            .SetCompletePageFlag(false);

        public Element feeAmountStandard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtStandardFeeAmount"), "/Edit"))
            .SetCompletePageFlag(false);

        public Element feeAmountOverride => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtOverrideAmount"), "/Edit[@AutomationId=\"txtDecimalValue\"]/Edit"))
            .SetCompletePageFlag(false);

        public Element feeAmountWaive => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtWaive"), "/Edit"));

        public Element standard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=ceStandardInterest"), "/Edit"));

        public Element overrideDropdown => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=ceOverrideInterest"), "/Edit"));

        public Element whenPayable => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=ceWhenPayable"), "/Edit"));

        public Element remarksBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtRemarks"), "/Edit"));

        public Element nextBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Next"), tag: "Button"))
            .SetIsButtonFlag(true);
    }

    public class AddNewFeeP1Data : PageData
    {
        public string type { get; set; } = "[CHAPS_FEE] CHAPS Fee";
        public string feeAmountWaive { get; set; } = null;
        public string standard { get; set; } = null;
        public string overrideDropdown { get; set; } = "Never";
        public string whenPayable { get; set; } = null;
        public string remarks { get; set; } = "Test Remarks";
    }
}
