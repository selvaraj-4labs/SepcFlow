using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_DeclarationsPage : WebBasePage
    {
        public FMA_DeclarationsPage()
        {
            pageLoadedElement = creditSearchConfirm;
            correspondingDataClass = new FMA_DeclarationsPageData().GetType();
            textName = "FMA Declarations Page";
        }

        public Element creditSearchConfirm => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoCreditConsent_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoCreditConsent_btn", "rbl_1")));
        public Element consentConfirm => new Element(FindElement("ctl02_chkAcceptDeclaration"));
        public Element useofPersonalDataConfirm => new Element(FindElement("ctl03_ctl00_chkAcceptDeclaration"));
        public Element privacyNoticeConfirm => new Element(FindElement("ctl04_chkAcceptDeclaration"));
        public Element next => new Element(FindElement("Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class FMA_DeclarationsPageData : PageData
    {
        public string creditSearchConfirm { get; set; } = Defs.radioButtonYes;
        public string consentConfirm { get; set; } = Defs.checkBoxSelected;
        public string useofPersonalDataConfirm { get; set; } = Defs.checkBoxSelected;
        public string privacyNoticeConfirm { get; set; } = Defs.checkBoxSelected;
    }
}
