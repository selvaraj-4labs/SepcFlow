using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AddRegularDeposit
{
    public class AddRegularDepositP2 : GenericFinalWizardPage
    {
        public AddRegularDepositP2()
        {
            correspondingDataClass = new AddRegularDepositP2Data().GetType();
            textName = "Add Regular Deposit Page 2";
        }

        //public WaitFor waitForPage => new WaitFor(null)
        //    .AddWaitElement(messagesBox.locator);

        public new Element nextBtn => base.nextBtn;
    }

    public class AddRegularDepositP2Data : GenericFinalWizardPageData
    {
    }
}
