using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.UploadDocument

{
    public class UploadDocumentP2 : AppBasePage
    {
        public UploadDocumentP2()
        {
            pageLoadedElement = renameDocument;
            correspondingDataClass = new UploadDocumentP2Data().GetType();
            textName = "Upload Document Page 2";
        }
        public Element renameDocument => new Element(FindElement("=cbRenameDocument", attributeType: Defs.boLocatorAutomationId, tag: "CheckBox"));
            
        public Element documentName => new Element(FindElement("=txtRenameDocument:", attributeType: Defs.boLocatorAutomationId, tag: "Edit"), new ConditionList()
            .Add(new Condition(className, "renameDocument", Defs.checkBoxSelected)));

        public Element selectFilter => new Element(FindElement("=cbProcessInstructionFilter", attributeType: Defs.boLocatorAutomationId, tag: "ComboBox"));

        public Element processessSince => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=processesSinceUltraDateTimeEditor"), "/ComboBox/Edit/Edit", tag: "ComboBox"));

        public Element documentReason => new Element(new RadioButton()
            .AddRadioButtonElement("Open Processes or Instructions", FindElement("=rbProcessesOrInstructions", attributeType: Defs.boLocatorAutomationId, tag: "RadioButton"))
            .AddRadioButtonElement("Returned Mail Process", FindElement("=rbReturnedMailProcess", attributeType: Defs.boLocatorAutomationId, tag: "RadioButton"))
            .AddRadioButtonElement("New Activity", FindElement("=rbNewWorkspace", attributeType: Defs.boLocatorAutomationId, tag: "RadioButton"))
            .AddRadioButtonElement("Leave on Default Activity", FindElement("=rbDefaultWorkspace", attributeType: Defs.boLocatorAutomationId, tag: "RadioButton")));

        public Element openProcessesOrInstructions => new Element(FindElement("=cbProcessesOrInstructions", attributeType: Defs.boLocatorAutomationId, tag: "ComboBox"), new ConditionList()
            .Add(new Condition(className, "documentReason", "Open Processes or Instructions")));

        public Element returnedMailProcess => new Element(FindElement("=cbReturnedMailProcess", attributeType: Defs.boLocatorAutomationId, tag: "ComboBox"), new ConditionList()
            .Add(new Condition(className, "documentReason", "Returned Mail Process")));

        public Element newActivity => new Element(FindElement("=cbNewWorkspace", attributeType: Defs.boLocatorAutomationId, tag: "ComboBox"), new ConditionList()
            .Add(new Condition(className, "documentReason", "New Activity")));


        public Element remarks => new Element(FindElement("remarksUltraTextEditor", attributeType: Defs.boLocatorAutomationId, tag: "Edit"));


        public Element nextBtn => new Element(FindElement("=pnlNextButton", attributeType: Defs.boLocatorAutomationId))
            .SetIsButtonFlag(true);
    }

    public class UploadDocumentP2Data : PageData
    {
        public string renameDocument { set; get; } = Defs.checkBoxNotSelected;

        public string documentName  {set;get;} = "testRename";

        public string selectFilter { set; get; } = null;

        public string processessSince { set; get; } = null;

        public string documentReason { set; get; } = "Leave on Default Activity";

        public string openProcessesOrInstructions { set; get; } = null;

        public string returnedMailProcess { set; get; } = null;

        public string newActivity { set; get; } = "Admin";


        public string remarks { set; get; } = null;

    }
}
