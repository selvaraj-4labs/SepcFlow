using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP04JointApplicant : HEBS_EAP04
    {
        public HEBS_EAP04JointApplicant()
        {
            {
                pageLoadedElement = titleLookup;
                correspondingDataClass = new HEBS_EAP04JointApplicantData().GetType();
                textName = "Additional Account Holder - About You";
                pageCondition = new PageCondition(new Element(new ConditionList()
                    .Add(new Condition("HEBS_EAP00", "productType", "corporate", Defs.conditionTypeNotEqual))
                    .Add(new Condition("HEBS_EAP04", "singleJointAccount", "Joint"))));
            }
        }
        public new Element singleJointAccountRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Single", FindElement("NumberOfApplicants", "_0"))
            .AddRadioButtonElement("Joint", FindElement("NumberOfApplicants", "_1")))
            .SetCompletePageFlag(false);
    }
        
    public class HEBS_EAP04JointApplicantData : EAP04JointApplicantData
    {
    }
}

