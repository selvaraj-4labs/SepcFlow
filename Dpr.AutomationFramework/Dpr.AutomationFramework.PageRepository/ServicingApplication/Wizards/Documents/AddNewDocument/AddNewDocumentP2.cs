using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.AddNewDocument
{
    public class AddNewDocumentP2 : GenericFinalWizardPage
    {
        public AddNewDocumentP2()
        {
            correspondingDataClass = new AddNewDocumentP2Data().GetType();
            textName = "Add New Document Page 2";
        }
    }

    public class AddNewDocumentP2Data : GenericFinalWizardPageData
    {

    }
}
