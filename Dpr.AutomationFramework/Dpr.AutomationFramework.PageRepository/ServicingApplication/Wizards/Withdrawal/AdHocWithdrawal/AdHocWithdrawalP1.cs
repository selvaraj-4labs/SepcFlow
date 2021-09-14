using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.CreateWithdrawal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.AdHocWithdrawal
{
    public class AdHocWithdrawalP1 : CreateWithdrawalP1
    {
        public AdHocWithdrawalP1()
        {
            pageLoadedElement = currentBalanceBox;
            correspondingDataClass = new AdHocWithdrawalP1Data().GetType();
            textName = "Ad Hoc Withdrawal Page 1";
        }
    }

    public class AdHocWithdrawalP1Data : CreateWithdrawalP1Data
    {
    }
}
