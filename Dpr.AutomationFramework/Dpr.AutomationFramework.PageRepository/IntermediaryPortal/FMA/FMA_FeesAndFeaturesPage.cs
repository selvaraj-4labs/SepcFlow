using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_FeesAndFeaturesPage : WebBasePage
    {
        public FMA_FeesAndFeaturesPage()
        {
            pageLoadedElement = intermediaryFees;
            correspondingDataClass = new FMA_FeesAndFeaturesPageData().GetType();
            textName = "FMA Fees And Features Page";
        }
        public Element applicationFee => new Element(new RadioButton()
            .AddRadioButtonElement("Add", FindElement("item0", "_FeeCategory_0"))
            .AddRadioButtonElement("Deduct", FindElement("item0", "_FeeCategory_1")));
        public Element bacsTransferFee => new Element(new RadioButton()
            .AddRadioButtonElement("Add", FindElement("item1", "_FeeCategory_0"))
            .AddRadioButtonElement("Deduct", FindElement("item1", "_FeeCategory_1")));

        #region 'Intermediary Fees' Section
        public Element intermediaryFees => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HasIntermediaryFees_btn", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HasIntermediaryFees_btn", "_rbl_1")));

        public Section addIntermediaryFeesSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "intermediaryFees", Defs.radioButtonYes))));

        // Intermediary Fees - Fee 1
        public Element feeDescription_1 => new Element(FindElement("item0", "cboFeeDescription"));
        public Element amount_1 => new Element(FindElement("item0", "FeeAmount"));
        public Element whenPayable_1 => new Element(FindElement("item0", "FeeWhenPayable"));
        public Element refundableAmount_1 => new Element(FindElement("item0", "FeeRefundableAmount"));

        // Intermediary Fees - Fee 2
        public Element feeDescription_2 => new Element(FindElement("item1", "cboFeeDescription"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_2", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element amount_2 => new Element(FindElement("item1", "FeeAmount"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_2", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element whenPayable_2 => new Element(FindElement("item1", "FeeWhenPayable"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_2", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element refundableAmount_2 => new Element(FindElement("item1", "FeeRefundableAmount"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_2", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);

        // Intermediary Fees - Fee 3
        public Element feeDescription_3 => new Element(FindElement("item2", "cboFeeDescription"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_3", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element amount_3 => new Element(FindElement("item2", "FeeAmount"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_3", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element whenPayable_3 => new Element(FindElement("item2", "FeeWhenPayable"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_3", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element refundableAmount_3 => new Element(FindElement("item2", "FeeRefundableAmount"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_3", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);

        // Intermediary Fees - Fee 4
        public Element feeDescription_4 => new Element(FindElement("item3", "cboFeeDescription"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_4", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element amount_4 => new Element(FindElement("item3", "FeeAmount"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_4", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element whenPayable_4 => new Element(FindElement("item3", "FeeWhenPayable"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_4", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element refundableAmount_4 => new Element(FindElement("item3", "FeeRefundableAmount"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_4", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);

        public Element addIntermediaryFees => new Element(FindElement("IntermediaryFees", "ctl01_btnAdd")).SetCompletePageFlag(false);

        public SectionEnd addIntermediaryFeesSectionEnd => new SectionEnd();
        #endregion

        public Element next => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class FMA_FeesAndFeaturesPageData : PageData
    {
        public string applicationFee { get; set; } = "Deduct";
        public string bacsTransferFee { get; set; } = "Deduct";

        public string intermediaryFees { get; set; } = Defs.radioButtonNo;

        public string feeDescription_1 { get; set; } = null;
        public string amount_1 { get; set; } = null;
        public string whenPayable_1 { get; set; } = null;
        public string refundableAmount_1 { get; set; } = null;

        public string intermediaryFee_2 { get; set; } = null;
        public string feeDescription_2 { get; set; } = null;
        public string amount_2 { get; set; } = null;
        public string whenPayable_2 { get; set; } = null;
        public string refundableAmount_2 { get; set; } = null;

        public string intermediaryFee_3 { get; set; } = null;
        public string feeDescription_3 { get; set; } = null;
        public string amount_3 { get; set; } = null;
        public string whenPayable_3 { get; set; } = null;
        public string refundableAmount_3 { get; set; } = null;

        public string intermediaryFee_4 { get; set; } = null;
        public string feeDescription_4 { get; set; } = null;
        public string amount_4 { get; set; } = null;
        public string whenPayable_4 { get; set; } = null;
        public string refundableAmount_4 { get; set; } = null;
    }
}
