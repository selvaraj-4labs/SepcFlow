using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP04JointApplicant : EAP04
    {
        public EAP04JointApplicant()
        {
            pageLoadedElement = titleLookup;
            correspondingDataClass = new EAP04JointApplicantData().GetType();
            textName = "Additional Account Holder - About You";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("ProductSelection", "productType", "corporate", Defs.conditionTypeNotEqual))
                .Add(new Condition("EAP04", "singleJointAccount", "Joint"))));
        }

        public new Element singleJointAccountRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Single", FindElement("NumberOfApplicants", "_0"))
            .AddRadioButtonElement("Joint", FindElement("NumberOfApplicants", "_1")))
            .SetCompletePageFlag(false);


    }

    public class EAP04JointApplicantData : EAP04Data
    {
        public new string singleJointAccount { get; set; } = null;
        public new string firstName { get; set; } = "JointApplicant";
        public new string lastName { get; set; } = "Test";
        public new string title { get; set; } = "Mr";
        public new string dateOfBirth { get; set; } = "01/01/1990";
        public new string mobilePhoneNumber { get; set; } = "07740000001";
    }
}
