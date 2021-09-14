using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_NewUserIDPage : NewUserIDPage
    {
        public HEBS_NewUserIDPage()
        {
            pageLoadedElement = userNameBox;
            correspondingDataClass = new HEBS_NewUserIDPageData().GetType();
            textName = "New User ID Page";
        }
    }

    public class HEBS_NewUserIDPageData : NewUserIDPageData
    {
    }
}
