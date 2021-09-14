using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline
{
    public class EAP01Ebanking : EAP01
    {

        public EAP01Ebanking()
        {
            pageLoadedElement = acceptDeclarationChbox;
            correspondingDataClass = new EAP01EbankingData().GetType();
            textName = "Entry Page Retail Ebanking";
        }
        public Element name => new Element(FindElement("txtName")).SetCompletePageFlag(false);

        public Element customerNumber => new Element(FindElement("txtCustomerNumber")).SetCompletePageFlag(false);

        public Element addJointApplicant => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("RetailExistingSingleAccount", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("RetailExistingSingleAccount", "_1")), new ConditionList()
            .Add(new Condition(FindElement("Would you like to add a joint applicant?", attributeType: Defs.locatorText), Defs.elementDisplayed))
            .Add(new Condition("AP01", "productType", "ISA", Defs.conditionTypeNotEqual))
            .Add(new Condition("AP01", "productType", "ChildIsa", Defs.conditionTypeNotEqual)));

        public Element useExistingJointApplicant => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("RetailExistingJointAccount", "_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("RetailExistingJointAccount", "_1")), new ConditionList()
            .Add(new Condition(FindElement("Would you like to use the existing joint applicant?", attributeType: Defs.locatorText), Defs.elementDisplayed))
            .Add(new Condition("AP01", "productType", "ISA", Defs.conditionTypeNotEqual))
            .Add(new Condition("AP01", "productType", "ChildIsa", Defs.conditionTypeNotEqual)));

        // Removed 28/07/2020
        //public Element sameAccountDetails => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AccountOptions", "_0"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AccountOptions", "_1"))); 
    }

    public class EAP01EbankingData : EAP01Data
    {
        public string addJointApplicant { get; set; } = Defs.radioButtonNo;
        // Removed 28/07/2020
        //public string sameAccountDetails { get; set; } = Defs.radioButtonYes;
        public string confirmAboveStatement { get; set; } = Defs.checkBoxSelected;

        // Added 21/10/2020 - Not sure if it is a permanent addition, page looks unfinished.
        public string acceptDeclarationChbox { get; set; } = Defs.checkBoxSelected;
    }
}
