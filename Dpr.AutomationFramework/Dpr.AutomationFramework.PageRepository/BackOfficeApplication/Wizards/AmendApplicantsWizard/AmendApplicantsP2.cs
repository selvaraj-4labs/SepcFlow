using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendApplicantsWizard
{
    public class AmendApplicantsP2 : BOWizardBasePage
    {
        public AmendApplicantsP2()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new AmendApplicantsP2Data().GetType();
            textName = "Amend Account Setting Page 2";
            windowTitle = "Amend Applicants";
        }

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AmendApplicantsP2Data : PageData
    { 
    }
}
