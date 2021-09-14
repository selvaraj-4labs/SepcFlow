using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.ValuationReceiptWizard
{
    public class ValuationReceiptP1 : BOWizardBasePage
    {
        public ValuationReceiptP1()
        {
            pageLoadedElement = next;
            correspondingDataClass = new ValuationReceiptP1Data().GetType();
            textName = "Valuation Receipt Page 1";
            windowTitle = "Valuation Receipt (Quest)";
        }

        public Element selectSecurity => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "LoanSecurity"),
            "/Pane[@AutomationId=\"rightPanel\"]" +
            "/ComboBox[@AutomationId=\"ultraComboEditor\"]"));

        public Element typeOfValuation => new Element(new RadioButton()
            .AddRadioButtonElement("Standard Valuation", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"Standard Valuation\"]"))
            .AddRadioButtonElement("Re-inspection", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"Re-inspection\"]"))
            .AddRadioButtonElement("Re-Type with Photos", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"Re-Type with Photos\"]"))
            .AddRadioButtonElement("AVM", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"AVM\"]")));
        
        public Element next => new Element(FindElement(
            "pnlNextButton",
            attributeType: Defs.boLocatorAutomationId))
        .SetIsButtonFlag(true);
    }

    public class ValuationReceiptP1Data : PageData
    {
        // Set the value when the journey is called.
        public string selectSecurity { get; set; } = null;
    }
}
