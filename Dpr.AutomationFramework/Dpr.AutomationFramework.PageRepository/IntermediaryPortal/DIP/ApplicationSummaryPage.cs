using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class ApplicationSummaryPage : WebBasePage
    {
        public ApplicationSummaryPage()
        {
            pageLoadedElement = summaryPanel;
            correspondingDataClass = new ApplicationSummaryPageData().GetType();
            textName = "Application Summary Page";
        }
        public Element summaryPanel => new Element(FindElement("applicationsummary-panel"));
        public Element caseReference => new Element(FindElement("MC_ApplicationRefLabel"));
        //public Element proceedOptions => new Element(new ButtonGroup()
        //    .AddButtonElement("Proceed to FMA", FindElement("bProceedDipToFma", attributeType: Defs.locatorHref))
        //    .AddButtonElement("Edit DIP", FindElement("bProceedToDipEdit", attributeType: Defs.locatorHref))
        //    .AddButtonElement("Copy DIP", FindElement("bCreateRevisedDip", attributeType: Defs.locatorHref)));
    }
    public class ApplicationSummaryPageData : PageData
    {
        public string proceedOptions { get; set; } = null;
    }
}