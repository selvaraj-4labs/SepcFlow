using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.InstructValuation
{
    public class IV_ApplicationSummaryPage : FMA_ApplicationSummaryPage
    {
        public IV_ApplicationSummaryPage()
        {
            pageLoadedElement = summaryPanel;
            correspondingDataClass = new IV_ApplicationSummaryPageData().GetType();
            textName = "Instruct Valuation Application Summary Page";
        }

        public Element instructValuation => new Element(FindElement("divInstructValuation"))
            .SetCompletePageFlag(true)
            .SetIsButtonFlag(true);
    }

    public class IV_ApplicationSummaryPageData : PageData
    {
    }
}
