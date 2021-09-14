using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;
namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.ChequeDepositReversal
{
    public class ChequeDepositReversalP3 : GenericFinalWizardPage
    {
        public ChequeDepositReversalP3()
        {
            correspondingDataClass = new ChequeDepositReversalP3Data().GetType();
            textName = "Cancel Regular Deposit Page 3";
        }
    }
    public class ChequeDepositReversalP3Data : GenericFinalWizardPageData
    {
    }
}
