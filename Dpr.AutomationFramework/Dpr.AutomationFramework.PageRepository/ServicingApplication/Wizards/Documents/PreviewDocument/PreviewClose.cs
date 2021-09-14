using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.RibbonMenu;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class PreviewClose : GenericWizardClose
    {
        public PreviewClose()
        {
            correspondingDataClass = new PreviewCloseData().GetType();
            textName = "Preview Document Close";
            pageLoadedElement = new Ribbon().newProcessMenu;
        }
    }

    public class PreviewCloseData : GenericWizardCloseData
    {
    }
}
