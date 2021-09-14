using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.SetLoanAccountStatusDate
{
    public class SetLoanAccountStatusDateP2 : GenericFinalWizardPage
    {
        public SetLoanAccountStatusDateP2()
        {
            correspondingDataClass = new SetLoanAccountStatusDateP2Data().GetType();
            textName = "Set Account Status Date Page 2";
        }
    }

    public class SetLoanAccountStatusDateP2Data : GenericFinalWizardPageData
    {
    }
}
