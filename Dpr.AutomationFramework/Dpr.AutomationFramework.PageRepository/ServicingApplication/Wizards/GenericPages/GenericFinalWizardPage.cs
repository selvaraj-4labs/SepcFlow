using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages
{
    public class GenericFinalWizardPage : AppBasePage
    {
        public GenericFinalWizardPage()
        {
            pageLoadedElement = messagesBox;
            correspondingDataClass = new GenericFinalWizardPageData().GetType();
            textName = string.Empty;
        }

        //public Element successResult => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "processingResultDetails"), "/Edit[@Name='Success']", "Pane"))
        //    .SetCompletePageFlag(false);

        public Element successResult => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtResult_EmbeddableTextBox")))
            .SetCompletePageFlag(false);

        public Element testResult => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "testValueThatWillNotBeFound")))
            .SetCompletePageFlag(false);


        public Element messagesBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtMessages")))
            .SetCompletePageFlag(false);

        public Element nextBtn => new Element(FindElement(new Core.ClassDefinitions.LocatorList()
            .Add(Defs.boLocatorClass, "WindowsForms10")
            .Add(Defs.boLocatorName, "=Next"), tag: "Button"))
            .SetIsButtonFlag(true);
    }

    public class GenericFinalWizardPageData : PageData
    {
    }
}