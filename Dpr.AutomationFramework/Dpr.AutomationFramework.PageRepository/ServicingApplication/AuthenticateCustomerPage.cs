using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication
{
    public class AuthenticateCustomerPage : AppBasePage
    {
        public AuthenticateCustomerPage()
        {
            pageLoadedElement = authenticateInPerson;
            correspondingDataClass = new AuthenticateCustomerPageData().GetType();
            textName = "Authenticate Customer";
        }

        // public Element authenticateInPersonBtn => new Element(FindElement("btnAuthenticateInPerson", attributeType: Defs.boLocatorAutomationId))
        //                                          .SetIsButtonFlag(true);
        //public Element authenticateInPersonBtn => new Element(By.Id("btnAuthenticateInPerson"))
        //    .SetIsButtonFlag(true);

        //public Element authenticateInPerson1 => new Element(FindElement("btnAuthenticateInPerson", attributeType: Defs.boLocatorAutomationId, tag:"button"))
        //    .SetIsButtonFlag(true);

        public Element authenticateInPerson => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "gbAuthenticationInPerson"),
            "/Button")).SetIsButtonFlag(true);
    }

    public class AuthenticateCustomerPageData : PageData
    {
    }
}
