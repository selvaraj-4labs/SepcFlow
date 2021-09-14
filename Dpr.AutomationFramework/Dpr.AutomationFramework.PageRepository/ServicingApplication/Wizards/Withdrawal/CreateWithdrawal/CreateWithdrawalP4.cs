using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.CreateWithdrawal
{
    public class CreateWithdrawalP4 : GenericFinalWizardPage
    {
        public CreateWithdrawalP4()
        {
            correspondingDataClass = new CreateWithdrawalP4Data().GetType();
            textName = "Create Withdrawal Page 4";
        }
    }

    public class CreateWithdrawalP4Data : GenericFinalWizardPageData
    {

    }
}
