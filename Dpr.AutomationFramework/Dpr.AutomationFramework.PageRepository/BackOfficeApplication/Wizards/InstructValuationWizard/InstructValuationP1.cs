using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.InstructValuationWizard
{
    public class InstructValuationP1 : BOWizardBasePage
    {
        public InstructValuationP1()
        {
            pageLoadedElement = next;
            correspondingDataClass = new InstructValuationP1Data().GetType();
            textName = "Instruct Valution Page 1";
            windowTitle = "Instruct Valution";
        }

        public Element address => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "Security_SelectProperty"),
            "/ComboBox[@AutomationId=\"ceAddress\"]/Edit[@AutomationId=\"\"[Editor\"]"));

        public Element contactAccess => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "Security_SelectProperty"),
            "/ComboBox[@AutomationId=\"ceContacts\"]" +
            "/Edit[@AutomationId=\"ceContacts_EmbeddableTextBox\"]"));

        public Element applicationValuationType => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "originalSurveyType"),
            "/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element notesAtApplication => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "originalNotes"),
            "/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));


        public Element additionalNotes => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "additionalNotes"),
            "/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element next => new Element(FindElement(
                "pnlNextButton", 
                attributeType: Defs.boLocatorAutomationId))
            .SetIsButtonFlag(true);
    }

    //TODO: Populate the data class.
    public class InstructValuationP1Data : PageData
    {
        public string applicationValuationType { get; set; } = "Standard Valuation";
        public string additionalNotes { get; set; } = "Automation";
    }
}
