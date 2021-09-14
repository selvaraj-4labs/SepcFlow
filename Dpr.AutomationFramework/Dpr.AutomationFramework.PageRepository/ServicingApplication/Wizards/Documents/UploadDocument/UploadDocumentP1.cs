using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.UploadDocument

{
    public class UploadDocumentP1 : AppBasePage
    {
        public UploadDocumentP1()
        {
            pageLoadedElement = browse;
            correspondingDataClass = new UploadDocumentP1Data().GetType();
            textName = "Upload Document Page 1";
        }
        public Element browse => new Element(FindElement("=btnSelectDocument", attributeType: Defs.boLocatorAutomationId, tag: "Button"))
            .SetIsButtonFlag(true);

        public Element fileLocation => new Element(FindElement("=File name:", attributeType: Defs.boLocatorName, tag: "Edit"));

        //public Element openBtn => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "=Open"), "/Button[@Name='Open']", "Window"))
        //    .SetIsButtonFlag(true);

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId))
            .SetIsButtonFlag(true);
    }

    public class UploadDocumentP1Data : PageData
    {
        public string fileLocation { get; set; } = null;

    }
}
