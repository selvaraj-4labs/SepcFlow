using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP12 : CBS_DIP12
    {
        public CBS_ADV_DIP12()
        {
            pageLoadedElement = ownAnyBTLProperties;
            correspondingDataClass = new CBS_ADV_DIP12Data().GetType();
            textName = "CBS Advised Applicant 1 BTL Portfolio Page";
        }
    }

    public class CBS_ADV_DIP12Data : CBS_DIP12Data
    {
    }
}