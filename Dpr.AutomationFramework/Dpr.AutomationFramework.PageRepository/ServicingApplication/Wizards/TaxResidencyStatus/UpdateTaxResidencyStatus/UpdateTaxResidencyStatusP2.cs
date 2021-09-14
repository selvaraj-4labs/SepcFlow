using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.UpdateTaxResidencyStatus
{
    public class UpdateTaxResidencyStatusP2 : AppBasePage
    {
        public UpdateTaxResidencyStatusP2()
        {
            pageLoadedElement = hmrcFormCompleteChecklistRequired;
            correspondingDataClass = new UpdateTaxResidencyStatusP2Data().GetType();
            textName = "Update Tax/Residency Status Page 2";
        }

        #region 'HMRC form complete Checklist' Row

        
        public Element hmrcFormCompleteChecklistRequired => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkRequiredYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkRequiredNo']")));

        public Element hmrcFormCompleteChecklistCompleted => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkCompletedYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkCompletedNo']"))
            .AddRadioButtonElement("N/A", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkCompletedNA']")));

        public Element hmrcFormCompleteChecklistSatisfied => new Element(new RadioButton()
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

        #region 'All customers listed on the form' Row

        public Element allCustomersListedOnFormRequired => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][3]/CheckBox[@AutomationId='chkRequiredYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][3]/CheckBox[@AutomationId='chkRequiredNo']")));

        public Element allCustomersListedOnFormCompleted => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][3]/CheckBox[@AutomationId='chkCompletedYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][3]/CheckBox[@AutomationId='chkCompletedNo']"))
            .AddRadioButtonElement("N/A", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][3]/CheckBox[@AutomationId='chkCompletedNA']")));

        public Element allCustomersListedOnFormSatisfied => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][3]/CheckBox[@AutomationId='chkSatisfactoryYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][3]/CheckBox[@AutomationId='chkSatisfactoryNo']"))
            .AddRadioButtonElement("U/K", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][3]/CheckBox[@AutomationId='chkSatisfactoryUnk']")));



        #endregion

        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class UpdateTaxResidencyStatusP2Data : PageData
    {
        public string hmrcFormCompleteChecklistRequired { get; set; } = "Yes";
        public string hmrcFormCompleteChecklistCompleted { get; set; } = "Yes";
        public string hmrcFormCompleteChecklistSatisfied { get; set; } = "Yes";
        public string allCustomersListedOnFormRequired { get; set; } = "Yes";
        public string eligibilityCheckCompleted { get; set; } = "Yes";
        public string eligibilityCheckSatisfied { get; set; } = "Yes";
        public string eligibilityCheckRequired { get; set; } = "Yes";
        public string allCustomersListedOnFormCompleted { get; set; } = "Yes";
        public string allCustomersListedOnFormSatisfied { get; set; } = "Yes";

        public string remarks { get; set; } = "TestRemarks";
    }
}
