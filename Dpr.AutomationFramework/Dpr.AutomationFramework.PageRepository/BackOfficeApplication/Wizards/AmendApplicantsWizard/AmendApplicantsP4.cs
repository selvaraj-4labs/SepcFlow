using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AnonymiseApplicantWizard
{
    public class AmendApplicantsP4 : BOWizardBasePage
    {
        public AmendApplicantsP4()
        {
            pageLoadedElement = finishBtn;
            correspondingDataClass = new AmendApplicantsP4Data().GetType();
            textName = "Amend Applicants Page 4";
            windowTitle = "Amend Applicants";
        }
        public Element finishBtn => new Element(FindElement("Finish", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);
    }

    public class AmendApplicantsP4Data : PageData
    {
    }
}
