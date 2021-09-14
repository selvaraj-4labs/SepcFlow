using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP15 : CBS_PBD02
    {
        public CBS_ADV_DIP15()
        {
            pageLoadedElement = consentConfirm;
            correspondingDataClass = new CBS_ADV_DIP15Data().GetType();
            textName = "CBS Advised DPA & Credit Search Permission";
        }
    }

    public class CBS_ADV_DIP15Data : CBS_PBD02Data
    {
        public new string allApplicantsBeNamed { get; set; } = null;
    }
}
