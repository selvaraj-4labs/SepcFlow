using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.AddNewDocument
{
    public class AddNewDocumentClose : GenericWizardClose
    {
        public AddNewDocumentClose()
        {
            correspondingDataClass = new AddNewDocumentCloseData().GetType();
            textName = "Add New Document Close";
        }
    }
    public class AddNewDocumentCloseData : GenericWizardCloseData
    {
    }

}
