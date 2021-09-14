using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.CreateWithdrawal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.AdHocWithdrawal
{
    public class AdHocWithdrawalP4 : CreateWithdrawalP4
    {
        public AdHocWithdrawalP4()
        {
            correspondingDataClass = new AdHocWithdrawalP4Data().GetType();
            textName = "Ad Hoc Withdrawal Page 4";
        }
    }

    public class AdHocWithdrawalP4Data : CreateWithdrawalP3Data
    {
    }
}
