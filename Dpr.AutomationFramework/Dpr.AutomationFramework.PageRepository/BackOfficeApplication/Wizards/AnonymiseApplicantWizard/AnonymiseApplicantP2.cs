using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AnonymiseApplicantWizard
{
    public class AnonymiseApplicantP2 : BOWizardBasePage
    {
        public AnonymiseApplicantP2()
        {

            pageLoadedElement = new Element(FindElement("Anonymise data", attributeType: Defs.boLocatorName));
            correspondingDataClass = new AnonymiseApplicantP2Data().GetType();
            textName = "Anonymise Applicant Page 2";

        }

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

    }

    public class AnonymiseApplicantP2Data : PageData
    {
    }

}
