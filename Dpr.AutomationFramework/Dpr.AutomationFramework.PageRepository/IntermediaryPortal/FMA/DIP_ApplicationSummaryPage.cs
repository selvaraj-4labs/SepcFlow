using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    // Same page as 'DIP.ApplicationSummaryPage'.
    // Used to select one of the proceed options
    // as opposed reading values.
    public class DIP_ApplicationSummaryPage : WebBasePage
    {
        public DIP_ApplicationSummaryPage()
        {
            pageLoadedElement = summaryPanel;
            correspondingDataClass = new DIP_ApplicationSummaryPageData().GetType();
            textName = "DIP Application Summary Page";
        }

        public Element summaryPanel => new Element(FindElement("applicationsummary-panel"));
        public Element proceedOptions => new Element(new ButtonGroup()
            .AddButtonElement("Proceed to FMA", FindElement("bProceedDipToFma", attributeType: Defs.locatorHref))
            .AddButtonElement("Edit DIP", FindElement("bProceedToDipEdit", attributeType: Defs.locatorHref))
            .AddButtonElement("Copy DIP", FindElement("bCreateRevisedDip", attributeType: Defs.locatorHref)));
    }

    public class DIP_ApplicationSummaryPageData : PageData
    {
        #region DIP -> FMA Transfer Variables
        // 1 or 2.
        public string _numberOfApplicants { get; set; } = null;

        // Employed, Self Employed, Fixed Term Contract, etc...
        public string _app1EmploymentType { get; set; } = null;

        // Employed, Self Employed, Fixed Term Contract, etc...
        public string _app2EmploymentType { get; set; } = null;
        
        // Residential or BTL.
        public string _loanType { get; set; } = null;

        // Purchase or Remortgage.
        public string _loanPurpose { get; set; } = null;
        #endregion

        public string proceedOptions { get; set; } = "Proceed to FMA";
    }
}
