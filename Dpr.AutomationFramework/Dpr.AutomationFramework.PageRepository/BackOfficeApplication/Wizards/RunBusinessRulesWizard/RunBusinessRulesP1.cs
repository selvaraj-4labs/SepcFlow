using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.RunBusinessRulesWizard
{
    public class RunBusinessRulesP1 : BOWizardBasePage
    {
        public RunBusinessRulesP1()
        {
            pageLoadedElement = next;
            correspondingDataClass = new RunBusinessRulesP1Data().GetType();
            textName = "Run Business Rules Page 1";
            windowTitle = "Run Business Rules";
        }

        #region 'DIP Process' Section
        public Element runDIPDecisionProcess => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[1]/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[1]/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"No\"]")));
        #endregion

        #region 'FMA Process' Section
        public Element runFMADecisionProcess => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[2]/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[2]/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"No\"]")));
        #endregion

        #region 'Post-Valuation Process' Section
        public Element runPostValuationProcess => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[3]/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[3]/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"No\"]")));
        #endregion

        public Element next => new Element(FindElement("pnlNextButton", Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class RunBusinessRulesP1Data : PageData
    {
        public string runDIPDecisionProcess { get; set; } = Defs.radioButtonYes;
        public string runFMADecisionProcess { get; set; } = Defs.radioButtonNo;
        public string runPostValuationProcess { get; set; } = Defs.radioButtonNo;
    }
}
