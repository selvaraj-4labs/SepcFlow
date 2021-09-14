using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_SaveAndRestore : SaveAndRestore
    {
        public HEBS_SaveAndRestore()
        {
            pageLoadedElement = titleLookup;
            correspondingDataClass = new HEBS_SaveAndRestoreData().GetType();
            textName = "Save And Restore Page";
        }
    }

    public class HEBS_SaveAndRestoreData : SaveAndRestoreData
    {
    }
}
