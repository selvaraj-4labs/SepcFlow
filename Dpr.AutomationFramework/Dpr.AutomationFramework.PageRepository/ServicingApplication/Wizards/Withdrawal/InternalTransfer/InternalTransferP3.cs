using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.CreateWithdrawal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.InternalTransfer
{
    public class InternalTransferP3 : GenericFinalWizardPage
    {
        public InternalTransferP3()
        {
            correspondingDataClass = new InternalTransferP3Data().GetType();
            textName = "Internal Transfer Page 3";
        }
    }

    public class InternalTransferP3Data : CreateWithdrawalP3Data
    {
    }
}
