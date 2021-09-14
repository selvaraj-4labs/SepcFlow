using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.SendToThirdParty
{
    public class SendToThirdPartyP1 : AppBasePage
    {
        public SendToThirdPartyP1()
        {
            pageLoadedElement = thirdPartyLookup;
            correspondingDataClass = new SendToThirdPartyP1Data().GetType();
            textName = "Send To Third Party Page 1";
        }

        public Element thirdPartyLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "thirdPartyUltraComboEditor"),
            "/Edit"));
        public Element templateLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "templateUltraComboEditor"),
            "/Edit"));
        public Element statusLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "statusFilterUltraComboEditor"),
            "/Edit"));
        public Element dateUpdatedBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updatedDateFilterUltraDateTimeEditor"),
            "/Edit"));

        public Element documentToSelect => new Element(new ButtonGroup()
            .AddButtonElement("First Cover Email", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "attachmentsCheckedListBox"),
                "/CheckBox[1]"))
            .AddButtonElement("Second Cover Email", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "attachmentsCheckedListBox"),
                "/CheckBox[2]"))
            .AddButtonElement("CS7063", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "attachmentsCheckedListBox"),
                "/CheckBox[4]"))
            .AddButtonElement("CS7032", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "attachmentsCheckedListBox"),
                "/CheckBox[3]"))
            .AddButtonElement("CS7011", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "attachmentsCheckedListBox"),
                "/CheckBox[5]"))
            .AddButtonElement("C0226", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "attachmentsCheckedListBox"),
                "/CheckBox[6]"))
            );
        public Element ok => new Element(FindElement("okUltraButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }
    public class SendToThirdPartyP1Data : PageData
    {
        public string thirdParty { get; set; } = "(ServicingAgent)";
        public string template { get; set; } = null;
        public string status { get; set; } = "All";
        public string dateUpdated { get; set; } = null;
        public string documentToSelect { get; set; } = "CS7063";
    }
}
