using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.ExtendOfferWizard
{
    public class ExtendOfferP2 : BOWizardBasePage
    {
        public ExtendOfferP2()
        {
            pageLoadedElement = next;
            correspondingDataClass = new ExtendOfferP2Data().GetType();
            textName = "Extend Offer Page 2";
            windowTitle = "Offer Extension";
        }
        public Element next => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class ExtendOfferP2Data : PageData
    {
    }
}
