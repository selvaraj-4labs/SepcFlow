using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.RibbonMenu;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Documents.DocumentHistory
{
    public class DocumentHistoryClose : AppBasePage
    {
        public DocumentHistoryClose()
        {
            pageLoadedElement = new Ribbon().newProcessMenu;
            correspondingDataClass = new DocumentHistoryCloseData().GetType();
            textName = "Document History Close";
        }

        
    }

    public class DocumentHistoryCloseData : PageData
    {
    }
}
