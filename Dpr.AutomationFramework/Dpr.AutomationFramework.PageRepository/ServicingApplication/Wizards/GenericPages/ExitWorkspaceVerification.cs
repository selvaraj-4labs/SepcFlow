using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages
{
    public class ExitWorkspaceVerification : AppBasePage
    {
        public ExitWorkspaceVerification()
        {
            pageLoadedElement = exitQuery;
            correspondingDataClass = new ExitWorkspaceVerificationData().GetType();
            textName = "Exit Workspace Verifcation Window";
        }

        public Element exitQuery => new Element(new ButtonGroup()
            .AddButtonElement("Yes", FindElement(new LocatorList().Add(Defs.boLocatorName, "Exit Account").Add(Defs.boLocatorName, "Yes")))
            .AddButtonElement("No", FindElement(new LocatorList().Add(Defs.boLocatorName, "Exit Account").Add(Defs.boLocatorName, "No"))))
            .SetCompletePageFlag(false);

    }

    public class ExitWorkspaceVerificationData : PageData
    {
        public string exitQuery { get; set; } = "Yes";
    }
}
