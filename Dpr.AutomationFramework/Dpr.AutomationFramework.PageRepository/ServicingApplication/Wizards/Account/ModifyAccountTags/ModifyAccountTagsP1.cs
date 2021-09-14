using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.ModifyAccountTags
{
    public class ModifyAccountTagsP1 : AppBasePage
    {
        public ModifyAccountTagsP1()
        {
            pageLoadedElement = accountTagLookup;
            correspondingDataClass = new ModifyAccountTagsP1Data().GetType();
            textName = "Modify Account Tags Page 1";
        }
        public Element accountTagLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=ceAccountTag")));
        public Element accountTagValueLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=ceAccountTagValue")));
        public Element accountTagCustomValueBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtAccountTagCustomValue")));
           
        public Element nextBtn => new Element(FindElement("pnlNextButton", 
            attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class ModifyAccountTagsP1Data : PageData
    {
        public string accountTag { get; set; } = "Account Tag1";
        public string accountTagValue { get; set; } = null;
        public string accountTagCustomValue { get; set; } = null;
    }
}
