using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.OverrideCustomerTaxStatus
{
    public class OverrideCustomerTaxStatusP2 : AppBasePage
    {
        public OverrideCustomerTaxStatusP2()
        {
            pageLoadedElement = declarationFormCompleteRequired;
            correspondingDataClass = new OverrideCustomerTaxStatusP2Data().GetType();
            textName = "Override Customer Tax Status Page 2";
        }

        #region 'Declaration form complete' Row


        public Element declarationFormCompleteRequired => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkRequiredYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkRequiredNo']")));

        public Element declarationFormCompleteCompleted => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkCompletedYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkCompletedNo']"))
            .AddRadioButtonElement("N/A", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkCompletedNA']")));

        public Element declarationFormCompleteSatisfied => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkSatisfactoryYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkSatisfactoryNo']"))
            .AddRadioButtonElement("U/K", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkSatisfactoryUnk']")));


        #endregion

        #region 'Eligibility check' Row

        public Element eligibilityCheckRequired => new Element(new RadioButton()
        .AddRadioButtonElement("Yes", FindElement(new LocatorList()
          .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][2]/CheckBox[@AutomationId='chkRequiredYes']"))
        .AddRadioButtonElement("No", FindElement(new LocatorList()
          .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][2]/CheckBox[@AutomationId='chkRequiredNo']")));

        public Element eligibilityCheckCompleted => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][2]/CheckBox[@AutomationId='chkCompletedYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][2]/CheckBox[@AutomationId='chkCompletedNo']"))
            .AddRadioButtonElement("N/A", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][2]/CheckBox[@AutomationId='chkCompletedNA']")));

        public Element eligibilityCheckSatisfied => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][2]/CheckBox[@AutomationId='chkSatisfactoryYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][2]/CheckBox[@AutomationId='chkSatisfactoryNo']"))
            .AddRadioButtonElement("U/K", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][2]/CheckBox[@AutomationId='chkSatisfactoryUnk']")));


        #endregion

        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class OverrideCustomerTaxStatusP2Data : PageData
    {
        public string declarationFormCompleteRequired { get; set; } = "Yes";
        public string declarationFormCompleteCompleted { get; set; } = "Yes";
        public string declarationFormCompleteSatisfied { get; set; } = "Yes";
        public string allCustomersListedOnFormRequired { get; set; } = "Yes";
        public string eligibilityCheckCompleted { get; set; } = "Yes";
        public string eligibilityCheckSatisfied { get; set; } = "Yes";
        public string eligibilityCheckRequired { get; set; } = "Yes";

        public string remarks { get; set; } = "TestRemarks";
    }
}
