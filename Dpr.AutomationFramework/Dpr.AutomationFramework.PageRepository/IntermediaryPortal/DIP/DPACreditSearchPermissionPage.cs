
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class DPACreditSearchPermissionPage : WebBasePage
    {
        public DPACreditSearchPermissionPage()
        {
            pageLoadedElement = haveYouEverBeenRefusedAMortgageByAnotherLender;
            correspondingDataClass = new DPACreditSearchPermissionPageData().GetType();
            textName = "DPA & Credit Search Permission";
        }

        public Element haveYouEverBeenRefusedAMortgageByAnotherLender => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl00_rdoQuestion1", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl00_rdoQuestion1", "rbl_1")));

        //public Element  refusedDetails => new Element(FindElement("txtDeclerationDetails1"));

        public Element haveYouEverHadAnyCriminalConvictions => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl01_rdoQuestion1", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl01_rdoQuestion1", "rbl_1")));

        public Element pleaseConfirmIfYouConsentToTheCreditSearch => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl03_rdoCreditConsent", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl03_rdoCreditConsent", "rbl_1")));

        public Element consentConfirm => new Element(FindElement("ctl03_chkAcceptConsent"));
        public Element useOfPersonalDataConfirm => new Element(FindElement("ctl04_ctl00_chkAcceptConsent"));
        public Element privacyNoticeConfirm => new Element(FindElement("ctl05_ctl00_chkPersonalData"));


        public Element nextBtn => new Element(FindElement("Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }


    public class DPACreditSearchPermissionPageData : PageData
    {
        public string haveYouEverBeenRefusedAMortgageByAnotherLender { get; set; } = Defs.radioButtonNo;
        public string haveYouEverHadAnyCriminalConvictions { get; set; } = Defs.radioButtonNo;
        public string pleaseConfirmIfYouConsentToTheCreditSearch { get; set; } = Defs.radioButtonYes;
        public string consentConfirm { get; set; } = Defs.checkBoxSelected;
        public string useOfPersonalDataConfirm { get; set; } = Defs.checkBoxSelected;
        public string privacyNoticeConfirm { get; set; } = Defs.checkBoxSelected;

    }
}
