using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.RibbonMenu;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class VersionsClose : GenericWizardClose
    {
        public VersionsClose()
        {
            correspondingDataClass = new VersionsCloseData().GetType();
            textName = "Versions Close";
            pageLoadedElement = new Ribbon().newProcessMenu;
        }
    }

    public class VersionsCloseData : GenericWizardCloseData
    {
    }
}
