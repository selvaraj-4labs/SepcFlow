using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP07 : Applicant1AddressHistoryPage
    {
        public CBS_DIP07()
        {
            pageLoadedElement = everHadAUKAddress;
            correspondingDataClass = new CBS_DIP07Data().GetType();
            textName = "CBS Applicant 1 Address Histroy Page";
        }
    }

    public class CBS_DIP07Data : Applicant1AddressHistoryPageData
    {
        public new string residentialStatus { get; set; } = "Owner with Mortgage";
    }
}
