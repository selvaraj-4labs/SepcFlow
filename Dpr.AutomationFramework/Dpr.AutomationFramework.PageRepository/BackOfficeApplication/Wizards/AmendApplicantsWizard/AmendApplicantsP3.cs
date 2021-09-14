using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendApplicantsWizard
{
    public class AmendApplicantsP3 : BOWizardBasePage
    {
        public AmendApplicantsP3()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new AmendApplicantsP3Data().GetType();
            textName = "Amend Account Setting Page 3";
            windowTitle = "Amend Applicants";
        }

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AmendApplicantsP3Data : PageData
    {
    }
}
