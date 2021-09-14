using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP01 : WebBasePage
    {
        public CBS_DIP01()
        {
            pageLoadedElement = applicantOverRequiredAge;
            correspondingDataClass = new CBS_DIP01Data().GetType();
            textName = "CBS Pre-Requisite Questions Page";
        }
        public Element applicantOverRequiredAge => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoQuestionPreReq1_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoQuestionPreReq1_btn_rbl_1")));

        public Element propertyinEnglandOrWales => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoQuestionPreReq2_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoQuestionPreReq2_btn_rbl_1")));

        public Element notBeenBackrupt => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoQuestionPreReq3_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoQuestionPreReq3_btn_rbl_1")));
        public Element incomeInGBP => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoQuestionPreReq4_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoQuestionPreReq4_btn_rbl_1")));


        public Element gdprDeclaration => new Element(FindElement("ctl00_chkAcceptConsent"));
        public Element intermediaryDeclaration => new Element(FindElement("ctl00_chkPersonalData"));

        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class CBS_DIP01Data : PageData
    {
        public string applicantOverRequiredAge { get; set; } = Defs.radioButtonYes;
        public string propertyinEnglandOrWales { get; set; } = Defs.radioButtonYes;
        public string notBeenBackrupt { get; set; } = Defs.radioButtonYes;
        public string incomeInGBP { get; set; } = Defs.radioButtonYes;
        public string gdprDeclaration { get; set; } = Defs.checkBoxSelected;
        public string intermediaryDeclaration { get; set; } = Defs.checkBoxSelected;
    }
}
