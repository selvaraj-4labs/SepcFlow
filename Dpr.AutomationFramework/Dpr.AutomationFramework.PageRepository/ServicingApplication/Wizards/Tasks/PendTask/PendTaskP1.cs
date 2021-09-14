using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.PendTask
{
    public class PendTaskP1 : AppBasePage
    {
        public PendTaskP1()
        {
            pageLoadedElement = schedulingRbtn;
            correspondingDataClass = new PendTaskP1Data().GetType();
            textName = "Pend Task Page 1";
        }
        public Element schedulingRbtn => new Element(new RadioButton()
        .AddRadioButtonElement("Immediate", FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "optSchedulingType"),
            "/RadioButton[@Name =\"Immediate\"]"))
        .AddRadioButtonElement("Specfic Date", FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "optSchedulingType"),
            "/RadioButton[@Name =\"Specific Date:\"]"))
            .AddRadioButtonElement("Pend For", FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "optSchedulingType"),
            "/RadioButton[@Name =\"Pend For:\"]")));
        
        public Section pendForSchedulingSection => new Section(new Element(
           new ConditionList()
           .Add(new Condition(className, "scheduling", "Pend For"))));

        public Element daysPendingBox => new Element(FindElement("itxSchedulingPendDays", attributeType: Defs.boLocatorAutomationId));
        public Element hoursPendingBox => new Element(FindElement("itxSchedulingPendHours", attributeType: Defs.boLocatorAutomationId));
        public Element minutesPendingBox => new Element(FindElement("itxSchedulingPendMinutes", attributeType: Defs.boLocatorAutomationId));

        public SectionEnd pendForSchedulingSectionEnd => new SectionEnd();

        public Element reasonBox => new Element(FindElement("txtReason", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

    }
    public class PendTaskP1Data : PageData
    {
        public string scheduling { get; set; } = "Pend For";
        public string daysPending { get; set; } = "1";
        public string hoursPending { get; set; } = "0";
        public string minutesPending { get; set; } = "0";
        public string reason { get; set; } = "TestPendReason";
    }
}
