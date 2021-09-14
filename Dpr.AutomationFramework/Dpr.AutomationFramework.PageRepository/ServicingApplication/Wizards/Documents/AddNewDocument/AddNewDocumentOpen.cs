using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.AddNewDocument
{
    public class AddNewDocumentOpen : GenericWizardOpen
    {
        public AddNewDocumentOpen()
        {
            pageLoadedElement = clickNewDocument;
            correspondingDataClass = new AddNewDocumentOpenData().GetType();
            textName = "Add New Document Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.accountAdmin;
        public Element clickDocuments => ribbon.documentsMenu;
        public Element clickNewDocument => documents.newDocument;


        /*        
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.customer;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickCustomer => processActions.customer;
        public Element clickCustomerInLongTermCareNotification => processActions.customerInLongTermCareNotification;
        */
    }
    public class AddNewDocumentOpenData : GenericWizardOpenData
    {
    }
}
