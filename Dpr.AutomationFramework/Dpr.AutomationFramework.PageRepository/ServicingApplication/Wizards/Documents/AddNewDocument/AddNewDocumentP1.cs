using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.AddNewDocument
{
    public class AddNewDocumentP1 : AppBasePage
    {
        public AddNewDocumentP1()
        {
            pageLoadedElement = titleLookup;
            correspondingDataClass = new AddNewDocumentP1Data().GetType();
            textName = "Add New Document Page 1";
        }
        public Element titleLookup => new Element(FindElement("templateTitleUltraComboEditor", attributeType: Defs.boLocatorAutomationId));
        public Element actionLookup => new Element(FindElement("associateActionUltraComboEditor", attributeType: Defs.boLocatorAutomationId));
        public Element litigationEpisodeLookup => new Element(FindElement("associateLitigationEpisodeUltraComboEditor", attributeType: Defs.boLocatorAutomationId));
        public Element instructionLookup => new Element(FindElement("associateInstructionUltraComboEditor", attributeType: Defs.boLocatorAutomationId));
        public Element riskProfileLookup => new Element(FindElement("cboRiskProfile", attributeType: Defs.boLocatorAutomationId));
        public Element remarksBox => new Element(FindElement("remarksUltraTextEditor", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AddNewDocumentP1Data : PageData
    {
        public string title { get; set; } = null;
        public string action { get; set; } = null;
        public string litigationEpisode { get; set; } = null;
        public string instruction { get; set; } = null;
        public string riskProfile { get; set; } = null;
        public string remarks { get; set; } = "TestRemarks";
    }
}
