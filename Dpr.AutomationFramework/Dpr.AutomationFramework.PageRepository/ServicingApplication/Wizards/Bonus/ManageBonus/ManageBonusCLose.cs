using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AdHocDeposit
{
    public class ManageBonusClose : GenericWizardClose
    {
        public ManageBonusClose()
        {
            correspondingDataClass = new ManageBonusCloseData().GetType();
            textName = "Manage Bonus Close";
        }
    }

    public class ManageBonusCloseData : GenericWizardCloseData
    {
    }
}
