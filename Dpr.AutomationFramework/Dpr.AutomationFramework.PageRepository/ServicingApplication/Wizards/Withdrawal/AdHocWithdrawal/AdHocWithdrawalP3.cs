using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.CreateWithdrawal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.AdHocWithdrawal
{
    public class AdHocWithdrawalP3 : CreateWithdrawalP3
    {
        public AdHocWithdrawalP3()
        {
            pageLoadedElement = withdrawalDateBox;
            correspondingDataClass = new AdHocWithdrawalP3Data().GetType();
            textName = "Ad Hoc Withdrawal Page 3";
        }
    }

    public class AdHocWithdrawalP3Data : CreateWithdrawalP3Data
    {
    }
}
