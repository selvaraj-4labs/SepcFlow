using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdateCustomerPreferences
{
    public class UpdateCustomerPreferencesP2 : AppBasePage
    {
        public UpdateCustomerPreferencesP2()
        {
            pageLoadedElement = houseFlatNumberBox;
            correspondingDataClass = new UpdateCustomerPreferencesP2Data().GetType();
            textName = "Update Customer Prefernces Page 2";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("UpdateCustomerPreferencesP1", "editButtonGroup", "Edit"))
                ));
        }
        public Element houseFlatNumberBox => new Element(FindElement("teAddressLine", attributeType: Defs.boLocatorAutomationId));
        public Element postcodeBox => new Element(FindElement("tePostCodeSrch", attributeType: Defs.boLocatorAutomationId));
        public Element searchBtn => new Element(FindElement("btnAddressSearch", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

    }
    public class UpdateCustomerPreferencesP2Data : PageData
    {
        public string houseFlatNumber { get; set; } = "11";
        public string postcode { get; set; } = "DA1 1TX";
    }
}
