using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerDeceased.UpdateConfirmCustomerDeceased
{
    public class UpdateConfirmCustomerDeceasedP1 : AppBasePage
    {
        public UpdateConfirmCustomerDeceasedP1()
        {
            pageLoadedElement = grantOfProbateRecievedRequiredRbtn;
            correspondingDataClass = new UpdateConfirmCustomerDeceasedP1Data().GetType();
            textName = "Update Confirm Customer Deceased Page 1";
        }

        #region 'Grant Of Probate Recieved?' Section
        public Element grantOfProbateRecievedRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element grantOfProbateRecievedCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element grantOfProbateRecievedSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'A copy of will recieved?' Section
        public Element copyOfWillRecievedRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element copyOfWillRecievedCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element copyOfWillRecievedSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Legal Representative details held?' Section
        public Element legalRepresentativeDetailsHeldRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element legalRepresentativeDetailsHeldCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element legalRepresentativeDetailsHeldSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Confirmation recieved that property is adequately secured and fully insured?' Section
        public Element propertyAdequatelySecuredAndInsuredRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element propertyAdequatelySecuredAndInsuredCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element propertyAdequatelySecuredAndInsuredSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Executor detalis recieved?' Section
        public Element executorDetailsRecievedRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][5]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][5]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element executorDetailsRecievedCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][5]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][5]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][5]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element executorDetailsRecievedSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][5]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][5]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][5]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Estate agent details received?' Section
        public Element estateAgentDetailsRecievedRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][6]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][6]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element estateAgentDetailsRecievedCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][6]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][6]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][6]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element estateAgentDetailsRecievedSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][6]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][6]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][6]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Death Certificate/electronic confirmation recevied?' Section
        public Element confirmationRecievedRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][7]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][7]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element confirmationRecievedCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][7]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][7]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][7]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element confirmationRecievedSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][7]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][7]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][7]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Is the property being sold?' Section
        public Element propertyBeingSoldRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][8]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][8]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element propertyBeingSoldCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][8]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][8]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][8]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element propertyBeingSoldSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][8]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][8]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][8]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class UpdateConfirmCustomerDeceasedP1Data : PageData
    {
        #region 'Grant Of Probate Recieved?' Section
        public string grantOfProbateRecievedRequired { get; set; } = "Yes";
        public string grantOfProbateRecievedCompleted { get; set; } = "Yes";
        public string grantOfProbateRecievedSatisfied { get; set; } = "Yes";
        #endregion

        #region 'A copy of will recieved?' Section
        public string copyOfWillRecievedRequired { get; set; } = "Yes";
        public string copyOfWillRecievedCompleted { get; set; } = "Yes";
        public string copyOfWillRecievedSatisfied { get; set; } = "Yes";
        #endregion

        #region 'Legal Representative details held?' Section
        public string legalRepresentativeDetailsHeldRequired { get; set; } = "Yes";
        public string legalRepresentativeDetailsHeldCompleted { get; set; } = "Yes";
        public string legalRepresentativeDetailsHeldSatisfied { get; set; } = "Yes";
        #endregion

        #region 'Confirmation recieved that property is adequately secured and fully insured?' Section
        public string propertyAdequatelySecuredAndInsuredRequired { get; set; } = "Yes";
        public string propertyAdequatelySecuredAndInsuredCompleted { get; set; } = "Yes";
        public string propertyAdequatelySecuredAndInsuredSatisfied { get; set; } = "Yes";
        #endregion

        #region 'Executor detalis recieved?' Section
        public string executorDetailsRecievedRequired { get; set; } = "Yes";
        public string executorDetailsRecievedCompleted { get; set; } = "Yes";
        public string executorDetailsRecievedSatisfied { get; set; } = "Yes";
        #endregion

        #region 'Estate agent details received?' Section
        public string estateAgentDetailsRecievedRequired { get; set; } = "Yes";
        public string estateAgentDetailsRecievedCompleted { get; set; } = "Yes";
        public string estateAgentDetailsRecievedSatisfied { get; set; } = "Yes";
        #endregion

        #region 'Death Certificate/electronic confirmation recevied?' Section
        public string confirmationRecievedRequired { get; set; } = "Yes";
        public string confirmationRecievedCompleted { get; set; } = "Yes";
        public string confirmationRecievedSatisfied { get; set; } = "Yes";
        #endregion

        #region 'Is the property being sold?' Section
        public string propertyBeingSoldRequired { get; set; } = "Yes";
        public string propertyBeingSoldCompleted { get; set; } = "Yes";
        public string propertyBeingSoldSatisfied { get; set; } = "Yes";
        #endregion

        public string remarks { get; set; } = "TestRemarks";
    }
}
