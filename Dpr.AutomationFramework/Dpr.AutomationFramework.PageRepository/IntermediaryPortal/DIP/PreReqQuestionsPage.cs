using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class PreReqQuestionsPage : WebBasePage 
    {
        public PreReqQuestionsPage()
        {
            pageLoadedElement = bankruptcy;
            correspondingDataClass = new PreReqQuestionsPageData().GetType();
            textName = "Pre-Requisite Questions Page";
        }

        public Element bankruptcy => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoQuestionPreReq1_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoQuestionPreReq1_btn_rbl_1")));

        public Element applicantsMainResidence => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoQuestionPreReq2_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoQuestionPreReq2_btn_rbl_1")));

        public Element foreignCurrencyIncome => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoQuestionPreReq3_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoQuestionPreReq3_btn_rbl_1")));
        public Element outsideOfLendingCriteria => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoQuestionPreReq4_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoQuestionPreReq4_btn_rbl_1")));
        public Element outsideOfPropertyCriteria => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoQuestionPreReq5_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoQuestionPreReq5_btn_rbl_1")));

        public Element gdprDeclaration => new Element(FindElement("ctl00_chkAcceptConsent"));
        public Element intermediaryDeclaration => new Element(FindElement("ctl00_chkPersonalData"));

        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }
    public class PreReqQuestionsPageData : PageData
    {
        public string bankruptcy { get; set; } = Defs.radioButtonNo;
        public string applicantsMainResidence { get; set; } = Defs.radioButtonNo;
        public string foreignCurrencyIncome { get; set; } = Defs.radioButtonNo;
        public string outsideOfLendingCriteria { get; set; } = Defs.radioButtonNo;
        public string outsideOfPropertyCriteria { get; set; } = Defs.radioButtonNo;
        public string gdprDeclaration { get; set; } = Defs.checkBoxSelected;
        public string intermediaryDeclaration { get; set; } = Defs.checkBoxSelected;

    }
}
