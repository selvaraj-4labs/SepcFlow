using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP07 : CBS_DIP07
    {
        public CBS_ADV_DIP07()
        {
            pageLoadedElement = everHadAUKAddress;
            correspondingDataClass = new CBS_ADV_DIP07Data().GetType();
            textName = "CBS Advised Applicant 1 Address Histroy Page";
        }
    }

    public class CBS_ADV_DIP07Data : CBS_DIP07Data
    {
    }
}
