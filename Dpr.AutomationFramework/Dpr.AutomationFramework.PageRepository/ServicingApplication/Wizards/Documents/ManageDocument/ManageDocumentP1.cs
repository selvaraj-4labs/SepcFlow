using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.ManageDocument
{
    public class ManageDocumentP1 : AppBasePage
    {
        public ManageDocumentP1()
        {
            pageLoadedElement = documentTypeLookup;
            correspondingDataClass = new ManageDocumentP1Data().GetType();
            textName = "Manage Document Page 1";
        }

        public Element title => new Element(FindElement("txtTitile", attributeType: Defs.boLocatorAutomationId))
            .SetCompletePageFlag(false);

        public Element updateDate => new Element(FindElement("txtUpdateDate", attributeType: Defs.boLocatorAutomationId))
            .SetCompletePageFlag(false);

        public Element updateTime => new Element(FindElement("txtUpdatedTime", attributeType: Defs.boLocatorAutomationId))
            .SetCompletePageFlag(false);
        public Element documentTypeLookup => new Element(FindElement("cboDocumentType", attributeType: Defs.boLocatorAutomationId));
        public Element documentSubTypeLookup => new Element(FindElement("cboDocumentSubType", attributeType: Defs.boLocatorAutomationId));
        public Element action => new Element(new RadioButton()
            .AddRadioButtonElement("Rename Document", FindElement("rbRenameDocument", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Reassign To Account", FindElement("rbAssignToAccount", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Delete Document", FindElement("rbDeleteDocument", attributeType: Defs.boLocatorAutomationId)));

        public Element documentNameBox => new Element(FindElement("txtNewDocumentName", attributeType: Defs.boLocatorAutomationId), new ConditionList()
            .Add(new Condition(className, "action", "Rename Document")));

        public Element accountNumber => new Element(FindElement("=txtLoanAccount", attributeType: Defs.boLocatorAutomationId, tag: "Edit"), new ConditionList()
            .Add(new Condition(className, "action", "Reassign To Account")));

        public Element validate => new Element(FindElement("=btnValidate", attributeType: Defs.boLocatorAutomationId, tag: "Button"), new ConditionList()
            .Add(new Condition(className, "action", "Reassign To Account")))
            .SetIsButtonFlag(true);

        public Element reason => new Element(FindElement("txtReason", attributeType: Defs.boLocatorAutomationId));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class ManageDocumentP1Data : PageData
    {
        public string documentType { get; set; } = null;
        public string accountNumber { get; set; } = null;
        public string documentSubType { get; set; } = null;
        public string action { get; set; } = "Rename Document";
        public string documentName { get; set; } = "TestDocument";
        public string reason { get; set; } = "TestReason";
    }
}
