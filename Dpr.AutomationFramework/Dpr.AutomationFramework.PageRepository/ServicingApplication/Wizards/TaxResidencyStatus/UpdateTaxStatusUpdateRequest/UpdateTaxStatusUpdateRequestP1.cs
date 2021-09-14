using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.UpdateTaxResidencyStatus;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.UpdateTaxStatusUpdateRequest
{
    public class UpdateTaxStatusUpdateRequestP1 : UpdateTaxResidencyStatusP2
    {
        public UpdateTaxStatusUpdateRequestP1()
        {
            
            correspondingDataClass = new UpdateTaxStatusUpdateRequestP1Data().GetType();
            textName = "Update Tax Status Update Request Page 1";
        }





        //#region 'HMRC form complete Checklist' Row

        //public Element hmrcRequiredYesChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"]" +
        //    "/ CheckBox[@AutomationId =\"chkRequiredYes\"]"));

        //public Element hmrcRequiredNoChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"]" +
        //    "/ CheckBox[@AutomationId =\"chkRequiredNo\"]"));

        //public Element hmrcCompletedYesChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"]" +
        //    "/ CheckBox[@AutomationId =\"chkCompletedYes\"]"));

        //public Element hmrcCompletedNoChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"]" +
        //    "/ CheckBox[@AutomationId =\"chkCompletedNo\"]"));

        //public Element hmrcCompletedNAChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"]" +
        //    "/ CheckBox[@AutomationId =\"chkCompletedNA\"]"));

        //public Element hmrcSatisfiedYesChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"]" +
        //    "/ CheckBox[@AutomationId =\"chkSatisfactoryYes\"]"));

        //public Element hmrcSatisfiedNoChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"]" +
        //    "/ CheckBox[@AutomationId =\"chkSatisfactoryNo\"]"));

        //public Element hmrcSatisfiedUKChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"]" +
        //    "/ CheckBox[@AutomationId =\"chkSatisfactoryUnk\"]"))
        //    ;
        //#endregion

        //#region 'Eligibility check' Row

        //public Element eligibilityRequiredYesChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"][1]" +
        //    "/ CheckBox[@AutomationId =\"chkRequiredYes\"]"));

        //public Element eligibilityRequiredNoChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"][1]" +
        //    "/ CheckBox[@AutomationId =\"chkRequiredNo\"]"));

        //public Element eligibilityCompletedYesChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"][1]" +
        //    "/ CheckBox[@AutomationId =\"chkCompletedYes\"]"));

        //public Element eligibilityCompletedNoChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"][1]" +
        //    "/ CheckBox[@AutomationId =\"chkCompletedNo\"]"));

        //public Element eligibilityCompletedNAChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"][1]" +
        //    "/ CheckBox[@AutomationId =\"chkCompletedNA\"]"));

        //public Element eligibilitySatisfiedYesChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"][1]" +
        //    "/ CheckBox[@AutomationId =\"chkSatisfactoryYes\"]"));

        //public Element eligibilitySatisfiedNoChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"][1]" +
        //    "/ CheckBox[@AutomationId =\"chkSatisfactoryNp\"]"));

        //public Element eligibilitySatisfiedUKChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"][1]" +
        //    "/ CheckBox[@AutomationId =\"chkSatisfactoryUnk\"]"));

        //#endregion

        //#region 'All customers listed on the form' Row

        //public Element customersRequiredYesChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"][2]" +
        //    "/ CheckBox[@AutomationId =\"chkRequiredYes\"]"));

        //public Element customersRequiredNoChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"][2]" +
        //    "/ CheckBox[@AutomationId =\"chkRequiredNo\"]"));

        //public Element customersCompletedYesChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"][2]" +
        //    "/ CheckBox[@AutomationId =\"chkCompletedYes\"]"));

        //public Element customersCompletedNoChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"][2]" +
        //    "/ CheckBox[@AutomationId =\"chkCompletedNo\"]"));

        //public Element customersCompletedNAChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"][1]" +
        //    "/ CheckBox[@AutomationId =\"chkCompletedNA\"]"));

        //public Element customersSatisfiedYesChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"][2]" +
        //    "/ CheckBox[@AutomationId =\"chkSatisfactoryYes\"]"));

        //public Element customersSatisfiedNoChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"][1]" +
        //    "/ CheckBox[@AutomationId =\"chkSatisfactoryNp\"]"));

        //public Element customersSatisfiedUKChBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "GenericChecklistControl"),
        //    "/Group[@Name=\"Checklist Items\"][@AutomationId=\"dprGroupBoxChecklistItems\"]" +
        //    "/ Pane[@AutomationId =\"pnlCheckListItems\"]" +
        //    "/ Pane[@AutomationId =\"GenericChecklistControlLine\"][1]" +
        //    "/ CheckBox[@AutomationId =\"chkSatisfactoryUnk\"]"));


        //#endregion

        //public Element remarksBox => new Element(FindElement("txtRemarks", Defs.boLocatorAutomationId));

        //public Element nextBtn => new Element(FindElement("pnlNextButton", Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class UpdateTaxStatusUpdateRequestP1Data : UpdateTaxResidencyStatusP2Data
    {
        //public string hmrcRequiredYes { get; set; } = Defs.checkBoxSelected;
        //public string hmrcRequiredNo { get; set; } = Defs.checkBoxNotSelected;
        //public string hmrcCompletedYes { get; set; } = Defs.checkBoxSelected;
        //public string hmrcCompletedNo { get; set; } = Defs.checkBoxNotSelected;
        //public string hmrcCompletedNA { get; set; } = Defs.checkBoxNotSelected;
        //public string hmrcSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        //public string hmrcSatisfiedNo { get; set; } = Defs.checkBoxNotSelected;
        //public string hmrcSatisfiedUK { get; set; } = Defs.checkBoxNotSelected;

        //public string eligibilityRequiredYes { get; set; } = Defs.checkBoxSelected;
        //public string eligibilityRequiredNo { get; set; } = Defs.checkBoxNotSelected;
        //public string eligibilityCompletedYes { get; set; } = Defs.checkBoxSelected;
        //public string eligibilityCompletedNo { get; set; } = Defs.checkBoxNotSelected;
        //public string eligibilityCompletedNA { get; set; } = Defs.checkBoxNotSelected;
        //public string eligibilitySatisfiedYes { get; set; } = Defs.checkBoxSelected;
        //public string eligibilitySatisfiedNo { get; set; } = Defs.checkBoxNotSelected;
        //public string eligibilitySatisfiedUK { get; set; } = Defs.checkBoxNotSelected;


        //public string customersRequiredYes { get; set; } = Defs.checkBoxSelected;
        //public string customersRequiredNo { get; set; } = Defs.checkBoxNotSelected;
        //public string customersCompletedYes { get; set; } = Defs.checkBoxSelected;
        //public string customersCompletedNo { get; set; } = Defs.checkBoxNotSelected;
        //public string customersCompletedNA { get; set; } = Defs.checkBoxNotSelected;
        //public string customersSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        //public string customersSatisfiedNo { get; set; } = Defs.checkBoxNotSelected;
        //public string customersSatisfiedUK { get; set; } = Defs.checkBoxNotSelected;

        //public string remarks { get; set; } = "TestRemarks";
    }
}
