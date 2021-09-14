using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.UpdateConfirmCustomerInLongTermCare
{
    public class UpdateConfirmCustomerInLongTermCareP1: AppBasePage
    {
        public UpdateConfirmCustomerInLongTermCareP1()
        {
            pageLoadedElement = dailyActivitiesLetterRequiredRbtn;
            correspondingDataClass = new UpdateConfirmCustomerInLongTermCareP1Data().GetType();
            textName = "Update Customer In Long Term Care  Page 1";
        }
        #region 'Have you received the Daily Activities Letter from the customer's doctor?' Section
        public Element dailyActivitiesLetterRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element dailyActivitiesLetterCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element dailyActivitiesLetterSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Have you received the Power of Attorney Details?' Section
        public Element powerOfAttorneyReceivedRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element powerOfAttorneyReceivedCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element powerOfAttorneyReceivedSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Confirmation Received that  property is adequately secured and fully insured?' Section
        public Element propertySecuredInsuredRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element propertySecuredInsuredCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element propertySecuredInsuredSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Is the Property being Sold?' Section
        public Element propertySoldRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element propertySoldCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element propertySoldSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion
        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class UpdateConfirmCustomerInLongTermCareP1Data : PageData
    {
        public string dailyActivitiesLetterRequired { get; set; } = "Yes";
        public string dailyActivitiesLetterCompleted { get; set; } = "Yes";
        public string dailyActivitiesLetterSatisfied { get; set; } = "Yes";

        public string powerOfAttorneyReceivedRequired { get; set; } = "Yes";
        public string powerOfAttorneyReceivedCompleted { get; set; } = "Yes";
        public string powerOfAttorneyReceivedSatisfied { get; set; } = "Yes";

        public string propertySecuredInsuredRequired { get; set; } = "Yes";
        public string propertySecuredInsuredCompleted { get; set; } = "Yes";
        public string propertySecuredInsuredSatisfied { get; set; } = "Yes";

        public string propertySoldRequired { get; set; } = "Yes";
        public string propertySoldCompleted { get; set; } = "Yes";
        public string propertySoldSatisfied { get; set; } = "Yes";
        public string remarks { get; set; } = "TestRemarks";
    }
}
