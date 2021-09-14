using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.GenerateDataOutputDocumentWizard
{
    public class UpdateApplicantConsentsP4 : BOWizardBasePage
    {
        public UpdateApplicantConsentsP4()
        {
            pageLoadedElement = finishBtn;
            correspondingDataClass = new UpdateApplicantConsentsP4Data().GetType();
            textName = "Update Applicant Consents Page 4";
        }

        public Element finishBtn => new Element(FindElement("Finish", attributeType: Defs.boLocatorName))
            .SetIsButtonFlag(true);

    }

    public class UpdateApplicantConsentsP4Data : PageData
    {
    }

}
