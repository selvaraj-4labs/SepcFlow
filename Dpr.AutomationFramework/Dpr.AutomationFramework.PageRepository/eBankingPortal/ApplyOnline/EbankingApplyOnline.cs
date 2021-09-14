using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline
{
    public class EbankingApplyOnline : WebBasePage
    {
        public EbankingApplyOnline()
        {
            pageLoadedElement = name;
            correspondingDataClass = new EbankingApplyOnlineData().GetType();
            textName = "EBanking Apply Online";
        }
        public Element name => new Element(FindElement("txtName")).SetCompletePageFlag(false);
        public Element customerNumber => new Element(FindElement("txtCustomerNumber")).SetCompletePageFlag(false); 
        public Element addJointApplicant => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("RetailExistingSingleAccount", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("RetailExistingSingleAccount", "_1")),new ConditionList()
            .Add(new Condition(FindElement("Would you like to add a joint applicant?", attributeType: Defs.locatorText), Defs.elementDisplayed))
            .Add(new Condition("AP01", "productType", "ISA", Defs.conditionTypeNotEqual))
            .Add(new Condition("AP01", "productType", "ChildIsa", Defs.conditionTypeNotEqual)));
        public Element useExistingJointApplicant => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("RetailExistingJointAccount", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("RetailExistingJointAccount", "_1")),new ConditionList()
            .Add(new Condition(FindElement("Would you like to use the existing joint applicant?", attributeType: Defs.locatorText), Defs.elementDisplayed))
            .Add(new Condition("AP01", "productType", "ISA", Defs.conditionTypeNotEqual))
            .Add(new Condition("AP01", "productType", "ChildIsa", Defs.conditionTypeNotEqual)));
        // Removed 28/07/2020
        //public Element sameAccountDetails => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AccountOptions", "_0"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AccountOptions", "_1"))); 
        public Element confirmAboveStatement => new Element(FindElement("chkAcceptDeclaration"));
        public Element next => new Element(FindElement("_Next")).SetIsButtonFlag(true);
    }

    public class EbankingApplyOnlineData : PageData
    {
        public string addJointApplicant { get; set; } = Defs.radioButtonNo;
        // Removed 28/07/2020
        //public string sameAccountDetails { get; set; } = Defs.radioButtonYes;
        public string confirmAboveStatement { get; set; } = Defs.checkBoxSelected;
    }
}
