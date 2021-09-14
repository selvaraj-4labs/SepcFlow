using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AddRegularDeposit
{
    public class AccountSettingsP4 : AppBasePage
    {
        public AccountSettingsP4()
        {
            pageLoadedElement = salutationOverridePersonal;
            correspondingDataClass = new AccountSettingsP4Data().GetType();
            textName = "Account Settings Page 4";
        }

        public Element salutationOverridePersonal => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtAccountSalutationOverride"), "/Edit"));

        public Element salutationOverrideCompany => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtCompanySalutation"), "/Edit"));

        public Element update => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=btnUpdate")), new ConditionList()
            .Add(new Condition(className, "salutationOverride", null, Defs.conditionTypeNotEqual)))
            .SetIsButtonFlag(true);



        public Element next => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Next"), tag: "Button"))
            .SetIsButtonFlag(true);



    }

    public class AccountSettingsP4Data : PageData
    {

        public string salutationOverridePersonal { set; get; } = null;

        public string salutationOverrideCompany { set; get; } = null;


    }
}
