using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP06_3 : CBS_ADV_DIP06
    {
        public CBS_ADV_DIP06_3()
        {
            pageLoadedElement = title;
            correspondingDataClass = new CBS_ADV_DIP06_3Data().GetType();
            textName = "CBS Advised Applicant 3 Details Page";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_ADV_DIP06", "numberOfApplicants", "3")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_ADV_DIP06", "numberOfApplicants", "4"))));
        }
        public Element relationshipWithMainApplicant => new Element(FindElement("cboRelationshipToBorrower"));
        public Element addressSummary => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("CopyAddressRadioButton_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("CopyAddressRadioButton_1", tag: "input")));
        public new Element emailAddress => new Element(FindElement("txtEmailAddress", tag: "input"));
        public new Element confirmEmailAddress => new Element(FindElement("txtConfirmEmailAddress", tag: "input"));
    }

    public class CBS_ADV_DIP06_3Data : CBS_ADV_DIP06Data
    {
        public new string numberOfApplicants { get; set; } = null;
        public string relationshipWithMainApplicant { get; set; } = "Brother";
        public string addressSummary { get; set; } = Defs.radioButtonNo;
    }
}
