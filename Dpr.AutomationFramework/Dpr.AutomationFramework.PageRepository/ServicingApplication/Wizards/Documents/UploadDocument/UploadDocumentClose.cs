using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.UploadDocument
{
    public class UploadDocumentClose : GenericWizardClose
    {
        public UploadDocumentClose()
        {
            correspondingDataClass = new UploadDocumentCloseData().GetType();
            textName = "Add New Document Close";
        }
    }
    public class UploadDocumentCloseData : GenericWizardCloseData
    {
    }

}
