using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant2DetailsPage : Applicant1DetailsPage
    {
        public Applicant2DetailsPage()
        {
            pageLoadedElement = title;
            correspondingDataClass = new Applicant2DetailsPageData().GetType();
            textName = "Applicant 2 Details Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("Applicant1DetailsPage", "numberOfApplicants", "2"))));
        }
        public Element relationshipWithMainApplicant => new Element(FindElement("cboRelationshipToBorrower"));
        public Element addressSummary => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("CopyAddressRadioButton_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("CopyAddressRadioButton_1")));
        public  new Element emailAddress => new Element(FindElement("txtEmailAddress", tag: "input"));
        public new Element confirmEmailAddress => new Element(FindElement("txtConfirmEmailAddress", tag: "input"));
    }

    public class Applicant2DetailsPageData : Applicant1DetailsPageData
    {
        public new string numberOfApplicants { get; set; } = null;
        public string relationshipWithMainApplicant { get; set; } = "Brother";
        public string addressSummary { get; set; } = Defs.radioButtonNo;
    }
}
