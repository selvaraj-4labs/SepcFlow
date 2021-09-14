using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.CreateWithdrawal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.AdHocWithdrawal
{
    public class AdHocWithdrawalP2 : CreateWithdrawalP2
    {
        public AdHocWithdrawalP2()
        {
            pageLoadedElement = overrideToProceed;
            correspondingDataClass = new AdHocWithdrawalP2Data().GetType();
            textName = "Ad Hoc Withdrawal Page 2";
        }
    }
    public class AdHocWithdrawalP2Data : CreateWithdrawalP2Data
    {
    }
}
