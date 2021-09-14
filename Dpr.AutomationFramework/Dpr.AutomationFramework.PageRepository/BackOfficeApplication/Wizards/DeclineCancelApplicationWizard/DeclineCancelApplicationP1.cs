using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;


namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.DeclineCancelApplicationWizard
{
    public class DeclineCancelApplicationP1 : BOWizardBasePage
    {

        public DeclineCancelApplicationP1()
        {
            pageLoadedElement = finishBtn;
            correspondingDataClass = new DeclineCancelApplicationP1Data().GetType();
            textName = "Decline / Cancel Application Page 1";
            windowTitle = "Decline/Cancel Application";
        }

        public Element declineCancelReasonLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "Reason")
            .Add(Defs.boLocatorAutomationId, "ultraComboEditor")
            ));

        public Element notesBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ultraTextEditor")));

        public Element finishBtn => new Element(FindElement("Finish", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);

    }

    public class DeclineCancelApplicationP1Data : PageData
    {
        public string declineCancelReasonLookup { get; set; } = "Cancelled ? No longer require loan, no reason given ?";


        public string notes { get; set; } = "Automation: Cancelled ? No longer require loan, no reason given ?";
    }
}
