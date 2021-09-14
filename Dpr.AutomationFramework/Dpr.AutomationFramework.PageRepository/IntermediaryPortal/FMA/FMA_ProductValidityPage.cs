using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_ProductValidityPage : WebBasePage
    {
        public FMA_ProductValidityPage()
        {
            pageLoadedElement = amendLoanDetails;
            correspondingDataClass = new FMA_ProductValidityPageData().GetType();
            textName = "FMA Product Validity Page";
        }

        public Element amendLoanDetails => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoAmendLoanDetails_btn", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoAmendLoanDetails_btn", "_rbl_1")));

        public Element amendPropertyDetails => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoAmendPropertyDetails_btn", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoAmendPropertyDetails_btn", "_rbl_1")),
            new ConditionList()
                .Add(new Condition("DIP_ApplicationSummaryPage", "_loanPurpose", "Remortgage")));

        public Element fmaDeclaration => new Element(FindElement("ctl00_chkAcceptDeclaration"));
        public Element next => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }
    public class FMA_ProductValidityPageData : PageData
    {
        public string amendLoanDetails { get; set; } = Defs.radioButtonNo;
        public string amendPropertyDetails { get; set; } = Defs.radioButtonNo;
        public string fmaDeclaration { get; set; } = Defs.checkBoxSelected;

    }
}
