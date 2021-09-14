using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AddRegularDeposit
{
    public class AccountSettingsP5 : GenericFinalWizardPage
    {
        public AccountSettingsP5()
        {
            correspondingDataClass = new AccountSettingsP5Data().GetType();
            textName = "Account Settings Page 5";
        }

        //public WaitFor waitForPage => new WaitFor(null)
        //    .AddWaitElement(messagesBox.locator);

        public new Element nextBtn => base.nextBtn;
    }

    public class AccountSettingsP5Data : GenericFinalWizardPageData
    {
    }
}
