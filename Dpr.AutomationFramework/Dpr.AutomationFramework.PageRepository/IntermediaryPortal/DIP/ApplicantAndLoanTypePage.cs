using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class ApplicantAndLoanTypePage : WebBasePage
    {
        public ApplicantAndLoanTypePage()
        {
            pageLoadedElement = applicantType;
            correspondingDataClass = new ApplicantAndLoanTypePageData().GetType();
            textName = "Applicant And Loan Type Page";
        }

        public Element applicantType => new Element(FindElement("ddlApplicantType", tag: "select"));
        public Element loanType => new Element(FindElement("txtLoanType", tag: "select"));
        public Element howWasSaleMade => new Element(FindElement("ModeofSale", "ctl00_Details", tag: "select"));


        #region 'Consumer BTL Verification' Section
        public Section consumerBTLSection => new Section(new Element(
            new ConditionList()
            .Add(new Condition(className, "applicantType", "Individual"))
            .Add(new Condition(className, "loanType", "BTL"))));

        public Element ownAnyOtherBTLProperties => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl03_rdoQuestion_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl03_rdoQuestion_btn_rbl_1")));

        public Element borrowerEverLivedInProperty => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl04_rdoQuestion_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl04_rdoQuestion_btn_rbl_1")));

        public SectionEnd consumerBTLSectionEnd => new SectionEnd();
        #endregion

        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);

    }

    public class ApplicantAndLoanTypePageData : PageData
    {
        public string applicantType { get; set; } = "Individual";
        public string loanType { get; set; } = "Residential";
        public string howWasSaleMade { get; set; } = "Face to Face";
        public string ownAnyOtherBTLProperties { get; set; } = Defs.radioButtonNo;
        public string borrowerEverLivedInProperty{ get; set; } = Defs.radioButtonNo;
    }
}
