using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AdHocDeposit
{
    public class AdHocDepositP4 : GenericFinalWizardPage
    {
        public AdHocDepositP4()
        {
            correspondingDataClass = new AdHocDepositP4Data().GetType();
            textName = "Ad-hoc Deposit Page 4";
        }
        public new Element nextBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Ok"), tag: "Button"))
            .SetIsButtonFlag(true);
    }
    public class AdHocDepositP4Data : GenericFinalWizardPageData
    {
    }
}
