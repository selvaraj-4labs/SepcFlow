using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{ 
    public class EAP15 : WebBasePage
    {
        public EAP15()
        {
            pageLoadedElement = fscsChbox;
            correspondingDataClass = new EAP15Data().GetType();
            textName = "Summary";
        }

        #region Locators
        // WAIT FOR THIS INPUT ELEMENT AFTER "emailAddress" + "requiestCode" ARE SELECTED ON EAP27.
        // AUTOMATION SHOULD, IN THEORY, PICK UP AFTER THIS INPUT ELEMENT IS FOUND.
        public Element yourAgreement => new Element(FindElement("YourAgreement1_ctl00_chkAcceptDeclaration"), 
            new ConditionList()
                .Add(new Condition("ProductSelection", "productType", "retail")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("ProductSelection", "productType", "child")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("ProductSelection", "productType", "isa")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("ProductSelection", "productType", "childisa")))
            .AddNewConditionList(new ConditionList()
                    .Add(new Condition("ProductSelection", "productType", "Corporate"))
                    .Add(new Condition("EAP03", "businessType", "Limited Company", Defs.conditionTypeNotEqual)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("ProductSelection", "productType", "Corporate"))
                .Add(new Condition("EAP06", "signatoryShareholding_1", Defs.radioButtonNo, Defs.conditionTypeEqual)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("ProductSelection", "productType", "Corporate"))
                .Add(new Condition("EAP06", "signatoryShareholding_2", Defs.radioButtonNo, Defs.conditionTypeEqual)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("ProductSelection", "productType", "Corporate"))
                .Add(new Condition("EAP06", "signatoryShareholding_3", Defs.radioButtonNo, Defs.conditionTypeEqual)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("ProductSelection", "productType", "Corporate"))
                .Add(new Condition("EAP06", "signatoryShareholding_4", Defs.radioButtonNo, Defs.conditionTypeEqual)));

        /*
         * new ConditionList()
            .Add(new Condition("ProductSelection", "productType", "Corporate", Defs.conditionTypeNotEqual)));
         */
        //public Element declarationChbox => new Element(FindElement("chkAcceptDeclaration"));

        public Element fscsChbox => new Element(FindElement("chkFSCSAccept"));

        public Element nextBtn => new Element(FindElement("_Next")).SetIsButtonFlag(true);
        #endregion
    }

    public class EAP15Data : PageData
    {
        public string yourAgreement { get; set; } = Defs.checkBoxSelected;
        public string fscs { get; set; } = Defs.checkBoxSelected;
    }
}
