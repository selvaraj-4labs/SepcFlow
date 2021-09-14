using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Fees.UpdateReverseFee
{
    public class UpdateReverseFeeP2 : AppBasePage
    {
        public UpdateReverseFeeP2()
        {
            pageLoadedElement = feeUpdateReasonRbtn;
            correspondingDataClass = new UpdateReverseFeeP2Data().GetType();
            textName = "Update Reverse Fee Page 2";
        }

        public Element feeUpdateReasonRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Waive Fee", FindElement("rbWaive", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Hold Fee", FindElement("rbHold", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Reverse Fee", FindElement("rbReverse", attributeType: Defs.boLocatorAutomationId)));

        public Section reverseSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "feeUpdateReason", "Reverse Fee"))));

        public Element reverseChbox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "chkReverse"), "/CheckBox"));

        public Element reverseReasonBox => new Element(FindElement("txtReverseReason", attributeType: Defs.boLocatorAutomationId));
        public SectionEnd reverseSectionEnd => new SectionEnd();
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class UpdateReverseFeeP2Data : PageData
    {
        public string feeUpdateReason { get; set; } = "Reverse Fee";
        public string reverse { get; set; } = Defs.checkBoxSelected;
        public string reverseReason { get; set; } = "TestReason";
    }
}
