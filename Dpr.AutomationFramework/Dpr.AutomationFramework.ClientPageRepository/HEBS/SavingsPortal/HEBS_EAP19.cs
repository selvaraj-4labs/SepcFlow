using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP19 : EAP19
    {
    public HEBS_EAP19()
        {
            pageLoadedElement = pledgeAmountBox;
            correspondingDataClass = new HEBS_EAP19Data().GetType();
            textName = "Payment Options";
        }
    }

    public class HEBS_EAP19Data : EAP19Data
    {
        public new string sourceOfFunds { get; set; } = "Accumulated Savings";
    }
}
