using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Gherkin.Ast;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AnonymiseApplicantWizard
{
    public class AnonymiseApplicantP1 : BOWizardBasePage
    {
        public AnonymiseApplicantP1()
        {

            pageLoadedElement = nextBtn;
            correspondingDataClass = new AnonymiseApplicantP1Data().GetType();
            textName = "Anonymise Applicant Page 1";

        }

        // First value in the table. [Edit]
        //public Element anonymiseApplicant => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "gridAnonymize"), "/Custom[@Name =\"List`1 row 1\"]/ DataItem[@Name =\"Anonymize?\"]")); UPDATED: 08/07/2020

        public Element anonymiseApplicant => new Element(FindElement(new LocatorList()
            /*.Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0")*/
            .Add(Defs.boLocatorName, "Anonymize?"), "[1]", tag: "CheckBox"));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

    }

    public class AnonymiseApplicantP1Data : PageData
    {
        public string anonymiseApplicant { get; set; } = Defs.checkBoxSelected;
    }

}
