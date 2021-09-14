using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_PBD02 : WebBasePage
    {
        public CBS_PBD02()
        {
            pageLoadedElement = consentConfirm;
            correspondingDataClass = new CBS_PBD02Data().GetType();
            textName = "CBS DPA & Credit Search Permission";
        }
        public Element allApplicantsBeNamed => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl00_rdoQuestion1", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl00_rdoQuestion1", "rbl_1")));

        public Element consentToCreditSearch => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl03_rdoCreditConsent_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl03_rdoCreditConsent_btn", "rbl_1")));

        public Element consentConfirm => new Element(FindElement("ctl03_chkAcceptConsent"));

        public Element useOfPersonalDataConfirm => new Element(FindElement("ctl04_ctl00_chkAcceptConsent"));
        public Element privacyNoticeConfirm => new Element(FindElement("ctl05_ctl00_chkPersonalData"));

        public Element next => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class CBS_PBD02Data : PageData
    {
        public string allApplicantsBeNamed { get; set; } = Defs.radioButtonYes;
        public string consentToCreditSearch { get; set; } = Defs.radioButtonYes;

        public string consentConfirm { get; set; } = Defs.checkBoxSelected;
        public string useOfPersonalDataConfirm { get; set; } = Defs.checkBoxSelected;
        public string privacyNoticeConfirm { get; set; } = Defs.checkBoxSelected;

    }
}
