using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_Applicant1DetailsPage : WebBasePage
    {
        public FMA_Applicant1DetailsPage()
        {
            pageLoadedElement = niNumber;
            correspondingDataClass = new FMA_Applicant1DetailsPageData().GetType();
            textName = "FMA Applicant 1 Details Page";
        }
        // Added on 15/04/2020.
        public Element gender => new Element(FindElement("cboGender"));

        public Element niNumber => new Element(FindElement("txtNIN"));
        public Element homePhone => new Element(FindElement("txtHomeTel"));
        public Element workPhone => new Element(FindElement("txtWorkTel"));
        public Element mobilePhone => new Element(FindElement("txtMobile"));
        public Element preferredContactMethod => new Element(FindElement("ddlPreferredContactMethod"));
        public Element emailAddress => new Element(FindElement("txtEmailAddress"));
        public Element confirmEmailAddress => new Element(FindElement("txtConfirmEmailAddress"));
        public Element contactByPhone => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl00_ctl27_radAgreementToContactByPhone", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl00_ctl27_radAgreementToContactByPhone", "_1")));
        public Element contactByEmail => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("MC_ucApplicantContactDetailsSimple_ctl01_pnlApplicantPanel_ctl00_ctl27_radAgreementToContact_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("MC_ucApplicantContactDetailsSimple_ctl01_pnlApplicantPanel_ctl00_ctl27_radAgreementToContact_1")));
        public Element pleaseEmail => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl00_ctl27_radAgreementToContactByEmail", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl00_ctl27_radAgreementToContactByEmail", "_1")));
        public Element contactBySMS => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl00_ctl27_radAgreementToContactByText", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl00_ctl27_radAgreementToContactByText", "_1")));
        public Element next => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);

    }
    public class FMA_Applicant1DetailsPageData : PageData
    {
        public string gender { get; set; } = "Male";
        public string homePhone { get; set; } = "01245678910";
        public string workPhone { get; set; } = "01245678910";
        public string mobilePhone { get; set; } = "07856734567";
        public string preferredContactMethod { get; set; } = "Mobile";
        public string emailAddress { get; set; } = "test@test.com";
        public string confirmEmailAddress { get; set; } = "test@test.com";
        public string contactByPhone { get; set; } = Defs.radioButtonNo;
        public string contactByEmail { get; set; } = Defs.radioButtonNo;
        public string pleaseEmail { get; set; } = Defs.radioButtonNo;
        public string contactBySMS { get; set; } = Defs.radioButtonNo;
    }
}
