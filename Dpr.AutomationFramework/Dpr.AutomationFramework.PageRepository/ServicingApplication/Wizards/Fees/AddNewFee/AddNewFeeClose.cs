using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AdHocDeposit
{
    public class AddNewFeeClose : GenericWizardClose
    {
        public AddNewFeeClose()
        {
            correspondingDataClass = new AddNewFeeCloseData().GetType();
            textName = "Add New Fee Close";
        }
    }

    public class AddNewFeeCloseData : GenericWizardCloseData
    {
    }
}
