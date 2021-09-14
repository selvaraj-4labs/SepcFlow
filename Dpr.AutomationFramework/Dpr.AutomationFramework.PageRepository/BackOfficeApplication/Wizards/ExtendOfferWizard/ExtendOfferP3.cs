using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.ExtendOfferWizard
{
    public class ExtendOfferP3 : BOWizardBasePage
    {
        public ExtendOfferP3()
        {
            pageLoadedElement = finish;
            correspondingDataClass = new ExtendOfferP3Data().GetType();
            textName = "Extend Offer Page 3";
            windowTitle = "Offer Extension";
        }
        public Element finish => new Element(FindElement("Finish", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);
    }

    public class ExtendOfferP3Data : PageData
    {
    }
}
