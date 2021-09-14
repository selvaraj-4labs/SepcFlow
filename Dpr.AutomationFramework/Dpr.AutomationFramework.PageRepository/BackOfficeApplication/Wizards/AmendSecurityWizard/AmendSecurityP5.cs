using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendSecurityWizard
{
    public class AmendSecurityP5 : BOWizardBasePage
    {
        public AmendSecurityP5()
        {
            pageLoadedElement = finish;
            correspondingDataClass = new AmendSecurityP5Data().GetType();
            textName = "Amend Security Page 4";
            windowTitle = "Amend Security";
        }
        public Element finish => new Element(FindElement("Finish", attributeType: Defs.boLocatorName))
            .SetIsButtonFlag(true);
    }

    public class AmendSecurityP5Data : PageData
    {
    }
}
