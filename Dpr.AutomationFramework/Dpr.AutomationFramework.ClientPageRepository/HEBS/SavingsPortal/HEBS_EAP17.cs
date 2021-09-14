using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP17 : EAP17
    {
        public HEBS_EAP17()
        {
            pageLoadedElement = homePageBtn;
            correspondingDataClass = new HEBS_EAP17Data().GetType();
            textName = "Thank You Fail EID";
        }
    }

    public class HEBS_EAP17Data : EAP17Data
    {
    }
}
