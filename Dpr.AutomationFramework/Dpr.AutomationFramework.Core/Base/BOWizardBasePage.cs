using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base
{
    public class BOWizardBasePage : AppBasePage
    {
        public bool firstPage;
        public string windowTitle;

        public BOWizardBasePage()
        {
            firstPage = false;
            windowTitle = null;
        }

        public Element successResult => new Element(FindElement("Success", attributeType: Defs.boLocatorName))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);


        public Element declineResult => new Element(FindElement("Declined", attributeType: Defs.boLocatorName))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element testResult => new Element(FindElement("testValueThatWillNotBeFound", attributeType: Defs.boLocatorName))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

    }
}