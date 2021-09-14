using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AddRegularDeposit
{
    public class ManageBonusP2 : GenericFinalWizardPage
    {
        public ManageBonusP2()
        {
            correspondingDataClass = new ManageBonusP2Data().GetType();
            textName = "Add Regular Deposit Page 2";
        }

        //public WaitFor waitForPage => new WaitFor(null)
        //    .AddWaitElement(messagesBox.locator);

        public new Element nextBtn => base.nextBtn;
    }

    public class ManageBonusP2Data : GenericFinalWizardPageData
    {
    }
}
