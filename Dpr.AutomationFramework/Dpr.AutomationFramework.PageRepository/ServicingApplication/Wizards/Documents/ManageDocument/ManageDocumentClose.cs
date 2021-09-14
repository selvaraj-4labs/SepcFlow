using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class ManageDocumentClose : GenericWizardClose
    {
        public ManageDocumentClose()
        {
            correspondingDataClass = new ManageDocumentCloseData().GetType();
            textName = "Manage Document Close";
        }
    }

    public class ManageDocumentCloseData : GenericWizardCloseData
    {
    }
}
