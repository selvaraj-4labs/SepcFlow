using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AddRegularDeposit
{
    public class AccountSettingsP1 : AppBasePage
    {
        public AccountSettingsP1()
        {
            pageLoadedElement = accountFriendlyName;
            correspondingDataClass = new AccountSettingsP1Data().GetType();
            textName = "Account Settings Page 1";
        }

        public Element noOfCustomersAuthorisationRequired => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtNoCustomerAuthRequired"), "/Edit"))
            .SetCompletePageFlag(false);

        public Element accountFriendlyName => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtAccountFriendlyName"), "/Edit"));

        public Element remarks => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtRemarks"), "/Edit"));


        public Element next => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Next"), tag: "Button"))
            .SetIsButtonFlag(true);



    }

    public class AccountSettingsP1Data : PageData
    {

        public string accountFriendlyName { set; get; } = null;

        public string remarks { set; get; } = null;




    }
}
