using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.DeclineCancelApplicationWizard
{
    public class DeclineCancelApplicationP2 : BOWizardBasePage
    {

        public DeclineCancelApplicationP2()
        {
            pageLoadedElement = processingCompleteLbl;
            correspondingDataClass = new DeclineCancelApplicationP2Data().GetType();
            textName = "Decline / Cancel Application Page 2";
        }

        public Element processingCompleteLbl => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Processing  complete")
            .Add(Defs.boLocatorAutomationId, "lblTitle")))
            .SetCompletePageFlag(false);


        public Element finishBtn => new Element(FindElement("Finish", attributeType: Defs.boLocatorName))
            .SetIsButtonFlag(true);

    }

    public class DeclineCancelApplicationP2Data : PageData
    {
    }

}
