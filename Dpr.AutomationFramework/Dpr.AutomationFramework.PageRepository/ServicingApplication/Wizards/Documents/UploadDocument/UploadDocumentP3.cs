using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.UploadDocument
{
    public class UploadDocumentP3 : GenericFinalWizardPage
    {
        public UploadDocumentP3()
        {
            correspondingDataClass = new UploadDocumentP3Data().GetType();
            textName = "Upload Document Page 3";
        }
    }

    public class UploadDocumentP3Data : GenericFinalWizardPageData
    {

    }
}
