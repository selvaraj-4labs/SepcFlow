using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Complaints.LogComplaint
{
    public class LogComplaintP2 : AppBasePage
    {
        public LogComplaintP2()
        {
            pageLoadedElement = acknowledgementLetterRequired;
            correspondingDataClass = new LogComplaintP2Data().GetType();
            textName = "Log Complaint Page 2";
        }
        #region 'Acknowledgement Letter' Section


        public Element acknowledgementLetterRequired => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkRequiredYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkRequiredNo']")));

        public Element acknowledgementLetterCompleted => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkCompletedYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkCompletedNo']"))
            .AddRadioButtonElement("N/A", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkCompletedNA']")));

        public Element acknowledgementLetterSatisfied => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkSatisfactoryYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkSatisfactoryNo']"))
            .AddRadioButtonElement("U/K", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][1]/CheckBox[@AutomationId='chkSatisfactoryUnk']")));


        #endregion

        #region '4 Week Holding Letter' Section

        public Element fourWeekHoldingLetterRequired => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][2]/CheckBox[@AutomationId='chkRequiredYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][2]/CheckBox[@AutomationId='chkRequiredNo']")));

        public Element fourWeekHoldingLetterCompleted => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][2]/CheckBox[@AutomationId='chkCompletedYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][2]/CheckBox[@AutomationId='chkCompletedNo']"))
            .AddRadioButtonElement("N/A", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][2]/CheckBox[@AutomationId='chkCompletedNA']")));

        public Element fourWeekHoldingLetterSatisfied => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][2]/CheckBox[@AutomationId='chkSatisfactoryYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][2]/CheckBox[@AutomationId='chkSatisfactoryNo']"))
            .AddRadioButtonElement("U/K", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][2]/CheckBox[@AutomationId='chkSatisfactoryUnk']")));


        #endregion

        #region 'Complaint Notification Form' Section

        public Element complaintNotificationFormRequired => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][3]/CheckBox[@AutomationId='chkRequiredYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][3]/CheckBox[@AutomationId='chkRequiredNo']")));

        public Element complaintNotificationFormCompleted => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][3]/CheckBox[@AutomationId='chkCompletedYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][3]/CheckBox[@AutomationId='chkCompletedNo']"))
            .AddRadioButtonElement("N/A", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][3]/CheckBox[@AutomationId='chkCompletedNA']")));

        public Element complaintNotificationFormSatisfied => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][3]/CheckBox[@AutomationId='chkSatisfactoryYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][3]/CheckBox[@AutomationId='chkSatisfactoryNo']"))
            .AddRadioButtonElement("U/K", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][3]/CheckBox[@AutomationId='chkSatisfactoryUnk']")));


        #endregion

        #region 'Final Response to Compliance' Section


        public Element finalResponseToComplianceRequired => new Element(new RadioButton()
                 .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                     .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][4]/CheckBox[@AutomationId='chkRequiredYes']"))
                 .AddRadioButtonElement("No", FindElement(new LocatorList()
                     .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][4]/CheckBox[@AutomationId='chkRequiredNo']")));

        public Element finalResponseToComplianceFormCompleted => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][4]/CheckBox[@AutomationId='chkCompletedYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][4]/CheckBox[@AutomationId='chkCompletedNo']"))
            .AddRadioButtonElement("N/A", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][4]/CheckBox[@AutomationId='chkCompletedNA']")));

        public Element finalResponseToComplianceFormSatisfied => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][4]/CheckBox[@AutomationId='chkSatisfactoryYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][4]/CheckBox[@AutomationId='chkSatisfactoryNo']"))
            .AddRadioButtonElement("U/K", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][4]/CheckBox[@AutomationId='chkSatisfactoryUnk']")));


        #endregion

        #region 'Final Response Issued to Customer' Section


        public Element finalResponseIssuedToCustomereRequired => new Element(new RadioButton()
         .AddRadioButtonElement("Yes", FindElement(new LocatorList()
             .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][5]/CheckBox[@AutomationId='chkRequiredYes']"))
         .AddRadioButtonElement("No", FindElement(new LocatorList()
             .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][5]/CheckBox[@AutomationId='chkRequiredNo']")));

        public Element finalResponseIssuedToCustomerCompleted => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][5]/CheckBox[@AutomationId='chkCompletedYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][5]/CheckBox[@AutomationId='chkCompletedNo']"))
            .AddRadioButtonElement("N/A", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][5]/CheckBox[@AutomationId='chkCompletedNA']")));

        public Element finalResponseIssuedToCustomerSatisfied => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][5]/CheckBox[@AutomationId='chkSatisfactoryYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][5]/CheckBox[@AutomationId='chkSatisfactoryNo']"))
            .AddRadioButtonElement("U/K", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][5]/CheckBox[@AutomationId='chkSatisfactoryUnk']")));




        #region 'Compensation Offered to Customer' Section
        public Element compensationOfferedtoCustomerRequired => new Element(new RadioButton()
                 .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                     .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][6]/CheckBox[@AutomationId='chkRequiredYes']"))
                 .AddRadioButtonElement("No", FindElement(new LocatorList()
                     .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][6]/CheckBox[@AutomationId='chkRequiredNo']")));

        public Element compensationOfferedtoCustomerCompleted => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][6]/CheckBox[@AutomationId='chkCompletedYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][6]/CheckBox[@AutomationId='chkCompletedNo']"))
            .AddRadioButtonElement("N/A", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][6]/CheckBox[@AutomationId='chkCompletedNA']")));

        public Element compensationOfferedtoCustomerSatisfied => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][6]/CheckBox[@AutomationId='chkSatisfactoryYes']"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][6]/CheckBox[@AutomationId='chkSatisfactoryNo']"))
            .AddRadioButtonElement("U/K", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId='GenericChecklistControlLine'][6]/CheckBox[@AutomationId='chkSatisfactoryUnk']")));
        #endregion

        #endregion
        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class LogComplaintP2Data : PageData
    {
        public string acknowledgementLetterCompleted { get; set; } = Defs.checkBoxSelected;
        public string acknowledgementLetterSatisfied { get; set; } = Defs.checkBoxSelected;
        public string acknowledgementLetterRequired { get; set; } = null;
        public string fourWeekHoldingLetterCompleted { get; set; } = Defs.checkBoxSelected;
        public string fourWeekHoldingLetterSatisfied { get; set; } = Defs.checkBoxSelected;
        public string fourWeekHoldingLetterRequired { get; set; } = null;
        public string complaintNotificationFormCompleted { get; set; } = Defs.checkBoxSelected;
        public string complaintNotificationFormSatisfied{ get; set; } = Defs.checkBoxSelected;
        public string complaintNotificationFormRequired { get; set; } = null;
        public string finalResponseToComplianceCompleted{ get; set; } = Defs.checkBoxSelected;
        public string finalResponseToComplianceSatisfied { get; set; } = Defs.checkBoxSelected;
        public string finalResponseToComplianceRequired { get; set; } = null;
        public string finalResponseIssuedToCustomerCompleted { get; set; } = Defs.checkBoxSelected;
        public string finalResponseIssuedToCustomerSatisfied { get; set; } = Defs.checkBoxSelected;
        public string finalResponseIssuedToCustomerRequired { get; set; } = null;
        public string compensationOfferedtoCustomerCompleted { get; set; } = Defs.checkBoxSelected;
        public string compensationOfferedtoCustomerSatisfied { get; set; } = Defs.checkBoxSelected;
        public string compensationOfferedtoCustomeRequired { get; set; } = null;

        public string remarks { get; set; } = "TestRemarks";
    }
}
