using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.ManageDocument
{
    public class ManageDocumentP2 : GenericFinalWizardPage
    {
        public ManageDocumentP2()
        {
            correspondingDataClass = new ManageDocumentP2Data().GetType();
            textName = "Manage Document Page 2";
        }
    }
    
    public class ManageDocumentP2Data : GenericFinalWizardPageData
    {
    }
}
