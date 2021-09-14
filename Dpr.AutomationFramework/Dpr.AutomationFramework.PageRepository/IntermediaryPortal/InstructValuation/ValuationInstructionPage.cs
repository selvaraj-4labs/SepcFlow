using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.InstructValuation
{
    public class ValuationInstructionPage : WebBasePage
    {
        public ValuationInstructionPage()
        {
            pageLoadedElement = valuationType;
            correspondingDataClass = new ValuationInstructionPageData().GetType();
            textName = "Valuation Instruction Page";
        }
        public Element valuationType => new Element(FindElement("cboValuationType-button"));
        public Element valuationDeclarationConfirm => new Element(FindElement("chkProceed"));
        public Element request => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }
    public class ValuationInstructionPageData : PageData
    {
        public string valuationDeclarationConfirm { get; set; } = Defs.checkBoxSelected;
    }
}
