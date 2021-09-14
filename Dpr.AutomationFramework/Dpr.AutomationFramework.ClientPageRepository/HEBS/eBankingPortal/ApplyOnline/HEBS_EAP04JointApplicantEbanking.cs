using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.ApplyOnline
{
    public class HEBS_EAP04JointApplicantEbanking : EAP04JointApplicant
    {
        public HEBS_EAP04JointApplicantEbanking()
        {
            pageLoadedElement = titleLookup;
            correspondingDataClass = new HEBS_EAP04JointApplicantEbankingData().GetType();
            textName = "Additional Account Holder - About You Ebanking";
            pageCondition = new PageCondition(new Element(new ConditionList()
                    .Add(new Condition("AP01", "productType", "Child"))
                    .Add(new Condition("EAP01Ebanking", "addJointApplicant", Defs.radioButtonYes)))
                    .AddNewConditionList(new ConditionList()
                    .Add(new Condition("AP01", "productType", "ISA"))
                    .Add(new Condition("EAP01Ebanking", "addJointApplicant", Defs.radioButtonYes)))
                    .AddNewConditionList(new ConditionList()
                    .Add(new Condition("AP01", "productType", "ChildIsa"))
                    .Add(new Condition("EAP01Ebanking", "addJointApplicant", Defs.radioButtonYes)))
                    .AddNewConditionList(new ConditionList()
                    .Add(new Condition("AP01", "productType", "Retail"))
                    .Add(new Condition("EAP01Ebanking", "addJointApplicant", Defs.radioButtonYes))));
        }
    }

    public class HEBS_EAP04JointApplicantEbankingData : EAP04JointApplicantData
    {
    }
}
