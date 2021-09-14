using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Notes.AddNewNote
{
    public class NewNoteP1 : AppBasePage
    {
        public NewNoteP1()
        {
            pageLoadedElement = type;
            correspondingDataClass = new NewNoteP1Data().GetType();
            textName = "Add New Note Page 1";
        }
        public Element type => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboNotePriority"),
            "/Edit"));
        public Element warningType => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboWarningType"),
            "/Edit"),
            new ConditionList()
                .Add(new Condition(className, "type", "Warning")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(className, "type", "Suspension")));
        public Element action => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboNoteAction"),
            "/Edit"));

        public Element noteVisibileToCustomer => new Element(new RadioButton()
            .AddRadioButtonElement("Visible to Customer", FindElement("rbVisibleToCustomer", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Internal Only", FindElement("rbInternalOnly", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Account Only", FindElement("rbAccountOnly", attributeType: Defs.boLocatorAutomationId)));
        public Element customer => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboCustomers"),
            "/Edit"));
        public Element riskProfile => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboRiskProfile"),
            "/Edit"));
        public Element titleBox => new Element(FindElement("txtNoteTitle", attributeType: Defs.boLocatorAutomationId));
        public Element additionalInfo => new Element(FindElement("txtNoteAdditionalInfo", attributeType: Defs.boLocatorAutomationId));
        public Element confirm => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class NewNoteP1Data : PageData
    {
        public string type { get; set; } = null;
        public string warningType { get; set; } = null;
        public string title { get; set; } = "TestNoteTitle";
        public string customer { get; set; } = null;
        public string action { get; set; } = null;
        public string noteVisibileToCustomer { get; set; } = null;
        public string riskProfile { get; set; } = null;
        public string titleBox { get; set; } = null;
        public string additionalInfo { get; set; } = "TestNoteAdditionalInformation";
    }
}
