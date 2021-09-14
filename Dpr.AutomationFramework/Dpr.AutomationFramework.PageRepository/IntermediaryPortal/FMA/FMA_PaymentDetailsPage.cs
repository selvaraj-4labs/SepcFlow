using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_PaymentDetailsPage : WebBasePage
    {
        public FMA_PaymentDetailsPage()
        {
            pageLoadedElement = saveIllustrationConfirm;
            correspondingDataClass = new FMA_PaymentDetailsPageData().GetType();
            textName = "FMA Payment Details Page";
        }

        public Element saveIllustrationConfirm => new Element(FindElement("chkESISAcceptDeclaration"));
        public Element payNowSubmit => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsMakeCardPayment_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsMakeCardPayment_btn", "rbl_1")));

        public Section makePaymentSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "payNowSubmit", Defs.radioButtonYes))));

        public Element whoIsMakingThePayment => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "WhoIsPaying")
            .Add(Defs.locatorId, "!PartyId"),
            "[1]",
            tag: "select"));
        public Element selectApplicant => new Element(FindElement("WhoIsPayingPartyId"),
            new ConditionList()
            .Add(new Condition(className, "whoIsMakingThePayment", "Applicant")));

        public Element makePaymentAndSubmit => new Element(new ButtonGroup()
            .AddButtonElement("Make Payment & Submit", FindElement("MakePaymentButton")));

        public SectionEnd makePaymentSectionEnd => new SectionEnd();

        public Element next => new Element(FindElement("_Next"),
            new ConditionList()
            .Add(new Condition(className, "payNowSubmit", Defs.radioButtonNo)))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class FMA_PaymentDetailsPageData : PageData
    {
        public string saveIllustrationConfirm { get; set; } = Defs.checkBoxSelected;
        public string payNowSubmit { get; set; } = Defs.radioButtonYes;
        public string whoIsMakingThePayment { get; set; } = "Intermediary";
        public string selectApplicant { get; set; } = null;
        public string makePaymentAndSubmit { get; set; } = "Make Payment & Submit";
        
    }
}
