using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.DepositReversal
{
    public class DepositReversalP3 : GenericFinalWizardPage
    {
        public DepositReversalP3()
        {
            correspondingDataClass = new DepositReveralP2Data().GetType();
            textName = "Deposit Reversal Page 3";
        }
        public new Element nextBtn => new Element(FindElement(new LocatorList() 
            .Add("ClassName", "WindowsForms10")
            .Add(Defs.boLocatorName, "=Next"), tag: "Button"))
            .SetIsButtonFlag(true);
    }

    public class DepositReversalP3Data : GenericFinalWizardPageData
    {
    }
}
