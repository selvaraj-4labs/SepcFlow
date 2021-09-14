using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.UploadDocument
{
    public class UploadDocumentOpen : GenericWizardOpen
    {
        public UploadDocumentOpen()
        {
            pageLoadedElement = clickNewProcess;
            correspondingDataClass = new UploadDocumentOpenData().GetType();
            textName = "Upload Document Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountAdmin => newProcess.accountAdmin;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountAdmin2 => processActions.accountAdmin;
        public Element clickUploadDocument => processActions.uploadDocument;



        /*        
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.customer;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickCustomer => processActions.customer;
        public Element clickCustomerInLongTermCareNotification => processActions.customerInLongTermCareNotification;
        */
    }
    public class UploadDocumentOpenData : GenericWizardOpenData
    {
    }
}
