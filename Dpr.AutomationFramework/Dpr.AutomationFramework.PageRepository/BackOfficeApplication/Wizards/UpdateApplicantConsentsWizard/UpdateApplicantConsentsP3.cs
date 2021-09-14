using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.GenerateDataOutputDocumentWizard
{
    public class UpdateApplicantConsentsP3 : BOWizardBasePage
    {
        public UpdateApplicantConsentsP3()
        {
            pageLoadedElement = new Element(FindElement("Confirm Business Rules Processing", attributeType: Defs.boLocatorName));
            correspondingDataClass = new UpdateApplicantConsentsP3Data().GetType();
            textName = "Update Applicant Consents Page 3";
        }

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

    }

    public class UpdateApplicantConsentsP3Data : PageData
    {
    }

}
