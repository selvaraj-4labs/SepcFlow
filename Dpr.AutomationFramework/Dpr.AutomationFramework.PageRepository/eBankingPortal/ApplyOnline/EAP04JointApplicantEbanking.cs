using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline
{
    public class EAP04JointApplicantEbanking : EAP04JointApplicant
    {
        public EAP04JointApplicantEbanking()
        {
            pageLoadedElement = titleLookup;
            correspondingDataClass = new EAP04JointApplicantEbankingData().GetType();
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
        public new Element maritalStatusLookup => new Element(base.maritalStatusLookup.locator,
            new ConditionList()
            .Add(new Condition("AP01", "productType", "Child", Defs.conditionTypeNotEqual)));
        public new Element nationalInsuranceNumberBox => new Element(base.nationalInsuranceNumberBox.locator,
            new ConditionList()
            .Add(new Condition("AP01", "productType", "Child", Defs.conditionTypeNotEqual)));
        public new Element existingBankMemberRbtn => new Element(base.existingBankMemberRbtn.radioButton,
            new ConditionList()
            .Add(new Condition("AP01", "productType", "Child", Defs.conditionTypeNotEqual)));
        public new Element permanentUKResidentRbtn => new Element(base.permanentUKResidentRbtn.radioButton,
            new ConditionList()
            .Add(new Condition("AP01", "productType", "Child", Defs.conditionTypeNotEqual)));
        public new Element currentlyUkResident => new Element(base.currentlyUkResident.radioButton, 
            new ConditionList()
            .Add(new Condition("AP01", "productType", "Child", Defs.conditionTypeNotEqual)));
        public new Element accountNumberBox => new Element(base.accountNumberBox.locator, new ConditionList()
            .Add(new Condition("EAP04EBanking", "existingBankMemberRbtn", Defs.radioButtonYes))
            .Add(new Condition("AP01", "productType", "Child", Defs.conditionTypeNotEqual)));
        public new Section contactDetailsSection => new Section(new Element(new ConditionList()
            .Add(new Condition("AP01", "productType", "Child", Defs.conditionTypeNotEqual))));
        public new Element secondNationalityLookup => new Element(base.secondNationalityLookup.locator, new ConditionList()
            .Add(new Condition("EAP04Ebanking", "dualNationalityRbtn", "_rbl_0")));
        public new Section keepingInformedSection => new Section(new Element(new ConditionList()
            .Add(new Condition("AP01", "productType", "Child", Defs.conditionTypeNotEqual))));
        public new Section employmentDetailsSection => new Section(new Element(new ConditionList()
            .Add(new Condition("AP01", "productType", "Child", Defs.conditionTypeNotEqual))));
    }

    public class EAP04JointApplicantEbankingData : EAP04JointApplicantData
    {
    }
}
