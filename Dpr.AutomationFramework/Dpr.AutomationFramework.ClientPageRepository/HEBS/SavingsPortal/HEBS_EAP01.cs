using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP01 : EAP01
    {
        public HEBS_EAP01()
        {
            pageLoadedElement = acceptDeclarationChbox;
            correspondingDataClass = new HEBS_EAP01Data().GetType();
            textName = "Entry Page";
        }
    }

    public class HEBS_EAP01Data : EAP01Data
    {
    }
}
