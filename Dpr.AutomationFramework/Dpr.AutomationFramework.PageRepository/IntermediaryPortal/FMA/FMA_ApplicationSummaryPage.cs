using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_ApplicationSummaryPage : WebBasePage
    {
        public FMA_ApplicationSummaryPage()
        {
            pageLoadedElement = summaryPanel;
            correspondingDataClass = new FMA_ApplicationSummaryPageData().GetType();
            textName = "FMA Application Summary Page";
        }
        public Element summaryPanel => new Element(FindElement("applicationsummary-panel"));
        public Element caseReference => new Element(FindElement("MC_ApplicationRefLabel"));
        public Element applicationStatus => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "MC_CaseStatusPanel"),
            "/div[1]/div[2]" +
            ""));

        public Element proceedOptions => new Element(new ButtonGroup()
            .AddButtonElement("Copy", FindElement("bCreateRevisedDip", attributeType: Defs.locatorHref)));
    }
    public class FMA_ApplicationSummaryPageData : PageData
    {
        public string proceedOptions { get; set; } = null;
    }
}