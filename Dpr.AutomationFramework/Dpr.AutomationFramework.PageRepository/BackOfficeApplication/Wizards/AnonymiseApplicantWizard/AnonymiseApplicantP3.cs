using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AnonymiseApplicantWizard
{
    public class AnonymiseApplicantP3 : BOWizardBasePage
    {
        public AnonymiseApplicantP3()
        {

            pageLoadedElement = resultTable;
            correspondingDataClass = new AnonymiseApplicantP3Data().GetType();
            textName = "Anonymise Applicant Page 3";

        }

        public Element resultTable => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "Anonymize case list"),
            tag: "DataItem"));

        public Element finishBtn => new Element(FindElement("Finish", attributeType: Defs.boLocatorName))
            .SetIsButtonFlag(true);
    }

    public class AnonymiseApplicantP3Data : PageData
    {
    }
}
