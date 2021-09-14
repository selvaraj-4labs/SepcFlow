using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.MaintainEmploymentDetails
{
    public class MaintainEmploymentDetailsP7 : AppBasePage
    {
        public MaintainEmploymentDetailsP7()
        {
            pageLoadedElement = basicSalaryBox;
            correspondingDataClass = new MaintainEmploymentDetailsP7Data().GetType();
            textName = "Maintain Employment Details Page 7";
        }
        public Element basicSalaryBox => new Element(FindElement("txtBasicSalary", attributeType: Defs.boLocatorAutomationId));
        public Element bonusBox => new Element(FindElement("txtBonus", attributeType: Defs.boLocatorAutomationId));
        public Element bonusGuaranteedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "optBonusGuaranteed"), "/RadioButton[@Name='Yes']"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "optBonusGuaranteed"), "/RadioButton[@Name='No']")));
        public Element commissionBox => new Element(FindElement("txtCommission", attributeType: Defs.boLocatorAutomationId));
        public Element cominssionGuaranteedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "optCommissionGuaranteed"), "/RadioButton[@Name='Yes']"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "optCommissionGuaranteed"), "/RadioButton[@Name='No']")));
        public Element overtimeBox => new Element(FindElement("txtOvertime", attributeType: Defs.boLocatorAutomationId));
        public Element overtimeGuaranteedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "optOvertimeGuaranteed"), "/RadioButton[@Name='Yes']"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "optOvertimeGuaranteed"), "/RadioButton[@Name='No']")));
        public Element shiftAllowanceBox => new Element(FindElement("txtShiftAllowance", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("Next", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);

    }

    public class MaintainEmploymentDetailsP7Data : PageData
    {
        public string basicSalary { get; set; } = "11000";
        public string bonus { get; set; } = null;
        public string bonusGuaranteed { get; set; } = null;
        public string commission { get; set; } = null;
        public string cominssionGuaranteed { get; set; } = null;
        public string overtime { get; set; } = null;
        public string overtimeGuaranteed { get; set; } = null;
        public string shiftAllowance { get; set; } = null;
    }
}
