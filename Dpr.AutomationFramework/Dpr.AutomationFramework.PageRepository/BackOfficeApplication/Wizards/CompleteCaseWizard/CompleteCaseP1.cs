using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.CompleteCaseWizard
{
    public class CompleteCaseP1 : BOWizardBasePage
    {
        public CompleteCaseP1()
        {

            pageLoadedElement = nextBtn;
            correspondingDataClass = new CompleteCaseP1Data().GetType();
            textName = "Complete Case Page 1";
            windowTitle = "Complete Case";

        }



        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CompleteCaseP1Data : PageData
    {
    }

}
