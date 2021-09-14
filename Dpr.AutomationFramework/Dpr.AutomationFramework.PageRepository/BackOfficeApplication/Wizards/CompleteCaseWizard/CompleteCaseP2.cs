using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.CompleteCaseWizard
{
    public class CompleteCaseP2 : BOWizardBasePage
    {
        public CompleteCaseP2()
        {
            pageLoadedElement = applicantsSummaryLbl;
            correspondingDataClass = new CompleteCaseP2Data().GetType();
            textName = "Complete Case Page 2";

        }

        public Element applicantsSummaryLbl => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Applicants Summary")
            .Add(Defs.boLocatorAutomationId, "lblTitle")))
            .SetCompletePageFlag(false);

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CompleteCaseP2Data : PageData
    {
    }

}
