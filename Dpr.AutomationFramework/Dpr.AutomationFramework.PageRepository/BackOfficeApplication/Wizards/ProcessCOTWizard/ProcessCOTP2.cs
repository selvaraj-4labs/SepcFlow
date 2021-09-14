using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.ProcessCOTWizard
{
    public class ProcessCOTP2 : BOWizardBasePage
    {
        public ProcessCOTP2()
        {
            pageLoadedElement = finish;
            correspondingDataClass = new ProcessCOTP2Data().GetType();
            textName = "Process COT Page 2";
            windowTitle = "Process COT /Change Approved";
        }

        #region Non Editable Values
        public Element fundsReleaseDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprDateTimeEditableField"),
            "[1]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraDateTimeEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element completion => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprDateTimeEditableField"),
            "[2]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraDateTimeEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element titleNumber1 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprTextEditableField"),
            "[1]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element titleNumber2 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprTextEditableField"),
            "[2]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element titleNumber3 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprTextEditableField"),
            "[3]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element solicitorSortCode => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprTextEditableField"),
            "[4]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element solicitorAccountNumber => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprTextEditableField"),
            "[5]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element dateOfLenderInstruction => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprDateTimeEditableField"),
            "[3]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraDateTimeEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element nameOfAuthorisedSignatory => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprTextEditableField"),
            "[6]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));
         
        public Element qualificationOfAuthorisedSignatory => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprTextEditableField"),
            "[7]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element dateOfSignature => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprDateTimeEditableField"),
            "[4]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraDateTimeEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element isTheCOTSigned => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.radioButtonYes, "DprOptionEditableField"),
                "[1]/Pane[@AutomationId=\"rightPanel\"]" +
                "/Edit[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.radioButtonYes, "DprOptionEditableField"),
                "[1]/Pane[@AutomationId=\"rightPanel\"]" +
                "/Edit[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"No\"]")));

        public Element haveAnyAmendmentsBeenMade => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.radioButtonYes, "DprOptionEditableField"),
                "[2]/Pane[@AutomationId=\"rightPanel\"]" +
                "/Edit[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.radioButtonYes, "DprOptionEditableField"),
                "[2]/Pane[@AutomationId=\"rightPanel\"]" +
                "/Edit[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"No\"]")));
        #endregion

        #region 'Reflection Period' Section
        public Element refelctionPeriodWaiverReason => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ultraComboEditor"),
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element refelctionPeriodWaiverReasonNotes => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ReflectionPeriodWaiverNotes"),
            "/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));
        #endregion

        public Element finish => new Element(FindElement(
                "pnlNextButton",
                attributeType: Defs.boLocatorAutomationId))
            .SetIsButtonFlag(true);
    }

    public class ProcessCOTP2Data : PageData
    {
        public string refelctionPeriodWaiverReason { get; set; } = "Reason 1 Text";
        public string refelctionPeriodWaiverReasonNotes { get; set; } = "Automation Notes";
    }
}
